namespace WinFormsApp1
{
    partial class StatisticsDisplay
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            labAvgTemp = new Label();
            labMinTemp = new Label();
            labMaxTemp = new Label();
            btnReg = new Button();
            btnDeReg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(77, 31);
            label1.Name = "label1";
            label1.Size = new Size(187, 30);
            label1.TabIndex = 0;
            label1.Text = "Weather Statistics";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(60, 108);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 1;
            label2.Text = "Average Temp.:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(60, 147);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 1;
            label3.Text = "Min Temp.:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(60, 193);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 1;
            label4.Text = "Max Temp.:";
            // 
            // labAvgTemp
            // 
            labAvgTemp.AutoSize = true;
            labAvgTemp.Location = new Point(163, 108);
            labAvgTemp.Name = "labAvgTemp";
            labAvgTemp.Size = new Size(57, 15);
            labAvgTemp.TabIndex = 1;
            labAvgTemp.Text = "__________";
            // 
            // labMinTemp
            // 
            labMinTemp.AutoSize = true;
            labMinTemp.Location = new Point(163, 147);
            labMinTemp.Name = "labMinTemp";
            labMinTemp.Size = new Size(57, 15);
            labMinTemp.TabIndex = 1;
            labMinTemp.Text = "__________";
            // 
            // labMaxTemp
            // 
            labMaxTemp.AutoSize = true;
            labMaxTemp.Location = new Point(163, 193);
            labMaxTemp.Name = "labMaxTemp";
            labMaxTemp.Size = new Size(57, 15);
            labMaxTemp.TabIndex = 1;
            labMaxTemp.Text = "__________";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(91, 243);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(144, 23);
            btnReg.TabIndex = 2;
            btnReg.Text = "Register as observer";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnDeReg
            // 
            btnDeReg.Location = new Point(91, 272);
            btnDeReg.Name = "btnDeReg";
            btnDeReg.Size = new Size(144, 23);
            btnDeReg.TabIndex = 2;
            btnDeReg.Text = "De-register as observer";
            btnDeReg.UseVisualStyleBackColor = true;
            btnDeReg.Click += btnDereg_Click;
            // 
            // StatisticsDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 321);
            Controls.Add(btnDeReg);
            Controls.Add(btnReg);
            Controls.Add(labMaxTemp);
            Controls.Add(label4);
            Controls.Add(labMinTemp);
            Controls.Add(labAvgTemp);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "StatisticsDisplay";
            Text = "StatisticsDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labAvgTemp;
        private Label labMinTemp;
        private Label labMaxTemp;
        private Button btnReg;
        private Button btnDeReg;
    }
}