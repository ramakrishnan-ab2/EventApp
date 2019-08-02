using EVENT_MANAGEMENT.Manager;
using EVENT_MANAGEMENT.Model;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EVENT_MANAGEMENT.Printing
{
    public class RegistrationPrinting
    {
        public static void GenerateRegistrationPrinting(int RegId, System.Drawing.Image Logo)
        {
            RegisterManager RegisterManager = new RegisterManager();
            Register Register = RegisterManager.GetRegisterById(RegId);
            if (Register != null)
            {
                var path = System.AppDomain.CurrentDomain.BaseDirectory;
                using (MemoryStream myMemoryStream = new MemoryStream())
                {
                    FontFactory.RegisterDirectories();
                    string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
                    string FONT = string.Format("{0}Resources\\CenturyGothic.ttf", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\")));

                    iTextSharp.text.Font BoldFont = FontFactory.GetFont(FONT, 14, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font NormalFont = FontFactory.GetFont(FONT, 14, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font BoldFontHeading = FontFactory.GetFont(FONT, 16, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
                    iTextSharp.text.Font NormalFontHeading = FontFactory.GetFont(FONT, 16, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
                    iTextSharp.text.Font NormalFont1 = FontFactory.GetFont(FONT, 10, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                    var pgSize = new iTextSharp.text.Rectangle(230, 400);

                    Document pdfDoc = new Document(pgSize, -10, -10, 0, 0);
                    PdfWriter writer = PdfWriter.GetInstance(pdfDoc, myMemoryStream);
                    pdfDoc.Open();

                    PdfPTable Table = new PdfPTable(3);
                    float[] widths = new float[] { 40f, 30f, 30f };
                    Table.SetTotalWidth(widths);
                    PdfPCell TableCell = new PdfPCell();

                    MemoryStream Stream = new MemoryStream();
                    Logo.Save(Stream, System.Drawing.Imaging.ImageFormat.Png);
                    iTextSharp.text.Image image = iTextSharp.text.Image.GetInstance(Stream.ToArray());
                    image.ScaleToFit(50f, 20f);
                    image.ScaleAbsolute(40, 40);

                    TableCell = new PdfPCell(new Phrase("Rotary", BoldFontHeading));
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.WHITE;
                    TableCell.BorderColorTop = BaseColor.WHITE;
                    TableCell.BorderColorRight = BaseColor.WHITE;
                    TableCell.BorderColorBottom = BaseColor.WHITE;
                    TableCell.Padding = 4;
                    TableCell.Colspan = 2;
                    TableCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    Table.AddCell(TableCell);

                    TableCell = new PdfPCell(image);
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.WHITE;
                    TableCell.BorderColorTop = BaseColor.WHITE;
                    TableCell.BorderColorRight = BaseColor.WHITE;
                    TableCell.BorderColorBottom = BaseColor.WHITE;
                    TableCell.Padding = 4;
                    TableCell.Rowspan = 2;
                    TableCell.HorizontalAlignment = Element.ALIGN_RIGHT;
                    Table.AddCell(TableCell);

                    //Table.AddCell(CreateColSpanCell("Rotary", BoldFontHeading));

                    Table.AddCell(CreateColSpanCell("Club of Nagercoil South", NormalFont1));
                    Table.AddCell(CreateColSpanCell("Rotaryutsav " + DateTime.Now.Year, BoldFontHeading));

                    Table.AddCell(CreateCell(" ", NormalFont, true,1));
                    Table.AddCell(CreateCell("Date :"+Register.Date.ToShortDateString(), NormalFont, false,2));

                    TableCell = new PdfPCell(new Phrase("Roll No ", BoldFontHeading));
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.BLACK;
                    TableCell.BorderColorTop = BaseColor.BLACK;
                    TableCell.BorderColorRight = BaseColor.WHITE;
                    TableCell.BorderColorBottom = BaseColor.BLACK;
                    TableCell.Padding = 4;
                    TableCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    Table.AddCell(TableCell);

                    TableCell = new PdfPCell(new Phrase(": " + NameSplit(Register.Event.EventName) + "-" + Register.Category.CategoryName + "-" + Register.EventRollNo.ToString(), BoldFontHeading));
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.WHITE;
                    TableCell.BorderColorTop = BaseColor.BLACK;
                    TableCell.BorderColorRight = BaseColor.BLACK;
                    TableCell.BorderColorBottom = BaseColor.BLACK;
                    TableCell.Padding = 4;
                    TableCell.Colspan = 2;
                    TableCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    Table.AddCell(TableCell);

                    TableCell = new PdfPCell(new Phrase("Name ", NormalFont));
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.WHITE;
                    TableCell.BorderColorTop = BaseColor.BLACK;
                    TableCell.BorderColorRight = BaseColor.WHITE;
                    TableCell.BorderColorBottom = BaseColor.WHITE;
                    TableCell.Padding = 4;
                    TableCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    Table.AddCell(TableCell);

                    TableCell = new PdfPCell(new Phrase(": " + Register.StudentName, NormalFont));
                    TableCell.UseVariableBorders = true;
                    TableCell.BorderColorLeft = BaseColor.WHITE;
                    TableCell.BorderColorTop = BaseColor.BLACK;
                    TableCell.BorderColorRight = BaseColor.WHITE;
                    TableCell.BorderColorBottom = BaseColor.WHITE;
                    TableCell.Padding = 4;
                    TableCell.Colspan = 2;
                    TableCell.HorizontalAlignment = Element.ALIGN_LEFT;
                    Table.AddCell(TableCell);                    

                    Table.AddCell(CreateCell("Category", BoldFont, true,1));
                    Table.AddCell(CreateCell(": " + Register.Category.CategoryName, BoldFont, true,2));

                    Table.AddCell(CreateCell("Student ID", NormalFont, true,1));
                    Table.AddCell(CreateCell(": " + Register.RollNo, NormalFont, true,2));

                    Table.AddCell(CreateCell("Event", BoldFont, true,1));
                    Table.AddCell(CreateCell(": " + Register.Event.EventName, BoldFont, true,2));

                    Table.AddCell(CreateColSpanCell(Register.School.Name+" "+ Register.School.Address, NormalFontHeading));
                    Table.AddCell(CreateColSpanCell("Wish you all the best", NormalFont));
                    pdfDoc.Add(Table);
                    pdfDoc.Close();
                    SaveMemoryStream(myMemoryStream);
                }


            }
        }
        public static string NameSplit(string Ename)
        {
            string Output = string.Empty;
            string[] split = Ename.Split(' ');
            foreach (var word in split)
            {
                Output += word[0].ToString();
            }
            return Output;
        }
        public static PdfPCell CreateCell(string Txt, iTextSharp.text.Font font, bool left,int cols)
        {           
            PdfPCell rowCell = new PdfPCell();
            rowCell = new PdfPCell(new Phrase(Txt, font));
            rowCell.UseVariableBorders = true;
            rowCell.BorderColorLeft = BaseColor.WHITE;
            rowCell.BorderColorTop = BaseColor.WHITE;
            rowCell.BorderColorRight = BaseColor.WHITE;
            rowCell.BorderColorBottom = BaseColor.WHITE;
            rowCell.Padding = 4;
            rowCell.Colspan = cols;
            rowCell.HorizontalAlignment = left? Element.ALIGN_LEFT: Element.ALIGN_RIGHT;
            return rowCell;
        }
        public static PdfPCell CreateColSpanCell(string Txt, iTextSharp.text.Font font)
        {
            PdfPCell rowCell = new PdfPCell();
            rowCell = new PdfPCell(new Phrase(Txt, font));
            rowCell.UseVariableBorders = true;
            rowCell.BorderColorLeft = BaseColor.WHITE;
            rowCell.BorderColorTop = BaseColor.WHITE;
            rowCell.BorderColorRight = BaseColor.WHITE;
            rowCell.BorderColorBottom = BaseColor.WHITE;
            rowCell.Padding = 4;
            rowCell.Colspan = 3;
            rowCell.HorizontalAlignment = Element.ALIGN_CENTER;
            return rowCell;
        }
        public static bool SaveMemoryStream(MemoryStream ms)
        {
            bool wasFileSaved = false;
            try
            {
                SaveFileDialog sfDlg = new SaveFileDialog();
                try
                {
                    sfDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);                    
                    sfDlg.RestoreDirectory = true;
                    sfDlg.FileName = "print";
                    var windowsTempPath = Path.GetTempPath();
                    Directory.CreateDirectory(windowsTempPath + "");
                    var printFilePath = String.Format("{0}", windowsTempPath);
                    var printFileName = String.Format("{0}.pdf", sfDlg.FileName);
                    var tempFilePath = String.Format("{0}\\{1}.pdf", Path.GetTempPath(), sfDlg.FileName);
                    byte[] bytes = ms.ToArray();                   
                    try
                    {
                        File.WriteAllBytes(printFilePath + "\\" + printFileName, bytes);
                        Print(printFilePath + printFileName);
                    }
                    catch (Exception e)
                    {
                        if (e.Message.Contains("The process cannot access the file"))
                        {
                            Random random = new Random();
                            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                            string randomFileName = new string(Enumerable.Repeat(chars, 5).Select(s => s[random.Next(s.Length)]).ToArray());
                            var printFilePathCatch = String.Format("{0}", windowsTempPath);
                            printFileName = String.Format("{0}Print{1}.pdf", sfDlg.FileName, randomFileName);
                            File.WriteAllBytes(printFilePathCatch + "\\" + printFileName, bytes);
                            Print(printFilePath + printFileName);
                        }
                    }                   
                }
                finally
                {
                    sfDlg.Dispose();
                }
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message,"Aborted",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            return wasFileSaved;
        }
        public static void Print(string pdfFileName)
        {
            string processFilename = Microsoft.Win32.Registry.LocalMachine
                    .OpenSubKey("Software")
                    .OpenSubKey("Microsoft")
                    .OpenSubKey("Windows")
                    .OpenSubKey("CurrentVersion")
                    .OpenSubKey("App Paths")
                    .OpenSubKey("AcroRd32.exe")
                    .GetValue(String.Empty).ToString();
            ProcessStartInfo info = new ProcessStartInfo();
            info.Verb = "print";
            info.FileName = processFilename;
            info.Arguments = String.Format("/p /h {0}", pdfFileName);
            info.CreateNoWindow = true;
            info.WindowStyle = ProcessWindowStyle.Hidden;
            info.UseShellExecute = false;
            Process p = Process.Start(info);
            p.StartInfo.WindowStyle = ProcessWindowStyle.Normal;
            int counter = 0;
            while (!p.HasExited)
            {
                System.Threading.Thread.Sleep(500);
                counter += 1;
                if (counter == 25)
                    break;
            }
            if (!p.HasExited)
            {
                p.CloseMainWindow();
                p.Kill();
            }
        }
    }
}