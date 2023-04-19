namespace WinFormsApp1
{
    partial class WeatherData
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxTemp = new TextBox();
            textBoxHumidity = new TextBox();
            textBoxPressure = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(132, 41);
            label1.Name = "label1";
            label1.Size = new Size(146, 30);
            label1.TabIndex = 0;
            label1.Text = "Weather Data";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(73, 116);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 1;
            label2.Text = "Temp:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(73, 167);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 1;
            label3.Text = "Humidity:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(73, 213);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 1;
            label4.Text = "Pressure:";
            // 
            // textBoxTemp
            // 
            textBoxTemp.Location = new Point(178, 113);
            textBoxTemp.Name = "textBoxTemp";
            textBoxTemp.Size = new Size(100, 23);
            textBoxTemp.TabIndex = 2;
            textBoxTemp.Leave += textBoxTemp_Leave;
            // 
            // textBoxHumidity
            // 
            textBoxHumidity.Location = new Point(178, 164);
            textBoxHumidity.Name = "textBoxHumidity";
            textBoxHumidity.Size = new Size(100, 23);
            textBoxHumidity.TabIndex = 2;
            textBoxHumidity.TextChanged += textBoxHumidity_Leave;
            // 
            // textBoxPressure
            // 
            textBoxPressure.Location = new Point(178, 210);
            textBoxPressure.Name = "textBoxPressure";
            textBoxPressure.Size = new Size(100, 23);
            textBoxPressure.TabIndex = 2;
            textBoxPressure.TextChanged += textBoxPressure_Leave;
            // 
            // WeatherData
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 321);
            Controls.Add(textBoxPressure);
            Controls.Add(textBoxHumidity);
            Controls.Add(textBoxTemp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "WeatherData";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxHumidity;
        private TextBox textBoxPressure;
        private TextBox textBoxTemp;
    }
}