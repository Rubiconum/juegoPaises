using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasPaises
    {
        [TestMethod]
        public void TestEspa�a_Capital()
        {
            BaseDatosGeografica miBaseDatosGeografica = 
                Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.capital, "Madrid");
        }

        [TestMethod]
        public void TestEspa�a_Nombre()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Assert.AreEqual(espa�a.nombre, "Espa�a");
        }

        [TestMethod]
        public void TestEspa�a_Continente()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Pais espa�a = miBaseDatosGeografica.getPais("Espa�a");
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(espa�a.continente, europa);
        }
    }
}
