using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagerApp2
{
    public partial class FormDetail : MetroFramework.Forms.MetroForm
    {
        string namePro,idPro,descPro,statusPro,memPro;
        public FormDetail()
        {
            InitializeComponent();
        }
        
        public FormDetail(string namePro,string idPro,string statusPro, string descPro,string memPro)
        {
            InitializeComponent();
            this.namePro = namePro;
            this.idPro = idPro;
            this.statusPro = statusPro;
            this.descPro = descPro;
            this.memPro = memPro;
        }
        public string getnamePro()
        {
            return namePro;
        }
        public string getidPro()
        {
            return idPro;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

        }

        public string getstatusPro()
        {
            return statusPro;
        }

        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        public string getdescPro()
        {
            return descPro;
        }
        public string getmemPro()
        {
            return memPro;
        }
        private void FormDetail_Load(object sender, EventArgs e)
        {
            metroLabel1.Text = getnamePro();
            metroLabel4.Text = getidPro();
            metroLabel6.Text = getstatusPro();
            metroLabel8.Text = getdescPro();
            metroLabel10.Text = getmemPro();
        }
    }
}
