﻿namespace WeatherControl
{
    partial class WindControl
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindControl));
            this.pictureBoxWind = new System.Windows.Forms.PictureBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.pnlWeather = new System.Windows.Forms.Panel();
            this.lblWindSpeed = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxWind
            // 
            this.pictureBoxWind.Location = new System.Drawing.Point(3, 118);
            this.pictureBoxWind.Name = "pictureBoxWind";
            this.pictureBoxWind.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxWind.TabIndex = 0;
            this.pictureBoxWind.TabStop = false;
            this.pictureBoxWind.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxWind_Paint);
            // 
            // lblDay
            // 
            this.lblDay.Font = new System.Drawing.Font("Arial Black", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDay.Location = new System.Drawing.Point(0, 0);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(56, 23);
            this.lblDay.TabIndex = 0;
            this.lblDay.Text = "17:00";
            this.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTemperature
            // 
            this.lblTemperature.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTemperature.Location = new System.Drawing.Point(-1, 79);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(56, 23);
            this.lblTemperature.TabIndex = 1;
            this.lblTemperature.Text = "13°C";
            this.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlWeather
            // 
            this.pnlWeather.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlWeather.BackgroundImage")));
            this.pnlWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlWeather.Location = new System.Drawing.Point(3, 26);
            this.pnlWeather.Name = "pnlWeather";
            this.pnlWeather.Size = new System.Drawing.Size(50, 50);
            this.pnlWeather.TabIndex = 2;
            // 
            // lblWindSpeed
            // 
            this.lblWindSpeed.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWindSpeed.Location = new System.Drawing.Point(0, 171);
            this.lblWindSpeed.Name = "lblWindSpeed";
            this.lblWindSpeed.Size = new System.Drawing.Size(56, 23);
            this.lblWindSpeed.TabIndex = 3;
            this.lblWindSpeed.Text = "10mph";
            this.lblWindSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WindControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.lblWindSpeed);
            this.Controls.Add(this.pnlWeather);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.pictureBoxWind);
            this.Name = "WindControl";
            this.Size = new System.Drawing.Size(56, 200);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWind)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxWind;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblTemperature;
        private System.Windows.Forms.Panel pnlWeather;
        private System.Windows.Forms.Label lblWindSpeed;
    }
}