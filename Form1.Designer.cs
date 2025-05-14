namespace PID_Control_Playground
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.startSimulationButton = new System.Windows.Forms.Button();
            this.tabControlSimulation = new System.Windows.Forms.TabControl();
            this.tabPageSimulation = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.numericUpDownDerivativeConstant = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownProportionalConstant = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownIntegralConstant = new System.Windows.Forms.NumericUpDown();
            this.tabPageSettings = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.checkedListBoxItemsToGraph = new System.Windows.Forms.CheckedListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numericUpDownCyclesBetweenInputFlowRateUpdate = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numericUpDownCyclesToSimulate = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericUpDownTankMaximum = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.numericUpDownBeginningTankLevel = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDownSetPoint = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDownBeginningInputFlowRate = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownMaxInputRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownConstantOutputFlowRate = new System.Windows.Forms.NumericUpDown();
            this.tabControlSimulation.SuspendLayout();
            this.tabPageSimulation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDerivativeConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProportionalConstant)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegralConstant)).BeginInit();
            this.tabPageSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyclesBetweenInputFlowRateUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyclesToSimulate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTankMaximum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginningTankLevel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetPoint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginningInputFlowRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInputRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstantOutputFlowRate)).BeginInit();
            this.SuspendLayout();
            // 
            // startSimulationButton
            // 
            this.startSimulationButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startSimulationButton.Location = new System.Drawing.Point(27, 599);
            this.startSimulationButton.Name = "startSimulationButton";
            this.startSimulationButton.Size = new System.Drawing.Size(158, 47);
            this.startSimulationButton.TabIndex = 0;
            this.startSimulationButton.Text = "Start Simulation";
            this.startSimulationButton.UseVisualStyleBackColor = true;
            this.startSimulationButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tabControlSimulation
            // 
            this.tabControlSimulation.Controls.Add(this.tabPageSimulation);
            this.tabControlSimulation.Controls.Add(this.tabPageSettings);
            this.tabControlSimulation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlSimulation.Location = new System.Drawing.Point(23, 12);
            this.tabControlSimulation.Name = "tabControlSimulation";
            this.tabControlSimulation.SelectedIndex = 0;
            this.tabControlSimulation.Size = new System.Drawing.Size(1385, 558);
            this.tabControlSimulation.TabIndex = 8;
            // 
            // tabPageSimulation
            // 
            this.tabPageSimulation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageSimulation.Controls.Add(this.label3);
            this.tabPageSimulation.Controls.Add(this.chart1);
            this.tabPageSimulation.Controls.Add(this.numericUpDownDerivativeConstant);
            this.tabPageSimulation.Controls.Add(this.label1);
            this.tabPageSimulation.Controls.Add(this.label2);
            this.tabPageSimulation.Controls.Add(this.numericUpDownProportionalConstant);
            this.tabPageSimulation.Controls.Add(this.numericUpDownIntegralConstant);
            this.tabPageSimulation.Location = new System.Drawing.Point(4, 29);
            this.tabPageSimulation.Name = "tabPageSimulation";
            this.tabPageSimulation.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSimulation.Size = new System.Drawing.Size(1377, 525);
            this.tabPageSimulation.TabIndex = 0;
            this.tabPageSimulation.Text = "Simulation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "Derivative (D):";
            // 
            // chart1
            // 
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(147, 6);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1205, 503);
            this.chart1.TabIndex = 2;
            this.chart1.Text = "chart1";
            // 
            // numericUpDownDerivativeConstant
            // 
            this.numericUpDownDerivativeConstant.DecimalPlaces = 6;
            this.numericUpDownDerivativeConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownDerivativeConstant.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownDerivativeConstant.Location = new System.Drawing.Point(7, 159);
            this.numericUpDownDerivativeConstant.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownDerivativeConstant.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownDerivativeConstant.Name = "numericUpDownDerivativeConstant";
            this.numericUpDownDerivativeConstant.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownDerivativeConstant.TabIndex = 18;
            this.numericUpDownDerivativeConstant.Value = new decimal(new int[] {
            15,
            0,
            0,
            -2147352576});
            this.numericUpDownDerivativeConstant.ValueChanged += new System.EventHandler(this.numericUpDownPIDConstant_valueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Proportional (P):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Integral (I):";
            // 
            // numericUpDownProportionalConstant
            // 
            this.numericUpDownProportionalConstant.DecimalPlaces = 6;
            this.numericUpDownProportionalConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownProportionalConstant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownProportionalConstant.Location = new System.Drawing.Point(7, 38);
            this.numericUpDownProportionalConstant.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownProportionalConstant.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownProportionalConstant.Name = "numericUpDownProportionalConstant";
            this.numericUpDownProportionalConstant.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownProportionalConstant.TabIndex = 14;
            this.numericUpDownProportionalConstant.Value = new decimal(new int[] {
            7,
            0,
            0,
            131072});
            this.numericUpDownProportionalConstant.ValueChanged += new System.EventHandler(this.numericUpDownPIDConstant_valueChanged);
            // 
            // numericUpDownIntegralConstant
            // 
            this.numericUpDownIntegralConstant.DecimalPlaces = 6;
            this.numericUpDownIntegralConstant.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownIntegralConstant.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownIntegralConstant.Location = new System.Drawing.Point(7, 97);
            this.numericUpDownIntegralConstant.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownIntegralConstant.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownIntegralConstant.Name = "numericUpDownIntegralConstant";
            this.numericUpDownIntegralConstant.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownIntegralConstant.TabIndex = 16;
            this.numericUpDownIntegralConstant.Value = new decimal(new int[] {
            200,
            0,
            0,
            327680});
            this.numericUpDownIntegralConstant.ValueChanged += new System.EventHandler(this.numericUpDownPIDConstant_valueChanged);
            // 
            // tabPageSettings
            // 
            this.tabPageSettings.BackColor = System.Drawing.SystemColors.ControlDark;
            this.tabPageSettings.Controls.Add(this.label12);
            this.tabPageSettings.Controls.Add(this.checkedListBoxItemsToGraph);
            this.tabPageSettings.Controls.Add(this.label11);
            this.tabPageSettings.Controls.Add(this.numericUpDownCyclesBetweenInputFlowRateUpdate);
            this.tabPageSettings.Controls.Add(this.label10);
            this.tabPageSettings.Controls.Add(this.numericUpDownCyclesToSimulate);
            this.tabPageSettings.Controls.Add(this.label9);
            this.tabPageSettings.Controls.Add(this.numericUpDownTankMaximum);
            this.tabPageSettings.Controls.Add(this.label7);
            this.tabPageSettings.Controls.Add(this.numericUpDownBeginningTankLevel);
            this.tabPageSettings.Controls.Add(this.label8);
            this.tabPageSettings.Controls.Add(this.numericUpDownSetPoint);
            this.tabPageSettings.Controls.Add(this.label4);
            this.tabPageSettings.Controls.Add(this.numericUpDownBeginningInputFlowRate);
            this.tabPageSettings.Controls.Add(this.label5);
            this.tabPageSettings.Controls.Add(this.label6);
            this.tabPageSettings.Controls.Add(this.numericUpDownMaxInputRate);
            this.tabPageSettings.Controls.Add(this.numericUpDownConstantOutputFlowRate);
            this.tabPageSettings.Location = new System.Drawing.Point(4, 29);
            this.tabPageSettings.Name = "tabPageSettings";
            this.tabPageSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSettings.Size = new System.Drawing.Size(1377, 525);
            this.tabPageSettings.TabIndex = 1;
            this.tabPageSettings.Text = "Settings";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(533, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(124, 20);
            this.label12.TabIndex = 37;
            this.label12.Text = "Items To Graph:";
            // 
            // checkedListBoxItemsToGraph
            // 
            this.checkedListBoxItemsToGraph.CheckOnClick = true;
            this.checkedListBoxItemsToGraph.FormattingEnabled = true;
            this.checkedListBoxItemsToGraph.Items.AddRange(new object[] {
            "Set Point",
            "Current Level",
            "Input Flow Rate",
            "Output Flow Rate",
            "Error",
            "Proportional Response",
            "Integral Response",
            "Derivative Response"});
            this.checkedListBoxItemsToGraph.Location = new System.Drawing.Point(537, 37);
            this.checkedListBoxItemsToGraph.Name = "checkedListBoxItemsToGraph";
            this.checkedListBoxItemsToGraph.Size = new System.Drawing.Size(191, 214);
            this.checkedListBoxItemsToGraph.TabIndex = 36;
            this.checkedListBoxItemsToGraph.SelectedValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 147);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(210, 20);
            this.label11.TabIndex = 35;
            this.label11.Text = "Cycles Between IFR Update";
            // 
            // numericUpDownCyclesBetweenInputFlowRateUpdate
            // 
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Location = new System.Drawing.Point(96, 170);
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Name = "numericUpDownCyclesBetweenInputFlowRateUpdate";
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.TabIndex = 34;
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCyclesBetweenInputFlowRateUpdate.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(320, 208);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(143, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Cycles to Simulate:";
            // 
            // numericUpDownCyclesToSimulate
            // 
            this.numericUpDownCyclesToSimulate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownCyclesToSimulate.Location = new System.Drawing.Point(343, 230);
            this.numericUpDownCyclesToSimulate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownCyclesToSimulate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownCyclesToSimulate.Name = "numericUpDownCyclesToSimulate";
            this.numericUpDownCyclesToSimulate.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownCyclesToSimulate.TabIndex = 32;
            this.numericUpDownCyclesToSimulate.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.numericUpDownCyclesToSimulate.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(344, 147);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 31;
            this.label9.Text = "Tank Maximum:";
            // 
            // numericUpDownTankMaximum
            // 
            this.numericUpDownTankMaximum.DecimalPlaces = 6;
            this.numericUpDownTankMaximum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownTankMaximum.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownTankMaximum.Location = new System.Drawing.Point(343, 170);
            this.numericUpDownTankMaximum.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownTankMaximum.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownTankMaximum.Name = "numericUpDownTankMaximum";
            this.numericUpDownTankMaximum.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownTankMaximum.TabIndex = 30;
            this.numericUpDownTankMaximum.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericUpDownTankMaximum.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(299, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Beginning Tank Level:";
            // 
            // numericUpDownBeginningTankLevel
            // 
            this.numericUpDownBeginningTankLevel.DecimalPlaces = 6;
            this.numericUpDownBeginningTankLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBeginningTankLevel.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownBeginningTankLevel.Location = new System.Drawing.Point(343, 37);
            this.numericUpDownBeginningTankLevel.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownBeginningTankLevel.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownBeginningTankLevel.Name = "numericUpDownBeginningTankLevel";
            this.numericUpDownBeginningTankLevel.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownBeginningTankLevel.TabIndex = 28;
            this.numericUpDownBeginningTankLevel.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownBeginningTankLevel.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(385, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 27;
            this.label8.Text = "Set Point:";
            // 
            // numericUpDownSetPoint
            // 
            this.numericUpDownSetPoint.DecimalPlaces = 6;
            this.numericUpDownSetPoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSetPoint.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownSetPoint.Location = new System.Drawing.Point(343, 104);
            this.numericUpDownSetPoint.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownSetPoint.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownSetPoint.Name = "numericUpDownSetPoint";
            this.numericUpDownSetPoint.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownSetPoint.TabIndex = 26;
            this.numericUpDownSetPoint.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.numericUpDownSetPoint.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(201, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Beginning Input Flow Rate:";
            // 
            // numericUpDownBeginningInputFlowRate
            // 
            this.numericUpDownBeginningInputFlowRate.DecimalPlaces = 6;
            this.numericUpDownBeginningInputFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownBeginningInputFlowRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownBeginningInputFlowRate.Location = new System.Drawing.Point(96, 104);
            this.numericUpDownBeginningInputFlowRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownBeginningInputFlowRate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownBeginningInputFlowRate.Name = "numericUpDownBeginningInputFlowRate";
            this.numericUpDownBeginningInputFlowRate.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownBeginningInputFlowRate.TabIndex = 24;
            this.numericUpDownBeginningInputFlowRate.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Max Input Flow Rate (MIFR):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 20);
            this.label6.TabIndex = 23;
            this.label6.Text = "Constant Output Flow Rate:";
            // 
            // numericUpDownMaxInputRate
            // 
            this.numericUpDownMaxInputRate.DecimalPlaces = 6;
            this.numericUpDownMaxInputRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownMaxInputRate.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownMaxInputRate.Location = new System.Drawing.Point(96, 37);
            this.numericUpDownMaxInputRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMaxInputRate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownMaxInputRate.Name = "numericUpDownMaxInputRate";
            this.numericUpDownMaxInputRate.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownMaxInputRate.TabIndex = 20;
            this.numericUpDownMaxInputRate.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownMaxInputRate.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // numericUpDownConstantOutputFlowRate
            // 
            this.numericUpDownConstantOutputFlowRate.DecimalPlaces = 6;
            this.numericUpDownConstantOutputFlowRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownConstantOutputFlowRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            262144});
            this.numericUpDownConstantOutputFlowRate.Location = new System.Drawing.Point(96, 230);
            this.numericUpDownConstantOutputFlowRate.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownConstantOutputFlowRate.Minimum = new decimal(new int[] {
            100000000,
            0,
            0,
            -2147483648});
            this.numericUpDownConstantOutputFlowRate.Name = "numericUpDownConstantOutputFlowRate";
            this.numericUpDownConstantOutputFlowRate.Size = new System.Drawing.Size(120, 26);
            this.numericUpDownConstantOutputFlowRate.TabIndex = 22;
            this.numericUpDownConstantOutputFlowRate.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownConstantOutputFlowRate.ValueChanged += new System.EventHandler(this.numericUpDownGeneralSetting_valueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.ClientSize = new System.Drawing.Size(1431, 671);
            this.Controls.Add(this.tabControlSimulation);
            this.Controls.Add(this.startSimulationButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControlSimulation.ResumeLayout(false);
            this.tabPageSimulation.ResumeLayout(false);
            this.tabPageSimulation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDerivativeConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownProportionalConstant)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIntegralConstant)).EndInit();
            this.tabPageSettings.ResumeLayout(false);
            this.tabPageSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyclesBetweenInputFlowRateUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCyclesToSimulate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownTankMaximum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginningTankLevel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSetPoint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBeginningInputFlowRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMaxInputRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownConstantOutputFlowRate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startSimulationButton;
        private System.Windows.Forms.TabControl tabControlSimulation;
        private System.Windows.Forms.TabPage tabPageSimulation;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TabPage tabPageSettings;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownDerivativeConstant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownProportionalConstant;
        private System.Windows.Forms.NumericUpDown numericUpDownIntegralConstant;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDownBeginningInputFlowRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownMaxInputRate;
        private System.Windows.Forms.NumericUpDown numericUpDownConstantOutputFlowRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numericUpDownBeginningTankLevel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDownSetPoint;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericUpDownTankMaximum;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown numericUpDownCyclesToSimulate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown numericUpDownCyclesBetweenInputFlowRateUpdate;
        private System.Windows.Forms.CheckedListBox checkedListBoxItemsToGraph;
        private System.Windows.Forms.Label label12;
    }
}

