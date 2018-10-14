namespace _1._2._12_form_
{
    partial class DiamondForm
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
            this.getPriceButton = new System.Windows.Forms.Button();
            this.inputName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputWeight = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputCutQuality = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputColor = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.priceOutput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // getPriceButton
            // 
            this.getPriceButton.Location = new System.Drawing.Point(291, 123);
            this.getPriceButton.Name = "getPriceButton";
            this.getPriceButton.Size = new System.Drawing.Size(112, 53);
            this.getPriceButton.TabIndex = 0;
            this.getPriceButton.Text = "Получить цену";
            this.getPriceButton.UseVisualStyleBackColor = true;
            this.getPriceButton.Click += new System.EventHandler(this.getPriceButton_Click);
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(12, 40);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(100, 22);
            this.inputName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Вес (в каратах)";
            // 
            // inputWeight
            // 
            this.inputWeight.Location = new System.Drawing.Point(12, 104);
            this.inputWeight.Name = "inputWeight";
            this.inputWeight.Size = new System.Drawing.Size(100, 22);
            this.inputWeight.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Качество огранки (число)";
            // 
            // inputCutQuality
            // 
            this.inputCutQuality.Location = new System.Drawing.Point(14, 179);
            this.inputCutQuality.Name = "inputCutQuality";
            this.inputCutQuality.Size = new System.Drawing.Size(100, 22);
            this.inputCutQuality.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Цвет";
            // 
            // inputColor
            // 
            this.inputColor.Location = new System.Drawing.Point(12, 260);
            this.inputColor.Name = "inputColor";
            this.inputColor.Size = new System.Drawing.Size(38, 22);
            this.inputColor.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(506, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // priceOutput
            // 
            this.priceOutput.BackColor = System.Drawing.SystemColors.Window;
            this.priceOutput.Location = new System.Drawing.Point(509, 138);
            this.priceOutput.Name = "priceOutput";
            this.priceOutput.ReadOnly = true;
            this.priceOutput.Size = new System.Drawing.Size(100, 22);
            this.priceOutput.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(274, 85);
            this.label6.TabIndex = 11;
            this.label6.Text = "Введите номер цвета алмаза из списка:\r\n1) Голубой \r\n2) Желтый \r\n3) Красный \r\n4) Б" +
    "елый";
            // 
            // DiamondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 389);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.priceOutput);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputColor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputCutQuality);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputWeight);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.getPriceButton);
            this.Name = "DiamondForm";
            this.Text = "DiamondForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getPriceButton;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputWeight;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputCutQuality;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox priceOutput;
        private System.Windows.Forms.Label label6;
    }
}

