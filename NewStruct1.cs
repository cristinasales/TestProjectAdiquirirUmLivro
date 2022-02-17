using iText.Layout.Element;
using iText.Layout.Properties;
using iText.IO.Image;

namespace TestProjectAdiquirirUmLivro
{
    internal record struct NewStruct1(LineDrawerNewStruct Item1, object Item2)
    {
        public static implicit operator (LineDrawerNewStruct, object)(NewStruct1 value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct1((LineDrawerNewStruct, object) value)
        {
            return new NewStruct1(value.Item1, value.Item2);
        }

        // Adicionar imagem
        Imagem img = new Image(ImageDataFactory
           .Create(@"..\..\image.jpg")
           .SetTextAlignment(TextAlignment.CENTER);
        document.AddNewStruct2
    }


    }
