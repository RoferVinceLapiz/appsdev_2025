namespace SimpleFormsWithComboBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string[] cuisineGenre = { "Filipino", "Korean", "Italian", "Indian" };
            cmdcuisine.Items.AddRange(cuisineGenre);

            cmdcuisine.DropDownStyle = ComboBoxStyle.DropDownList;
            cmdcuisine.SelectedIndex = 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] filipinoCuisineList = { "bihon", "kare-kare", "tinola", "lechon" };
            string[] koreanCuisinelist = { "XiaoLongbao", "Kimchi", "bibimbap", "Gimbap" };
            string[] ItalianCuisineList = { "pasta", "pizza", "risotto", "tiramisu" };
            string[] indianCuisineList = { "curry", "biryani", "tandoori chicken", "mutton" };

            FoodchLstBox.Items.Clear();

            if (cmdcuisine.SelectedItem != null && cmdcuisine.SelectedItem.ToString()!.Contains("Filipino"))
            {
                FoodchLstBox.Items.AddRange(filipinoCuisineList);

            }
            else if (cmdcuisine.SelectedItem != null && cmdcuisine.SelectedItem.ToString()!.Contains("Korean"))
            {
                FoodchLstBox.Items.AddRange(koreanCuisinelist);
            }
            else if (cmdcuisine.SelectedItem != null && cmdcuisine.SelectedItem.ToString()!.Contains("Italian" +
                ""))
            {
                FoodchLstBox.Items.AddRange(ItalianCuisineList);

            }
            else if (cmdcuisine.SelectedItem != null && cmdcuisine.SelectedItem.ToString()!.Contains("Indian"))
            {
                FoodchLstBox.Items.AddRange(indianCuisineList);
            }
        }

        private void RemoveBTN_Click(object sender, EventArgs e)
        {
            if (FBox.Items.Count >= 1 && FBox.SelectedItem != null)
            {
                FBox.Items.Remove(FBox.SelectedItem);
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            foreach (var item in FoodchLstBox.Items)
            {
                bool isSelected = FoodchLstBox.GetItemChecked(FoodchLstBox.Items.IndexOf(item));
                if (isSelected && !FBox.Items.Contains(item))
                {
                    FBox.Items.Add(item);
                }
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            FBox.Items.Clear();
        }
    }
}

