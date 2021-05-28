namespace TaskManagerApp2
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.endTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarCPU = new MetroFramework.Controls.MetroProgressBar();
            this.metroProgressBarRAM = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lbCPU = new MetroFramework.Controls.MetroLabel();
            this.lbRAM = new MetroFramework.Controls.MetroLabel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.metrolabel5 = new MetroFramework.Controls.MetroLabel();
            this.lbMA = new MetroFramework.Controls.MetroLabel();
            this.lbHU = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.lbDISK = new MetroFramework.Controls.MetroLabel();
            this.metroProgressBarDISK = new MetroFramework.Controls.MetroProgressBar();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.mbtt3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.runNewTaskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader5,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(23, 96);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(659, 474);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Process Name";
            this.columnHeader1.Width = 190;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "PID";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Memory( private working set)";
            this.columnHeader5.Width = 170;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "title";
            this.columnHeader4.Width = 150;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.endTToolStripMenuItem,
            this.runNewTaskToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 48);
            // 
            // endTToolStripMenuItem
            // 
            this.endTToolStripMenuItem.Name = "endTToolStripMenuItem";
            this.endTToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.endTToolStripMenuItem.Text = "End Task";
            this.endTToolStripMenuItem.Click += new System.EventHandler(this.endTToolStripMenuItem_Click);
            // 
            // runNewTaskToolStripMenuItem
            // 
            this.runNewTaskToolStripMenuItem.Name = "runNewTaskToolStripMenuItem";
            this.runNewTaskToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.runNewTaskToolStripMenuItem.Text = "Run new task";
            this.runNewTaskToolStripMenuItem.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 576);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "End Task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(700, 127);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(42, 19);
            this.metroLabel1.TabIndex = 3;
            this.metroLabel1.Text = "CPU: ";
            // 
            // metroProgressBarCPU
            // 
            this.metroProgressBarCPU.Location = new System.Drawing.Point(748, 123);
            this.metroProgressBarCPU.Name = "metroProgressBarCPU";
            this.metroProgressBarCPU.Size = new System.Drawing.Size(490, 23);
            this.metroProgressBarCPU.TabIndex = 4;
            // 
            // metroProgressBarRAM
            // 
            this.metroProgressBarRAM.Location = new System.Drawing.Point(748, 165);
            this.metroProgressBarRAM.Name = "metroProgressBarRAM";
            this.metroProgressBarRAM.Size = new System.Drawing.Size(490, 23);
            this.metroProgressBarRAM.TabIndex = 6;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(700, 169);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(45, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "RAM: ";
            // 
            // lbCPU
            // 
            this.lbCPU.AutoSize = true;
            this.lbCPU.Location = new System.Drawing.Point(1244, 123);
            this.lbCPU.Name = "lbCPU";
            this.lbCPU.Size = new System.Drawing.Size(31, 19);
            this.lbCPU.TabIndex = 7;
            this.lbCPU.Text = "0 %";
            // 
            // lbRAM
            // 
            this.lbRAM.AutoSize = true;
            this.lbRAM.Location = new System.Drawing.Point(1244, 165);
            this.lbRAM.Name = "lbRAM";
            this.lbRAM.Size = new System.Drawing.Size(31, 19);
            this.lbRAM.TabIndex = 8;
            this.lbRAM.Text = "0 %";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(748, 268);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(490, 300);
            this.chart1.TabIndex = 9;
            this.chart1.Text = "chart1";
            // 
            // metrolabel5
            // 
            this.metrolabel5.AutoSize = true;
            this.metrolabel5.Location = new System.Drawing.Point(750, 246);
            this.metrolabel5.Name = "metrolabel5";
            this.metrolabel5.Size = new System.Drawing.Size(124, 19);
            this.metrolabel5.TabIndex = 10;
            this.metrolabel5.Text = "Available Memory: ";
            // 
            // lbMA
            // 
            this.lbMA.AutoSize = true;
            this.lbMA.Location = new System.Drawing.Point(880, 246);
            this.lbMA.Name = "lbMA";
            this.lbMA.Size = new System.Drawing.Size(40, 19);
            this.lbMA.TabIndex = 11;
            this.lbMA.Text = "0 MB";
            // 
            // lbHU
            // 
            this.lbHU.AutoSize = true;
            this.lbHU.Location = new System.Drawing.Point(1171, 246);
            this.lbHU.Name = "lbHU";
            this.lbHU.Size = new System.Drawing.Size(54, 19);
            this.lbHU.TabIndex = 13;
            this.lbHU.Text = "0 Hours";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(1054, 246);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(111, 19);
            this.metroLabel4.TabIndex = 12;
            this.metroLabel4.Text = "System Up Time: ";
            // 
            // lbDISK
            // 
            this.lbDISK.AutoSize = true;
            this.lbDISK.Location = new System.Drawing.Point(1244, 204);
            this.lbDISK.Name = "lbDISK";
            this.lbDISK.Size = new System.Drawing.Size(31, 19);
            this.lbDISK.TabIndex = 16;
            this.lbDISK.Text = "0 %";
            // 
            // metroProgressBarDISK
            // 
            this.metroProgressBarDISK.Location = new System.Drawing.Point(748, 204);
            this.metroProgressBarDISK.Name = "metroProgressBarDISK";
            this.metroProgressBarDISK.Size = new System.Drawing.Size(490, 23);
            this.metroProgressBarDISK.TabIndex = 15;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(700, 208);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(42, 19);
            this.metroLabel6.TabIndex = 14;
            this.metroLabel6.Text = "DISK: ";
            // 
            // mbtt3
            // 
            this.mbtt3.AutoSize = true;
            this.mbtt3.Location = new System.Drawing.Point(23, 581);
            this.mbtt3.Name = "mbtt3";
            this.mbtt3.Size = new System.Drawing.Size(35, 19);
            this.mbtt3.TabIndex = 17;
            this.mbtt3.Text = "total";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(23, 610);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(260, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "* right click your mouse to RUN NEW TASK";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(20, 60);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1280, 24);
            this.menuStrip1.TabIndex = 19;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.runNewTaskToolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "File";
            // 
            // runNewTaskToolStripMenuItem1
            // 
            this.runNewTaskToolStripMenuItem1.Name = "runNewTaskToolStripMenuItem1";
            this.runNewTaskToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.runNewTaskToolStripMenuItem1.Text = "Run New Task";
            this.runNewTaskToolStripMenuItem1.Click += new System.EventHandler(this.runNewTaskToolStripMenuItem1_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(495, 577);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(95, 23);
            this.metroButton1.TabIndex = 20;
            this.metroButton1.Text = "Detail Process";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 663);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.mbtt3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.lbDISK);
            this.Controls.Add(this.metroProgressBarDISK);
            this.Controls.Add(this.metroLabel6);
            this.Controls.Add(this.lbHU);
            this.Controls.Add(this.metroLabel4);
            this.Controls.Add(this.lbMA);
            this.Controls.Add(this.metrolabel5);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.lbRAM);
            this.Controls.Add(this.lbCPU);
            this.Controls.Add(this.metroProgressBarRAM);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroProgressBarCPU);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Simple Task Manager";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem endTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Diagnostics.PerformanceCounter pRAM;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Windows.Forms.Timer timer2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarCPU;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarRAM;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lbCPU;
        private MetroFramework.Controls.MetroLabel lbRAM;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private MetroFramework.Controls.MetroLabel metrolabel5;
        private MetroFramework.Controls.MetroLabel lbMA;
        private MetroFramework.Controls.MetroLabel lbHU;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel lbDISK;
        private MetroFramework.Controls.MetroProgressBar metroProgressBarDISK;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private MetroFramework.Controls.MetroLabel mbtt3;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem runNewTaskToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private MetroFramework.Controls.MetroButton metroButton1;
    }
}

