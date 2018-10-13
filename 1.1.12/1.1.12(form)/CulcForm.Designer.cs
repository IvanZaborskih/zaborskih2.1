namespace _1._1._12_form_
{
    partial class CulcForm
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
            this.inputFirstNum = new System.Windows.Forms.TextBox();
            this.inputFirstDen = new System.Windows.Forms.TextBox();
            this.inputSecondNum = new System.Windows.Forms.TextBox();
            this.inputSecondDen = new System.Windows.Forms.TextBox();
            this.multNum = new System.Windows.Forms.TextBox();
            this.multDen = new System.Windows.Forms.TextBox();
            this.multBut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.divBut = new System.Windows.Forms.Button();
            this.divDen = new System.Windows.Forms.TextBox();
            this.divNum = new System.Windows.Forms.TextBox();
            this.sumBut = new System.Windows.Forms.Button();
            this.sumDen = new System.Windows.Forms.TextBox();
            this.sumNum = new System.Windows.Forms.TextBox();
            this.subBut = new System.Windows.Forms.Button();
            this.subDen = new System.Windows.Forms.TextBox();
            this.subNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // inputFirstNum
            // 
            this.inputFirstNum.Location = new System.Drawing.Point(40, 80);
            this.inputFirstNum.Margin = new System.Windows.Forms.Padding(0);
            this.inputFirstNum.Name = "inputFirstNum";
            this.inputFirstNum.Size = new System.Drawing.Size(59, 22);
            this.inputFirstNum.TabIndex = 0;
            // 
            // inputFirstDen
            // 
            this.inputFirstDen.Location = new System.Drawing.Point(40, 101);
            this.inputFirstDen.Name = "inputFirstDen";
            this.inputFirstDen.Size = new System.Drawing.Size(59, 22);
            this.inputFirstDen.TabIndex = 1;
            // 
            // inputSecondNum
            // 
            this.inputSecondNum.Location = new System.Drawing.Point(156, 80);
            this.inputSecondNum.Name = "inputSecondNum";
            this.inputSecondNum.Size = new System.Drawing.Size(59, 22);
            this.inputSecondNum.TabIndex = 2;
            // 
            // inputSecondDen
            // 
            this.inputSecondDen.Location = new System.Drawing.Point(156, 101);
            this.inputSecondDen.Name = "inputSecondDen";
            this.inputSecondDen.Size = new System.Drawing.Size(59, 22);
            this.inputSecondDen.TabIndex = 3;
            // 
            // multNum
            // 
            this.multNum.Location = new System.Drawing.Point(351, 80);
            this.multNum.Name = "multNum";
            this.multNum.Size = new System.Drawing.Size(96, 22);
            this.multNum.TabIndex = 4;
            // 
            // multDen
            // 
            this.multDen.Location = new System.Drawing.Point(351, 101);
            this.multDen.Name = "multDen";
            this.multDen.Size = new System.Drawing.Size(96, 22);
            this.multDen.TabIndex = 5;
            // 
            // multBut
            // 
            this.multBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.multBut.Location = new System.Drawing.Point(453, 80);
            this.multBut.Name = "multBut";
            this.multBut.Size = new System.Drawing.Size(43, 43);
            this.multBut.TabIndex = 6;
            this.multBut.Text = "*";
            this.multBut.UseVisualStyleBackColor = true;
            this.multBut.Click += new System.EventHandler(this.Mult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "2";
            // 
            // divBut
            // 
            this.divBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.divBut.Location = new System.Drawing.Point(453, 168);
            this.divBut.Name = "divBut";
            this.divBut.Size = new System.Drawing.Size(43, 43);
            this.divBut.TabIndex = 13;
            this.divBut.Text = "/";
            this.divBut.UseVisualStyleBackColor = true;
            this.divBut.Click += new System.EventHandler(this.divBut_Click);
            // 
            // divDen
            // 
            this.divDen.Location = new System.Drawing.Point(351, 189);
            this.divDen.Name = "divDen";
            this.divDen.Size = new System.Drawing.Size(96, 22);
            this.divDen.TabIndex = 12;
            // 
            // divNum
            // 
            this.divNum.Location = new System.Drawing.Point(351, 168);
            this.divNum.Name = "divNum";
            this.divNum.Size = new System.Drawing.Size(96, 22);
            this.divNum.TabIndex = 11;
            // 
            // sumBut
            // 
            this.sumBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sumBut.Location = new System.Drawing.Point(453, 257);
            this.sumBut.Name = "sumBut";
            this.sumBut.Size = new System.Drawing.Size(43, 43);
            this.sumBut.TabIndex = 16;
            this.sumBut.Text = "+";
            this.sumBut.UseVisualStyleBackColor = true;
            this.sumBut.Click += new System.EventHandler(this.sumBut_Click);
            // 
            // sumDen
            // 
            this.sumDen.Location = new System.Drawing.Point(351, 278);
            this.sumDen.Name = "sumDen";
            this.sumDen.Size = new System.Drawing.Size(96, 22);
            this.sumDen.TabIndex = 15;
            // 
            // sumNum
            // 
            this.sumNum.Location = new System.Drawing.Point(351, 257);
            this.sumNum.Name = "sumNum";
            this.sumNum.Size = new System.Drawing.Size(96, 22);
            this.sumNum.TabIndex = 14;
            // 
            // subBut
            // 
            this.subBut.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subBut.Location = new System.Drawing.Point(453, 348);
            this.subBut.Name = "subBut";
            this.subBut.Size = new System.Drawing.Size(43, 43);
            this.subBut.TabIndex = 19;
            this.subBut.Text = "-";
            this.subBut.UseVisualStyleBackColor = true;
            this.subBut.Click += new System.EventHandler(this.subBut_Click);
            // 
            // subDen
            // 
            this.subDen.Location = new System.Drawing.Point(351, 369);
            this.subDen.Name = "subDen";
            this.subDen.Size = new System.Drawing.Size(96, 22);
            this.subDen.TabIndex = 18;
            // 
            // subNum
            // 
            this.subNum.Location = new System.Drawing.Point(351, 348);
            this.subNum.Name = "subNum";
            this.subNum.Size = new System.Drawing.Size(96, 22);
            this.subNum.TabIndex = 17;
            // 
            // CulcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 466);
            this.Controls.Add(this.subBut);
            this.Controls.Add(this.subDen);
            this.Controls.Add(this.subNum);
            this.Controls.Add(this.sumBut);
            this.Controls.Add(this.sumDen);
            this.Controls.Add(this.sumNum);
            this.Controls.Add(this.divBut);
            this.Controls.Add(this.divDen);
            this.Controls.Add(this.divNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multBut);
            this.Controls.Add(this.multDen);
            this.Controls.Add(this.multNum);
            this.Controls.Add(this.inputSecondDen);
            this.Controls.Add(this.inputSecondNum);
            this.Controls.Add(this.inputFirstDen);
            this.Controls.Add(this.inputFirstNum);
            this.Name = "CulcForm";
            this.Text = "SimpleFraction";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputFirstNum;
        private System.Windows.Forms.TextBox inputFirstDen;
        private System.Windows.Forms.TextBox inputSecondNum;
        private System.Windows.Forms.TextBox inputSecondDen;
        private System.Windows.Forms.TextBox multNum;
        private System.Windows.Forms.TextBox multDen;
        private System.Windows.Forms.Button multBut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox divDen;
        private System.Windows.Forms.TextBox divNum;
        private System.Windows.Forms.Button divBut;
        private System.Windows.Forms.Button sumBut;
        private System.Windows.Forms.TextBox sumDen;
        private System.Windows.Forms.TextBox sumNum;
        private System.Windows.Forms.Button subBut;
        private System.Windows.Forms.TextBox subDen;
        private System.Windows.Forms.TextBox subNum;
    }
}

