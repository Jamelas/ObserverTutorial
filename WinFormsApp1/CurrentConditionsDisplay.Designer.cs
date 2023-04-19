namespace WinFormsApp1
{
    partial class CurrentConditionsDisplay
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
            labTemp = new Label();
            labHumidity = new Label();
            labPressure = new Label();
            btnReg = new Button();
            btnDereg = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(70, 111);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Temp:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 159);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Humidity:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 206);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 0;
            label3.Text = "Pressure:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(70, 33);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 1;
            label4.Text = "Current Conditions";
            // 
            // labTemp
            // 
            labTemp.AutoSize = true;
            labTemp.Location = new Point(195, 111);
            labTemp.Name = "labTemp";
            labTemp.Size = new Size(57, 15);
            labTemp.TabIndex = 2;
            labTemp.Text = "__________";
            // 
            // labHumidity
            // 
            labHumidity.AutoSize = true;
            labHumidity.Location = new Point(195, 159);
            labHumidity.Name = "labHumidity";
            labHumidity.Size = new Size(57, 15);
            labHumidity.TabIndex = 2;
            labHumidity.Text = "__________";
            // 
            // labPressure
            // 
            labPressure.AutoSize = true;
            labPressure.Location = new Point(195, 206);
            labPressure.Name = "labPressure";
            labPressure.Size = new Size(57, 15);
            labPressure.TabIndex = 2;
            labPressure.Text = "__________";
            // 
            // btnReg
            // 
            btnReg.Location = new Point(93, 245);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(144, 23);
            btnReg.TabIndex = 3;
            btnReg.Text = "Register as observer";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnDereg
            // 
            btnDereg.Location = new Point(93, 274);
            btnDereg.Name = "btnDereg";
            btnDereg.Size = new Size(144, 23);
            btnDereg.TabIndex = 3;
            btnDereg.Text = "De-register as observer";
            btnDereg.UseVisualStyleBackColor = true;
            btnDereg.Click += btnDereg_Click;
            // 
            // CurrentConditionsDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 321);
            Controls.Add(btnDereg);
            Controls.Add(btnReg);
            Controls.Add(labPressure);
            Controls.Add(labHumidity);
            Controls.Add(labTemp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "CurrentConditionsDisplay";
            Text = "CurrentConditionsDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label labTemp;
        private Label labHumidity;
        private Label labPressure;
        private Button btnReg;
        private Button btnDereg;
    }
}