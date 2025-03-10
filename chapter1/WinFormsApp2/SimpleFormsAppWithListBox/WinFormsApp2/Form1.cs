using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtbox.Text) && !lstbox.Items.Contains(txtbox.Text))
            {
                lstbox.Items.Add(txtbox.Text);
            }
        }
        private void removebtn_Click(object sender, EventArgs e)
        {
            lstbox.Items.Remove(lstbox.Text);
        }

        private void clearbtn_Click(object sender, EventArgs e)
        {
            lstbox.Items.Clear();
        }
    }
}
