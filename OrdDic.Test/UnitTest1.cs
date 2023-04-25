using System.Collections.Specialized;

namespace OrdDic.Test
{
    public class UnitTest1
    {
        // TESTS CON ORDERED DICTIONARY
        OrderedDictionary dic = new OrderedDictionary();
        [Fact]
        public void ObtenerValor()
        {
            dic.Add("1", "Elemento 1");
            Assert.Equal("Elemento 1", dic[0]); // x indice
            Assert.Equal("Elemento 1", dic["1"]); // x key/clave
        }
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(500000)]
        public void AgregarElementos(int cantidad)
        {
            for (int i = 1; i <= cantidad; i++)
            {
                dic.Add(i, $"Alumno {i}");
            }
            Assert.Equal(cantidad, dic.Count);
        }
        [Theory]
        [InlineData(100,50)]
        [InlineData(1000,75)]
        [InlineData(10000,1000)]
        [InlineData(100000,50000)]
        [InlineData(500000,205000)]
        public void EliminarElementosXKey(int agregar, int eliminar)
        {
            for (int i = 1 ; i <= agregar ; i++)
            {
                dic.Add(i, $"Alumno {i}");
            }
            for (int i = 1 ;i <= eliminar ; i++)
            {
                dic.Remove(i);
            }
            Assert.Equal(agregar-eliminar, dic.Count);
        }
        [Theory]
        [InlineData(100, 50)]
        [InlineData(1000, 75)]
        [InlineData(10000, 1000)]
        [InlineData(100000, 50000)]
        [InlineData(500000, 205000)]
        public void EliminarElementosXIndex(int agregar, int eliminar)
        {
            for (int i = 1 ; i <= agregar ; i++)
            {
                dic.Add(i, $"Alumno {i}");
            }
            for (int i = 1 ; i <= eliminar ; i++)
            {
                dic.RemoveAt(i);
            }
            Assert.Equal(agregar - eliminar, dic.Count);
        }
    }
}