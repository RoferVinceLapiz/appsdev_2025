namespace MessageBox

{
    using System.Windows.Forms;
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            string fNameValue = firstname.Text;
            string mNameValue = middlename.Text;
            string lNameValue = lastname.Text;
            string sNameValue = suffix.Text;

           
            DialogResult result = MessageBox.Show("Are you sure you want to submit?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

           
            if (result == DialogResult.Yes)
            {
                
                MessageBox.Show($"Hello World! {fNameValue} {mNameValue} {lNameValue} {sNameValue}", "Greetings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }
    }
}


