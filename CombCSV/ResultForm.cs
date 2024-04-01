using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CombCSV
{
    public partial class ResultForm : Form
    {
        public ResultForm()
        {
            InitializeComponent();
        }

        private string firstUpper(string str)
        {
            if (string.IsNullOrEmpty(str))
            {
                return "";
            }
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        private void ResultForm_Load(object sender, EventArgs e)
        {
            dataGridViewResult.Rows.Clear();
            for (int i = 0; i < rlt.Count; i++)
            {
                dataGridViewResult.Rows.Add();
                dataGridViewResult.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridViewResult.Rows[i].Cells[1].Value = false;
                dataGridViewResult.Rows[i].Cells[2].Value = firstUpper(rlt[i]);
                string[] strs = rlt1[i % cnt1].Split('*');
                if (strs.Length > 0)
                {
                    dataGridViewResult.Rows[i].Cells[3].Value = firstUpper(strs[0]);
                } else
                {
                    dataGridViewResult.Rows[i].Cells[3].Value = "";
                }

                if (strs.Length > 1)
                {
                    dataGridViewResult.Rows[i].Cells[4].Value = firstUpper(strs[1]);
                }
                else
                {
                    dataGridViewResult.Rows[i].Cells[4].Value = "";
                }
                if (strs.Length > 2)
                {
                    dataGridViewResult.Rows[i].Cells[5].Value = firstUpper(strs[2]);
                }
                else
                {
                    dataGridViewResult.Rows[i].Cells[5].Value = "";
                }
            }

            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.Location = new Point(70, 10);
            dataGridViewResult.Controls.Add(headerCheckBox);
            dataGridViewResult.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewResult.Columns[1].HeaderCell.Value = "";

            // Handle the CheckBox.CheckedChanged event
            headerCheckBox.CheckedChanged += (s, ev) =>
            {
                foreach (DataGridViewRow row in dataGridViewResult.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[1] as DataGridViewCheckBoxCell;
                    if (checkBox != null)
                    {
                        checkBox.Value = headerCheckBox.Checked;
                    }
                }
            };
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridViewResult.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[1] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value == true)
                {
                    rowsToRemove.Add(row);
                }
            }
            foreach (DataGridViewRow row in rowsToRemove)
            {
                dataGridViewResult.Rows.Remove(row);
            }
            for (int i = 0; i < dataGridViewResult.Rows.Count - 1; i++)
            {
                dataGridViewResult.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dataGridViewResult, saveFileDialog.FileName);
            }
        }

        static void ExportToExcel(DataGridView dgv, string filePath)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                excelApp.Visible = false;
                Excel.Workbook workbook = excelApp.Workbooks.Add(Type.Missing);
                Excel.Worksheet worksheet = workbook.ActiveSheet;

                // Set Excel column headers using DataGridView column headers
                for (int i = 1; i <= dgv.Columns.Count; i++)
                {
                    if (i == 2) continue;
                    if (i < 2)
                    {
                        worksheet.Cells[1, i] = dgv.Columns[i - 1].HeaderText;
                    }
                    else
                    {
                        worksheet.Cells[1, i - 1] = dgv.Columns[i - 1].HeaderText;
                    }
                }

                // Copy DataGridView rows to Excel cells
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (j == 1) continue;
                        if (j < 1)
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
                        } else
                        {
                            worksheet.Cells[i + 2, j] = dgv.Rows[i].Cells[j].Value.ToString();
                        }
                        
                    }
                }

                // Save the Excel file
                workbook.SaveAs(filePath);
                workbook.Close();
                excelApp.Quit();
                MessageBox.Show("Data exported to Excel successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error exporting data to Excel: " + ex.Message);
            }
        }
    }
}
