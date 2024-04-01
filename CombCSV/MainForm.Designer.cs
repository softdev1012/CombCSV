namespace CombCSV
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listboxWord = new System.Windows.Forms.ListBox();
            this.btnWorkModify = new System.Windows.Forms.Button();
            this.btnWordDelete = new System.Windows.Forms.Button();
            this.btnWordEdit = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnContentEdit = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnContentExport = new System.Windows.Forms.Button();
            this.dataGridViewMain = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Keyword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.btnContentImport = new System.Windows.Forms.Button();
            this.btnContentDelete = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtInput4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnInsert4 = new System.Windows.Forms.Button();
            this.txtInput3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert3 = new System.Windows.Forms.Button();
            this.txtInput2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert2 = new System.Windows.Forms.Button();
            this.chkDup = new System.Windows.Forms.CheckBox();
            this.txtInput1 = new System.Windows.Forms.TextBox();
            this.btnInsert1 = new System.Windows.Forms.Button();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            this.chkBulk = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listboxWord);
            this.groupBox1.Controls.Add(this.btnWorkModify);
            this.groupBox1.Controls.Add(this.btnWordDelete);
            this.groupBox1.Controls.Add(this.btnWordEdit);
            this.groupBox1.Location = new System.Drawing.Point(10, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(350, 400);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1. Word Classification";
            // 
            // listboxWord
            // 
            this.listboxWord.FormattingEnabled = true;
            this.listboxWord.ItemHeight = 16;
            this.listboxWord.Items.AddRange(new object[] {
            "Product Keyword",
            "Prefix",
            "Suffix"});
            this.listboxWord.Location = new System.Drawing.Point(10, 65);
            this.listboxWord.Name = "listboxWord";
            this.listboxWord.Size = new System.Drawing.Size(330, 324);
            this.listboxWord.TabIndex = 3;
            this.listboxWord.SelectedIndexChanged += new System.EventHandler(this.listboxWord_SelectedIndexChanged);
            // 
            // btnWorkModify
            // 
            this.btnWorkModify.Location = new System.Drawing.Point(170, 25);
            this.btnWorkModify.Name = "btnWorkModify";
            this.btnWorkModify.Size = new System.Drawing.Size(70, 30);
            this.btnWorkModify.TabIndex = 2;
            this.btnWorkModify.Text = "Modify";
            this.btnWorkModify.UseVisualStyleBackColor = true;
            this.btnWorkModify.Click += new System.EventHandler(this.btnWorkModify_Click);
            // 
            // btnWordDelete
            // 
            this.btnWordDelete.Location = new System.Drawing.Point(90, 25);
            this.btnWordDelete.Name = "btnWordDelete";
            this.btnWordDelete.Size = new System.Drawing.Size(70, 30);
            this.btnWordDelete.TabIndex = 1;
            this.btnWordDelete.Text = "Delete";
            this.btnWordDelete.UseVisualStyleBackColor = true;
            this.btnWordDelete.Click += new System.EventHandler(this.btnWordDelete_Click);
            // 
            // btnWordEdit
            // 
            this.btnWordEdit.Location = new System.Drawing.Point(10, 25);
            this.btnWordEdit.Name = "btnWordEdit";
            this.btnWordEdit.Size = new System.Drawing.Size(70, 30);
            this.btnWordEdit.TabIndex = 0;
            this.btnWordEdit.Text = "Add";
            this.btnWordEdit.UseVisualStyleBackColor = true;
            this.btnWordEdit.Click += new System.EventHandler(this.btnWordEdit_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnContentEdit);
            this.groupBox2.Controls.Add(this.lblTotal);
            this.groupBox2.Controls.Add(this.btnContentExport);
            this.groupBox2.Controls.Add(this.dataGridViewMain);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.btnContentImport);
            this.groupBox2.Controls.Add(this.btnContentDelete);
            this.groupBox2.Location = new System.Drawing.Point(370, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(405, 400);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2. Contents";
            // 
            // btnContentEdit
            // 
            this.btnContentEdit.Location = new System.Drawing.Point(10, 25);
            this.btnContentEdit.Name = "btnContentEdit";
            this.btnContentEdit.Size = new System.Drawing.Size(70, 30);
            this.btnContentEdit.TabIndex = 4;
            this.btnContentEdit.Text = "Add";
            this.btnContentEdit.UseVisualStyleBackColor = true;
            this.btnContentEdit.Click += new System.EventHandler(this.btnContentEdit_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.Blue;
            this.lblTotal.Location = new System.Drawing.Point(371, 28);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 24);
            this.lblTotal.TabIndex = 9;
            // 
            // btnContentExport
            // 
            this.btnContentExport.Location = new System.Drawing.Point(250, 25);
            this.btnContentExport.Name = "btnContentExport";
            this.btnContentExport.Size = new System.Drawing.Size(70, 30);
            this.btnContentExport.TabIndex = 7;
            this.btnContentExport.Text = "Export";
            this.btnContentExport.UseVisualStyleBackColor = true;
            this.btnContentExport.Click += new System.EventHandler(this.btnContentExport_Click);
            // 
            // dataGridViewMain
            // 
            this.dataGridViewMain.AllowUserToAddRows = false;
            this.dataGridViewMain.AllowUserToDeleteRows = false;
            this.dataGridViewMain.AllowUserToResizeColumns = false;
            this.dataGridViewMain.AllowUserToResizeRows = false;
            this.dataGridViewMain.ColumnHeadersHeight = 30;
            this.dataGridViewMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.check,
            this.Keyword});
            this.dataGridViewMain.Location = new System.Drawing.Point(10, 65);
            this.dataGridViewMain.MultiSelect = false;
            this.dataGridViewMain.Name = "dataGridViewMain";
            this.dataGridViewMain.RowHeadersVisible = false;
            this.dataGridViewMain.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewMain.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMain.Size = new System.Drawing.Size(385, 324);
            this.dataGridViewMain.TabIndex = 8;
            this.dataGridViewMain.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMain_CellEndEdit);
            // 
            // Num
            // 
            this.Num.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Num.FillWeight = 50F;
            this.Num.HeaderText = "";
            this.Num.Name = "Num";
            this.Num.ReadOnly = true;
            this.Num.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Num.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Num.Width = 50;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.check.FillWeight = 50F;
            this.check.HeaderText = "";
            this.check.Name = "check";
            this.check.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.check.Width = 50;
            // 
            // Keyword
            // 
            this.Keyword.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Keyword.FillWeight = 200F;
            this.Keyword.HeaderText = "";
            this.Keyword.Name = "Keyword";
            this.Keyword.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Keyword.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Keyword.Width = 255;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(327, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Total:";
            // 
            // btnContentImport
            // 
            this.btnContentImport.Location = new System.Drawing.Point(170, 25);
            this.btnContentImport.Name = "btnContentImport";
            this.btnContentImport.Size = new System.Drawing.Size(70, 30);
            this.btnContentImport.TabIndex = 6;
            this.btnContentImport.Text = "Import";
            this.btnContentImport.UseVisualStyleBackColor = true;
            this.btnContentImport.Click += new System.EventHandler(this.btnContentImport_Click);
            // 
            // btnContentDelete
            // 
            this.btnContentDelete.Location = new System.Drawing.Point(90, 25);
            this.btnContentDelete.Name = "btnContentDelete";
            this.btnContentDelete.Size = new System.Drawing.Size(70, 30);
            this.btnContentDelete.TabIndex = 5;
            this.btnContentDelete.Text = "Delete";
            this.btnContentDelete.UseVisualStyleBackColor = true;
            this.btnContentDelete.Click += new System.EventHandler(this.btnContentDelete_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkBulk);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.txtInput4);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.btnInsert4);
            this.groupBox3.Controls.Add(this.txtInput3);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnInsert3);
            this.groupBox3.Controls.Add(this.txtInput2);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.btnInsert2);
            this.groupBox3.Controls.Add(this.chkDup);
            this.groupBox3.Controls.Add(this.txtInput1);
            this.groupBox3.Controls.Add(this.btnInsert1);
            this.groupBox3.Location = new System.Drawing.Point(10, 430);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(765, 185);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3. Generated Method";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(105, 150);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 16);
            this.label9.TabIndex = 16;
            this.label9.Text = "=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(105, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 16);
            this.label8.TabIndex = 15;
            this.label8.Text = "=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(105, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(14, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "=";
            // 
            // txtInput4
            // 
            this.txtInput4.Location = new System.Drawing.Point(125, 147);
            this.txtInput4.Name = "txtInput4";
            this.txtInput4.ReadOnly = true;
            this.txtInput4.Size = new System.Drawing.Size(450, 22);
            this.txtInput4.TabIndex = 19;
            this.txtInput4.Text = "[Random]";
            this.txtInput4.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput4_PreviewKeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 16);
            this.label4.TabIndex = 11;
            this.label4.Text = "Keyword3";
            // 
            // btnInsert4
            // 
            this.btnInsert4.Location = new System.Drawing.Point(582, 142);
            this.btnInsert4.Name = "btnInsert4";
            this.btnInsert4.Size = new System.Drawing.Size(70, 30);
            this.btnInsert4.TabIndex = 20;
            this.btnInsert4.Text = "Insert";
            this.btnInsert4.UseVisualStyleBackColor = true;
            this.btnInsert4.Click += new System.EventHandler(this.btnInsert4_Click);
            // 
            // txtInput3
            // 
            this.txtInput3.Location = new System.Drawing.Point(125, 107);
            this.txtInput3.Name = "txtInput3";
            this.txtInput3.ReadOnly = true;
            this.txtInput3.Size = new System.Drawing.Size(450, 22);
            this.txtInput3.TabIndex = 17;
            this.txtInput3.Text = "[Random]";
            this.txtInput3.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput3_PreviewKeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Keyword2";
            // 
            // btnInsert3
            // 
            this.btnInsert3.Location = new System.Drawing.Point(582, 102);
            this.btnInsert3.Name = "btnInsert3";
            this.btnInsert3.Size = new System.Drawing.Size(70, 30);
            this.btnInsert3.TabIndex = 18;
            this.btnInsert3.Text = "Insert";
            this.btnInsert3.UseVisualStyleBackColor = true;
            this.btnInsert3.Click += new System.EventHandler(this.btnInsert3_Click);
            // 
            // txtInput2
            // 
            this.txtInput2.Location = new System.Drawing.Point(125, 67);
            this.txtInput2.Name = "txtInput2";
            this.txtInput2.ReadOnly = true;
            this.txtInput2.Size = new System.Drawing.Size(450, 22);
            this.txtInput2.TabIndex = 15;
            this.txtInput2.Text = "[Product Keyword]";
            this.txtInput2.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput2_PreviewKeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Keyword1";
            // 
            // btnInsert2
            // 
            this.btnInsert2.Location = new System.Drawing.Point(582, 62);
            this.btnInsert2.Name = "btnInsert2";
            this.btnInsert2.Size = new System.Drawing.Size(70, 30);
            this.btnInsert2.TabIndex = 16;
            this.btnInsert2.Text = "Insert";
            this.btnInsert2.UseVisualStyleBackColor = true;
            this.btnInsert2.Click += new System.EventHandler(this.btnInsert2_Click);
            // 
            // chkDup
            // 
            this.chkDup.AutoSize = true;
            this.chkDup.Location = new System.Drawing.Point(667, 28);
            this.chkDup.Name = "chkDup";
            this.chkDup.Size = new System.Drawing.Size(83, 20);
            this.chkDup.TabIndex = 14;
            this.chkDup.Text = "Duplicate";
            this.chkDup.UseVisualStyleBackColor = true;
            // 
            // txtInput1
            // 
            this.txtInput1.Location = new System.Drawing.Point(125, 27);
            this.txtInput1.Name = "txtInput1";
            this.txtInput1.ReadOnly = true;
            this.txtInput1.Size = new System.Drawing.Size(450, 22);
            this.txtInput1.TabIndex = 12;
            this.txtInput1.Text = "[Prefix][Product Keyword][Suffix]";
            this.txtInput1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.txtInput1_PreviewKeyDown);
            // 
            // btnInsert1
            // 
            this.btnInsert1.Location = new System.Drawing.Point(582, 22);
            this.btnInsert1.Name = "btnInsert1";
            this.btnInsert1.Size = new System.Drawing.Size(70, 30);
            this.btnInsert1.TabIndex = 13;
            this.btnInsert1.Text = "Insert";
            this.btnInsert1.UseVisualStyleBackColor = true;
            this.btnInsert1.Click += new System.EventHandler(this.btnInsert1_Click);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(562, 639);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(80, 30);
            this.btnGenerate.TabIndex = 22;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(669, 639);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(80, 30);
            this.btnEnd.TabIndex = 23;
            this.btnEnd.Text = "Back";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // chkBulk
            // 
            this.chkBulk.AutoSize = true;
            this.chkBulk.Location = new System.Drawing.Point(667, 68);
            this.chkBulk.Name = "chkBulk";
            this.chkBulk.Size = new System.Drawing.Size(95, 20);
            this.chkBulk.TabIndex = 22;
            this.chkBulk.Text = "Bulk Create";
            this.chkBulk.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 681);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "Auto Generator for Product title and Keyword";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMain)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnWordDelete;
        private System.Windows.Forms.Button btnWordEdit;
        private System.Windows.Forms.Button btnWorkModify;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnContentImport;
        private System.Windows.Forms.Button btnContentDelete;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnInsert1;
        private System.Windows.Forms.CheckBox chkDup;
        private System.Windows.Forms.TextBox txtInput1;
        private System.Windows.Forms.TextBox txtInput4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnInsert4;
        private System.Windows.Forms.TextBox txtInput3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert3;
        private System.Windows.Forms.TextBox txtInput2;
        private System.Windows.Forms.Button btnInsert2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox listboxWord;
        private System.Windows.Forms.DataGridView dataGridViewMain;
        private System.Windows.Forms.Button btnContentExport;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewCheckBoxColumn check;
        private System.Windows.Forms.DataGridViewTextBoxColumn Keyword;
        private System.Windows.Forms.Button btnContentEdit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox chkBulk;
    }
}

