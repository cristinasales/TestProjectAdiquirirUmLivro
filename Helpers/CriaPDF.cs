using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.Layout.Properties;
namespace TestProjectAdiquirirUmLivro.Helpers
{
    internal class CriaPDF
    {
        private object? parágrafo;
        private AreaBreak? subheader;

        public object? Subcabeçalho { get; private set; }

        public object GerarPdf
        {




            {
                Document document;
                var arquivo = @"C:\Users\cristina.sales\source\repos\TestProjectAdiquirirUmLivro\Dados\Evidecias.pdf";
                using (PdfWriter wPdf = new PdfWriter(arquivo, new WriterProperties().SetPdfVersion
                    (PdfVersion.PDF_2_0)))
                {
                    PdfDocument pdfDocument1 = new PdfDocument(wPdf);
                    document = new Document(pdfDocument1);
                    document.Add(new Paragraph("ToolsQA."));
                    document.Close();

                    document.Close();

                    Subcabeçalho = null;

                    {
                        parágrafo = new Parágrafo("Login")
                       .SetTextAlignment(TextAlignment.CENTER).SetFontSize(15);

                        document.Add(subheader);

                    }

                    //MessageBox.Show("Arquivo PDF gerado em" + arquivo);
                }

            }
        }
    }
}
