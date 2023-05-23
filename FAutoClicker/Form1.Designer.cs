namespace FAutoClicker
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.btn_Start = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rb_Left = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.rb_Right = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rb_Double = new System.Windows.Forms.RadioButton();
            this.rb_Singl = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ColorePanel = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.MyTGLink = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Start
            // 
            this.btn_Start.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(232, 138);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(96, 28);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "Запустить";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 16);
            this.textBox1.MaxLength = 8;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "500";
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Задержка клика:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Миллисекунд";
            // 
            // rb_Left
            // 
            this.rb_Left.AutoSize = true;
            this.rb_Left.Checked = true;
            this.rb_Left.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rb_Left.Location = new System.Drawing.Point(5, 1);
            this.rb_Left.Name = "rb_Left";
            this.rb_Left.Size = new System.Drawing.Size(111, 19);
            this.rb_Left.TabIndex = 3;
            this.rb_Left.TabStop = true;
            this.rb_Left.Tag = "1";
            this.rb_Left.Text = "Левой кнопкой";
            this.rb_Left.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кликать:";
            // 
            // rb_Right
            // 
            this.rb_Right.AutoSize = true;
            this.rb_Right.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rb_Right.Location = new System.Drawing.Point(118, 1);
            this.rb_Right.Name = "rb_Right";
            this.rb_Right.Size = new System.Drawing.Size(119, 19);
            this.rb_Right.TabIndex = 4;
            this.rb_Right.Tag = "1";
            this.rb_Right.Text = "Правой кнопкой";
            this.rb_Right.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Бинд:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Comic Sans MS", 8.75F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(50, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Нету";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btn_BindSet_Clicked);
            // 
            // rb_Double
            // 
            this.rb_Double.AutoSize = true;
            this.rb_Double.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rb_Double.Location = new System.Drawing.Point(143, 68);
            this.rb_Double.Name = "rb_Double";
            this.rb_Double.Size = new System.Drawing.Size(76, 19);
            this.rb_Double.TabIndex = 8;
            this.rb_Double.Tag = "2";
            this.rb_Double.Text = "Двойной";
            this.rb_Double.UseVisualStyleBackColor = true;
            // 
            // rb_Singl
            // 
            this.rb_Singl.AutoSize = true;
            this.rb_Singl.Checked = true;
            this.rb_Singl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.75F);
            this.rb_Singl.Location = new System.Drawing.Point(50, 68);
            this.rb_Singl.Name = "rb_Singl";
            this.rb_Singl.Size = new System.Drawing.Size(91, 19);
            this.rb_Singl.TabIndex = 7;
            this.rb_Singl.TabStop = true;
            this.rb_Singl.Tag = "2";
            this.rb_Singl.Text = "Одиночный";
            this.rb_Singl.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 69);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Клик:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rb_Left);
            this.panel1.Controls.Add(this.rb_Right);
            this.panel1.Location = new System.Drawing.Point(69, 41);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(248, 21);
            this.panel1.TabIndex = 9;
            // 
            // ColorePanel
            // 
            this.ColorePanel.BackColor = System.Drawing.Color.LimeGreen;
            this.ColorePanel.Location = new System.Drawing.Point(-2, -4);
            this.ColorePanel.Name = "ColorePanel";
            this.ColorePanel.Size = new System.Drawing.Size(339, 13);
            this.ColorePanel.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(126, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Продукт: FAutoClicker | Версия: 1.0.0";
            // 
            // MyTGLink
            // 
            this.MyTGLink.ActiveLinkColor = System.Drawing.Color.White;
            this.MyTGLink.AutoSize = true;
            this.MyTGLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(76)))), ((int)(((byte)(157)))));
            this.MyTGLink.DisabledLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(26)))), ((int)(((byte)(53)))));
            this.MyTGLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.MyTGLink.LinkColor = System.Drawing.Color.White;
            this.MyTGLink.Location = new System.Drawing.Point(6, 166);
            this.MyTGLink.Name = "MyTGLink";
            this.MyTGLink.Size = new System.Drawing.Size(76, 15);
            this.MyTGLink.TabIndex = 12;
            this.MyTGLink.TabStop = true;
            this.MyTGLink.Text = "@FSoftaware";
            this.MyTGLink.VisitedLinkColor = System.Drawing.Color.White;
            this.MyTGLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.MyTGLink_Clicked);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(334, 186);
            this.Controls.Add(this.MyTGLink);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ColorePanel);
            this.Controls.Add(this.rb_Double);
            this.Controls.Add(this.rb_Singl);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_Start);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(350, 225);
            this.MinimumSize = new System.Drawing.Size(350, 225);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FAutoClicker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rb_Left;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rb_Right;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rb_Double;
        private System.Windows.Forms.RadioButton rb_Singl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel ColorePanel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.LinkLabel MyTGLink;
    }
}

