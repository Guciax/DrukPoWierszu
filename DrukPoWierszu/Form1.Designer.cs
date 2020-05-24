namespace DrukPoWierszu
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.bOpenFile = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cbWorksheets = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.numHeaderRowIndex = new System.Windows.Forms.NumericUpDown();
            this.lHeaderPreview = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.bSelectAll = new System.Windows.Forms.Button();
            this.bSelectNone = new System.Windows.Forms.Button();
            this.bPrint = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaderRowIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bOpenFile);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 32);
            this.panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dgv, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel4, 0, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 391F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(470, 577);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wybierz plik excel";
            // 
            // bOpenFile
            // 
            this.bOpenFile.Location = new System.Drawing.Point(107, 3);
            this.bOpenFile.Name = "bOpenFile";
            this.bOpenFile.Size = new System.Drawing.Size(81, 23);
            this.bOpenFile.TabIndex = 1;
            this.bOpenFile.Text = "Otwórz...";
            this.bOpenFile.UseVisualStyleBackColor = true;
            this.bOpenFile.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cbWorksheets);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(464, 35);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Wybierz arkusz";
            // 
            // cbWorksheets
            // 
            this.cbWorksheets.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbWorksheets.FormattingEnabled = true;
            this.cbWorksheets.Location = new System.Drawing.Point(107, 7);
            this.cbWorksheets.Name = "cbWorksheets";
            this.cbWorksheets.Size = new System.Drawing.Size(121, 21);
            this.cbWorksheets.TabIndex = 2;
            this.cbWorksheets.SelectedIndexChanged += new System.EventHandler(this.cbWorksheets_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.lHeaderPreview);
            this.panel3.Controls.Add(this.numHeaderRowIndex);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 82);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(464, 67);
            this.panel3.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Numer wiersza nagłówka";
            // 
            // numHeaderRowIndex
            // 
            this.numHeaderRowIndex.Location = new System.Drawing.Point(142, 8);
            this.numHeaderRowIndex.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numHeaderRowIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeaderRowIndex.Name = "numHeaderRowIndex";
            this.numHeaderRowIndex.Size = new System.Drawing.Size(60, 20);
            this.numHeaderRowIndex.TabIndex = 2;
            this.numHeaderRowIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numHeaderRowIndex.ValueChanged += new System.EventHandler(this.numHeaderRowIndex_ValueChanged);
            // 
            // lHeaderPreview
            // 
            this.lHeaderPreview.AutoSize = true;
            this.lHeaderPreview.Location = new System.Drawing.Point(9, 40);
            this.lHeaderPreview.Name = "lHeaderPreview";
            this.lHeaderPreview.Size = new System.Drawing.Size(16, 13);
            this.lHeaderPreview.TabIndex = 3;
            this.lHeaderPreview.Text = "...";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(3, 155);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersVisible = false;
            this.dgv.Size = new System.Drawing.Size(464, 385);
            this.dgv.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.bPrint);
            this.panel4.Controls.Add(this.bSelectNone);
            this.panel4.Controls.Add(this.bSelectAll);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 546);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(464, 28);
            this.panel4.TabIndex = 4;
            // 
            // bSelectAll
            // 
            this.bSelectAll.Dock = System.Windows.Forms.DockStyle.Left;
            this.bSelectAll.Location = new System.Drawing.Point(0, 0);
            this.bSelectAll.Name = "bSelectAll";
            this.bSelectAll.Size = new System.Drawing.Size(120, 28);
            this.bSelectAll.TabIndex = 0;
            this.bSelectAll.Text = "Zaznacz wszystkie";
            this.bSelectAll.UseVisualStyleBackColor = true;
            this.bSelectAll.Click += new System.EventHandler(this.bSelectAll_Click);
            // 
            // bSelectNone
            // 
            this.bSelectNone.Dock = System.Windows.Forms.DockStyle.Left;
            this.bSelectNone.Location = new System.Drawing.Point(120, 0);
            this.bSelectNone.Name = "bSelectNone";
            this.bSelectNone.Size = new System.Drawing.Size(91, 28);
            this.bSelectNone.TabIndex = 1;
            this.bSelectNone.Text = "Zaznacz nic";
            this.bSelectNone.UseVisualStyleBackColor = true;
            this.bSelectNone.Click += new System.EventHandler(this.bSelectNone_Click);
            // 
            // bPrint
            // 
            this.bPrint.Dock = System.Windows.Forms.DockStyle.Right;
            this.bPrint.Location = new System.Drawing.Point(372, 0);
            this.bPrint.Name = "bPrint";
            this.bPrint.Size = new System.Drawing.Size(92, 28);
            this.bPrint.TabIndex = 2;
            this.bPrint.Text = "Drukuj";
            this.bPrint.UseVisualStyleBackColor = true;
            this.bPrint.Click += new System.EventHandler(this.bPrint_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 577);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Copyright by Olena S.";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numHeaderRowIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bOpenFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cbWorksheets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lHeaderPreview;
        private System.Windows.Forms.NumericUpDown numHeaderRowIndex;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button bSelectNone;
        private System.Windows.Forms.Button bSelectAll;
        private System.Windows.Forms.Button bPrint;
    }
}

