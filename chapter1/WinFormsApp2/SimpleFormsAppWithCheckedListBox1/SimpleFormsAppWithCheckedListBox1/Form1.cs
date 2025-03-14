namespace SimpleFormsAppWithCheckedListBox1
{
    public partial class x : Form
    {
        public x()
        {
            InitializeComponent();
            String[] movies = { "Avatar: The Way of Water", "Avengers: Endgame", "Titanic" };
            checkList.Items.AddRange(movies);

            checkList.CheckOnClick = true;

        }
        

        private void checkedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            if (listBox.Items.Count >= 1)
            {
                listBox.Items.Remove(listBox.SelectedItem);
            }
        }

        private void clrBtn_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            foreach (var movies in checkList.Items) {

                bool isSelected = checkList.GetItemChecked(checkList.Items.IndexOf(movies));
                if (isSelected && !listBox.Items.Contains(movies)) {
                    listBox.Items.Add(movies);
                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
