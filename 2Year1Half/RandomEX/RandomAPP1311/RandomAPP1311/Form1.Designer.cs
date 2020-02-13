namespace RandomAPP1311
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
            this.createbutton = new System.Windows.Forms.Button();
            this.calcbutton = new System.Windows.Forms.Button();
            this.numtextBox = new System.Windows.Forms.TextBox();
            this.maxtextBox = new System.Windows.Forms.TextBox();
            this.numPosittextBox = new System.Windows.Forms.TextBox();
            this.arraytextBox = new System.Windows.Forms.TextBox();
            this.numPositcheckBox = new System.Windows.Forms.CheckBox();
            this.maxcheckBox = new System.Windows.Forms.CheckBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createbutton
            // 
            this.createbutton.Location = new System.Drawing.Point(72, 246);
            this.createbutton.Name = "createbutton";
            this.createbutton.Size = new System.Drawing.Size(122, 58);
            this.createbutton.TabIndex = 0;
            this.createbutton.Text = "Create";
            this.createbutton.UseVisualStyleBackColor = true;
            this.createbutton.Click += new System.EventHandler(this.createbutton_Click);
            // 
            // calcbutton
            // 
            this.calcbutton.Location = new System.Drawing.Point(291, 246);
            this.calcbutton.Name = "calcbutton";
            this.calcbutton.Size = new System.Drawing.Size(122, 58);
            this.calcbutton.TabIndex = 1;
            this.calcbutton.Text = "Calculate";
            this.calcbutton.UseVisualStyleBackColor = true;
            this.calcbutton.Click += new System.EventHandler(this.calcbutton_Click);
            // 
            // numtextBox
            // 
            this.numtextBox.Location = new System.Drawing.Point(151, 33);
            this.numtextBox.Name = "numtextBox";
            this.numtextBox.Size = new System.Drawing.Size(100, 22);
            this.numtextBox.TabIndex = 2;
            // 
            // maxtextBox
            // 
            this.maxtextBox.Location = new System.Drawing.Point(35, 74);
            this.maxtextBox.Name = "maxtextBox";
            this.maxtextBox.Size = new System.Drawing.Size(100, 22);
            this.maxtextBox.TabIndex = 3;
            this.maxtextBox.TextChanged += new System.EventHandler(this.maxtextBox_TextChanged);
            // 
            // numPosittextBox
            // 
            this.numPosittextBox.Location = new System.Drawing.Point(35, 129);
            this.numPosittextBox.Name = "numPosittextBox";
            this.numPosittextBox.Size = new System.Drawing.Size(100, 22);
            this.numPosittextBox.TabIndex = 4;
            // 
            // arraytextBox
            // 
            this.arraytextBox.Location = new System.Drawing.Point(491, 28);
            this.arraytextBox.Multiline = true;
            this.arraytextBox.Name = "arraytextBox";
            this.arraytextBox.Size = new System.Drawing.Size(274, 234);
            this.arraytextBox.TabIndex = 5;
            // 
            // numPositcheckBox
            // 
            this.numPositcheckBox.AutoSize = true;
            this.numPositcheckBox.Location = new System.Drawing.Point(151, 130);
            this.numPositcheckBox.Name = "numPositcheckBox";
            this.numPositcheckBox.Size = new System.Drawing.Size(140, 21);
            this.numPositcheckBox.TabIndex = 6;
            this.numPositcheckBox.Text = "Positive elements";
            this.numPositcheckBox.UseVisualStyleBackColor = true;
            this.numPositcheckBox.CheckedChanged += new System.EventHandler(this.numPositcheckBox_CheckedChanged);
            // 
            // maxcheckBox
            // 
            this.maxcheckBox.AutoSize = true;
            this.maxcheckBox.Location = new System.Drawing.Point(151, 76);
            this.maxcheckBox.Name = "maxcheckBox";
            this.maxcheckBox.Size = new System.Drawing.Size(106, 21);
            this.maxcheckBox.TabIndex = 7;
            this.maxcheckBox.Text = "MaxElement";
            this.maxcheckBox.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(315, 101);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(81, 21);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Click me";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(315, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 9;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Num*10";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Array size";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.maxcheckBox);
            this.Controls.Add(this.numPositcheckBox);
            this.Controls.Add(this.arraytextBox);
            this.Controls.Add(this.numPosittextBox);
            this.Controls.Add(this.maxtextBox);
            this.Controls.Add(this.numtextBox);
            this.Controls.Add(this.calcbutton);
            this.Controls.Add(this.createbutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createbutton;
        private System.Windows.Forms.Button calcbutton;
        private System.Windows.Forms.TextBox numtextBox;
        private System.Windows.Forms.TextBox maxtextBox;
        private System.Windows.Forms.TextBox numPosittextBox;
        private System.Windows.Forms.TextBox arraytextBox;
        private System.Windows.Forms.CheckBox numPositcheckBox;
        private System.Windows.Forms.CheckBox maxcheckBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Label label1;
    }
}

