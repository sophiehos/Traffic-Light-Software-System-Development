using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;


namespace Sophie
{
    public partial class Form1 : Form
    {

        int i = 0;
        TrafficLight North = new TrafficLight("North");
        TrafficLight South = new TrafficLight("South");
        TrafficLight West = new TrafficLight("West");
        TrafficLight East = new TrafficLight("East");
        public Form1()
        {
            InitializeComponent();
            North.isGreen = false;
            South.isGreen = false;
            West.isGreen = true;
            East.isGreen = true;

            updateLight(North);
            updateLight(South);
            updateLight(East);
            updateLight(West);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            i++;
            if (i == 1)
            {
                //Init
                North.isGreen = false;
                South.isGreen = false;
                West.isGreen = true;
                East.isGreen = true;

                //Step 4
                PrintConfiguration(North, South, East, West);
                North.isGreen = false;
                South.isGreen = false;
                West.isGreen = false;
                East.isGreen = false;
                updateLight(North);
                updateLight(South);
                updateLight(East);
                updateLight(West);
            }
            else if (i == 2)
            {
                //Step 5
                North.isGreen = false;
                South.isGreen = false;
                West.isGreen = false;
                East.isGreen = false;
                updateLight(North);
                updateLight(South);
                updateLight(East);
                updateLight(West);

                //Step 6 
                PrintConfiguration(North, South, East, West);
            }
            else if (i == 3)
            {
                //Step 7
                North.isGreen = true;
                updateLight(North);
                updateLight(South);
                updateLight(East);
                updateLight(West);


                //Step 8
                PrintConfiguration(North, South, East, West);
            }

            else if (i == 4)
            {
                //Step 9
                South.isGreen = true;
                updateLight(South);

                //Step 10
                PrintConfiguration(North, South, East, West);
            }

            else if (i == 5)
            {
                //Step 11
                North.isGreen = false;
                South.isGreen = false;
                updateLight(North);
                updateLight(South);

                //Step 12
                PrintConfiguration(North, South, East, West);
            }

            else if (i == 6)
            {
                //Step 13
                East.isGreen = true;
                updateLight(East);

                //Step 14
                PrintConfiguration(North, South, East, West);
            }

            else if (i == 7)
            {
                //Step 15
                West.isGreen = true;
                updateLight(West);

                //Step 16
                PrintConfiguration(North, South, East, West);
            }

            else if (i == 8)
            {
                //Step 17
                East.isGreen = false;
                West.isGreen = false;
                updateLight(East);
                updateLight(West);

                //Step 18
                PrintConfiguration(North, South, East, West);
            }

        }


        private void updateLight(TrafficLight light)
        {
            switch (light.Name)
            {
                case "North":
                    GreenNorth.Visible = light.isGreen;
                    RedNorth.Visible = !light.isGreen;
                    break;
                case "South":
                    GreenSouth.Visible = light.isGreen;
                    RedSouth.Visible = !light.isGreen;
                    break;
                case "East":
                    GreenEast.Visible = light.isGreen;
                    RedEast.Visible = !light.isGreen;
                    break;
                case "West":
                    GreenWest.Visible = light.isGreen;
                    RedWest.Visible = !light.isGreen;
                    break;
                default:
                    break;
            }
        }


        private void PrintConfiguration(TrafficLight north, TrafficLight south, TrafficLight east, TrafficLight west)
        {
            if (north.isGreen)
            {
                Console.WriteLine("North is green");
            }
            else
            {
                Console.WriteLine("North is red");
            }

            if (south.isGreen)
            {
                Console.WriteLine("South is green");
            }
            else
            {
                Console.WriteLine("South is red");
            }

            if (east.isGreen)
            {
                Console.WriteLine("East is green");
            }
            else
            {
                Console.WriteLine("East is red");
            }

            if (west.isGreen)
            {
                Console.WriteLine("West is green");
            }
            else
            {
                Console.WriteLine("West is red");
            }


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedNorth_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void RedEast_Click(object sender, EventArgs e)
        {

        }
    }
}


