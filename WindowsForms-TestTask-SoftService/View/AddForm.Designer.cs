
namespace WindowsForms_TestTask_SoftService.View
{
    partial class AddForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.AddForm_textBox1_Number = new System.Windows.Forms.TextBox();
            this.AddForm_textBox1_Brand = new System.Windows.Forms.TextBox();
            this.AddForm_textBox1_Color = new System.Windows.Forms.TextBox();
            this.AddForm_textBox1_Mileage = new System.Windows.Forms.TextBox();
            this.AddForm_textBox1_Speed = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AddForm_textBox1_Number
            // 
            this.AddForm_textBox1_Number.Location = new System.Drawing.Point(16, 42);
            this.AddForm_textBox1_Number.Name = "AddForm_textBox1_Number";
            this.AddForm_textBox1_Number.Size = new System.Drawing.Size(102, 22);
            this.AddForm_textBox1_Number.TabIndex = 1;
            // 
            // AddForm_textBox1_Brand
            // 
            this.AddForm_textBox1_Brand.Location = new System.Drawing.Point(124, 42);
            this.AddForm_textBox1_Brand.Name = "AddForm_textBox1_Brand";
            this.AddForm_textBox1_Brand.Size = new System.Drawing.Size(111, 22);
            this.AddForm_textBox1_Brand.TabIndex = 2;
            // 
            // AddForm_textBox1_Color
            // 
            this.AddForm_textBox1_Color.Location = new System.Drawing.Point(241, 42);
            this.AddForm_textBox1_Color.Name = "AddForm_textBox1_Color";
            this.AddForm_textBox1_Color.Size = new System.Drawing.Size(111, 22);
            this.AddForm_textBox1_Color.TabIndex = 3;
            // 
            // AddForm_textBox1_Mileage
            // 
            this.AddForm_textBox1_Mileage.Location = new System.Drawing.Point(358, 42);
            this.AddForm_textBox1_Mileage.Name = "AddForm_textBox1_Mileage";
            this.AddForm_textBox1_Mileage.Size = new System.Drawing.Size(111, 22);
            this.AddForm_textBox1_Mileage.TabIndex = 4;
            // 
            // AddForm_textBox1_Speed
            // 
            this.AddForm_textBox1_Speed.Location = new System.Drawing.Point(475, 42);
            this.AddForm_textBox1_Speed.Name = "AddForm_textBox1_Speed";
            this.AddForm_textBox1_Speed.Size = new System.Drawing.Size(111, 22);
            this.AddForm_textBox1_Speed.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Номер";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Марка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(267, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Цвет";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(386, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пробег";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(492, 22);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Скорость";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(592, 41);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 81);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddForm_textBox1_Speed);
            this.Controls.Add(this.AddForm_textBox1_Mileage);
            this.Controls.Add(this.AddForm_textBox1_Color);
            this.Controls.Add(this.AddForm_textBox1_Brand);
            this.Controls.Add(this.AddForm_textBox1_Number);
            this.Name = "AddForm";
            this.Text = "AddForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox AddForm_textBox1_Number;
        private System.Windows.Forms.TextBox AddForm_textBox1_Brand;
        private System.Windows.Forms.TextBox AddForm_textBox1_Color;
        private System.Windows.Forms.TextBox AddForm_textBox1_Mileage;
        private System.Windows.Forms.TextBox AddForm_textBox1_Speed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
    }
}