using Entidades;
namespace TestFuncionalidades
{
    [TestClass]
    public class FuncionalidadesTest
    {

        [TestMethod]
        public void TestEstablecer_ValorDevuelveLista_ConCantidadDeDados_Y_EntreElRangoEspecificado()
        {
            // Arrange - Preparar el caso de prueba.

            int cantidadDadosTirar = 3;

            // Act - Invocar al método a probar.
            List<int> resultado = Funcionalidades.EstablecerValor(cantidadDadosTirar);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(cantidadDadosTirar, resultado.Count);
            foreach (int valor in resultado)
            {
                Assert.IsTrue(valor >= 1 && valor <= 6);
            }
        }

        [TestMethod]
        public void TestEstablecerValor_DadosGenerados_CantidadCorrecta()
        {
            // Arrange
            int cantidadDadosTirar = 5;

            // Act
            List<int> dados = Funcionalidades.EstablecerValor(cantidadDadosTirar);

            // Assert
            Assert.AreEqual(cantidadDadosTirar, dados.Count);
        }

        [TestMethod]
        public void TestEstablecerValor_DadosGenerados_CantidadIncorrecta()
        {
            // Arrange
            int cantidadDadosTirar = 7;

            // Act
            List<int> dados = Funcionalidades.EstablecerValor(cantidadDadosTirar);

            // Assert
            Assert.AreEqual(0, dados.Count);
        }
    }
}