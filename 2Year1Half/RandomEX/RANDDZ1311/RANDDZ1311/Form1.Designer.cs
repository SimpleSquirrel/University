namespace RANDDZ1311
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.minusSpeed = new System.Windows.Forms.Button();
            this.plusSpeed = new System.Windows.Forms.Button();
            this.gotop = new System.Windows.Forms.Button();
            this.gobot = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 40);
            this.button1.TabIndex = 0;
            this.button1.Text = "Animate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 379);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // minusSpeed
            // 
            this.minusSpeed.Location = new System.Drawing.Point(317, 398);
            this.minusSpeed.Name = "minusSpeed";
            this.minusSpeed.Size = new System.Drawing.Size(67, 40);
            this.minusSpeed.TabIndex = 2;
            this.minusSpeed.Text = "-";
            this.minusSpeed.UseVisualStyleBackColor = true;
            this.minusSpeed.Click += new System.EventHandler(this.button2_Click);
            // 
            // plusSpeed
            // 
            this.plusSpeed.Location = new System.Drawing.Point(390, 398);
            this.plusSpeed.Name = "plusSpeed";
            this.plusSpeed.Size = new System.Drawing.Size(67, 40);
            this.plusSpeed.TabIndex = 3;
            this.plusSpeed.Text = "+";
            this.plusSpeed.UseVisualStyleBackColor = true;
            this.plusSpeed.Click += new System.EventHandler(this.button3_Click);
            // 
            // gotop
            // 
            this.gotop.Location = new System.Drawing.Point(595, 399);
            this.gotop.Name = "gotop";
            this.gotop.Size = new System.Drawing.Size(100, 39);
            this.gotop.TabIndex = 4;
            this.gotop.Text = "Don\'tMove";
            this.gotop.UseVisualStyleBackColor = true;
            this.gotop.Click += new System.EventHandler(this.gotop_Click);
            // 
            // gobot
            // 
            this.gobot.Location = new System.Drawing.Point(701, 398);
            this.gobot.Name = "gobot";
            this.gobot.Size = new System.Drawing.Size(87, 39);
            this.gobot.TabIndex = 5;
            this.gobot.Text = "MoveByY";
            this.gobot.UseVisualStyleBackColor = true;
            this.gobot.Click += new System.EventHandler(this.gobot_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gobot);
            this.Controls.Add(this.gotop);
            this.Controls.Add(this.plusSpeed);
            this.Controls.Add(this.minusSpeed);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button minusSpeed;
        private System.Windows.Forms.Button plusSpeed;
        private System.Windows.Forms.Button gotop;
        private System.Windows.Forms.Button gobot;
    }
}

