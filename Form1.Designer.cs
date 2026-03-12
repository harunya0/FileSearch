namespace FileSearch
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            FileName = new DataGridViewTextBoxColumn();
            pass = new DataGridViewTextBoxColumn();
            buttonSearch = new Button();
            textBoxKeyword = new TextBox();
            buttonFolder_Click = new Button();
            textBoxPath = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { FileName, pass });
            dataGridView1.Location = new Point(12, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(642, 426);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellDoubleClick += dataGridView1_CellDoubleClick;
            // 
            // FileName
            // 
            FileName.HeaderText = "ファイル名";
            FileName.Name = "FileName";
            FileName.Width = 200;
            // 
            // pass
            // 
            pass.HeaderText = "パス";
            pass.Name = "pass";
            pass.Width = 300;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(698, 402);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(90, 36);
            buttonSearch.TabIndex = 1;
            buttonSearch.Text = "検索";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // textBoxKeyword
            // 
            textBoxKeyword.Location = new Point(660, 362);
            textBoxKeyword.Name = "textBoxKeyword";
            textBoxKeyword.Size = new Size(128, 23);
            textBoxKeyword.TabIndex = 2;
            // 
            // buttonFolder_Click
            // 
            buttonFolder_Click.Location = new Point(698, 320);
            buttonFolder_Click.Name = "buttonFolder_Click";
            buttonFolder_Click.Size = new Size(90, 36);
            buttonFolder_Click.TabIndex = 3;
            buttonFolder_Click.Text = "ファイル選択";
            buttonFolder_Click.UseVisualStyleBackColor = true;
            buttonFolder_Click.Click += buttonFolder_Click_Click;
            // 
            // textBoxPath
            // 
            textBoxPath.Location = new Point(660, 291);
            textBoxPath.Name = "textBoxPath";
            textBoxPath.Size = new Size(128, 23);
            textBoxPath.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxPath);
            Controls.Add(buttonFolder_Click);
            Controls.Add(textBoxKeyword);
            Controls.Add(buttonSearch);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button buttonSearch;
        private TextBox textBoxKeyword;
        private Button buttonFolder_Click;
        private TextBox textBoxPath;
        private DataGridViewTextBoxColumn FileName;
        private DataGridViewTextBoxColumn pass;
    }
}
