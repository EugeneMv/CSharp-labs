namespace OOP6
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
            this.Base = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SubBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SubBox2 = new System.Windows.Forms.TextBox();
            this.unionStr = new System.Windows.Forms.Button();
            this.DelSubStr = new System.Windows.Forms.Button();
            this.Replace = new System.Windows.Forms.Button();
            this.DoubleStr = new System.Windows.Forms.Button();
            this.LengthStr = new System.Windows.Forms.Button();
            this.FindStr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Base
            // 
            this.Base.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Base.Location = new System.Drawing.Point(12, 32);
            this.Base.Name = "Base";
            this.Base.Size = new System.Drawing.Size(520, 26);
            this.Base.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Главная строка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(78, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Подстрока";
            // 
            // SubBox1
            // 
            this.SubBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubBox1.Location = new System.Drawing.Point(12, 111);
            this.SubBox1.Name = "SubBox1";
            this.SubBox1.Size = new System.Drawing.Size(205, 26);
            this.SubBox1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(320, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вспомогательная строка";
            // 
            // SubBox2
            // 
            this.SubBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SubBox2.Location = new System.Drawing.Point(315, 111);
            this.SubBox2.Name = "SubBox2";
            this.SubBox2.Size = new System.Drawing.Size(217, 26);
            this.SubBox2.TabIndex = 4;
            // 
            // unionStr
            // 
            this.unionStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.unionStr.Location = new System.Drawing.Point(120, 159);
            this.unionStr.Name = "unionStr";
            this.unionStr.Size = new System.Drawing.Size(140, 38);
            this.unionStr.TabIndex = 6;
            this.unionStr.Text = "объединить";
            this.unionStr.UseVisualStyleBackColor = true;
            this.unionStr.Click += new System.EventHandler(this.unionStr_Click);
            // 
            // DelSubStr
            // 
            this.DelSubStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelSubStr.Location = new System.Drawing.Point(120, 203);
            this.DelSubStr.Name = "DelSubStr";
            this.DelSubStr.Size = new System.Drawing.Size(140, 38);
            this.DelSubStr.TabIndex = 7;
            this.DelSubStr.Text = "Удалить";
            this.DelSubStr.UseVisualStyleBackColor = true;
            this.DelSubStr.Click += new System.EventHandler(this.DelSubStr_Click);
            // 
            // Replace
            // 
            this.Replace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Replace.Location = new System.Drawing.Point(120, 247);
            this.Replace.Name = "Replace";
            this.Replace.Size = new System.Drawing.Size(140, 38);
            this.Replace.TabIndex = 8;
            this.Replace.Text = "Заменить";
            this.Replace.UseVisualStyleBackColor = true;
            this.Replace.Click += new System.EventHandler(this.Replace_Click);
            // 
            // DoubleStr
            // 
            this.DoubleStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoubleStr.Location = new System.Drawing.Point(266, 247);
            this.DoubleStr.Name = "DoubleStr";
            this.DoubleStr.Size = new System.Drawing.Size(140, 38);
            this.DoubleStr.TabIndex = 11;
            this.DoubleStr.Text = "Удвоение";
            this.DoubleStr.UseVisualStyleBackColor = true;
            this.DoubleStr.Click += new System.EventHandler(this.DoubleStr_Click);
            // 
            // LengthStr
            // 
            this.LengthStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LengthStr.Location = new System.Drawing.Point(266, 203);
            this.LengthStr.Name = "LengthStr";
            this.LengthStr.Size = new System.Drawing.Size(140, 38);
            this.LengthStr.TabIndex = 10;
            this.LengthStr.Text = "Длина";
            this.LengthStr.UseVisualStyleBackColor = true;
            this.LengthStr.Click += new System.EventHandler(this.LengthStr_Click);
            // 
            // FindStr
            // 
            this.FindStr.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FindStr.Location = new System.Drawing.Point(266, 159);
            this.FindStr.Name = "FindStr";
            this.FindStr.Size = new System.Drawing.Size(140, 38);
            this.FindStr.TabIndex = 9;
            this.FindStr.Text = "Найти";
            this.FindStr.UseVisualStyleBackColor = true;
            this.FindStr.Click += new System.EventHandler(this.FindStr_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 311);
            this.Controls.Add(this.DoubleStr);
            this.Controls.Add(this.LengthStr);
            this.Controls.Add(this.FindStr);
            this.Controls.Add(this.Replace);
            this.Controls.Add(this.DelSubStr);
            this.Controls.Add(this.unionStr);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SubBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SubBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Base);
            this.Name = "Form1";
            this.Text = "calc";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Base;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SubBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SubBox2;
        private System.Windows.Forms.Button unionStr;
        private System.Windows.Forms.Button DelSubStr;
        private System.Windows.Forms.Button Replace;
        private System.Windows.Forms.Button DoubleStr;
        private System.Windows.Forms.Button LengthStr;
        private System.Windows.Forms.Button FindStr;
    }
}

