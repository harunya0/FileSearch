namespace FileSearch
{
    public partial class Form1 : Form
    {
        string searchPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFolder_Click_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                searchPath = dialog.SelectedPath;
                textBoxPath.Text = searchPath;
            }
        }

        private async void buttonSearch_Click(object sender, EventArgs e)
        {
            string keyword = textBoxKeyword.Text;
            if (string.IsNullOrEmpty(searchPath))
            {
                MessageBox.Show("検索するフォルダを選択してください。");
                return;
            }
            dataGridView1.Rows.Clear();
            await Task.Run(() => SearchDirectory(searchPath, keyword));

            void SearchDirectory(string dir, string words)
            {
                string[] files = [];
                try
                {
                    files = Directory.GetFiles(dir);
                }
                catch
                {
                    return;
                }

                foreach (var file in files)
                {
                    string name = Path.GetFileName(file);

                    if (name.IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Invoke(new Action(() =>
                        {
                            dataGridView1.Rows.Add(name, file);
                        }));
                    }
                }

                string[] dirs = [];
                try
                {
                    dirs = Directory.GetDirectories(dir);
                }
                catch
                {
                    return;
                }
                foreach (var subdir in dirs)
                {
                    SearchDirectory(subdir, words);
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string path = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString() ?? "";
            if (!string.IsNullOrEmpty(path))
            {
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = path,
                    UseShellExecute = true   // ← これが重要
                };
                System.Diagnostics.Process.Start(psi);
            }
        }
    }
}
