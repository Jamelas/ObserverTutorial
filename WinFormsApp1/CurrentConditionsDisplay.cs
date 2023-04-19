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
    public partial class CurrentConditionsDisplay : Form, IObserver, IDisplayElement
    {
        private ISubject _subject;
        private float _temp;
        private float _humidity;
        private int _pressure;

        public CurrentConditionsDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        public void Display()
        {
            labTemp.Text = _temp.ToString();
            labHumidity.Text = _humidity.ToString();
            labPressure.Text = _pressure.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            _temp = temp;
            _humidity = humidity;
            _pressure = pressure;
            Display();
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            _subject.RegisterObserver(this);
        }

        private void btnDereg_Click(object obj, EventArgs e)
        {
            _subject.RemoveObserver(this);
        }
    }
}
