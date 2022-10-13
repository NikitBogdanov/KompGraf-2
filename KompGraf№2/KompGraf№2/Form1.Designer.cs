
namespace KompGraf_2
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Pixel = new System.Windows.Forms.Button();
            this.Millimeter = new System.Windows.Forms.Button();
            this.Inch = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(900, 450);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Pixel
            // 
            this.Pixel.Location = new System.Drawing.Point(12, 493);
            this.Pixel.Name = "Pixel";
            this.Pixel.Size = new System.Drawing.Size(167, 46);
            this.Pixel.TabIndex = 1;
            this.Pixel.Text = "Pixel";
            this.Pixel.UseVisualStyleBackColor = true;
            this.Pixel.Click += new System.EventHandler(this.Pixel_Click);
            // 
            // Millimeter
            // 
            this.Millimeter.Location = new System.Drawing.Point(254, 493);
            this.Millimeter.Name = "Millimeter";
            this.Millimeter.Size = new System.Drawing.Size(167, 46);
            this.Millimeter.TabIndex = 1;
            this.Millimeter.Text = "Millimeter";
            this.Millimeter.UseVisualStyleBackColor = true;
            this.Millimeter.Click += new System.EventHandler(this.Millimeter_Click);
            // 
            // Inch
            // 
            this.Inch.Location = new System.Drawing.Point(500, 493);
            this.Inch.Name = "Inch";
            this.Inch.Size = new System.Drawing.Size(167, 46);
            this.Inch.TabIndex = 1;
            this.Inch.Text = "Inch";
            this.Inch.UseVisualStyleBackColor = true;
            this.Inch.Click += new System.EventHandler(this.Inch_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(745, 493);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(167, 46);
            this.Clear.TabIndex = 1;
            this.Clear.Text = "Очистка";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 570);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Inch);
            this.Controls.Add(this.Millimeter);
            this.Controls.Add(this.Pixel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Pixel;
        private System.Windows.Forms.Button Millimeter;
        private System.Windows.Forms.Button Inch;
        private System.Windows.Forms.Button Clear;
    }
}

