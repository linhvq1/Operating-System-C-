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

namespace TaskManagerApp2
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
            GetProcess();
        }
        // mang de luu lai danh sach cac process
        Process[] proc;
        // lay len danh sach process va luu lai
        void GetProcess()
        {
            proc = Process.GetProcesses();
            listView1.Items.Clear();
            foreach (var item in proc)
            {
                ListViewItem newItem = new ListViewItem() {Text = item.ProcessName };
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.PagedSystemMemorySize64.ToString() });
                listView1.Items.Add(newItem);

            }
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(proc.Length != Process.GetProcesses().Length)
            {
                GetProcess();
            }
        }

        private void endTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(var item in proc)
            {
                if(item.ProcessName == listView1.SelectedItems[0].Text)
                {
                    index = proc.ToList().IndexOf(item);
                    break;
                }
            }

            if(listView1.SelectedItems.Count >0)
                proc[index].Kill();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ListVIewItemComparer(e.Column);
            listView1.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var item in proc)
            {
                if (item.ProcessName == listView1.SelectedItems[0].Text)
                {
                    index = proc.ToList().IndexOf(item);
                    break;
                }
            }

            if (listView1.SelectedItems.Count > 0)
                proc[index].Kill();
        }

        private void runNewTaskToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (RunNewTask fm = new RunNewTask())
            {
                if(fm.ShowDialog() == DialogResult.OK)
                {
                    GetProcess();
                }
            }
        }
        PerformanceCounter perSystemCounter = new PerformanceCounter("System", "System Up Time");
        PerformanceCounter perDiskCounter = new PerformanceCounter("PhysicalDisk", "% Disk Write Time", "_Total");
        private void timer2_Tick(object sender, EventArgs e)
        {
            float fcpu = pCPU.NextValue();
            float fram = pRAM.NextValue();
            //float fmema = pMEMA.NextValue();

            
            PerformanceCounter perMemCounter = new PerformanceCounter("Memory","Available MBytes");
            

            metroProgressBarCPU.Value = (int)fcpu;
            metroProgressBarRAM.Value = (int)fram;

            float fdisk = perDiskCounter.NextValue();

            metroProgressBarDISK.Value = (int)fdisk;

            lbCPU.Text = string.Format("{0:0.00}%", fcpu);
            lbRAM.Text = string.Format("{0:0.00}%", fram);
            lbDISK.Text = string.Format("{0:0.00}%", fdisk);

            lbMA.Text = (int)perMemCounter.NextValue() + " MB";
            lbHU.Text = (int)perSystemCounter.NextValue() / 60 / 60 + " Hours";

            chart1.Series["CPU"].Points.AddY(fcpu);
            chart1.Series["RAM"].Points.AddY(fram);
        }

        private void metroProgressBarMA_Click(object sender, EventArgs e)
        {

        }
    }
}
