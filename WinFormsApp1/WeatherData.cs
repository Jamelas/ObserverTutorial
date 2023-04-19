namespace WinFormsApp1
{
    public partial class WeatherData : Form, ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        private float _temp;
        private float _humidity;
        private int _pressure;
        public WeatherData()
        {
            InitializeComponent();
            CurrentConditionsDisplay ccd = new CurrentConditionsDisplay(this);
            ccd.Show();
            ForecastDisplay fd = new ForecastDisplay(this);
            fd.Show();
            StatisticsDisplay sd = new StatisticsDisplay(this);
            sd.Show();
        }

        public void NotifyObservers()
        {
            foreach (IObserver o in _observers)
            {
                o.Update(_temp, _humidity, _pressure);
            }
        }

        public void RegisterObserver(IObserver o)
        {
            if (!_observers.Contains(o))
            {
                _observers.Add(o);
            }
        }

        public void RemoveObserver(IObserver o)
        {
            _observers.Remove(o);
        }

        private void textBoxTemp_Leave(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        private void textBoxHumidity_Leave(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        private void textBoxPressure_Leave(object sender, EventArgs e)
        {
            MeasurementsChanged();
        }

        private void MeasurementsChanged()
        {
            float.TryParse(textBoxTemp.Text, out _temp);
            float.TryParse(textBoxHumidity.Text, out _humidity);
            Int32.TryParse(textBoxPressure.Text, out _pressure);

            NotifyObservers();
        }
    }
}