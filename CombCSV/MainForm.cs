using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace CombCSV
{
    public partial class MainForm : Form
    {
        private int seled = -1;
        private List<DataTable> dtList = new List<DataTable>();
        private int cnt = 0;
        private List<string> rlt = new List<string>();
        private int[] stacks = new int[1];
        private int stack_num = 0;


        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            dtList.Clear();
            
            int sz = listboxWord.Items.Count;
            for (int i  = 0; i < sz; i++)
            {
                DataTable dt = new DataTable();
                dtList.Add(dt);
            }

            CheckBox headerCheckBox = new CheckBox();
            headerCheckBox.Size = new Size(15, 15);
            headerCheckBox.Location = new Point(70, 10);
            dataGridViewMain.Controls.Add(headerCheckBox);
            dataGridViewMain.Columns[1].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewMain.Columns[1].HeaderCell.Value = "";

            // Handle the CheckBox.CheckedChanged event
            headerCheckBox.CheckedChanged += (s, ev) =>
            {
                foreach (DataGridViewRow row in dataGridViewMain.Rows)
                {
                    DataGridViewCheckBoxCell checkBox = row.Cells[1] as DataGridViewCheckBoxCell;
                    if (checkBox != null)
                    {
                        checkBox.Value = headerCheckBox.Checked;
                    }
                }
            };
        }

        private void btnWorkModify_Click(object sender, EventArgs e)
        {
            if (listboxWord.SelectedIndex < 1) return;

            var tmpValue = listboxWord.Items[listboxWord.SelectedIndex].ToString();
            ValueInputForm newRoomDisplayForm = new ValueInputForm();
            newRoomDisplayForm.value = tmpValue;
            newRoomDisplayForm.ShowDialog();
            if (newRoomDisplayForm.DialogResult == DialogResult.OK)
            {
                listboxWord.Items[listboxWord.SelectedIndex] = newRoomDisplayForm.value;
            }
        }

        private void btnWordEdit_Click(object sender, EventArgs e)
        {
            listboxWord.Items.Add("New Item");
            DataTable dt = new DataTable();
            dtList.Add(dt);
        }

        private void btnWordDelete_Click(object sender, EventArgs e)
        {
            if (listboxWord.SelectedIndex < 1) return;
            int selected = listboxWord.SelectedIndex;
            listboxWord.Items.RemoveAt(listboxWord.SelectedIndex);
            dtList.RemoveAt(selected);
            if (listboxWord.Items.Count < selected + 1) { selected--; }
            listboxWord.SelectedIndex = selected;
            seled = selected;
        }

        private void dataGridViewMain_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //int sz = dataGridViewMain.RowCount;
            //int r = dataGridViewMain.CurrentCell.RowIndex;
            //int c = dataGridViewMain.CurrentCell.ColumnIndex;
            //if (r != e.RowIndex || c != e.ColumnIndex || r != sz - 1 || dataGridViewMain.CurrentCell.Value == "" || dataGridViewMain.CurrentCell.Value == null)
            //{
            //    return;
            //}
            //dataGridViewMain.Rows[r].Cells[0].Value = sz.ToString();
            //dataGridViewMain.Rows.Add();
            //dataGridViewMain.Rows[sz].Cells[1].Value = false;
            //lblTotal.Text = (dataGridViewMain.Rows.Count).ToString();
            //saveDataToDT();
            //if (MouseButtons == MouseButtons.Left || MouseButtons == MouseButtons.Right) {
            //    return;
            //}
            //dataGridViewMain.CurrentCell = dataGridViewMain.Rows[sz].Cells[2];
            //dataGridViewMain.BeginEdit(true);
        }
        private void btnContentEdit_Click(object sender, EventArgs e)
        {
            if (seled < 0)
            {
                MessageBox.Show("Select One Item.");
                return;
            }
            MultiInputForm newRoomDisplayForm = new MultiInputForm();
            newRoomDisplayForm.value = "";
            newRoomDisplayForm.ShowDialog();
            if (newRoomDisplayForm.DialogResult == DialogResult.OK)
            {
                string[] items = newRoomDisplayForm.value.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                int sz = dataGridViewMain.Rows.Count;
                foreach (string item in items)
                {
                    if (item == null || item == "") continue;
                    dataGridViewMain.Rows.Add();
                    dataGridViewMain.Rows[sz].Cells[0].Value = (sz + 1).ToString();
                    dataGridViewMain.Rows[sz].Cells[1].Value = false;
                    dataGridViewMain.Rows[sz].Cells[2].Value = item;
                    sz++;
                }
                saveDataToDT();
                lblTotal.Text = (dataGridViewMain.Rows.Count).ToString();
            }
        }
        private void btnContentDelete_Click(object sender, EventArgs e)
        {
            List<DataGridViewRow> rowsToRemove = new List<DataGridViewRow>();

            foreach (DataGridViewRow row in dataGridViewMain.Rows)
            {
                DataGridViewCheckBoxCell checkBoxCell = row.Cells[1] as DataGridViewCheckBoxCell;
                if (checkBoxCell != null && (bool)checkBoxCell.Value == true)
                {
                    rowsToRemove.Add(row);
                }
            }
            foreach (DataGridViewRow row in rowsToRemove)
            {
                dataGridViewMain.Rows.Remove(row);
            }
            for (int i = 0; i < dataGridViewMain.Rows.Count - 1; i ++)
            {
                dataGridViewMain.Rows[i].Cells[0].Value = (i + 1).ToString();
            }
            lblTotal.Text = (dataGridViewMain.Rows.Count).ToString();
            saveDataToDT();
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
                    } else
                    {
                        worksheet.Cells[1, i - 1] = dgv.Columns[i - 1].HeaderText;
                    }
                }

                // Copy DataGridView rows to Excel cells
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        if (j == 1 || dgv.Rows[i].Cells[j].Value == null) continue;
                        if (j > 1)
                        {
                            worksheet.Cells[i + 2, j] = dgv.Rows[i].Cells[j].Value.ToString();
                        } else
                        {
                            worksheet.Cells[i + 2, j + 1] = dgv.Rows[i].Cells[j].Value.ToString();
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

        private void btnContentExport_Click(object sender, EventArgs e)
        {

            if (seled < 0)
            {
                MessageBox.Show("Select One Item.");
                return;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                ExportToExcel(dataGridViewMain, saveFileDialog.FileName);
            }
        }

        private void btnContentImport_Click(object sender, EventArgs e)
        {
            if (seled < 0)
            {
                MessageBox.Show("Select One Item.");
                return;
            }
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel files(*.xlsx)|*.xlsx";
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() == DialogResult.OK )
            {
                Excel.Application excelApp = new Excel.Application();
                Excel.Workbook workbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                Excel.Worksheet worksheet = workbook.Sheets[1];
                int rowCount = worksheet.UsedRange.Rows.Count;
                int colCount = worksheet.UsedRange.Columns.Count;
                dataGridViewMain.Rows.Clear();
                for (int i = 2; i <= rowCount; i ++)
                {
                    dataGridViewMain.Rows.Add();
                    for(int j = 1; j <= colCount; j ++) {
                        string cellValue;
                        if (worksheet.Cells[i, j].Value == null)
                        {
                            cellValue = "";
                        } else
                        {
                            cellValue = worksheet.Cells[i, j].Value.ToString();
                        }
                        
                        if (j == 1)
                        {
                            dataGridViewMain.Rows[i - 2].Cells[j - 1].Value = cellValue;
                        } else
                        {
                            dataGridViewMain.Rows[i - 2].Cells[j].Value = cellValue;
                        }
                        dataGridViewMain.Rows[i - 2].Cells[1].Value = false;
                    }
                }
                lblTotal.Text = (dataGridViewMain.Rows.Count).ToString();
                MessageBox.Show("Data imported from csv file successfully.");
            }
        }

        private void listboxWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            saveDataToDT();
            dataGridViewMain.Columns[2].HeaderText = listboxWord.Text;
            int idx = listboxWord.SelectedIndex;
            if (idx < 0)
            {
                return;
            }
            seled = idx;
            DataTable dt = dtList.ElementAt(idx);
            int sz = dt.Rows.Count;
            dataGridViewMain.Rows.Clear();
            for (int i = 0; i < sz; i++)
            {
                dataGridViewMain.Rows.Add();
                dataGridViewMain.Rows[i].Cells[0].Value = (i + 1).ToString();
                dataGridViewMain.Rows[i].Cells[1].Value = false;
                dataGridViewMain.Rows[i].Cells[2].Value = dt.Rows[i][2];
            }
            lblTotal.Text = (dataGridViewMain.Rows.Count).ToString();
        }

        private void saveDataToDT()
        {
            if (seled < 0 || seled >= dtList.Count) return;
            DataTable dt = new DataTable();
            foreach (DataGridViewColumn col in dataGridViewMain.Columns)
            {
                dt.Columns.Add(col.Name);
            }
            foreach(DataGridViewRow row in dataGridViewMain.Rows)
            {
                DataRow dRow = dt.NewRow();
                foreach (DataGridViewCell cell in row.Cells)
                {
                    dRow[cell.ColumnIndex] = cell.Value;
                }
                dt.Rows.Add(dRow);
            }
            dtList[seled] = dt;
        }

        private void showContextMenu(int x, int y, int t)
        {
            var txt = txtInput1;
            switch (t)
            {
                case 0:
                    txt = txtInput1;
                    break;
                case 1:
                    txt = txtInput2;
                    break;
                case 2:
                    txt = txtInput3;
                    break;
                case 3:
                    txt = txtInput4;
                    break;
                default:
                    txt = txtInput1;
                    break;
            }

            ContextMenuStrip context = new ContextMenuStrip();
            ToolStripMenuItem toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem1.Text = "Insert Word";

            foreach (var item in listboxWord.Items)
            {
                ToolStripMenuItem toolStripSubT = new ToolStripMenuItem();
                toolStripSubT.Text = item.ToString();
                toolStripSubT.Click += (sender, e) =>
                {
                    txt.Text = insertText(txt.Text, item.ToString());
                };
                toolStripMenuItem1.DropDownItems.Add(toolStripSubT);
            }

            context.Items.Add(toolStripMenuItem1);

            if (t >= 0)
            {
                ToolStripMenuItem toolStripMenuItem2 = new ToolStripMenuItem();
                toolStripMenuItem2.Text = "Insert Keyword";

                ToolStripMenuItem toolStripSub1 = new ToolStripMenuItem();
                toolStripSub1.Text = "Keyword1";
                toolStripSub1.Click += (sender, e) =>
                {
                    txt.Text = insertText(txt.Text, "Keyword1");
                };
                toolStripMenuItem2.DropDownItems.Add(toolStripSub1);
                ToolStripMenuItem toolStripSub2 = new ToolStripMenuItem();
                toolStripSub2.Text = "Keyword2";
                toolStripSub2.Click += (sender, e) =>
                {
                    txt.Text = insertText(txt.Text, "Keyword2");
                };
                toolStripMenuItem2.DropDownItems.Add(toolStripSub2);
                ToolStripMenuItem toolStripSub3 = new ToolStripMenuItem();
                toolStripSub3.Text = "Keyword3";
                toolStripSub3.Click += (sender, e) =>
                {
                    txt.Text = insertText(txt.Text, "Keyword3");
                };
                toolStripMenuItem2.DropDownItems.Add(toolStripSub3);
                context.Items.Add(toolStripMenuItem2);
            }

            ToolStripMenuItem toolStripMenuItem3 = new ToolStripMenuItem();
            toolStripMenuItem3.Text = "Default";
            toolStripMenuItem3.Click += (sender, e) =>
            {
                int sz = dtList[0].Rows.Count;
                txt.Text = "";
                switch (t)
                {
                    case 0:
                        txt.Text = "[Prefix][Product Keyword][Suffix]";
                        break;
                    case 1:
                        txt.Text = "[Product Keyword]";
                        break;
                    case 2:
                        txt.Text = "[Random]";
                        break;
                    case 3:
                        txt.Text = "[Random]";
                        break;
                    default:
                        break;
                }
            };
            context.Items.Add(toolStripMenuItem3);

            ToolStripMenuItem toolStripMenuItem4 = new ToolStripMenuItem();
            toolStripMenuItem4.Text = "Empty";
            toolStripMenuItem4.Click += (sender, e) =>
            {
                txt.Text = "";
            };
            context.Items.Add(toolStripMenuItem4);

            context.Show(this, new Point(x, y));
        }

        private string insertText(string origin, string str)
        {
            if (origin.IndexOf("[" + str + "]") != -1)
            {
                return origin.Replace("[" + str + "]", "").Trim();
            }
            if (origin == "[Random]")
            {
                return "[" + str + "]";
            }
            return origin + "[" + str + "]";
        }

        private void btnInsert1_Click(object sender, EventArgs e)
        {
            int x = groupBox3.Location.X + btnInsert1.Location.X;
            int y = groupBox3.Location.Y + btnInsert1.Location.Y + btnInsert1.Height;
            showContextMenu(x, y, 0);
        }

        private void btnInsert2_Click(object sender, EventArgs e)
        {
            int x = groupBox3.Location.X + btnInsert2.Location.X;
            int y = groupBox3.Location.Y + btnInsert2.Location.Y + btnInsert2.Height;
            showContextMenu(x, y, 1);
        }

        private void btnInsert3_Click(object sender, EventArgs e)
        {
            int x = groupBox3.Location.X + btnInsert3.Location.X;
            int y = groupBox3.Location.Y + btnInsert3.Location.Y + btnInsert3.Height;
            showContextMenu(x, y, 2);
        }

        private void btnInsert4_Click(object sender, EventArgs e)
        {
            int x = groupBox3.Location.X + btnInsert4.Location.X;
            int y = groupBox3.Location.Y + btnInsert4.Location.Y + btnInsert4.Height;
            showContextMenu(x, y, 3);
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void prework(bool isDup, string pt)
        {
            string k1 = txtInput2.Text;
            string k2 = txtInput3.Text;
            string k3 = txtInput4.Text;
            pt = pt.Replace("[Keyword1]", k1);
            pt = pt.Replace("[Keyword2]", k2);
            pt = pt.Replace("[Keyword3]", k3);
            int sz = listboxWord.Items.Count;
            for (int i = 0; i < sz; i ++)
            {
                string str = "[" + listboxWord.Items[i].ToString() + "]";
                pt = pt.Replace(str, i.ToString() + ",");
            }
            pt = pt.Replace("[Random]", "-1,");
            pt = pt.Substring(0, pt.Length - 1);
            string[] numbers = pt.Split(',');
            int[] nums = new int[numbers.Length];
            sz = 0;
            for (int i = 0; i < numbers.Length; i ++)
            {
                if (numbers[i] == "-1")
                {
                    nums[sz++] = -1;
                    continue;
                }
                if (isDup)
                {
                    nums[sz++] = int.Parse(numbers[i]);
                    continue;
                }
                int j;
                for (j = i + 1; j < numbers.Length; j ++)
                {
                    if (numbers[i] == numbers[j]) break;
                }
                if (j == numbers.Length)nums[sz ++] = int.Parse(numbers[i]);
            }
            Array.Resize(ref nums, sz);
            stack_num = sz;
            stacks = nums;
        }
        private void calc(int v, string cur, bool isDup)
        {
            string temp = cur;
            if (v == stack_num)
            {
                temp = cur.Substring(0, cur.Length - 1);
                int idx  = rlt.IndexOf(temp);
                if (idx != -1)
                {
                    rlt.RemoveAt(idx);
                    cnt--;
                }
                rlt.Add(temp);
                cnt++;
                return;
            }
            int t = stacks[v];
            if (t == -1) t = 0;
            for (int i = 0; i < dtList[t].Rows.Count; i ++)
            {
                if (isDup)
                {
                    calc(v + 1, temp + dtList[t].Rows[i][2] + " ", isDup);
                } else
                {
                    temp = temp.Replace(dtList[t].Rows[i][2] + " ", "");
                    calc(v + 1, temp + dtList[t].Rows[i][2] + " ", isDup);
                }
            }
        }

        private int getRandomNumber(int n)
        {
            if (n == 0) return -1;
            Random random = new Random(Guid.NewGuid().GetHashCode());
            int t = random.Next(n);
            return t;
        }

        private void bulkCreate()
        {
            
            for (int i = 0; i < dtList[0].Rows.Count; i ++)
            {
                string temp = "";
                for (int j = 0; j < stack_num; j ++)
                {
                    int t = stacks[j];
                    if (t == -1) t = 0;
                    int sz = dtList[t].Rows.Count;
                    if (sz == 0) continue;
                    if (j > 0) temp += " ";
                    if (stacks[j] == 0) temp += dtList[0].Rows[i][2];
                    else
                    {
                        int r = getRandomNumber(sz);
                        temp += dtList[t].Rows[r][2];
                    }
                }
                rlt.Add(temp);
                cnt++;
            }
        }

        private void calc2()
        {
            int[] temp = new int[1];
            prework(true, txtInput2.Text);
            temp = stacks;
            prework(true, txtInput3.Text);
            temp = ConcatArrays(temp, stacks);
            prework(true, txtInput3.Text);
            temp = ConcatArrays(temp, stacks);
            int sz = dtList[0].Rows.Count;
            for (int i = 0; i < sz; i ++)
            {
                List<int> rands = new List<int>();
                string tmp = "";
                for (int j = 0; j < sz; j ++) rands.Add(j);
                for (int j = 0; j < temp.Length; j ++)
                {
                    if (temp[j] == 0) {
                        rands.Remove(i);
                    }
                }
                for (int j = 0; j < temp.Length; j ++) {
                    if (temp[j] == -1)
                    {
                        int r = getRandomNumber(rands.Count);
                        int v = rands[r];
                        tmp = tmp + "*" + dtList[0].Rows[v][2];
                        rands.Remove(v);
                    } else
                    {
                        tmp = tmp + "*" + dtList[temp[j]].Rows[i % dtList[temp[j]].Rows.Count][2];
                    }
                }
                rlt.Add(tmp.Substring(1));
                cnt++;
            }
        }
        private int[] ConcatArrays(int[] a, int[] b)
        {
            int[] result = new int[a.Length + b.Length];
            Array.Copy(a, 0, result, 0, a.Length);
            Array.Copy(b, 0, result, a.Length, b.Length);
            return result;
        }


        private void btnGenerate_Click(object sender, EventArgs e)
        {
            cnt = 0;
            rlt = new List<string>();
            if (!chkBulk.Checked)
            {
                prework(chkDup.Checked, txtInput1.Text);
                bulkCreate();
            } else
            {
                prework(chkDup.Checked, txtInput1.Text);
                calc(0, "", chkDup.Checked);
            }
            ResultForm resultForm = new ResultForm();
            resultForm.cnt = cnt;
            resultForm.rlt = rlt;

            

            cnt = 0;
            rlt = new List<string>();
            calc2();
            resultForm.cnt1 = cnt;
            resultForm.rlt1 = rlt;


            resultForm.ShowDialog();
        }

        private string removeSelected(string fullText, int cur)
        {
            if (cur >= fullText.Length) cur = fullText.Length - 1;
            int i, st = cur, en = cur;
            for (i = cur; i >= 0; i --)
            {
                if (fullText.Substring(i, 1) == "[")
                {
                    st = i; break;
                }
            }
            for (i = cur; i < fullText.Length; i ++)
            {
                if (fullText.Substring(i, 1) == "]")
                {
                    en = i; break;
                }
            }
            string subText = fullText.Substring(st, en - st + 1);
            return fullText.Replace(subText, "");
        }

        private void txtInput1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtInput1.Text = removeSelected(txtInput1.Text, txtInput1.SelectionStart);
            }
        }

        private void txtInput2_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtInput2.Text = removeSelected(txtInput2.Text, txtInput2.SelectionStart);
            }
        }

        private void txtInput3_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtInput3.Text = removeSelected(txtInput3.Text, txtInput3.SelectionStart);
            }
        }

        private void txtInput4_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                txtInput4.Text = removeSelected(txtInput4.Text, txtInput4.SelectionStart);
            }
        }
    }
}
