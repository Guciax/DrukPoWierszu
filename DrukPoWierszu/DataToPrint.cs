using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrukPoWierszu
{
    public class DataToPrint
    {
        public static List<WorkerData> ItemsToPrint = new List<WorkerData>();
        public class WorkerData
        {
            public List<ItemStruct> ItemToPrint { get; set; } = new List<ItemStruct>();
        }
        public class ItemStruct
        {
            public string HeaderName { get; set; }
            public string ItemValue { get; set; }
        }
        public static void PrepareDataToPrint(List<int> excelRowsIndexes)
        {
            ItemsToPrint = new List<WorkerData>();
            var headers = ExcelFileData.HeaderCells;

            foreach (var rowIdx in excelRowsIndexes)
            {
                
                WorkerData newWorkerData = new WorkerData();
                for (int c = 1; c <= headers.Count; c++)
                {
                    ItemStruct newItem = new ItemStruct();
                    newItem.HeaderName = headers[c - 1];
                    newItem.ItemValue = SafeGetCellValue(ExcelFileData.ExcelFile.Workbook.Worksheets[ExcelFileData.SelectedWorkSheet].Cells[rowIdx, c]);

                    newWorkerData.ItemToPrint.Add(newItem);
                }

                ItemsToPrint.Add(newWorkerData);
            }
        }

        private static string SafeGetCellValue(OfficeOpenXml.ExcelRange cell)
        {
            if (cell == null) return "";
            if (cell.Value == null) return "";
            return cell.Value.ToString();
        }
    }
}
