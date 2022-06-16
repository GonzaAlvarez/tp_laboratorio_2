using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace Test_Unitarios
{
    [TestClass]
    public class TestProductos
    {
        /// <summary>
        /// Comprueba si se ingresa el elemento al stock verificando que retorne true
        /// </summary>
        [TestMethod]
        public void Add_DeberiaRetornarTrue_CuandoAñadeElemento()
        {
            //Arrange
            int expected = 2;
            Electrodomestico electrodomestico = new Electrodomestico(1, 30000, "Samsung", ETipoElectrodomestico.Celular);
            Instrumento instrumento = new Instrumento(2, 80000, "Gibson", ETipoInstrumento.Guitarra);
            Stock<Producto> stock = new Stock<Producto>(expected);

            //Act
            stock += electrodomestico;
            stock += instrumento;

            //Assert
            Assert.AreEqual(expected, stock.Productos.Count);
        }

        /// <summary>
        /// Comprueba si se elimina el elemento al stock verificando que retorne true
        /// </summary>
        [TestMethod]
        public void Add_DeberiaRetornarTrue_CuandoEliminaElemento()
        {
            //Arrange
            int cantidadStock = 2;
            int expected = 1;
            Electrodomestico electrodomestico = new Electrodomestico(1, 30000, "Samsung", ETipoElectrodomestico.Celular);
            Instrumento instrumento = new Instrumento(2, 80000, "Gibson", ETipoInstrumento.Guitarra);
            Stock<Producto> stock = new Stock<Producto>(cantidadStock);

            //Act
            stock += electrodomestico;
            stock += instrumento;
            stock -= electrodomestico;

            //Assert
            Assert.AreEqual(expected, stock.Productos.Count);
        }
    }
}
