using System.IO;

namespace Lab10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string curr = System.IO.Directory.GetCurrentDirectory();
            string path = Directory.GetParent(curr).Parent.Parent.ToString() +"//StudentFolder";
            listBox1.Items.Add(path);
           string[] files = Directory.GetFiles(path);
            foreach (string file in files)
           {
                listBox1.Items.Add(file.Split("\\").LastOrDefault());
           }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}