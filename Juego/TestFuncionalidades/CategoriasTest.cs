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
            Categorias categorias = new Categorias();
            bool valorEsperado = false;
            dados.Add(1); dados.Add(1); dados.Add(1); dados.Add(1); dados.Add(1);

            // Act - Invocar al método a probar.
            bool esGenerala = categorias.EsGenerala(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.AreEqual(valorEsperado, esGenerala);
        }

        [TestMethod]
        public void TestEsgenerala_CuandoSonDistintosDeUno_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int>();
            Categorias categorias = new Categorias();
            dados.Add(2); dados.Add(2); dados.Add(2); dados.Add(2); dados.Add(2);

            // Act - Invocar al método a probar.
            bool esGenerala = categorias.EsGenerala(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(esGenerala);
        }

        [TestMethod]
        public void EsPoker_SiTienePoker_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 2, 2, 2, 2, 5 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsPoker(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsPoker_SiNoTienePoker_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 2, 3, 4, 5 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsPoker(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsGeneralaReal_SiTieneGeneralaReal_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 1, 1, 1, 1 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsGeneralaReal(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        public void EsGeneralaReal_SiNoTieneGeneralaReal_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 1, 1, 5, 1 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsGeneralaReal(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsFull_SiTieneFull_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 5, 5, 1, 1, 1 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsFull(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsFull_SiNoTieneFull_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 1, 1, 1, 1 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsFull(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsEscaleraMayor_SiTieneEscaleraMayor_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 2, 3, 4, 5, 6 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsEscaleraMayor(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsEscaleraMayor_SiNoTieneEscaleraMayor_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 2, 4, 4, 4, 5 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsEscaleraMayor(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void EsEscaleraMenor_SiTieneEscaleraMenor_RetornaTrue()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 2, 3, 4, 5 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsEscaleraMenor(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void EsEscaleraMenor_SiNoTieneEscaleraMenor_RetornaFalse()
        {
            // Arrange - Preparar el caso de prueba.
            List<int> dados = new List<int> { 1, 5, 3, 2, 5 };
            Categorias categorias = new Categorias();
            // Act - Invocar al método a probar.
            bool resultado = categorias.EsEscaleraMenor(dados);

            // Assert - Verifico que el resultado sea el esperado.
            Assert.IsFalse(resultado);
        }
    }
}
