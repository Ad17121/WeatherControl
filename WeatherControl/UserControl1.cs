using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WeatherControl
{
    public partial class WindControl: UserControl
    {
        

        Pen black = new Pen(Color.Black);
        Pen red = new Pen(Color.Red);

        private int _degrees;
        private string _title;
        private int _temperature;
        private int _windSpeed;
        private Image _weatherImage;      

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
            get { return _temperature;  }
            set { _temperature = value; lblTemperature.Text = string.Format("{0}°C",_temperature); }
        }

        [Description("Wind Speed"), Category("Data")]
        public int WindSpeed
        {
            get { return _windSpeed; }
            set { _windSpeed = value; lblWindSpeed.Text = string.Format("{0}mph", _windSpeed); }
        }

        public WindControl()
        {
            InitializeComponent();
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
    }
}
