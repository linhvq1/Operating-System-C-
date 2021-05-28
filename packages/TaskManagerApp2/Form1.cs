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
using System.Management;
using System.Dynamic;

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
        Process[] processList;
        // lay len danh sach process va luu lai
        void GetProcess()
        {
            processList = Process.GetProcesses();
            // Create an Imagelist that will store the icons of every process
            ImageList Imagelist = new ImageList();
            listView1.Items.Clear();
            mbtt3.Text = processList.Length.ToString();
            foreach (var item in processList)
            {   //status
                string status = (item.Responding == true ? "Responding" : "Not responding");
                // Retrieve the object of extra information of the process (to retrieve Username and Description)
                // cai nay gay crash
                //dynamic extraProcessInfo = GetProcessExtraInformation(item.Id);

                try
                {
                    Imagelist.Images.Add(
                        // Add an unique Key as identifier for the icon (same as the ID of the process)
                        item.Id.ToString(),
                        // Add Icon to the List 
                        Icon.ExtractAssociatedIcon(item.MainModule.FileName).ToBitmap()
                    );
                }
                catch { }

                ListViewItem newItem = new ListViewItem()
                {// Set the ImageIndex of the item as the same defined in the previous try-catch
                    ImageIndex = Imagelist.Images.IndexOfKey(item.Id.ToString()),
                    Text = item.ProcessName
                };
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.Id.ToString() });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = status });
                //newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = extraProcessInfo.Username });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = BytesToReadableValue(item.PrivateMemorySize64) });
                newItem.SubItems.Add(new ListViewItem.ListViewSubItem() { Text = item.MainWindowTitle });
                //
                // As not every process has an icon then, prevent the app from crash


                listView1.Items.Add(newItem);
                // Set the imagelist of your list view the previous created list :)
                listView1.LargeImageList = Imagelist;
                listView1.SmallImageList = Imagelist;

            }

        }
        // tinh lai 
        public string BytesToReadableValue(long number)
        {
            List<string> suffixes = new List<string> { " B", " KB", " MB", " GB", " TB", " PB" };

            for (int i = 0; i < suffixes.Count; i++)
            {
                long temp = number / (int)Math.Pow(1024, i + 1);

                if (temp == 0)
                {
                    return (number / (int)Math.Pow(1024, i)) + suffixes[i];
                }
            }

            return number.ToString();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            timer2.Start();
            
            GetProcess();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (processList.Length != Process.GetProcesses().Length)
            {
                
                GetProcess();
            }
        }

        private void endTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach(var item in processList)
            {
                if(item.ProcessName == listView1.SelectedItems[0].Text)
                {
                    index = processList.ToList().IndexOf(item);
                    break;
                }
            }

            if(listView1.SelectedItems.Count >0)
                processList[index].Kill();
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            listView1.ListViewItemSorter = new ListVIewItemComparer(e.Column);
            listView1.Sort();
        }

        private void button1_Click(object sender, EventArgs e)
        {

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

        private void runNewTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            using (RunNewTask fm = new RunNewTask())
            {
                if (fm.ShowDialog() == DialogResult.OK)
                {
                    GetProcess();
                }
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void detailProcessToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var item in processList)
            {
                if (item.ProcessName == listView1.SelectedItems[0].Text)
                {
                    index = processList.ToList().IndexOf(item);
                    break;
                }
            }
            string status = (processList[index].Responding == true ? "Responding" : "Not responding");
            dynamic extraProcessInfo = GetProcessExtraInformation(processList[index].Id);
            if (listView1.SelectedItems.Count > 0)
            {
             
                using (FormDetail fm = new FormDetail(processList[index].ProcessName, processList[index].Id.ToString(),status, extraProcessInfo.Description, BytesToReadableValue(processList[index].PrivateMemorySize64), extraProcessInfo.Username))
                {
                    if (fm.ShowDialog() == DialogResult.OK)
                    {
                        GetProcess();
                        metroButton1.Enabled = false;
                        metroButton2.Enabled = false;
                    }
                }
            }
                
        }
        /// <summary>
        /// Returns an Expando object with the description and username of a process from the process ID.
        /// </summary>
        /// <param name="processId"></param>
        /// <returns></returns>
        public ExpandoObject GetProcessExtraInformation(int processId)
        {
            // Query the Win32_Process
            string query = "Select * From Win32_Process Where ProcessID = " + processId;
            ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);
            ManagementObjectCollection processList = searcher.Get();

            // Create a dynamic object to store some properties on it
            dynamic response = new ExpandoObject();
            response.Description = "";
            response.Username = "Unknown";

            foreach (ManagementObject obj in processList)
            {
                // Retrieve username 
                string[] argList = new string[] { string.Empty, string.Empty };
                int returnVal = Convert.ToInt32(obj.InvokeMethod("GetOwner", argList));
                if (returnVal == 0)
                {
                    // return Username
                    response.Username = argList[0];

                    // You can return the domain too like (PCDesktop-123123\Username using instead
                    //response.Username = argList[1] + "\\" + argList[0];
                }

                // Retrieve process description if exists
                if (obj["ExecutablePath"] != null)
                {
                    try
                    {
                        FileVersionInfo info = FileVersionInfo.GetVersionInfo(obj["ExecutablePath"].ToString());
                        response.Description = info.FileDescription;
                    }
                    catch { }
                }
            }

            return response;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            metroButton1.Enabled = true;
            metroButton2.Enabled = true;
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            int index = 0;
            foreach (var item in processList)
            {
                if (item.ProcessName == listView1.SelectedItems[0].Text)
                {
                    index = processList.ToList().IndexOf(item);
                    break;
                }
            }

            if (listView1.SelectedItems.Count > 0)
            {
                processList[index].Kill();
                metroButton1.Enabled = false;
                metroButton2.Enabled = false;
            }
        }
    }
}
