using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrukPoWierszu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numHeaderRowIndex.Value = 1;
            OpenFileDialog theDialog = new OpenFileDialog();
            theDialog.Title = "Wybierz plik excel.";
            theDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            if (theDialog.ShowDialog() == DialogResult.OK)
            {
                ExcelFileData.loadExcel(theDialog.FileName);
                FillOutWorksheetsCombo();
            }
        }

        private void FillOutWorksheetsCombo()
        {
            cbWorksheets.Items.Clear();
            if (ExcelFileData.ExcelFile == null) return;
            if (ExcelFileData.ExcelFile.Workbook.Worksheets.Count == 0) return;
            cbWorksheets.Items.AddRange(ExcelFileData.ExcelFile.Workbook.Worksheets.Select(w => w.Name).ToArray());
            
        }

        private void PreviewHeaderRow()
        {
            if (!ExcelFileData.ExcelFile.Workbook.Worksheets.Select(w => w.Name).Contains(cbWorksheets.SelectedItem.ToString()))
            {
                lHeaderPreview.Text = "Nieprawidłowy arkusz.";
                return;
            }
            //int selectedRow = (int)numHeaderRowIndex.Value ;
            //List<string> headerCellValues = new List<string>();
            //for (int c = 1; c < 6; c++)
            //{
            //    headerCellValues.Add(SafeGetCellValue(ExcelFileData.ExcelFile.Workbook.Worksheets[cbWorksheets.SelectedItem.ToString()].Cells[selectedRow, c]));
            //}
            string headerPreviewText = string.Join(" | ", ExcelFileData.HeaderCells.Take(5));

            lHeaderPreview.Text = headerPreviewText;
        }

        private string SafeGetCellValue(OfficeOpenXml.ExcelRange cell)
        {
            if (cell == null) return "";
            if (cell.Value == null) return "";
            return cell.Value.ToString();
        }

        private void numHeaderRowIndex_ValueChanged(object sender, EventArgs e)
        {
            ExcelFileData.HeaderRowIndex = (int)numHeaderRowIndex.Value;
            PreviewHeaderRow();
        }

        private void cbWorksheets_SelectedIndexChanged(object sender, EventArgs e)
        {
            ExcelFileData.SelectedWorkSheet = cbWorksheets.SelectedItem.ToString();
            ExcelFileData.HeaderRowIndex = (int)numHeaderRowIndex.Value;
            PreviewHeaderRow();
            PreviewDgv();
        }

        private void PreviewDgv()
        {
            if (dgv.Columns.Count == 0) SetUpDgvColumns();
            dgv.Rows.Clear();

            for (int r = ExcelFileData.HeaderRowIndex+1; r < ExcelFileData.ExcelFile.Workbook.Worksheets[ExcelFileData.SelectedWorkSheet].Dimension.End.Row; r++)
            {
                string cell1Value = SafeGetCellValue(ExcelFileData.ExcelFile.Workbook.Worksheets[ExcelFileData.SelectedWorkSheet].Cells[r, 1]);
                string cell2Value = SafeGetCellValue(ExcelFileData.ExcelFile.Workbook.Worksheets[ExcelFileData.SelectedWorkSheet].Cells[r, 2]);
                string cell3Value = SafeGetCellValue(ExcelFileData.ExcelFile.Workbook.Worksheets[ExcelFileData.SelectedWorkSheet].Cells[r, 3]);
                //if (string.IsNullOrWhiteSpace(cell1Value) & string.IsNullOrWhiteSpace(cell2Value) & string.IsNullOrWhiteSpace(cell3Value)) continue;
                dgv.Rows.Add(true, cell1Value, cell2Value, cell3Value);
            }
        }
        private void SetUpDgvColumns()
        {
            DataGridViewCheckBoxColumn cbCol = new DataGridViewCheckBoxColumn();
            cbCol.HeaderText = "Wybór";
            cbCol.Name = "cbCol";

            dgv.Columns.Add(cbCol);
            dgv.Columns.Add("Col2", "");
            dgv.Columns.Add("Col3", "");
            dgv.Columns.Add("Col4", "");
        }

        private void bSelectAll_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[0].Value = true;
            }
        }

        private void bSelectNone_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv.Rows)
            {
                row.Cells[0].Value = false;
            }
        }

        private void bPrint_Click(object sender, EventArgs e)
        {
            List<int> rowIndexesToPrint = new List<int>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                if (Convert.ToBoolean(row.Cells[0].Value) == true) rowIndexesToPrint.Add(row.Index +1 + ExcelFileData.HeaderRowIndex);
            }
            DataToPrint.PrepareDataToPrint(rowIndexesToPrint);
            Print.PrintData();
        }
    }
}
