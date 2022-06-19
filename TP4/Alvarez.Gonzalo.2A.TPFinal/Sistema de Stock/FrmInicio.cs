using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Entidades;

namespace Sistema_de_Stock
{
    public partial class FrmInicio : Form
    {
        #region Atributos
        private FrmCargarProducto frmCargarProducto;
        private FrmVenderProducto frmVenderProducto;
        private FrmClientes frmClientes;
        private Stock<Producto> stock = new Stock<Producto>(100);
        private SerializadorXML_JSON<List<Electrodomestico>> serializadorXmlElectrodomestico;
        private SerializadorXML_JSON<List<Instrumento>> serializadorXmlInstrumento;
        private SerializadorXML_JSON<List<Electrodomestico>> serializadorJsonElectrodomestico;
        private SerializadorXML_JSON<List<Instrumento>> serializadorJsonInstrumento;
        private List<Electrodomestico> listaElectrodomesticos;
        private List<Instrumento> listaInstrumentos;
        private string pathXmlElectrodomesticos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stockElectrodomesticos.xml");
        private string pathXmlInstrumento = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stockInstrumentos.xml");
        private string pathJsonElectrodomesticos = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stockElectrodomesticos.json");
        private string pathJsonInstrumento = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "stockInstrumentos.json");
        private double recaudacion;
        #endregion

        #region Constructores
        public FrmInicio()
        {
            InitializeComponent();
            InitializeDataStock();
            this.frmCargarProducto = new FrmCargarProducto(stock);
            this.frmClientes = new FrmClientes();
            this.serializadorXmlElectrodomestico = new SerializadorXML_JSON<List<Electrodomestico>>(IArchivo<List<Electrodomestico>>.ETipoArchivo.XML);
            this.serializadorXmlInstrumento = new SerializadorXML_JSON<List<Instrumento>>(IArchivo<List<Instrumento>>.ETipoArchivo.XML);
            this.serializadorJsonElectrodomestico = new SerializadorXML_JSON<List<Electrodomestico>>(IArchivo<List<Electrodomestico>>.ETipoArchivo.JSON);
            this.serializadorJsonInstrumento = new SerializadorXML_JSON<List<Instrumento>>(IArchivo<List<Instrumento>>.ETipoArchivo.JSON);
            this.listaElectrodomesticos = new List<Electrodomestico>();
            this.listaInstrumentos = new List<Instrumento>();
            this.recaudacion = 0;
        }
        #endregion

        #region Propiedades
        public double Recaudacion { get => this.recaudacion; set => this.recaudacion = value; }
        #endregion

        #region Metodos
        /// <summary>
        /// Actaliza los productos en el data grid
        /// </summary>
        private void Actualizar()
        {
            try
            {
                dtStock.Rows.Clear();
                foreach (Producto p in this.stock.Productos)
                {
                    if (p is Instrumento)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dtStock);
                        Instrumento i = (Instrumento)p;
                        fila.Cells[0].Value = i.Id;
                        fila.Cells[1].Value = i.Marca;
                        fila.Cells[2].Value = i.TipoInstrumento;
                        fila.Cells[3].Value = i.Precio;
                        dtStock.Rows.Add(fila);
                        dtStock.Sort(dtStock.Columns[0], ListSortDirection.Ascending);
                    }
                    if (p is Electrodomestico)
                    {
                        DataGridViewRow fila = new DataGridViewRow();
                        fila.CreateCells(dtStock);
                        Electrodomestico e = (Electrodomestico)p;
                        fila.Cells[0].Value = e.Id;
                        fila.Cells[1].Value = e.Marca;
                        fila.Cells[2].Value = e.TipoElectrodomestico;
                        fila.Cells[3].Value = e.Precio;
                        dtStock.Rows.Add(fila);
                        dtStock.Sort(dtStock.Columns[0], ListSortDirection.Ascending);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Elimina el producto seleccionado de los siguientes lugares:
        /// Data Grid View - stock - Base de datos (*Siempre y cuando este activa)
        /// </summary>
        private void EliminarProducto()
        {
            try
            {
                ETipoInstrumento tipoInstrumento;
                ETipoElectrodomestico tipoElectrodomestico;
                int id = Convert.ToInt32(dtStock.CurrentRow.Cells["id"].Value);

                foreach (Producto p in this.stock.Productos)
                {
                    Instrumento i;
                    Electrodomestico electrodomestico;
                    if (p.Id == id)
                    {
                        if (p is Instrumento)
                        {
                            Instrumento instrumento = (Instrumento)p;
                            tipoInstrumento = instrumento.TipoInstrumento == "Guitarra" ? ETipoInstrumento.Guitarra : ETipoInstrumento.Saxo;
                            i = new Instrumento(instrumento.Id, instrumento.Precio, instrumento.Marca, tipoInstrumento);
                            this.stock.Productos.Remove(i);
                            ConexionBD.EliminarProductoPorId(i.Id);
                            dtStock.Rows.Remove(dtStock.CurrentRow);
                            break;
                        }
                        if (p is Electrodomestico)
                        {
                            DataGridViewRow fila = new DataGridViewRow();
                            Electrodomestico elect = (Electrodomestico)p;
                            tipoElectrodomestico = elect.TipoElectrodomestico == "Celular" ? ETipoElectrodomestico.Celular :
                                elect.TipoElectrodomestico == "Televisor" ? ETipoElectrodomestico.Televisor :
                                elect.TipoElectrodomestico == "Lavarropa" ? ETipoElectrodomestico.Lavarropa : ETipoElectrodomestico.Heladera;
                            electrodomestico = new Electrodomestico(elect.Id, elect.Precio, elect.Marca, tipoElectrodomestico);
                            this.stock.Productos.Remove(electrodomestico);
                            ConexionBD.EliminarProductoPorId(electrodomestico.Id);
                            dtStock.Rows.Remove(dtStock.CurrentRow);
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        /// <summary>
        /// Vende el producto seleccionado al cliente ingresado en el FrmVenderProducto,
        /// luego lo elimina.
        /// </summary>
        private void VenderProducto()
        {
            try
            {
                ETipoInstrumento tipoInstrumento;
                ETipoElectrodomestico tipoElectrodomestico;
                int id = Convert.ToInt32(dtStock.CurrentRow.Cells["id"].Value);
                foreach (Producto p in this.stock.Productos)
                {
                    Instrumento i;
                    Electrodomestico electrodomestico;
                    if (p.Id == id)
                    {
                        if (p is Instrumento)
                        {
                            Instrumento instrumento = (Instrumento)p;
                            tipoInstrumento = instrumento.TipoInstrumento == "Guitarra" ? ETipoInstrumento.Guitarra : ETipoInstrumento.Saxo;
                            i = new Instrumento(instrumento.Id, instrumento.Precio, instrumento.Marca, tipoInstrumento);
                            this.frmVenderProducto = new FrmVenderProducto(i);
                            frmVenderProducto.ShowDialog();

                            if (this.frmVenderProducto.DialogResult == DialogResult.OK)
                            {
                                this.Recaudacion += i.Precio;
                                lblRecaudacion.Text = $"Recaudacion: ${this.recaudacion}";
                                this.stock.Productos.Remove(i);
                                ConexionBD.EliminarProductoPorId(i.Id);
                                dtStock.Rows.Remove(dtStock.CurrentRow);
                            }
                            break;
                        }
                        if (p is Electrodomestico)
                        {
                            Electrodomestico elect = (Electrodomestico)p;
                            tipoElectrodomestico = elect.TipoElectrodomestico == "Celular" ? ETipoElectrodomestico.Celular :
                                elect.TipoElectrodomestico == "Televisor" ? ETipoElectrodomestico.Televisor :
                                elect.TipoElectrodomestico == "Lavarropa" ? ETipoElectrodomestico.Lavarropa : ETipoElectrodomestico.Heladera;
                            electrodomestico = new Electrodomestico(elect.Id, elect.Precio, elect.Marca, tipoElectrodomestico);
                            this.frmVenderProducto = new FrmVenderProducto(electrodomestico);
                            frmVenderProducto.ShowDialog();

                            if (this.frmVenderProducto.DialogResult == DialogResult.OK)
                            {
                                DataGridViewRow row = new DataGridViewRow();
                                this.Recaudacion += elect.Precio;
                                lblRecaudacion.Text = $"Recaudacion: ${this.recaudacion}";
                                this.stock.Productos.Remove(electrodomestico);
                                ConexionBD.EliminarProductoPorId(electrodomestico.Id);
                                dtStock.Rows.Remove(dtStock.CurrentRow);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void GuardarXml()
        {
            try
            {
                this.listaElectrodomesticos.Clear();
                this.listaInstrumentos.Clear();
                string mensaje = "";
                if (this.stock.Productos.Count > 0)
                {
                    foreach (Producto p in this.stock.Productos)
                    {
                        if (p is Electrodomestico)
                        {
                            this.listaElectrodomesticos.Add((Electrodomestico)p);
                        }
                        if (p is Instrumento)
                        {
                            this.listaInstrumentos.Add((Instrumento)p);
                        }
                    }

                    if (this.listaElectrodomesticos.Count > 0)
                    {
                        this.serializadorXmlElectrodomestico.Escribir(this.listaElectrodomesticos, pathXmlElectrodomesticos);
                        mensaje += $"Electrodomesticos guardados en \n{pathXmlElectrodomesticos}\n";
                    }

                    if (this.listaInstrumentos.Count > 0)
                    {
                        this.serializadorXmlInstrumento.Escribir(this.listaInstrumentos, pathXmlInstrumento);
                        mensaje += $"Instrumentos guardados en \n{pathXmlInstrumento}\n";
                    }
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un producto ingresado en el stock para poder guardar el archivo", "Error");
                }
            }
            catch (Exception ex)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{ex.Message}", path);
            }
        }

        private void GuardarJson()
        {
            try
            {
                this.listaElectrodomesticos.Clear();
                this.listaInstrumentos.Clear();
                string mensaje = "";
                if (this.stock.Productos.Count > 0)
                {
                    foreach (Producto p in this.stock.Productos)
                    {
                        if (p is Electrodomestico)
                        {
                            this.listaElectrodomesticos.Add((Electrodomestico)p);
                        }
                        if (p is Instrumento)
                        {
                            this.listaInstrumentos.Add((Instrumento)p);
                        }
                    }

                    if (this.listaElectrodomesticos.Count > 0)
                    {
                        this.serializadorJsonElectrodomestico.Escribir(this.listaElectrodomesticos, pathJsonElectrodomesticos);
                        mensaje += $"Electrodomesticos guardados en \n{pathJsonElectrodomesticos}\n";
                    }

                    if (this.listaInstrumentos.Count > 0)
                    {
                        this.serializadorJsonInstrumento.Escribir(this.listaInstrumentos, pathJsonInstrumento);
                        mensaje += $"Instrumentos guardados en \n{pathJsonInstrumento}\n";
                    }
                    MessageBox.Show(mensaje);
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un producto ingresado en el stock para poder guardar el archivo", "Error");
                }
            }
            catch (Exception ex)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{ex.Message}", path);
            }
        }

        private void CargarXml()
        {
            try
            {
                this.stock.Productos.Clear();
                this.listaInstrumentos = new List<Instrumento>(this.serializadorXmlInstrumento.Leer(this.pathXmlInstrumento));
                this.listaElectrodomesticos = new List<Electrodomestico>(this.serializadorXmlElectrodomestico.Leer(this.pathXmlElectrodomesticos));

                foreach (Instrumento i in this.listaInstrumentos)
                {
                    this.stock.Productos.Add(i);
                }

                foreach (Electrodomestico elect in this.listaElectrodomesticos)
                {
                    this.stock.Productos.Add(elect);
                }

                if (ConexionBD.CargarProductos().Count > 0)
                {
                    foreach (Producto p in ConexionBD.CargarProductos())
                    {
                        foreach (Producto p2 in this.stock.Productos)
                        {
                            if (p.Id == p2.Id)
                            {
                                ConexionBD.EliminarProductoPorId(p.Id);
                            }
                        }
                    }
                }

                foreach (Producto p in this.stock.Productos)
                {
                    ConexionBD.GuardarProducto(p);
                }

                Actualizar();
                MessageBox.Show("Stock cargado correctamente", "Alerta");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void TraerStockBD()
        {
            try
            {
                MessageBox.Show("Cargando Stock desde la base de datos, pulse aceptar y aguarde un momento", "Cargando Stock BD");
                Thread.Sleep(2000);
                this.stock.Productos.Clear();
                if (dtStock.InvokeRequired)
                {
                    dtStock.BeginInvoke((MethodInvoker)delegate ()
                    {
                        foreach (Producto p in ConexionBD.CargarProductos())
                        {
                            this.stock.Productos.Add(p);
                        }
                        Actualizar();
                    });
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ha ocurrido un error al leer la base de datos", "Error");
            }
        }

        public void AsignarFechaYHora()
        {
            try
            {
                lblFechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
                Task actualizarFechaYHora = new Task(ActualizarFechaYHora);
                actualizarFechaYHora.Start();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        public void ActualizarFechaYHora()
        {
            try
            {
                if (lblFechaYHora.InvokeRequired)
                {
                    do
                    {
                        lblFechaYHora.BeginInvoke((MethodInvoker)delegate ()
                        {
                            lblFechaYHora.Text = DateTime.Now.ToString("dd/MM/yyyy - HH:mm:ss");
                        });
                        Thread.Sleep(1000);
                    } while (true);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }
        #endregion

        #region Eventos
        private void FrmInicio_Load(object sender, EventArgs e)
        {
            AsignarFechaYHora();
        }

        private void InitializeDataStock()
        {
            try
            {
                dtStock.ColumnCount = 4;
                dtStock.Columns[0].Name = "Id";
                dtStock.Columns[1].Name = "Marca";
                dtStock.Columns[2].Name = "Tipo";
                dtStock.Columns[3].Name = "Precio";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                this.frmCargarProducto.ShowDialog();
                if (this.frmCargarProducto.DialogResult == DialogResult.OK)
                {
                    Actualizar();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (this.stock.Productos.Count > 0)
            {
                EliminarProducto();
            }
            else
            {
                MessageBox.Show("Debe haber productos en el stock para poder eliminar", "Advertencia");
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            if (this.stock.Productos.Count > 0)
            {
                VenderProducto();
            }
            else
            {
                MessageBox.Show("Debe haber productos en el stock para poder vender", "Advertencia");
            }
        }

        private void btnCargarBD_Click(object sender, EventArgs e)
        {
            try
            {
                if (ConexionBD.CargarProductos().Count > 0)
                {
                    Task cargarStockBD = new Task(TraerStockBD);
                    cargarStockBD.Start();
                }
                else
                {
                    MessageBox.Show("Debe haber productos en la base de datos para poder cargarlos", "Advertencia");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnListaClientesBD_Click(object sender, EventArgs e)
        {
            try
            {
                frmClientes.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void btnGuardarStockXml_Click(object sender, EventArgs e)
        {
            GuardarXml();
        }

        private void btnCargarStockXml_Click(object sender, EventArgs e)
        {
            CargarXml();
        }

        private void btnGuardarStockJson_Click(object sender, EventArgs e)
        {
            GuardarJson();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion
    }
}
