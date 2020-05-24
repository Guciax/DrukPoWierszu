using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrukPoWierszu
{
    public class ExcelFileData
    {
        private static int _HeaderRowIndex = 1;

        public static OfficeOpenXml.ExcelPackage ExcelFile { get; set; }
        public static string SelectedWorkSheet { get; set; }
        public static int HeaderRowIndex 
        { 
            get { return _HeaderRowIndex; }
            set 
            { 
                _HeaderRowIndex = value;
                GetHeaderCells();
            }
        }
        public static List<string> HeaderCells { get; set; }

        private static void GetHeaderCells()
        {
            HeaderCells = new List<string>();
            int lastNotEmptyItemIndex = 0;
            for (int c = 1; c <= ExcelFile.Workbook.Worksheets[SelectedWorkSheet].Dimension.End.Column; c++)
            {
                string cellValue = "";
                if(ExcelFile.Workbook.Worksheets[SelectedWorkSheet].Cells[HeaderRowIndex, c].Value != null)
                {
                    cellValue = ExcelFile.Workbook.Worksheets[SelectedWorkSheet].Cells[HeaderRowIndex, c].Value.ToString();
                    lastNotEmptyItemIndex = HeaderCells.Count + 1;
                }
                HeaderCells.Add(cellValue);
            }

            HeaderCells = HeaderCells.Take(lastNotEmptyItemIndex).ToList();
        }

        public static void loadExcel(string FilePath)
        {
            OfficeOpenXml.ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (File.Exists(FilePath))
            {
                var fs = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                var pck = new OfficeOpenXml.ExcelPackage();
                try
                {
                    pck = new OfficeOpenXml.ExcelPackage(fs);
                }
                catch (Exception e) 
                { 
                    MessageBox.Show(e.Message);
                    return;
                }

                ExcelFile = pck;
            }

        }
    }
}
