namespace SmartNote
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
            txtTitle = new TextBox();
            label1 = new Label();
            listNotes = new ListBox();
            btnNew = new Button();
            btnSave = new Button();
            btnDelete = new Button();
            label2 = new Label();
            txtSearch = new TextBox();
            splitContainer1 = new SplitContainer();
            txtContents = new RichTextBox();
            btnTheme = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // txtTitle
            // 
            txtTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTitle.Location = new Point(47, 12);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(442, 25);
            txtTitle.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(32, 17);
            label1.TabIndex = 1;
            label1.Text = "Title";
            // 
            // listNotes
            // 
            listNotes.Dock = DockStyle.Fill;
            listNotes.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listNotes.FormattingEnabled = true;
            listNotes.ItemHeight = 17;
            listNotes.Location = new Point(0, 0);
            listNotes.Name = "listNotes";
            listNotes.Size = new Size(235, 633);
            listNotes.TabIndex = 2;
            listNotes.SelectedIndexChanged += listNotes_SelectedIndexChanged;
            // 
            // btnNew
            // 
            btnNew.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnNew.Location = new Point(119, 707);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(101, 60);
            btnNew.TabIndex = 4;
            btnNew.Text = "作成";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(497, 707);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(101, 60);
            btnSave.TabIndex = 5;
            btnSave.Text = "保存";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(855, 707);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(101, 60);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "削除";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(558, 15);
            label2.Name = "label2";
            label2.Size = new Size(40, 17);
            label2.TabIndex = 7;
            label2.Text = "検索";
            // 
            // txtSearch
            // 
            txtSearch.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSearch.Location = new Point(603, 12);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(458, 25);
            txtSearch.TabIndex = 8;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(12, 58);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(listNotes);
            splitContainer1.Panel1MinSize = 150;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(txtContents);
            splitContainer1.Size = new Size(1106, 633);
            splitContainer1.SplitterDistance = 235;
            splitContainer1.TabIndex = 9;
            // 
            // txtContents
            // 
            txtContents.Dock = DockStyle.Fill;
            txtContents.Location = new Point(0, 0);
            txtContents.Name = "txtContents";
            txtContents.Size = new Size(867, 633);
            txtContents.TabIndex = 0;
            txtContents.Text = "";
            txtContents.TextChanged += txtContents_TextChanged;
            txtContents.DoubleClick += txtContents_DoubleClick_1;
            txtContents.MouseDoubleClick += txtContents_MouseDoubleClick;
            // 
            // btnTheme
            // 
            btnTheme.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTheme.Location = new Point(1030, 725);
            btnTheme.Name = "btnTheme";
            btnTheme.Size = new Size(88, 42);
            btnTheme.TabIndex = 10;
            btnTheme.Text = "Theme";
            btnTheme.UseVisualStyleBackColor = true;
            btnTheme.Click += btnTheme_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1130, 779);
            Controls.Add(btnTheme);
            Controls.Add(txtSearch);
            Controls.Add(label2);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(btnNew);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(splitContainer1);
            KeyPreview = true;
            Name = "Form1";
            Text = "Form1";
            KeyDown += Form1_KeyDown;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtTitle;
        private Label label1;
        private ListBox listNotes;
        private Button btnNew;
        private Button btnSave;
        private Button btnDelete;
        private Label label2;
        private TextBox txtSearch;
        private SplitContainer splitContainer1;
        private Button btnTheme;
        private RichTextBox txtContents;
    }
}
