namespace WinFormsApp1
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
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            checkBox1 = new CheckBox();
            cbTest2 = new ComboBox();
            dtpTest1 = new DateTimePicker();
            nudTest1 = new NumericUpDown();
            rbUno = new RadioButton();
            rbDos = new RadioButton();
            tbcTest1 = new TabControl();
            tabPage1 = new TabPage();
            label2 = new Label();
            tabPage2 = new TabPage();
            button5 = new Button();
            lblResult2 = new Label();
            btnTest2 = new Button();
            ((System.ComponentModel.ISupportInitialize)nudTest1).BeginInit();
            tbcTest1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(521, 36);
            button1.Name = "button1";
            button1.Size = new Size(103, 32);
            button1.TabIndex = 0;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(555, 220);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "Answer";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Info;
            textBox1.Location = new Point(214, 45);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(128, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.BackColor = SystemColors.Info;
            textBox2.Location = new Point(838, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 23);
            textBox2.TabIndex = 3;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.ControlDarkDark;
            button2.Location = new Point(521, 108);
            button2.Name = "button2";
            button2.Size = new Size(103, 28);
            button2.TabIndex = 4;
            button2.Text = "/";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.ControlDarkDark;
            button3.Location = new Point(521, 71);
            button3.Name = "button3";
            button3.Size = new Size(103, 31);
            button3.TabIndex = 5;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.ControlDarkDark;
            button4.Location = new Point(521, 142);
            button4.Name = "button4";
            button4.Size = new Size(103, 28);
            button4.TabIndex = 6;
            button4.Text = "*";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(26, 467);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(61, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "My CB";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // cbTest2
            // 
            cbTest2.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTest2.FormattingEnabled = true;
            cbTest2.Items.AddRange(new object[] { "Uno", "Dos", "Tres", "Cuadro" });
            cbTest2.Location = new Point(173, 461);
            cbTest2.Name = "cbTest2";
            cbTest2.Size = new Size(121, 23);
            cbTest2.TabIndex = 8;
            // 
            // dtpTest1
            // 
            dtpTest1.Format = DateTimePickerFormat.Short;
            dtpTest1.Location = new Point(26, 516);
            dtpTest1.Name = "dtpTest1";
            dtpTest1.Size = new Size(95, 23);
            dtpTest1.TabIndex = 9;
            // 
            // nudTest1
            // 
            nudTest1.Location = new Point(173, 516);
            nudTest1.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            nudTest1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            nudTest1.Name = "nudTest1";
            nudTest1.Size = new Size(120, 23);
            nudTest1.TabIndex = 10;
            nudTest1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // rbUno
            // 
            rbUno.AutoSize = true;
            rbUno.Location = new Point(377, 462);
            rbUno.Name = "rbUno";
            rbUno.Size = new Size(47, 19);
            rbUno.TabIndex = 11;
            rbUno.TabStop = true;
            rbUno.Text = "Uno";
            rbUno.UseVisualStyleBackColor = true;
            // 
            // rbDos
            // 
            rbDos.AutoSize = true;
            rbDos.Location = new Point(377, 487);
            rbDos.Name = "rbDos";
            rbDos.Size = new Size(45, 19);
            rbDos.TabIndex = 12;
            rbDos.TabStop = true;
            rbDos.Text = "Dos";
            rbDos.UseVisualStyleBackColor = true;
            // 
            // tbcTest1
            // 
            tbcTest1.Controls.Add(tabPage1);
            tbcTest1.Controls.Add(tabPage2);
            tbcTest1.Location = new Point(430, 426);
            tbcTest1.Name = "tbcTest1";
            tbcTest1.SelectedIndex = 0;
            tbcTest1.Size = new Size(392, 202);
            tbcTest1.TabIndex = 13;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(384, 174);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Uno";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 80);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 0;
            label2.Text = "Hello";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(button5);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(384, 174);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Dos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(115, 64);
            button5.Name = "button5";
            button5.Size = new Size(75, 23);
            button5.TabIndex = 15;
            button5.Text = "Hello";
            button5.UseVisualStyleBackColor = true;
            // 
            // lblResult2
            // 
            lblResult2.AutoSize = true;
            lblResult2.Location = new Point(28, 586);
            lblResult2.Name = "lblResult2";
            lblResult2.Size = new Size(0, 15);
            lblResult2.TabIndex = 14;
            // 
            // btnTest2
            // 
            btnTest2.Location = new Point(119, 578);
            btnTest2.Name = "btnTest2";
            btnTest2.Size = new Size(75, 23);
            btnTest2.TabIndex = 15;
            btnTest2.Text = "Button";
            btnTest2.UseVisualStyleBackColor = true;
            btnTest2.Click += btnTest2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1108, 640);
            Controls.Add(btnTest2);
            Controls.Add(lblResult2);
            Controls.Add(tbcTest1);
            Controls.Add(rbDos);
            Controls.Add(rbUno);
            Controls.Add(nudTest1);
            Controls.Add(dtpTest1);
            Controls.Add(cbTest2);
            Controls.Add(checkBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)nudTest1).EndInit();
            tbcTest1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button button3;
        private Button button4;
        private CheckBox checkBox1;
        private ComboBox cbTest2;
        private DateTimePicker dtpTest1;
        private NumericUpDown nudTest1;
        private RadioButton rbUno;
        private RadioButton rbDos;
        private TabControl tbcTest1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label2;
        private Button button5;
        private Label lblResult2;
        private Button btnTest2;
    }
}