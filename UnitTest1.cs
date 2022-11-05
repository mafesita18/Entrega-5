using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Metroplus;

namespace PruebasMetroplus
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CompruebaRutaMenorPasajeros()
        {
            //Arrange
            int[] totalPasajerosTest = new int[] { 5, 25, 30, 39, 15 };
            string[] lasRutasTest = new string[] { "Envigado", "Conquistadores", "Castropol", "Sabaneta", "Hotelera" };

            //Act
            int numeroMenorPasajerosTest;
            string nombreRutaMenorTest;

            Program.ObtieneRutaMenorPasajeros( totalPasajerosTest, lasRutasTest, out nombreRutaMenorTest , out numeroMenorPasajerosTest);

            //Assert
            string rutaCorrecta = "Envigado";
            Assert.AreEqual(rutaCorrecta, nombreRutaMenorTest);
        }

        [TestMethod]
        public void CompruebaPasajerosRuta()
        {
            //Arrange
            string[] lasRutasTest = new string[] { "Envigado", "Conquistadores", "Castropol", "Sabaneta", "Hotelera" };
            Viaje[] viajesTest = new Viaje[]
            {
                new Viaje() {Ruta = "Hotelera", CantidadPasajeros = 30},
                new Viaje() {Ruta = "Envigado", CantidadPasajeros = 10},
                new Viaje() {Ruta = "Envigado", CantidadPasajeros = 33},
                new Viaje() {Ruta = "Castropol", CantidadPasajeros = 40},
                new Viaje() {Ruta = "Sabaneta", CantidadPasajeros = 20},
                new Viaje() {Ruta = "Hotelera", CantidadPasajeros = 35 },
                new Viaje() {Ruta = "Envigado", CantidadPasajeros = 45},
                new Viaje() {Ruta = "Castropol", CantidadPasajeros = 30},
                new Viaje() {Ruta = "Castropol", CantidadPasajeros = 10},
                new Viaje() {Ruta = "Sabaneta", CantidadPasajeros = 25}
            };

            //Act
            int[] totalPasajerosTest = Program.TotalizaPasajerosRuta(viajesTest, lasRutasTest);


            //Assert
            int pasajerosConquitadoresEsperado = 0;
            Assert.AreEqual(pasajerosConquitadoresEsperado, totalPasajerosTest[1]);

        }
    }
}
