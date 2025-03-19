namespace Midterm
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
            checkedListBox = new ListBox();
            comboBox = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            compute = new Button();
            listBox1 = new ListBox();
            textBox1 = new TextBox();
            label5 = new Label();
            SuspendLayout();
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.ItemHeight = 15;
            checkedListBox.Location = new Point(203, 115);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(166, 199);
            checkedListBox.TabIndex = 1;
            checkedListBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(391, 130);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(121, 23);
            comboBox.TabIndex = 2;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(44, 81);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 3;
            label1.Text = "iPhone Model";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(240, 80);
            label2.Name = "label2";
            label2.Size = new Size(75, 20);
            label2.TabIndex = 4;
            label2.Text = "Add-Ons:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(415, 81);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Loan Term:";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 18);
            label4.Name = "label4";
            label4.Size = new Size(325, 25);
            label4.TabIndex = 6;
            label4.Text = "Simple iPhone Loan Calculator App";
            label4.Click += label4_Click;
            // 
            // compute
            // 
            compute.Location = new Point(391, 173);
            compute.Name = "compute";
            compute.Size = new Size(121, 23);
            compute.TabIndex = 7;
            compute.Text = "Compute";
            compute.UseVisualStyleBackColor = true;
            compute.Click += compute_Click;
            // 
            // listBox1
            // 
            listBox1.ForeColor = SystemColors.MenuText;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 115);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(168, 199);
            listBox1.TabIndex = 8;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(17, 371);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(352, 153);
            textBox1.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 333);
            label5.Name = "label5";
            label5.Size = new Size(121, 21);
            label5.TabIndex = 10;
            label5.Text = "List of Details :";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 128);
            ClientSize = new Size(531, 535);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(listBox1);
            Controls.Add(compute);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBox);
            Controls.Add(checkedListBox);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListBox checkedListBox;
        private ComboBox comboBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button compute;
        private ListBox listBox1;
        private TextBox textBox1;
        private Label label5;
    }
}
