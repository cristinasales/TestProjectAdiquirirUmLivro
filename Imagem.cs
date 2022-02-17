using static System.Net.Mime.MediaTypeNames;

namespace TestProjectAdiquirirUmLivro
{
    internal class Imagem
    {
        // Adicionar imagem
        Imagem img = new Image(ImageDataFactory
           .Create(@"..\..\image.jpg"))
           .SetTextAlignment(TextAlignment.CENTER);
        document.Add(img);
    }
}