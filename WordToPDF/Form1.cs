using Spire.Doc;
using Spire.Doc.Documents;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordToPDF
{
    public partial class WordToPDF : Form
    {
        public WordToPDF()
        {
            InitializeComponent();
        }
        public string FileSpurcePath = "";
        private void button1_Click(object sender, EventArgs e)
        {
            if (IfLabTargetFileNull())
            {
                MessageBox.Show("請選取檔案來源...");
                return;
            }
            else
            {
                try
                {
                    Document doc = new Document(FileSpurcePath);
                    doc.SaveToFile(System.IO.Path.GetFileName(FileSpurcePath).Split('.')[0].ToString()+".PDF", FileFormat.PDF);
                }
                catch (Exception)
                {

                    MessageBox.Show("唔!出錯了，請檢查該檔案是否為.doc、.docx檔案");
                }
            }


        }

        private void btnGetFileSource_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "選檔案唷ww";
            dialog.InitialDirectory = ".\\";
            //篩選 為doc docx檔案
            dialog.Filter = "doc files (*.*)|*.docx;*.doc;";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                FileSpurcePath = dialog.FileName;
                labFileTarget.Text = dialog.FileName;
            }
            else
            {
                labFileTarget.Text = "請選取檔案來源...";
            }
        }

        public bool IfLabTargetFileNull()
        {
            if (string.IsNullOrEmpty(labFileTarget.Text) || labFileTarget.Text == "請選取檔案來源...")
            {
                return true;
            }
            else
            {
                return false;
            }



        }

        private void btnClearFileSource_Click(object sender, EventArgs e)
        {
            FileSpurcePath = "";
            labFileTarget.Text = "請選取檔案來源...";
        }
    }
}
