using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using MigraDoc.Rendering;
using System.Threading.Tasks;
using System.Windows.Forms;
using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Shapes;
using MigraDoc.DocumentObjectModel.Tables;
using Patagames.Pdf.Net;
using PdfiumViewer;
using System.Runtime.InteropServices;
namespace pdfdesign
{
    public partial class Form1 : Form
    {
        int pageNumber;
        Table table;
        Section section;
        string[] rowArray;
        Paragraph paragraph;
        private Row row;
        Column column;
        TextFrame textFrame;
        Document document;
        PdfiumViewer.PdfDocument pdfDocument;
        MemoryStream pdf = new MemoryStream();
        public Form1()
        {
            InitializeComponent();
            createPDF(CreateTable("WellCome  TO  HOME"));
            this.WindowState = FormWindowState.Maximized;
        }
       
        private Document CreateTable(string change)
        {
      
            document = new Document();
            paragraph = new Paragraph();
            addTitle(document);
            showPageNumber();
            addImage();
            addTable();
            column2Width();
            //string[] rowArray = new string[] { "WellCome  TO  HSP", "WellCome  TO  SBT", change, "WellCome  TO  DHL" };
            addColumnName();
            rowArray = new string[] { "A", "B", change, "C" };
            for (int i = 0; i < 100; i++)
                addRow(paragraph, table, rowArray);
            return document;
        }
        private void addColumnName()
        {
            string[] ColumnName = new string[] { "Column1", "Column2", "Column3", "Column4" };
            addRow(paragraph, table, ColumnName);
        }

        private void addTable()
        {
            table = section.AddTable();
            table.Columns.AddColumn();//ADD COLUMNS
            table.Columns.AddColumn();
            table.Columns.AddColumn();
            table.Columns.AddColumn();
        }

        private void addTitle(Document document)
        {
            MigraDoc.DocumentObjectModel.Shapes.TextFrame textFrame = new MigraDoc.DocumentObjectModel.Shapes.TextFrame();

            // Add a section to the document.
            section = document.AddSection();
            section.PageSetup.StartingNumber = 1;
            textFrame = section.AddTextFrame();
            textFrame.Height = "3.0cm";
            textFrame.Width = "7.0cm";
            textFrame.Left = 10;
            textFrame.Top = Top;
            // Put sender in address frame
            paragraph = textFrame.AddParagraph("Handels Software Partner · NotkeStr.9  · 12345 Hamburg");
        }

        private void addImage()
        {

            MigraDoc.DocumentObjectModel.Shapes.Image image = section.Headers.Primary.AddImage(@"C:\Users\k.algoursh\Pictures\cat.jpg");
            image.Height = "1.5cm";
            image.LockAspectRatio = true;
            image.RelativeVertical = RelativeVertical.Line;
            image.RelativeHorizontal = RelativeHorizontal.Margin;
            image.Top = ShapePosition.Top;
            image.Left = ShapePosition.Right;
           image.WrapFormat.Style = WrapStyle.Through;
        }

        private void column2Width()
        {
            IEnumerator columns = table.Columns.GetEnumerator();// wir haben column2 width detected
            while (columns.MoveNext())
            {
                column = (Column)columns.Current;
                if (column.Index == 2)
                {
                    column.Width = 220.0;
                }
                else
                {
                    column.Width = 80.0;
                }
            }
        }

        private void showPageNumber()
        {
       
            Paragraph pageNumber = new Paragraph();
            pageNumber.AddText("Page ");
            pageNumber.AddPageField();
            pageNumber.AddText(" of ");
            pageNumber.AddNumPagesField();
            section.Footers.Primary.Add(pageNumber);
        }

        private void createPDF(Document document)
        {

             Path.GetDirectoryName(typeof(int).Assembly.Location);
            try
            {
                // Create a renderer for the MigraDoc document.
                var pdfRenderer = new PdfDocumentRenderer(false) { Document = document };
                // Layout and render document to PDF.
                pdfRenderer.RenderDocument();
                // Save the document...
                using (pdf = new MemoryStream())
                {
                      pdfRenderer.PdfDocument.Save(pdf);
                    var pdfReader = new MemoryStream(pdf.GetBuffer());
                    pdfDocument = PdfiumViewer.PdfDocument.Load(pdfReader);

                  
                    pdfViewerShape.Renderer.Load(pdfDocument);   // the Problem here cant Found pdfium.dll 
                    int pagecount = pdfDocument.PageCount;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void addRow(Paragraph paragraph, Table table, String[] rowArray)
        {
            row = table.AddRow();
            addCell(row, 0, rowArray[0]);
            addCell(row, 1, rowArray[1]);
            addCell(row, 2, rowArray[2]);
            addCell(row, 3, rowArray[3]);
            row.Borders.Color = Colors.White;
            if (((int)row.Index % 2) == 0)
            {
                row.Shading.Color = Colors.Gray;
            }
            else
            {
                row.Shading.Color = Colors.GreenYellow;
            }
            if ((int)row.Index == 0)
            {
                row.Shading.Color = Colors.Yellow;
            }
        
        }

        private void addCell(Row row, int index, string text)
        {
            textFrame = row.Cells[index].AddTextFrame();
            textFrame.Width = row.Cells[index].Column.Width;
            textFrame.Height = 30;
            textFrame.MarginLeft = 30;
            textFrame.AddParagraph(text);
            if ((int)row.Index == 0)
            {
                textFrame.MarginLeft = 10;
            }
        }

        private void getFocusCurrentPage()
        {
            pageNumber = pdfViewerShape.Renderer.Page;
            createPDF(CreateTable((Guid.NewGuid()).ToString()));
            int pageCount = pdfViewerShape.Renderer.Document.PageCount;
            if (pageCount < pageNumber)
            {
                pdfViewerShape.Renderer.Page = pageCount;
            }
            else
            {
                pdfViewerShape.Renderer.Page = pageNumber;
            }
        }
        private void Print_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            var dlg = new PrintDialog();
            dlg.AllowCurrentPage = true;
            dlg.AllowSomePages = true;
            dlg.UseEXDialog = true;
            dlg.Document = pd;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                pdfDocument.CreatePrintDocument();
            }
        }

        private void ZoomIn_Click(object sender, EventArgs e)
        {
            pdfViewerShape.Renderer.ZoomIn();
        }

        private void ZoomOut_Click(object sender, EventArgs e)
        {
            pdfViewerShape.Renderer.ZoomOut();
        }


        private void LiveData_Click(object sender, EventArgs e)
        {
            createPDF(CreateTable(Guid.NewGuid().ToString()));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string test = "test";
            SaveFileDialog savefile = new SaveFileDialog();
            string filename = savefile.FileName;
            savefile.Filter = "(*.pdf)|*.pdf";
            if (test != null)
            {
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    pdfDocument.Save(savefile.FileName);
                }
            }
            else
            {
                MessageBox.Show("insert your Data Please");
            }
        }
        //private static bool TryLoadNativeLibrary(string path)
        //{
        //    if (path == null)
        //        return false;

        //    path = Path.Combine(path, IntPtr.Size == 4 ? "x86" : "x64");

        //    path = Path.Combine(path, "pdfium.dll");

        //    return File.Exists(path) && LoadLibrary(path) != IntPtr.Zero;
        //}

        //[DllImport("kernel32", SetLastError = true, CharSet = CharSet.Ansi)]
        //private static extern IntPtr LoadLibrary([MarshalAs(UnmanagedType.LPStr)] string lpFileName);
    }
}

