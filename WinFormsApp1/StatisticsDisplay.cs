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
    public partial class StatisticsDisplay : Form, IObserver, IDisplayElement
    {
        private ISubject _subject;
        private float _temp;
        private float _avgTemp;
        private int _readings;
        private float _sumOfReadings;
        private float _minTemp = 1000F;
        private float _maxTemp = -1000F;
        public StatisticsDisplay(ISubject s)
        {
            InitializeComponent();
            _subject = s;
        }

        public void Display()
        {
            labAvgTemp.Text = _avgTemp.ToString();
            labMinTemp.Text = _minTemp.ToString();
            labMaxTemp.Text = _maxTemp.ToString();
        }

        public void Update(float temp, float humidity, int pressure)
        {
            _temp = temp;
            _readings++;
            _sumOfReadings += temp;
            _avgTemp = _sumOfReadings / (float)_readings;

            if (temp < _minTemp)
            {
                _minTemp = temp;
            }

            if (temp > _maxTemp)
            {
                _maxTemp = temp;
            }

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
    }
}
