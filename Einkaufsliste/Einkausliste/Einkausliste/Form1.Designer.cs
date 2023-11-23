namespace Einkausliste
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
            comboBox1 = new ComboBox();
            textBoxname = new TextBox();
            textBoxprice = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            richTextBox1 = new RichTextBox();
            Checked = new CheckedListBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            comboBox1.Location = new Point(31, 75);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(96, 23);
            comboBox1.TabIndex = 1;
            // 
            // textBoxname
            // 
            textBoxname.Location = new Point(393, 76);
            textBoxname.Name = "textBoxname";
            textBoxname.Size = new Size(135, 23);
            textBoxname.TabIndex = 2;
            // 
            // textBoxprice
            // 
            textBoxprice.Location = new Point(230, 75);
            textBoxprice.Name = "textBoxprice";
            textBoxprice.Size = new Size(111, 23);
            textBoxprice.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 57);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 5;
            label1.Text = "Anzahl";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(230, 57);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 6;
            label2.Text = "Preis";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(393, 57);
            label3.Name = "label3";
            label3.Size = new Size(79, 15);
            label3.TabIndex = 7;
            label3.Text = "Produktname";
            // 
            // button1
            // 
            button1.Location = new Point(574, 73);
            button1.Name = "button1";
            button1.Size = new Size(87, 24);
            button1.TabIndex = 8;
            button1.Text = "Hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(31, 123);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(757, 287);
            richTextBox1.TabIndex = 9;
            richTextBox1.Text = "";
            // 
            // Checked
            // 
            Checked.FormattingEnabled = true;
            Checked.Location = new Point(668, 154);
            Checked.Name = "Checked";
            Checked.Size = new Size(120, 256);
            Checked.TabIndex = 10;
            Checked.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(668, 125);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(94, 19);
            checkBox1.TabIndex = 11;
            checkBox1.Text = "Alles erledigt";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(checkBox1);
            Controls.Add(Checked);
            Controls.Add(richTextBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxprice);
            Controls.Add(textBoxname);
            Controls.Add(comboBox1);
            Name = "Form1";
            Text = "Planung und Einkaufsliste";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox comboBox1;
        private TextBox textBoxname;
        private TextBox textBoxprice;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private RichTextBox richTextBox1;
        private CheckedListBox Checked;
        private CheckBox checkBox1;
    }
}