using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml;

namespace Project01_GaraLongSpeed.Export_file
{
    internal class ExportToExcel
    {
        public void xuatEXCEL(DataGridView dataGridView, string filePath, int y)
        {
            // Tạo một tệp Excel mới
            using (SpreadsheetDocument document = SpreadsheetDocument.Create(filePath, SpreadsheetDocumentType.Workbook))
            {
                WorkbookPart workbookPart = document.AddWorkbookPart();
                workbookPart.Workbook = new Workbook();

                WorksheetPart worksheetPart = workbookPart.AddNewPart<WorksheetPart>();
                worksheetPart.Worksheet = new Worksheet(new SheetData());

                Sheets sheets = workbookPart.Workbook.AppendChild(new Sheets());
                Sheet sheet = new Sheet()
                {
                    Id = workbookPart.GetIdOfPart(worksheetPart),
                    SheetId = 1,
                    Name = "Sheet1"
                };
                sheets.Append(sheet);

                // Lấy dữ liệu từ DataGridView
                DataTable dt = new DataTable();
                for (int i = 0; i < y; i++)
                {
                    DataGridViewColumn column = dataGridView.Columns[i];
                    dt.Columns.Add(column.HeaderText);
                }
                foreach (DataGridViewRow row in dataGridView.Rows)
                {
                    DataRow dataRow = dt.NewRow();
                    for (int j = 0; j < y; j++)
                    {
                        DataGridViewCell cell = row.Cells[j];
                        dataRow[j] = cell.Value;
                    }
                    dt.Rows.Add(dataRow);
                }

                // Thêm tiêu đề
                SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();
                Row headerRow = new Row();
                for (int i = 0; i < y; i++)
                {
                    DataGridViewColumn column = dataGridView.Columns[i];
                    Cell cell = new Cell();
                    cell.DataType = CellValues.String;
                    cell.CellValue = new CellValue(column.HeaderText);
                    headerRow.Append(cell);
                }
                sheetData.Append(headerRow);

                // Ghi dữ liệu vào tệp Excel
                foreach (DataRow row in dt.Rows)
                {
                    Row excelRow = new Row();
                    foreach (var cellValue in row.ItemArray)
                    {
                        Cell cell = new Cell();
                        cell.DataType = CellValues.String;
                        cell.CellValue = new CellValue(cellValue.ToString());
                        excelRow.Append(cell);
                    }
                    sheetData.Append(excelRow);
                }

                workbookPart.Workbook.Save();
            }
        }
    }
}
