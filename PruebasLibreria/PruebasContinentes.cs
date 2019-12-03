using LibreriasJuego;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace PruebasLibreria
{
    [TestClass]
    public class PruebasContinentes
    {
        [TestMethod]
        public void TestEuropa_Nombre()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreEqual(europa.nombre, "Europa");
        }

        [TestMethod]
        public void TestEuropa_Paises()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Assert.AreNotEqual(europa.paises.Count, 0);
        }

        [TestMethod]
        public void TestEuropa_Espa�a()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Pais espa�a = europa.getPais("Espa�a");
            Assert.IsNotNull(espa�a);
        }
        [TestMethod]
        public void TestEuropa_Nueva_Zelanda()
        {
            BaseDatosGeografica miBaseDatosGeografica =
                Juego.dameElJuego().baseDatosGeografica;
            Continente europa = miBaseDatosGeografica.getContinente("Europa");
            Pais nuevaZelanda = europa.getPais("Nueva Zelanda");
            Assert.IsNull(nuevaZelanda);
        }

    }
}
