namespace WinFormsApp1
{
    partial class ForecastDisplay
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
            labForecast = new Label();
            label1 = new Label();
            labelAnswer = new Label();
            btnReg = new Button();
            btnDereg = new Button();
            SuspendLayout();
            // 
            // labForecast
            // 
            labForecast.AutoSize = true;
            labForecast.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            labForecast.Location = new Point(113, 32);
            labForecast.Margin = new Padding(2, 0, 2, 0);
            labForecast.Name = "labForecast";
            labForecast.Size = new Size(94, 30);
            labForecast.TabIndex = 0;
            labForecast.Text = "Forecast";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(41, 110);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 1;
            label1.Text = "Expected conditions:";
            // 
            // labelAnswer
            // 
            labelAnswer.AutoSize = true;
            labelAnswer.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            labelAnswer.Location = new Point(186, 110);
            labelAnswer.Margin = new Padding(2, 0, 2, 0);
            labelAnswer.Name = "labelAnswer";
            labelAnswer.Size = new Size(47, 15);
            labelAnswer.TabIndex = 2;
            labelAnswer.Text = "________";
            labelAnswer.Click += label2_Click;
            // 
            // btnReg
            // 
            btnReg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnReg.Location = new Point(89, 232);
            btnReg.Margin = new Padding(2);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(144, 23);
            btnReg.TabIndex = 3;
            btnReg.Text = "Register as observer";
            btnReg.UseVisualStyleBackColor = true;
            btnReg.Click += btnReg_Click;
            // 
            // btnDereg
            // 
            btnDereg.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnDereg.Location = new Point(89, 259);
            btnDereg.Margin = new Padding(2);
            btnDereg.Name = "btnDereg";
            btnDereg.Size = new Size(144, 23);
            btnDereg.TabIndex = 3;
            btnDereg.Text = "De-register as observer";
            btnDereg.UseVisualStyleBackColor = true;
            btnDereg.Click += btnDereg_Click;
            // 
            // ForecastDisplay
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 321);
            Controls.Add(btnDereg);
            Controls.Add(btnReg);
            Controls.Add(labelAnswer);
            Controls.Add(label1);
            Controls.Add(labForecast);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "ForecastDisplay";
            Text = "ForecastDisplay";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labForecast;
        private Label label1;
        private Label labelAnswer;
        private Button btnReg;
        private Button btnDereg;
    }
}