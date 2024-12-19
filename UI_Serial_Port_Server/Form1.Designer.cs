namespace UI_Serial_Port_Server
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
            components = new System.ComponentModel.Container();
            button1 = new Button();
            button2 = new Button();
            richTextBox1 = new RichTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            listBox1 = new ListBox();
            label1 = new Label();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            listBox2 = new ListBox();
            label2 = new Label();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(42, 476);
            button1.Name = "button1";
            button1.Size = new Size(134, 23);
            button1.TabIndex = 0;
            button1.Text = "Слушать ардуино";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(216, 476);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Выкл";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(28, 94);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(364, 353);
            richTextBox1.TabIndex = 2;
            richTextBox1.Text = "";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(499, 12);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(223, 349);
            listBox1.TabIndex = 3;
            listBox1.Click += listBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(480, 376);
            label1.Name = "label1";
            label1.Size = new Size(279, 15);
            label1.TabIndex = 4;
            label1.Text = "Добавление/Редактирование/Удаление клиентов";
            // 
            // button3
            // 
            button3.Location = new Point(480, 400);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 5;
            button3.Text = "Добавить";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(670, 400);
            button4.Name = "button4";
            button4.Size = new Size(89, 23);
            button4.TabIndex = 6;
            button4.Text = "Удалить";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(561, 400);
            button5.Name = "button5";
            button5.Size = new Size(103, 23);
            button5.TabIndex = 7;
            button5.Text = "Редактировать";
            button5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(747, 15);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 9;
            label3.Text = "Имя";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(747, 43);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 10;
            label4.Text = "Фамилия";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label5.Location = new Point(747, 71);
            label5.Name = "label5";
            label5.Size = new Size(34, 15);
            label5.TabIndex = 11;
            label5.Text = "ИНН";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label6.Location = new Point(747, 97);
            label6.Name = "label6";
            label6.Size = new Size(54, 15);
            label6.TabIndex = 12;
            label6.Text = "Паспорт";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label7.Location = new Point(747, 121);
            label7.Name = "label7";
            label7.Size = new Size(40, 15);
            label7.TabIndex = 13;
            label7.Text = "Город";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(811, 121);
            label8.Name = "label8";
            label8.Size = new Size(40, 15);
            label8.TabIndex = 19;
            label8.Text = "Город";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(811, 97);
            label9.Name = "label9";
            label9.Size = new Size(54, 15);
            label9.TabIndex = 18;
            label9.Text = "Паспорт";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(811, 71);
            label10.Name = "label10";
            label10.Size = new Size(34, 15);
            label10.TabIndex = 17;
            label10.Text = "ИНН";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(811, 43);
            label11.Name = "label11";
            label11.Size = new Size(58, 15);
            label11.TabIndex = 16;
            label11.Text = "Фамилия";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(811, 15);
            label12.Name = "label12";
            label12.Size = new Size(31, 15);
            label12.TabIndex = 15;
            label12.Text = "Имя";
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.ItemHeight = 15;
            listBox2.Location = new Point(839, 182);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(169, 184);
            listBox2.TabIndex = 20;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(836, 153);
            label2.Name = "label2";
            label2.Size = new Size(172, 15);
            label2.TabIndex = 21;
            label2.Text = "Информация о счёте Клиента";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label13.Location = new Point(839, 376);
            label13.Name = "label13";
            label13.Size = new Size(81, 15);
            label13.TabIndex = 22;
            label13.Text = "Номер Счёта";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label14.Location = new Point(839, 400);
            label14.Name = "label14";
            label14.Size = new Size(62, 15);
            label14.TabIndex = 23;
            label14.Text = "Тип счёта";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label15.Location = new Point(839, 424);
            label15.Name = "label15";
            label15.Size = new Size(103, 15);
            label15.TabIndex = 24;
            label15.Text = "Остаток на счёте";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(860, 476);
            label16.Name = "label16";
            label16.Size = new Size(128, 15);
            label16.TabIndex = 25;
            label16.Text = "Операции со счетами";
            // 
            // button6
            // 
            button6.Location = new Point(885, 504);
            button6.Name = "button6";
            button6.Size = new Size(103, 23);
            button6.TabIndex = 28;
            button6.Text = "Редактировать";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.Location = new Point(994, 504);
            button7.Name = "button7";
            button7.Size = new Size(89, 23);
            button7.TabIndex = 27;
            button7.Text = "Удалить";
            button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.Location = new Point(804, 504);
            button8.Name = "button8";
            button8.Size = new Size(75, 23);
            button8.TabIndex = 26;
            button8.Text = "Добавить";
            button8.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(157, 71);
            label17.Name = "label17";
            label17.Size = new Size(50, 15);
            label17.TabIndex = 29;
            label17.Text = "Arduino";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(945, 376);
            label18.Name = "label18";
            label18.Size = new Size(80, 15);
            label18.TabIndex = 30;
            label18.Text = "Номер Счёта";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(945, 400);
            label19.Name = "label19";
            label19.Size = new Size(60, 15);
            label19.TabIndex = 31;
            label19.Text = "Тип счёта";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(945, 424);
            label20.Name = "label20";
            label20.Size = new Size(100, 15);
            label20.TabIndex = 32;
            label20.Text = "Остаток на счёте";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1221, 703);
            Controls.Add(label20);
            Controls.Add(label19);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(label13);
            Controls.Add(label2);
            Controls.Add(listBox2);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(richTextBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private RichTextBox richTextBox1;
        private System.Windows.Forms.Timer timer1;
        private ListBox listBox1;
        private Label label1;
        private Button button3;
        private Button button4;
        private Button button5;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private ListBox listBox2;
        private Label label2;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button button6;
        private Button button7;
        private Button button8;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
    }
}
