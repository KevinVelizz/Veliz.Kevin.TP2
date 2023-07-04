using Entidades;

namespace Pruebas
{
    [TestClass]
    public class AccesoDatosTest
    {
        [TestMethod]
        public void TestAccesoDatos_VerificarConexionTrue()
        {
            // Arrange - Preparar el caso de prueba.
            AccesoDatos accesoDatos = new AccesoDatos();

            // Act - Invocar al método a probar.
            bool acceso = accesoDatos.ProbarConexion();

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(acceso);
        }
    }
}
