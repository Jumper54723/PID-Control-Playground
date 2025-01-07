using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PID_Control_Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            chart1.Series.Clear();
            System.Windows.Forms.DataVisualization.Charting.Series setPointSeries = chart1.Series.Add("Set Point");
            System.Windows.Forms.DataVisualization.Charting.Series currentValue = chart1.Series.Add("Current Value");
            setPointSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            currentValue.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            setPointSeries.BorderWidth = 7;
            currentValue.BorderWidth = 3;

            double outputFlowRate = 2;
            double inputFlowRate = 0;
            double currentTankLevel = 100;
            double setPointLevel = 100;
            const double ProportionalConstant = 0.2;
            const double IntegralConstant = 0.0005;
            const double derivitiveConstant = 0.1;

            //Random random = new Random();
            //currentValue.Points.AddXY(i, 10 + random.Next(-1, 2));

            List<double> errorPoints = new List<double>();
            errorPoints.Add(0); // add first point of no error
            double errorSum = 0;
            double errorSlope;
            for (int i = 1; i < 1500; i++)
            {
                if(i == 400)
                {
                    setPointLevel = 20;
                }
                if (i == 800)
                {
                    setPointLevel = 170;
                }
                setPointSeries.Points.AddXY(i, setPointLevel);
                currentTankLevel += inputFlowRate - outputFlowRate;
                // clamp between 0 and 200
                if(currentTankLevel < 0)
                {
                    currentTankLevel = 0;
                }
                else if(currentTankLevel > 200)
                {
                    currentTankLevel = 200;
                }
                currentValue.Points.AddXY(i, currentTankLevel);
                errorPoints.Add(currentTankLevel - setPointLevel);
                errorSum += errorPoints[i];
                errorSlope = errorPoints[i - 1] - errorPoints[i];

                // update inflow rate based on PID every 10th loop
                if (i % 10 == 0)
                {
                    // input flow rate = ProprtionalResponse + IntegralResponse + DerivitiveResponse
                    inputFlowRate = -1*ProportionalConstant * errorPoints[i] - IntegralConstant*errorSum - derivitiveConstant*errorSlope; // proportional constant multiplied by current error
                    
                    // ensure input flow rate can not be less than 0 (we can't start sucking water out of the tower)
                    if(inputFlowRate < 0)
                    {
                        inputFlowRate = 0;
                    }
                }
            }

        }
    }
}
