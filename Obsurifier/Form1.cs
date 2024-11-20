using System.Diagnostics;
using System.Text.RegularExpressions;

namespace obscurifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectFile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "All files (*.*)|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtFilePath.Text = openFileDialog.FileName;
                }
            }
        }

        private void obscureBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var filePath = txtFilePath.Text;
                

                if (filePath.StartsWith("\"\\\"")) filePath = filePath.Substring(3, filePath.Length - 4);
                if (filePath.EndsWith("\"")) filePath = filePath.Substring(0, filePath.Length - 1);
                
                if (File.Exists(filePath))
                {
                    string fileContents = File.ReadAllText(filePath);
                    string tempFilePath = Path.GetTempFileName();

                    File.WriteAllText(tempFilePath, Utils.Obscurify(fileContents));

                    Process.Start("notepad.exe", tempFilePath);
                }
                else
                {
                    MessageBox.Show("The selected file does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while processing the file: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }




}
