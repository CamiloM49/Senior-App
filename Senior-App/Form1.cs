﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Presentation;

namespace Senior_App
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
            



        }

        FilterInfoCollection FilterInfoCollection;
        VideoCaptureDevice captureDevice;



        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FilterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in FilterInfoCollection)
                cboCamara.Items.Add(filterInfo.Name);
            cboCamara.SelectedIndex = 0; 
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Realmente quieres salir de la aplicación?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {

            }


        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {

        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel4_Click(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            captureDevice = new VideoCaptureDevice(FilterInfoCollection[cboCamara.SelectedIndex].MonikerString);
            captureDevice.NewFrame += CaptureDevide_NewFrame;
            captureDevice.Start();
            timer1.Start(); 

        }

        private void CaptureDevide_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            
            pictureBox2.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
                
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBox2.Image!= null)
            {


                ZXing.BarcodeReader barcodeReader = new ZXing.BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox2.Image); 
                if(result != null)
                {
                    txtQR.Text = result.ToString();
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                        captureDevice.Stop();
                }
            }
        }

        private void materialRaisedButton2_Click(object sender, EventArgs e)
        {
            if (txtQR.TextLength >= 4)
            {
                materialRaisedButton2.IsAccessible = false; 
            }
        }
    }
}
