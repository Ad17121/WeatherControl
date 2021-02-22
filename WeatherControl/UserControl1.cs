using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WeatherControl
{
    public partial class WindControl : UserControl
    {


        Pen black = new Pen(Color.Black);
        Pen red = new Pen(Color.Red);

        // Properties
        private int _degrees;
        private string _title;
        private int _temperature;
        private int _windSpeed;
        private Image _weatherImage;
        private string _weather;
        private int _feelsLike;
        private int _dewPoint;
        private int _pressure;
        private int _clouds;
        private int _max;
        private int _min;
        private string _sunset;
        private string _sunrise;

        // Local variable
        private bool isExpanded = false;


        [Description("Degress to move hand"), Category("Data")]
        public int Degrees
        {
            get { return _degrees; }
            set { _degrees = value; pictureBoxWind.Refresh(); }
        }

        [Description("Title"), Category("Data")]
        public string Title
        {
            get { return _title; }
            set { _title = value; lblDay.Text = _title; }
        }

        [Description("Image to display"), Category("Data")]
        public Image WeatherImage
        {
            get { return _weatherImage; }
            set { _weatherImage = value; pnlWeather.BackgroundImage = _weatherImage; }
        }

        [Description("Temperature to display"), Category("Data")]
        public int Temperature
        {
            get { return _temperature; }
            set { _temperature = value; lblTemperature.Text = string.Format("{0}°C", _temperature); }
        }

        [Description("Wind Speed"), Category("Data")]
        public int WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; lblWindSpeed.Text = string.Format("{0}mph", _windSpeed); }
        }

        [Description("Weather"), Category("Data")]
        public string Weather
        {
            get { return _weather; }
            set { _weather = value; updateExtraText(0, "Weather: "+_weather); }
        }

        [Description("Feels like temperature"), Category("Data")]
        public int FeelsLike
        {
            get { return _feelsLike; }
            set { _feelsLike = value; updateExtraText(1, string.Format("Feels Like: {0}°C", _feelsLike)); }
        }

        [Description("Dew point temp"), Category("Data")]
        public int DewPoint
        {
            get { return _dewPoint; }
            set { _dewPoint = value; updateExtraText(2, string.Format("Dew Point: {0}°C", _dewPoint)); }
        }

        [Description("Pressure"), Category("Data")]
        public int Pressure
        {
            get { return _pressure; }
            set { _pressure = value; updateExtraText(3, string.Format("Pressure: {0}hPa", _pressure)); }
        }

        [Description("Cloud coverage (percentage)")]
        public int Clouds
        {
            get { return _clouds; }
            set { _clouds = value; updateExtraText(4, string.Format("Clouds: {0}%", _clouds)); }
        }

        [Description("Minimum Temperature"), Category("Data")]
        public int MaxTemp
        {
            get { return _max; }
            set { _max = value; updateExtraText(5, string.Format("Max: {0}°C", _max)); }
        }

        [Description("Miniumum Temperature"), Category("Data")]
        public int MinTemp
        {
            get { return _min; }
            set { _min = value; updateExtraText(6, string.Format("Min: {0}°C", _min)); }
        }

        [Description("Dew point temp"), Category("Data")]
        public string Sunrise
        {
            get { return _sunrise; }
            set { _sunrise = value; updateExtraText(7, string.Format("Sunrise: {0}", _sunrise)); }
        }

        [Description("Dew point temp"), Category("Data")]
        public string Sunset
        {
            get { return _sunset; }
            set { _sunset = value; updateExtraText(8,string.Format("Sunset: {0}", _sunset)); }
        }

        public void updateExtraText(int line, string text)
        {
            var tempArray = (string[])txtExtra.Lines.Clone();
            tempArray[line] = text;
            txtExtra.Lines = tempArray;
        }

        public WindControl()
        {
            InitializeComponent();
            txtExtra.Enabled = false;
            txtExtra.BackColor = Color.White;
        }

        private void UserControl1_Degrees_changed(object sender, EventArgs e)
        {
            pictureBoxWind.Refresh();
        }

        private void pictureBoxWind_Paint(object sender, PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics g = e.Graphics;
            drawFace(g, pictureBoxWind.Width / 2, pictureBoxWind.Width / 2, pictureBoxWind.Height / 2);
            drawRotated(g, pictureBoxWind.Width / 2, _degrees, pictureBoxWind.Width / 2, pictureBoxWind.Height / 2);
        }

        private void drawFace(Graphics g, int length, int centreX, int centreY)
        {
            int indicatorLength = 8;
            g.DrawEllipse(black, new Rectangle(0, 0, length * 2 - 1, length * 2 - 1));
            g.DrawLine(black, centreX - length, centreY, centreX - length + indicatorLength, centreY);
            g.DrawLine(black, centreX + length, centreY, centreX + length - indicatorLength, centreY);
            g.DrawLine(black, centreX, centreY + length, centreX, centreY + length - indicatorLength);
            g.DrawLine(black, centreX, centreY - length, centreX, centreY - length + indicatorLength);
            g.DrawLine(black, centreX + (float)(length * Math.Cos(45 * Math.PI / 180)), centreY + (float)(length * Math.Sin(45 * Math.PI / 180)), centreX + (float)(length * Math.Cos(45 * Math.PI / 180)) - 3, centreY + (float)(length * Math.Sin(45 * Math.PI / 180)) - 3);
            g.DrawLine(black, centreX + (float)(length * Math.Cos(45 * Math.PI / 180)), centreY - (float)(length * Math.Sin(45 * Math.PI / 180)), centreX + (float)(length * Math.Cos(45 * Math.PI / 180)) - 3, centreY - (float)(length * Math.Sin(45 * Math.PI / 180)) + 3);
            g.DrawLine(black, centreX - (float)(length * Math.Cos(45 * Math.PI / 180)), centreY - (float)(length * Math.Sin(45 * Math.PI / 180)), centreX - (float)(length * Math.Cos(45 * Math.PI / 180)) + 3, centreY - (float)(length * Math.Sin(45 * Math.PI / 180)) + 3);
            g.DrawLine(black, centreX - (float)(length * Math.Cos(45 * Math.PI / 180)), centreY + (float)(length * Math.Sin(45 * Math.PI / 180)), centreX - (float)(length * Math.Cos(45 * Math.PI / 180)) + 3, centreY + (float)(length * Math.Sin(45 * Math.PI / 180)) - 3);

        }

        private void drawRotated(Graphics g, int length, double angle, int centreX, int centreY)
        {
            angle = -angle;
            int x = 0;
            int y = length;
            double newX = x * Math.Cos(angle * Math.PI / 180) - y * Math.Sin(angle * Math.PI / 180);
            double newY = x * Math.Sin(angle * Math.PI / 180) - y * Math.Cos(angle * Math.PI / 180);
            g.DrawLine(red, centreX, centreY, (float)newX + centreX, (float)newY + centreY);
        }

        private void WindControl_OnCLick(object sender, EventArgs e)
        {

            this.isExpanded = !this.isExpanded;
            if (this.isExpanded)
            {
                // Extra infro is open
                this.Width = 200;

            }
            else
            {
                // Extra info is closed
                this.Width = 56;

            }
        }

        private void WindControl_Load(object sender, EventArgs e)
        {

        }
    }
}
