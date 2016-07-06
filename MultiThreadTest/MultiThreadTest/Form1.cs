using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace MultiThreadTest
{
    public partial class Form1 : Form
    {
        int secondsPassed = 0; //Represents the time being kept.
        int mainSum = 0; //Represents the sum of main points.
        int secondsLeft = 5; //Represents how many more seconds the thread will sleep.
        bool secondThreadRunning = false; //Represents whether the second thread is running.
        bool timeIncrementing = false;

        public Form1()
        {
            InitializeComponent();
            Thread timeThread = new Thread(updateTime);
            timeThread.Start();
        }

        //Runs a 5 second countdown in childThread.
        public void secondThreadCall()
        {
            //Set running flag to true.
            secondThreadRunning = true;

            //Pause the thread for 5 seconds.
            for(int i = 0; i < 5; i ++)
            {
                secondThreadLabel.Invoke((MethodInvoker)delegate { secondThreadLabel.Text = "Child Thread Time Remaining: " + secondsLeft + ".";});
                Thread.Sleep(1000);
                secondsLeft--;
            }
            secondThreadLabel.Invoke((MethodInvoker)delegate { secondThreadLabel.Text = "Child Thread Ready."; });

            //Reset secondsLeft to default.
            secondsLeft = 5;

            //Set running flag to false.
            secondThreadRunning = false;
        }

        //Updates the timeLabel.Text.
        public void updateTime()
        {
            while(true)
            {
                Thread.Sleep(100);
                timeIncrementing = true;
                secondsPassed++;
                timeLabel.Invoke((MethodInvoker) delegate { timeLabel.Text = "Time Passed: " + secondsPassed; });
                timeIncrementing = false;
            }
        }

        //Creates and runs childThread.
        private void runThreadButton_Click(object sender, EventArgs e)
        {
            if(secondThreadRunning == false)
            {
                Thread childThread = new Thread(secondThreadCall);
                childThread.Start();
            }
        }

        //Updates the mainThreadLabel.Text.
        private void mainThreadButton_Click(object sender, EventArgs e)
        {
            if((secondsPassed % 10) == 0 && secondsLeft == 1)
            {
                mainSum++;
                mainThreadLabel.Text = "Successful Passes: " + mainSum.ToString();
            }
        }
    }
}
