using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PID_Control_Playground
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool formIsLoading;
        private void Form1_Load(object sender, EventArgs e)
        {
            formIsLoading = true;
            chart1.ChartAreas[0].AxisX.Title = "Cycles";
            chart1.ChartAreas[0].AxisY.Title = "Amplitude";

            updateFormFromSettings();
            formIsLoading = false;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(formIsLoading)
            {
                return;
            }
            runSimulation();
        }
        private void numericUpDownGeneralSetting_valueChanged(object sender, EventArgs e)
        {
            if (formIsLoading)
            {
                return;
            }
            updateSettingsFromFormAndSave();
        }
        private void numericUpDownPIDConstant_valueChanged(object sender, EventArgs e)
        {
            if (formIsLoading)
            {
                return;
            }
            runSimulation();
        }
        private void updateFormFromSettings()
        {
            numericUpDownMaxInputRate.Value = Properties.Settings.Default.maxInputFlowRate;
            numericUpDownBeginningInputFlowRate.Value = Properties.Settings.Default.beginningInputFlowRate;
            numericUpDownConstantOutputFlowRate.Value = Properties.Settings.Default.outputFlowRate;
            numericUpDownBeginningTankLevel.Value = Properties.Settings.Default.beginingTankLevel;
            numericUpDownSetPoint.Value = Properties.Settings.Default.setPointLevel;
            numericUpDownProportionalConstant.Value = Properties.Settings.Default.proportionalConstant;
            numericUpDownIntegralConstant.Value = Properties.Settings.Default.integralConstant;
            numericUpDownDerivativeConstant.Value = Properties.Settings.Default.derivativeConstant;
            numericUpDownTankMaximum.Value = Properties.Settings.Default.tankMaximumConstant;
            numericUpDownCyclesToSimulate.Value = Properties.Settings.Default.cyclesToSimulate;
            numericUpDownCyclesBetweenInputFlowRateUpdate.Value = Properties.Settings.Default.cyclesBetweenInputFlowRateUpdate;

            string[] itemsToGraph = Properties.Settings.Default.itemsToGraph.Split(',');
            for (int i = 0; i < checkedListBoxItemsToGraph.Items.Count; i++)
            {
                string item = checkedListBoxItemsToGraph.Items[i].ToString();
                if (itemsToGraph.Contains(item))
                {
                    checkedListBoxItemsToGraph.SetItemCheckState(i, CheckState.Checked);
                    continue;
                }
                checkedListBoxItemsToGraph.SetItemCheckState(i, CheckState.Unchecked);
            }
        }
        private void updateSettingsFromFormAndSave()
        {
            Properties.Settings.Default.maxInputFlowRate = numericUpDownMaxInputRate.Value; 
            Properties.Settings.Default.beginningInputFlowRate = numericUpDownBeginningInputFlowRate.Value; 
            Properties.Settings.Default.outputFlowRate = numericUpDownConstantOutputFlowRate.Value; 
            Properties.Settings.Default.beginingTankLevel = numericUpDownBeginningTankLevel.Value; 
            Properties.Settings.Default.setPointLevel = numericUpDownSetPoint.Value; 
            Properties.Settings.Default.proportionalConstant = numericUpDownProportionalConstant.Value; 
            Properties.Settings.Default.integralConstant = numericUpDownIntegralConstant.Value; 
            Properties.Settings.Default.derivativeConstant = numericUpDownDerivativeConstant.Value; 
            Properties.Settings.Default.tankMaximumConstant = numericUpDownTankMaximum.Value; 
            Properties.Settings.Default.cyclesToSimulate = numericUpDownCyclesToSimulate.Value; 
            Properties.Settings.Default.cyclesBetweenInputFlowRateUpdate = numericUpDownCyclesBetweenInputFlowRateUpdate.Value;

            Properties.Settings.Default.Save();


            string itemsToGraph = "";
            for (int i = 0; i < checkedListBoxItemsToGraph.CheckedItems.Count; i++)
            {
                itemsToGraph += checkedListBoxItemsToGraph.CheckedItems[i] + ",";
            }
            itemsToGraph = itemsToGraph.TrimEnd(',');
            Properties.Settings.Default.itemsToGraph = itemsToGraph;

            Properties.Settings.Default.Save();
        }
        public class TrackedValues
        {
            public List<double> setPoints = new List<double>();
            public List<double> outputFlowRates = new List<double>();
            public List<double> currentTankLevels = new List<double>();
            public List<double> errors = new List<double>();
            public List<double> inputFlowRates = new List<double>();
            public List<double> proportionalResponsePoints = new List<double>();
            public List<double> integralResponsePoints = new List<double>();
            public List<double> derivativeResponsePoints = new List<double>();
        }
        public TrackedValues trackedValues;
        private void runSimulation()
        {
            updateSettingsFromFormAndSave();
            chart1.Series.Clear();
            List<System.Windows.Forms.DataVisualization.Charting.Series> chartSeries = intializeSimulationChartSeries();

            double maxInputFlowRate = (double)numericUpDownMaxInputRate.Value;
            double inputFlowRate = (double)numericUpDownBeginningInputFlowRate.Value;
            double outputFlowRate = (double)numericUpDownConstantOutputFlowRate.Value;
            double currentTankLevel = (double)numericUpDownBeginningTankLevel.Value;
            double setPointLevel = (double)numericUpDownSetPoint.Value;
            double ProportionalConstant = (double)numericUpDownProportionalConstant.Value;
            double IntegralConstant = (double)numericUpDownIntegralConstant.Value;
            double derivitiveConstant = (double)numericUpDownDerivativeConstant.Value;
            double tankMaximumConstant = (double)numericUpDownTankMaximum.Value;
            double cyclesToSimulate = (double)numericUpDownCyclesToSimulate.Value;
            double cyclesBetweenInputFlowRateUpdate = (double)numericUpDownCyclesBetweenInputFlowRateUpdate.Value;

            // Wipe public class trackedValues and add initial values
            trackedValues = new TrackedValues();

            // initialize variables used for feedback calculation
            double errorSum = trackedValues.errors.Sum();
            double errorSlope = 0;
            double proportionalResponse = 0;
            double integralResponse = 0;
            double derivativeResponse = 0;

            int cyclesBetweenInputFlowRateUpdateCounter = 0;
            for (int i = 0; i < cyclesToSimulate; i++)
            {
                cyclesBetweenInputFlowRateUpdateCounter++;
                currentTankLevel += inputFlowRate - outputFlowRate;
                // clamp between 0 and tank maximum setting
                if (currentTankLevel < 0)
                {
                    currentTankLevel = 0;
                }
                else if (currentTankLevel > tankMaximumConstant)
                {
                    currentTankLevel = tankMaximumConstant;
                }

                // record all items current values
                trackedValues.setPoints.Add(setPointLevel);
                trackedValues.currentTankLevels.Add(currentTankLevel);
                trackedValues.inputFlowRates.Add(inputFlowRate);
                trackedValues.outputFlowRates.Add(outputFlowRate);
                trackedValues.errors.Add(setPointLevel - currentTankLevel);
                trackedValues.proportionalResponsePoints.Add(proportionalResponse);
                trackedValues.integralResponsePoints.Add(integralResponse);
                trackedValues.derivativeResponsePoints.Add(derivativeResponse);

                // chart desired series
                chartDesiredValues(chartSeries);

                errorSum = trackedValues.errors.Sum(); // used for integral calculation
                double currentError = trackedValues.errors[trackedValues.errors.Count() - 1]; // pulls current error from where it is saved
                if (i != 0)
                {
                    double lastError = trackedValues.errors[trackedValues.errors.Count() - 2];
                    errorSlope = currentError - lastError; // instant slope used  for derivitave calculation
                }
                // update inflow rate based on PID every x loop
                if (cyclesBetweenInputFlowRateUpdateCounter > cyclesBetweenInputFlowRateUpdate)
                {
                    cyclesBetweenInputFlowRateUpdateCounter = 0;

                    // calculates responses based on relevant contants
                    // In this case error is measured based on current value - setpoint
                    proportionalResponse = ProportionalConstant * currentError;
                    integralResponse = IntegralConstant * errorSum;
                    derivativeResponse = derivitiveConstant * errorSlope;

                    inputFlowRate = proportionalResponse + integralResponse + derivativeResponse; 

                    // ensure input flow rate can not be less than 0 or greater than maximum possible
                    if (inputFlowRate < 0)
                    {
                        inputFlowRate = 0;
                    }
                    if (inputFlowRate > maxInputFlowRate)
                    { 
                        inputFlowRate = maxInputFlowRate;
                    }
                }
            }

        }

        private List<System.Windows.Forms.DataVisualization.Charting.Series> intializeSimulationChartSeries()
        {
            List<System.Windows.Forms.DataVisualization.Charting.Series> chartSeriesToReturn = new List<System.Windows.Forms.DataVisualization.Charting.Series>();

            foreach(string checkedItem in checkedListBoxItemsToGraph.CheckedItems)
            {
                System.Windows.Forms.DataVisualization.Charting.Series chartSeries = chart1.Series.Add(checkedItem);
                chartSeries.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                chartSeries.BorderWidth = 3;
                chartSeriesToReturn.Add(chartSeries);
            }
            chart1.ChartAreas[0].AxisX.Title = "Cycles";
            chart1.ChartAreas[0].AxisY.Title = "Amplitude";

            return chartSeriesToReturn;
        }
        Color[] seriesColors = { 
            Color.FromArgb(31,119,180),     // Blue
            Color.FromArgb(255,127,14),     // Orange
            Color.FromArgb(44,160,44),      // Green
            Color.FromArgb(214,39,40),      // Red
            Color.FromArgb(148,103,189),    // Purple
            Color.FromArgb(140,86,75),      // Brown
            Color.FromArgb(227,119,194),    // Pink
            Color.FromArgb(127,127,127)     // Gray
        };
        private void chartDesiredValues(List<System.Windows.Forms.DataVisualization.Charting.Series> chartSeries)
        {
            int itemNumber = trackedValues.errors.Count() - 1;
            if(itemNumber == -1)
            {
                return;
            }
            foreach(Series series in chartSeries)
            {
                string name = series.Name;
                switch(name)
                {
                    case "Set Point":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.setPoints[itemNumber]);
                            series.Color = seriesColors[0];
                            break;
                        }
                    case "Current Level":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.currentTankLevels[itemNumber]);
                            series.Color = seriesColors[1];
                            break;
                        }
                    case "Input Flow Rate":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.inputFlowRates[itemNumber]);
                            series.Color = seriesColors[2];
                            break;
                        }
                    case "Output Flow Rate":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.outputFlowRates[itemNumber]);
                            series.Color = seriesColors[3];
                            break;
                        }
                    case "Error":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.errors[itemNumber]);
                            series.Color = seriesColors[4];
                            break;
                        }
                    case "Proportional Response":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.proportionalResponsePoints[itemNumber]);
                            series.Color = seriesColors[5];
                            break;
                        }
                    case "Integral Response":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.integralResponsePoints[itemNumber]);
                            series.Color = seriesColors[6];
                            break;
                        }
                    case "Derivative Response":
                        {
                            series.Points.AddXY(itemNumber + 1, trackedValues.derivativeResponsePoints[itemNumber]);
                            series.Color = seriesColors[7];
                            break;
                        }                     
                }
            }
        }


    }
}
