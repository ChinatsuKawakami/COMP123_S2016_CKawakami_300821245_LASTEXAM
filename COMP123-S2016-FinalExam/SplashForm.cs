﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2016_FinalExam
{

    /**
     * Description: this is program to display CustomerData
     * Author: Chinatsu Kawakami
     * StudentID: 300821245
     * version 0.0.2 - Created GeneratedNameForm and added GenerateName method and Added comment
     * *
     */
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }

        private void SplashFormTimer_Tick(object sender, EventArgs e)
        {
          
            //create Next form 
            GenerateNameForm generate = new GenerateNameForm();
            generate.Show();
            this.Hide();
        }


    }
}
