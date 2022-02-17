using System.IO;
using System.Reflection;

namespace TestProjectAdiquirirUmLivro.Helpers
{
    public static class TestHelper
    {
#pragma warning disable CS8603 // Possível retorno de referência nula.
        public static string PastaDoExecutavel => Path.GetDirectoryName
                 (Assembly.GetExecutingAssembly().Location);
#pragma warning restore CS8603 // Possível retorno de referência nula.
    }
}
