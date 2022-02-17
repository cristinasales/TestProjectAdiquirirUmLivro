
using iText.Kernel.Pdf;
using System;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
using TestProjectAdiquirirUmLivro;

namespace TestProjectAdiquirirUmLivro
{
    public partial class Form1 : Form
    {
        private object pdfDocument;
        private object parágrafo;
        private AreaBreak subheader;
        private readonly object Subcabeçalho;

        public object MessageBox { get; private set; }

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Form1()
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

        }

        private void Button1_Click(object sender, EventArgs e) => GerarPdf(pdfDocument);

#pragma warning disable CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        public Form1(object pdfDocument, object messageBox)
#pragma warning restore CS8618 // O campo não anulável precisa conter um valor não nulo ao sair do construtor. Considere declará-lo como anulável.
        {
            this.pdfDocument = pdfDocument;
            MessageBox = messageBox;
        }

        private void GerarPdf(object pdfDocument)
        {
            throw new NotImplementedException();
        }

        private object GetSubcabeçalho()
        {
            return Subcabeçalho;
        }

        private void GerarPdf(Document pdfDocument, object subcabeçalho)
        {


            var arquivo = @"C:\Users\cristina.sales\source\repos\TestProjectAdiquirirUmLivro\Dados";

            using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion
                (PdfVersion.PDF_2_0)))
            {


                PdfDocument pdfDocument1 = new PdfDocument(wPdf);
                Document document = new Document(pdfDocument1);
                document.Add(new Paragraph("ToolQA."));
                document.Close();

                pdfDocument.Close();
                subcabeçalhodo parágrafo = (subcabeçalhodo)new Parágrafo("Login")
                .SetTextAlignment(TextAlignment.CENTER);
                {
                    document.Add(subheader);
                }


                // Separador de linha
                LineSeparator ls = new LineSeparator(new SolidLine());
                document.Add(ls);



                //MessageBox.Show("Arquivo PDF gerado em" + arquivo);
            }

        }

        private bool SetFontSize(int v)
        {
            throw new NotImplementedException();
        }

        private class subcabeçalhodo
        {
        }
    }

    internal class SolidLineBase1
    {
    }

    internal class SolidLineBase2
    {
    }

    internal class SolidLine
    {
        iText.Kernel.Pdf.Canvas.Draw.ILineDrawer
    }
    
    public class Form

    {
        private readonly iText.Kernel.Pdf.Canvas.Draw.NewStruct1;
            

    }

    internal record struct NewStruct(object Item1, object Item2)
    {
        public static implicit operator (object, object)(NewStruct value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct((object, object) value)
        {
            return new NewStruct(value.Item1, value.Item2);
        }
    }


    }
    internal record struct NewStruct2(img Item1, object Item2)
    {
        public static implicit operator (img, object)(NewStruct2 value)
        {
            return (value.Item1, value.Item2);
        }

        public static implicit operator NewStruct2((img, object) value)
        {
            return new NewStruct2(value.Item1, value.Item2);
        }
    }
    