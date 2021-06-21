
namespace Lab15
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.T = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.NumericUpDown();
            this.Start = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Sunny = new System.Windows.Forms.TextBox();
            this.Rainy = new System.Windows.Forms.TextBox();
            this.Windy = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.T)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "T";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 197);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "N";
            // 
            // T
            // 
            this.T.Location = new System.Drawing.Point(96, 76);
            this.T.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.T.Name = "T";
            this.T.Size = new System.Drawing.Size(154, 26);
            this.T.TabIndex = 2;
            // 
            // N
            // 
            this.N.Location = new System.Drawing.Point(96, 197);
            this.N.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.N.Name = "N";
            this.N.Size = new System.Drawing.Size(154, 26);
            this.N.TabIndex = 3;
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Start.Location = new System.Drawing.Point(248, 298);
            this.Start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(200, 63);
            this.Start.TabIndex = 4;
            this.Start.Text = "Start and get forecast";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 63);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sunny";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(343, 131);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Rainy";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(343, 203);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Windy";
            // 
            // Sunny
            // 
            this.Sunny.Location = new System.Drawing.Point(465, 63);
            this.Sunny.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Sunny.Name = "Sunny";
            this.Sunny.Size = new System.Drawing.Size(127, 26);
            this.Sunny.TabIndex = 8;
            // 
            // Rainy
            // 
            this.Rainy.Location = new System.Drawing.Point(465, 131);
            this.Rainy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Rainy.Name = "Rainy";
            this.Rainy.Size = new System.Drawing.Size(127, 26);
            this.Rainy.TabIndex = 9;
            // 
            // Windy
            // 
            this.Windy.Location = new System.Drawing.Point(465, 203);
            this.Windy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Windy.Name = "Windy";
            this.Windy.Size = new System.Drawing.Size(127, 26);
            this.Windy.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 375);
            this.Controls.Add(this.Windy);
            this.Controls.Add(this.Rainy);
            this.Controls.Add(this.Sunny);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.N);
            this.Controls.Add(this.T);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.T)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.N)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown T;
        private System.Windows.Forms.NumericUpDown N;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Sunny;
        private System.Windows.Forms.TextBox Rainy;
        private System.Windows.Forms.TextBox Windy;
    }
}

