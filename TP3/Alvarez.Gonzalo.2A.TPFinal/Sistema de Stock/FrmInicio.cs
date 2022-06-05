using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
        public double Recaudacion
        {
            get
            {
                return this.recaudacion;
            }
            set
            {
                this.recaudacion = value;
            }
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Actaliza los productos en el data grid
        /// </summary>
        private void Actualizar()
        {
            dtStock.Rows.Clear();
            foreach (Producto p in this.stock.Productos)
            {
                if (p is Instrumento)
                {
                    Instrumento i = (Instrumento)p;
                    string[] i_array = { i.Id.ToString(), i.Marca, i.TipoInstrumento, i.Precio.ToString() };
                    dtStock.Rows.Add(i_array);
                }
                if (p is Electrodomestico)
                {
                    Electrodomestico e = (Electrodomestico)p;
                    string[] e_array = { e.Id.ToString(), e.Marca, e.TipoElectrodomestico, e.Precio.ToString() };
                    dtStock.Rows.Add(e_array);
                }
            }
        }

        private void EliminarProducto()
        {
            ETipoInstrumento tipoInstrumento;
            ETipoElectrodomestico tipoElectrodomestico;

            foreach (Producto p in this.stock.Productos)
            {
                Instrumento i;
                Electrodomestico electrodomestico;

                if (p is Instrumento)
                {
                    Instrumento instrumento = (Instrumento)p;
                    tipoInstrumento = instrumento.TipoInstrumento == "Guitarra" ? ETipoInstrumento.Guitarra : ETipoInstrumento.Saxo;
                    i = new Instrumento(instrumento.Id, instrumento.Precio, instrumento.Marca, tipoInstrumento);
                    this.stock.Productos.Remove(i);
                    dtStock.Rows.Remove(dtStock.CurrentRow);
                    break;
                }
                if (p is Electrodomestico)
                {
                    Electrodomestico elect = (Electrodomestico)p;
                    tipoElectrodomestico = elect.TipoElectrodomestico == "Celular" ? ETipoElectrodomestico.Celular :
                        elect.TipoElectrodomestico == "Televisor" ? ETipoElectrodomestico.Televisor :
                        elect.TipoElectrodomestico == "Lavarropa" ? ETipoElectrodomestico.Lavarropa : ETipoElectrodomestico.Heladera;
                    electrodomestico = new Electrodomestico(elect.Id, elect.Precio, elect.Marca, tipoElectrodomestico);
                    this.stock.Productos.Remove(electrodomestico);
                    dtStock.Rows.Remove(dtStock.CurrentRow);
                    break;
                }
            }
        }

        private void VenderProducto()
        {
            ETipoInstrumento tipoInstrumento;
            ETipoElectrodomestico tipoElectrodomestico;

            foreach (Producto p in this.stock.Productos)
            {
                Instrumento i;
                Electrodomestico electrodomestico;

                if (p is Instrumento)
                {
                    Instrumento instrumento = (Instrumento)p;
                    tipoInstrumento = instrumento.TipoInstrumento == "Guitarra" ? ETipoInstrumento.Guitarra : ETipoInstrumento.Saxo;
                    i = new Instrumento(instrumento.Id, instrumento.Precio, instrumento.Marca, tipoInstrumento);
                    this.Recaudacion += i.Precio;
                    lblRecaudacion.Text = $"Recaudacion: ${this.recaudacion}";
                    this.stock.Productos.Remove(i);
                    dtStock.Rows.Remove(dtStock.CurrentRow);
                    break;
                }
                if (p is Electrodomestico)
                {
                    Electrodomestico elect = (Electrodomestico)p;
                    tipoElectrodomestico = elect.TipoElectrodomestico == "Celular" ? ETipoElectrodomestico.Celular :
                        elect.TipoElectrodomestico == "Televisor" ? ETipoElectrodomestico.Televisor :
                        elect.TipoElectrodomestico == "Lavarropa" ? ETipoElectrodomestico.Lavarropa : ETipoElectrodomestico.Heladera;
                    electrodomestico = new Electrodomestico(elect.Id, elect.Precio, elect.Marca, tipoElectrodomestico);
                    this.Recaudacion += elect.Precio;
                    lblRecaudacion.Text = $"Recaudacion: ${this.recaudacion}";
                    this.stock.Productos.Remove(electrodomestico);
                    dtStock.Rows.Remove(dtStock.CurrentRow);
                    break;
                }
            }
        }

        private void GuardarXml()
        {
            try
            {
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
                    this.serializadorXmlElectrodomestico.Escribir(this.listaElectrodomesticos, pathXmlElectrodomesticos);
                    this.serializadorXmlInstrumento.Escribir(this.listaInstrumentos, pathXmlInstrumento);
                    MessageBox.Show($"Archivos guardados en \n{pathXmlElectrodomesticos}\n{pathXmlInstrumento}");
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un producto ingresado en el stock para poder guardar el archivo", "Error");
                }
            }
            catch (Exception exception)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{exception.Message}", path);
            }
        }

        private void GuardarJson()
        {
            try
            {
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
                    this.serializadorJsonElectrodomestico.Escribir(this.listaElectrodomesticos, pathJsonElectrodomesticos);
                    this.serializadorJsonInstrumento.Escribir(this.listaInstrumentos, pathJsonInstrumento);
                    MessageBox.Show($"Archivos guardados en \n{pathJsonElectrodomesticos}\n{pathJsonInstrumento}");
                }
                else
                {
                    MessageBox.Show("Debe tener al menos un producto ingresado en el stock para poder guardar el archivo", "Error");
                }
            }
            catch (Exception exception)
            {
                string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "error.log");
                Archivo archivo = new Archivo();
                MessageBox.Show($"Para ver mas detalles: {path}", "Error");
                archivo.Escribir($"{exception.Message}", path);
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
                Actualizar();
                MessageBox.Show("Stock cargado correctamente", "Alerta");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
        #endregion

        #region Eventos
        private void InitializeDataStock()
        {
            dtStock.ColumnCount = 4;
            dtStock.Columns[0].Name = "Id";
            dtStock.Columns[1].Name = "Marca";
            dtStock.Columns[2].Name = "Tipo";
            dtStock.Columns[3].Name = "Precio";
        }

        private void btnCargarProducto_Click(object sender, EventArgs e)
        {
            this.frmCargarProducto.ShowDialog();
            if (this.frmCargarProducto.DialogResult == DialogResult.OK)
            {
                Actualizar();
            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            EliminarProducto();
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            VenderProducto();
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
