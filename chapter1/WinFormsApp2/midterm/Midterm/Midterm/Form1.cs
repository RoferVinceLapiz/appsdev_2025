namespace Midterm
#nullable disable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.Load += new EventHandler(Form1_Load);




        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private double GetIphonePrice(string model)
        {
            if (model == "iPhone 16 Pro Max (256GB)") return 69990;
            if (model == "iPhone 16 Pro (128GB)") return 84990;
            if (model == "iPhone 16 Plus (128GB)") return 54990;
            if (model == "iPhone 16 (128GB)") return 62990;
            if (model == "iPhone 16e (128GB)") return 39990;
            return 0;
        }

        private double GetInterestRate(int term)
        {
            if (term == 12) return 0.05;
            if (term == 24) return 0.10;
            if (term == 30) return 0.125;
            if (term == 36) return 0.15;
            return 0;
        }
        private void compute_Click(object sender, EventArgs e)
        {
            {
                if (listBox1.SelectedItem == null || comboBox.SelectedItem == null)
                {
                    MessageBox.Show("Please select an iPhone model and a loan term.");
                    return;
                }

                string selectedModel = listBox1.SelectedItem.ToString();
                double principalAmount = GetIphonePrice(selectedModel);

                string selectedLoanTerm = comboBox.SelectedItem.ToString();
                int loanTerm = int.Parse(new string(selectedLoanTerm.Where(char.IsDigit).ToArray()));

                double interestRate = GetInterestRate(loanTerm);
                double downPayment = principalAmount * 0.10;



                double totalPrincipal = principalAmount;
                double interestAmount = totalPrincipal * interestRate;
                double totalAmount = totalPrincipal + interestAmount;
                double monthlyAmortization = totalAmount / loanTerm;

                textBox1.Text = $"Model: {selectedModel}\r\n" +
                $"Principal Amount: Php {principalAmount:N2}\r\n" +
                $"Down Payment: Php {downPayment:N2}\r\n" +
                $"Loan Term: {loanTerm} Months\r\n" +
                $"Interest Rate: {interestRate * 100}%\r\n" +
                $"Interest Amount: Php {interestAmount:N2}\r\n" +
                $"Total Monthly Amortization: Php {monthlyAmortization:N2}\r\n" +
                $"Total Loan Amount: Php {totalAmount:N2}";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox1.Items.Add("iPhone 16 Pro Max (256GB)");
            listBox1.Items.Add("iPhone 16 Pro (128GB)");
            listBox1.Items.Add("iPhone 16 Plus (128GB)");
            listBox1.Items.Add("iPhone 16 (128GB)");
            listBox1.Items.Add("iPhone 16e (128GB)");

            checkedListBox.Items.Clear();
            checkedListBox.Items.Add("Apple Care Plus");
            checkedListBox.Items.Add("USB-C Charging Adapter");
            checkedListBox.Items.Add("MagSafe Charger (1M)");

            comboBox.Items.Clear();
            comboBox.Items.Add("12 Months");
            comboBox.Items.Add("24 Months");
            comboBox.Items.Add("30 Months");
            comboBox.Items.Add("36 Months");
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

