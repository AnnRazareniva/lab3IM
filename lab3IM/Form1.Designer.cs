namespace lab3IM
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
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.Num = new System.Windows.Forms.NumericUpDown();
            this.kletka = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Num)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(573, 112);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 85);
            this.button1.TabIndex = 0;
            this.button1.Text = "Поехали!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(27, 142);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(327, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Введите число для правила";
            // 
            // Num
            // 
            this.Num.Location = new System.Drawing.Point(392, 150);
            this.Num.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Num.Maximum = new decimal(new int[] {
            256,
            0,
            0,
            0});
            this.Num.Minimum = new decimal(new int[] {
            64,
            0,
            0,
            0});
            this.Num.Name = "Num";
            this.Num.Size = new System.Drawing.Size(160, 22);
            this.Num.TabIndex = 3;
            this.Num.Value = new decimal(new int[] {
            110,
            0,
            0,
            0});
            // 
            // kletka
            // 
            this.kletka.BackColor = System.Drawing.Color.DarkGray;
            this.kletka.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kletka.Location = new System.Drawing.Point(98, 245);
            this.kletka.Name = "kletka";
            this.kletka.Size = new System.Drawing.Size(808, 586);
            this.kletka.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(788, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 85);
            this.button2.TabIndex = 6;
            this.button2.Text = "Чистка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 885);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kletka);
            this.Controls.Add(this.Num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown Num;
        private System.Windows.Forms.Panel kletka;
        private System.Windows.Forms.Button button2;
    }
}

