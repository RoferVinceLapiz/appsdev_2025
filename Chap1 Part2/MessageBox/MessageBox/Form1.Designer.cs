namespace MessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            firstname = new TextBox();
            middlename = new TextBox();
            lastname = new TextBox();
            suffix = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            submit = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // firstname
            // 
            firstname.Location = new Point(297, 117);
            firstname.Name = "firstname";
            firstname.Size = new Size(144, 23);
            firstname.TabIndex = 0;
            // 
            // middlename
            // 
            middlename.Location = new Point(297, 187);
            middlename.Name = "middlename";
            middlename.Size = new Size(144, 23);
            middlename.TabIndex = 1;
            // 
            // lastname
            // 
            lastname.Location = new Point(297, 259);
            lastname.Name = "lastname";
            lastname.Size = new Size(144, 23);
            lastname.TabIndex = 2;
            // 
            // suffix
            // 
            suffix.Location = new Point(297, 320);
            suffix.Name = "suffix";
            suffix.Size = new Size(144, 23);
            suffix.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(297, 99);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "First Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Snow;
            label2.Location = new Point(297, 169);
            label2.Name = "label2";
            label2.Size = new Size(79, 15);
            label2.TabIndex = 5;
            label2.Text = "Middle Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(297, 241);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 6;
            label3.Text = "Last Name";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(297, 302);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 7;
            label4.Text = "Suffix";
            label4.Click += label4_Click;
            // 
            // submit
            // 
            submit.BackColor = Color.Transparent;
            submit.Font = new Font("Segoe Fluent Icons", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            submit.ForeColor = Color.Red;
            submit.Location = new Point(317, 358);
            submit.Name = "submit";
            submit.Size = new Size(97, 34);
            submit.TabIndex = 8;
            submit.Text = "Submit";
            submit.UseVisualStyleBackColor = false;
            submit.Click += submit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe Fluent Icons", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonFace;
            label5.Location = new Point(254, 19);
            label5.Name = "label5";
            label5.Size = new Size(259, 27);
            label5.TabIndex = 9;
            label5.Text = "Sample Form Application";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(submit);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(suffix);
            Controls.Add(lastname);
            Controls.Add(middlename);
            Controls.Add(firstname);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox firstname;
        private TextBox middlename;
        private TextBox lastname;
        private TextBox suffix;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button submit;
        private Label label5;
    }
}
