using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class ForecastDisplay : Form, IObserver, IDisplayElement
    {
        private ISubject _subject;
        private int _pressure;
        public ForecastDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        public void Display()
        {
            if (_pressure < 1000)
            {
                labelAnswer.Text = "Rain";
            }
            else
            {
                labelAnswer.Text = "Sunshine";
            }
        }

        public void Update(float temp, float humidity, int pressure)
        {
            _pressure = pressure;
            Display();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnDereg_Click(object sender, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
