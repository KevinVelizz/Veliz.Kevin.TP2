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
    }
}