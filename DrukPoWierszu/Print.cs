using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrukPoWierszu
{
    public class Print
    {
        private static int pagesToPrint = 1;
        private static int currentPageIdxToPrint = 0;

        public static void PrintData()
        {
            pagesToPrint = DataToPrint.ItemsToPrint.Count;
            currentPageIdxToPrint = 0;
            PrintDocument printDoc = new PrintDocument();
            printDoc.PrintPage += PrintDoc_PrintPage;
            printDoc.Print();
        }
        private static void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font printFontArial10 = new Font("Arial", 8, FontStyle.Regular);

            var currentDataToPrint = DataToPrint.ItemsToPrint[currentPageIdxToPrint];
            var allHeaders = currentDataToPrint.ItemToPrint.Select(x => x.HeaderName);
            var longestHeader = allHeaders.Select(x => g.MeasureString(x, printFontArial10).Width).Max();

            float leftMargin = 20.0f;
            float topMargin = 40.0f;
            float lineInc = 20.0f;

            for (int i = 0; i < currentDataToPrint.ItemToPrint.Count; i++)
            {
                string header = currentDataToPrint.ItemToPrint[i].HeaderName;
                string value = currentDataToPrint.ItemToPrint[i].ItemValue;
                var headerLength = g.MeasureString(header, printFontArial10);


                e.Graphics.DrawString(header, printFontArial10, Brushes.Black, leftMargin + (longestHeader - headerLength.Width), topMargin + lineInc * i);
                e.Graphics.DrawString(value, printFontArial10, Brushes.Black, leftMargin + longestHeader + 10, topMargin + lineInc * i);
            }
            
            currentPageIdxToPrint++;
            if (currentPageIdxToPrint < pagesToPrint)
            {
                e.HasMorePages = true;
            }
            else
            {
                e.HasMorePages = false;
            }
        }
    }
}
