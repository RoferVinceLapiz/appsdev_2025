namespace SimpleFormsAppWithCheckedListBox1
{
    partial class x
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
            checkList = new CheckedListBox();
            listBox = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            delBtn = new Button();
            clrBtn = new Button();
            addBtn = new Button();
            SuspendLayout();
            // 
            // checkList
            // 
            checkList.BackColor = SystemColors.Menu;
            checkList.FormattingEnabled = true;
            checkList.Location = new Point(66, 126);
            checkList.Name = "checkList";
            checkList.Size = new Size(171, 166);
            checkList.TabIndex = 0;
            checkList.SelectedIndexChanged += checkedListBox_SelectedIndexChanged;
            // 
            // listBox
            // 
            listBox.BackColor = SystemColors.Menu;
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(298, 126);
            listBox.Name = "listBox";
            listBox.Size = new Size(163, 169);
            listBox.TabIndex = 1;
            listBox.SelectedIndexChanged += listBox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(188, 9);
            label1.Name = "label1";
            label1.Size = new Size(273, 25);
            label1.TabIndex = 2;
            label1.Text = "Sample Favorite Movie Picker";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(84, 85);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 3;
            label2.Text = "Movies/ Series List";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(345, 90);
            label3.Name = "label3";
            label3.Size = new Size(155, 20);
            label3.TabIndex = 4;
            label3.Text = "My Movie/Series List";
            label3.Click += label3_Click;
            // 
            // delBtn
            // 
            delBtn.BackColor = SystemColors.InactiveCaption;
            delBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delBtn.Location = new Point(479, 178);
            delBtn.Name = "delBtn";
            delBtn.Size = new Size(75, 23);
            delBtn.TabIndex = 5;
            delBtn.Text = "Delete ";
            delBtn.UseVisualStyleBackColor = false;
            delBtn.Click += delBtn_Click;
            // 
            // clrBtn
            // 
            clrBtn.BackColor = SystemColors.InactiveCaption;
            clrBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            clrBtn.Location = new Point(479, 218);
            clrBtn.Name = "clrBtn";
            clrBtn.Size = new Size(75, 23);
            clrBtn.TabIndex = 6;
            clrBtn.Text = "Clear All";
            clrBtn.UseVisualStyleBackColor = false;
            clrBtn.Click += clrBtn_Click;
            // 
            // addBtn
            // 
            addBtn.BackColor = SystemColors.InactiveCaption;
            addBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBtn.Location = new Point(113, 298);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(75, 23);
            addBtn.TabIndex = 7;
            addBtn.Text = "Add";
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // x
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(663, 450);
            Controls.Add(addBtn);
            Controls.Add(clrBtn);
            Controls.Add(delBtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox);
            Controls.Add(checkList);
            Name = "x";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkList;
        private ListBox listBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button delBtn;
        private Button clrBtn;
        private Button addBtn;
    }
}
