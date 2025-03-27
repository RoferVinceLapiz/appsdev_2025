namespace SimpleFormsWithComboBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmdcuisine = new ComboBox();
            button1 = new Button();
            FoodchLstBox = new CheckedListBox();
            FBox = new ListBox();
            RemoveBTN = new Button();
            ClearBtn = new Button();
            AddBtn = new Button();
            textBox1 = new TextBox();
            SuspendLayout();
            // 
            // cmdcuisine
            // 
            cmdcuisine.FormattingEnabled = true;
            cmdcuisine.Location = new Point(47, 76);
            cmdcuisine.Name = "cmdcuisine";
            cmdcuisine.Size = new Size(121, 23);
            cmdcuisine.TabIndex = 0;
            cmdcuisine.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonHighlight;
            button1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic);
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(47, 118);
            button1.Name = "button1";
            button1.Size = new Size(121, 32);
            button1.TabIndex = 1;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FoodchLstBox
            // 
            FoodchLstBox.FormattingEnabled = true;
            FoodchLstBox.Location = new Point(197, 47);
            FoodchLstBox.Name = "FoodchLstBox";
            FoodchLstBox.Size = new Size(217, 130);
            FoodchLstBox.TabIndex = 2;
            // 
            // FBox
            // 
            FBox.FormattingEnabled = true;
            FBox.ItemHeight = 15;
            FBox.Location = new Point(441, 47);
            FBox.Name = "FBox";
            FBox.Size = new Size(210, 184);
            FBox.TabIndex = 3;
            // 
            // RemoveBTN
            // 
            RemoveBTN.BackColor = SystemColors.ButtonHighlight;
            RemoveBTN.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic);
            RemoveBTN.Location = new Point(657, 76);
            RemoveBTN.Name = "RemoveBTN";
            RemoveBTN.Size = new Size(121, 41);
            RemoveBTN.TabIndex = 4;
            RemoveBTN.Text = "Remove";
            RemoveBTN.UseVisualStyleBackColor = false;
            RemoveBTN.Click += RemoveBTN_Click;
            // 
            // ClearBtn
            // 
            ClearBtn.BackColor = SystemColors.ButtonHighlight;
            ClearBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic);
            ClearBtn.Location = new Point(657, 136);
            ClearBtn.Name = "ClearBtn";
            ClearBtn.Size = new Size(121, 39);
            ClearBtn.TabIndex = 5;
            ClearBtn.Text = "Clear";
            ClearBtn.UseVisualStyleBackColor = false;
            ClearBtn.Click += ClearBtn_Click;
            // 
            // AddBtn
            // 
            AddBtn.BackColor = SystemColors.ButtonHighlight;
            AddBtn.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic);
            AddBtn.Location = new Point(228, 183);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(171, 32);
            AddBtn.TabIndex = 6;
            AddBtn.Text = "Add";
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold | FontStyle.Italic);
            textBox1.ForeColor = Color.Yellow;
            textBox1.Location = new Point(12, 25);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(776, 281);
            textBox1.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(AddBtn);
            Controls.Add(ClearBtn);
            Controls.Add(RemoveBTN);
            Controls.Add(FBox);
            Controls.Add(FoodchLstBox);
            Controls.Add(button1);
            Controls.Add(cmdcuisine);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmdcuisine;
        private Button button1;
        private CheckedListBox FoodchLstBox;
        private ListBox FBox;
        private Button RemoveBTN;
        private Button ClearBtn;
        private Button AddBtn;
        private TextBox textBox1;
    }
}
