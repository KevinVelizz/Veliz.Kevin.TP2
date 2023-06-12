using Entidades;

namespace Pruebas
{
    [TestClass]
    public class CategoriasTest
    {
        [TestMethod]
        public void TestEsGenerala_CuandoNoTienenTodosUno_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int>();
            bool valorEsperado = false;
            dados.Add(1); dados.Add(1); dados.Add(1); dados.Add(1); dados.Add(1);

            // Act - Invocar al método a probar.
            bool esGenerala = Categorias.EsGenerala(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(valorEsperado, esGenerala);
        }

        [TestMethod]
        public void TestEsgenerala_CuandoSonDistintosDeUno_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int>();
            dados.Add(2); dados.Add(2); dados.Add(2); dados.Add(2); dados.Add(2);

            // Act - Invocar al método a probar.
            bool esGenerala = Categorias.EsGenerala(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(esGenerala);
        }

        [TestMethod]
        public void EsPoker_SiTienePoker_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 2, 2, 2, 2, 5 };

            // Act - Invocar al método a probar.
            bool resultado = Categorias.EsPoker(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsPoker_SiNoTienePoker_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 2, 3, 4, 5 };

            // Act - Invocar al método a probar.
            bool resultado = Categorias.EsPoker(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }
    }
}
