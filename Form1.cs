using System.Text.RegularExpressions;

namespace SmartNote
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DateBase.Init();
            LoadNotes();
        }

        void LoadNotes()
        {
            var notes = DateBase.GetAll();

            listNotes.DataSource = null;
            listNotes.DataSource = notes;
            listNotes.DisplayMember = "Title";
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            listNotes.ClearSelected();
            txtTitle.Text = "";
            txtContents.Text = "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var note = (Note)listNotes.SelectedItem;
            if (note == null)
            {
                DateBase.Add(txtTitle.Text, txtContents.Text);
            }
            else
            {
                DateBase.Update(note.Id, txtTitle.Text, txtContents.Text);
            }
            LoadNotes();
            MessageBox.Show("保存した！");
        }

        private void listNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var note = (Note)listNotes.SelectedItem;
            if (note == null) return;

            txtTitle.Text = note.Title;
            txtContents.Text = note.Content;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var note = (Note)listNotes.SelectedItem;
            if (note == null) return;
            var result = MessageBox.Show(
                "削除する！",
                "確認",
                MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                DateBase.Delete(note.Id);
                LoadNotes();
                MessageBox.Show("削除した！");
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            var word = txtSearch.Text;

            if (string.IsNullOrWhiteSpace(word))
            {
                LoadNotes();
            }
            else
            {
                listNotes.DataSource = null;
                listNotes.DataSource = DateBase.Search(word);
                listNotes.DisplayMember = "Title";
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnSave.PerformClick();
            }
        }

        void ApplyDarkTheme()
        {
            this.BackColor = Color.FromArgb(30, 30, 30);

            txtTitle.BackColor = Color.FromArgb(45, 45, 45);
            txtTitle.ForeColor = Color.White;

            txtContents.BackColor = Color.FromArgb(45, 45, 45);
            txtContents.ForeColor = Color.White;

            listNotes.BackColor = Color.FromArgb(45, 45, 45);
            listNotes.ForeColor = Color.White;

            btnNew.BackColor = Color.FromArgb(70, 70, 70);
            btnSave.BackColor = Color.FromArgb(70, 70, 70);
            btnDelete.BackColor = Color.FromArgb(70, 70, 70);

            btnNew.ForeColor = Color.White;
            btnSave.ForeColor = Color.White;
            btnDelete.ForeColor = Color.White;
            listNotes.BorderStyle = BorderStyle.None;

            label1.BackColor = Color.FromArgb(45, 45, 45);
            label1.ForeColor = Color.White;
            label2.BackColor = Color.FromArgb(45, 45, 45);
            label2.ForeColor = Color.White;

            txtSearch.BackColor = Color.FromArgb(45, 45, 45);
            txtSearch.ForeColor = Color.White;

            btnTheme.BackColor = Color.FromArgb(70, 70, 70);
            btnTheme.ForeColor = Color.White;
            btnTheme.Text = " Light";
        }

        void ApplyLightTheme()
        {
            this.BackColor = Color.White;
            txtTitle.BackColor = Color.White;
            txtTitle.ForeColor = Color.Black;

            txtContents.BackColor = Color.White;
            txtContents.ForeColor = Color.Black;

            listNotes.BackColor = Color.White;
            listNotes.ForeColor = Color.Black;

            btnNew.BackColor = Color.LightGray;
            btnSave.BackColor = Color.LightGray;
            btnDelete.BackColor = Color.LightGray;

            btnNew.ForeColor = Color.Black;
            btnSave.ForeColor = Color.Black;
            btnDelete.ForeColor = Color.Black;

            label1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.BackColor = Color.White;
            label2.ForeColor = Color.Black;

            txtSearch.BackColor = Color.White;
            txtSearch.ForeColor = Color.Black;

            btnTheme.BackColor = Color.LightGray;
            btnTheme.ForeColor = Color.Black;
            btnTheme.Text = " Dark";
        }

        private void c(object sender, PaintEventArgs e)
        {

        }
        bool isDark = false;
        private void btnTheme_Click(object sender, EventArgs e)
        {
            if (isDark)
            {
                ApplyLightTheme();
                isDark = false;
            }
            else
            {
                ApplyDarkTheme();
                isDark = true;
            }
        }

        private void txtContents_DoubleClick(object sender, EventArgs e)
        {
            var text = txtContents.SelectedText;

            if (text.StartsWith("[[") && text.EndsWith("]]"))
            {
                var title = text.Replace("[[", "").Replace("]]", "");
                var note = DateBase.GetByTitle(title);

                if (note != null)
                {
                    txtTitle.Text = note.Title;
                    txtContents.Text = note.Content;
                }
            }
        }

        void HighlightLinks()
        {
            int cursor = txtContents.SelectionStart;

            txtContents.SelectAll();
            txtContents.SelectionColor = Color.White;
            var matches = Regex.Matches(txtContents.Text, @"\[\[(.*?)\]\]");
            foreach (Match match in matches)
            {
                txtContents.Select(match.Index, match.Length);
                txtContents.SelectionColor = Color.DeepSkyBlue;
            }
            if(cursor > txtContents.Text.Length)
                cursor = txtContents.Text.Length;
            txtContents.Select(cursor, 0);
        }

        private void txtContents_TextChanged(object sender, EventArgs e)
        {
            HighlightLinks();
        }

        private void txtContents_DoubleClick_1(object sender, EventArgs e)
        {

        }

        private void txtContents_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = txtContents.GetCharIndexFromPosition(e.Location);
            string text = txtContents.Text;
            var matches = Regex.Matches(text, @"\[\[(.*?)\]\]");
            foreach (Match match in matches)
            {
                if(index >= match.Index && index <=match.Index + match.Length)
                {
                    string title = match.Groups[1].Value;
                    var note = DateBase.GetByTitle(title);
                    if(note != null)
                    {
                        txtTitle.Text = note.Title;
                        txtContents.Text = note.Content;
                    }
                }
            }
        }
    }
}
