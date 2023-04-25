namespace OrdDic.Test
{
    public class UnitTest2
    {
        // TESTS CON DICCIONARIO NORMAL
        Dictionary<int, string> dic = new();
        [Theory]
        [InlineData(100)]
        [InlineData(1000)]
        [InlineData(10000)]
        [InlineData(100000)]
        [InlineData(500000)]
        public void AgregarElementos(int cantidad)
        {
            for (int i = 1 ; i <= cantidad ; i++)
            {
                dic.Add(i, $"Alumno {i}");
            }
            Assert.Equal(cantidad, dic.Count);
        }
        [Theory]
        [InlineData(100, 50)]
        [InlineData(1000, 75)]
        [InlineData(10000, 1000)]
        [InlineData(100000, 50000)]
        [InlineData(500000, 205000)]
        public void EliminarElementos(int agregar, int eliminar)
        {
            for (int i = 1 ; i <= agregar ; i++)
            {
                dic.Add(i, $"Alumno {i}");
            }
            for (int i = 1 ; i <= eliminar ; i++)
            {
                dic.Remove(i);
            }
            Assert.Equal(agregar - eliminar, dic.Count);
        }
    }
}