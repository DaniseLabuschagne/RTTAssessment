using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientInformation
{
    public partial class frmClientList : Form
    {
        public frmClientList()
        {
            InitializeComponent();
        }

        private void frmClientList_Load(object sender, EventArgs e)
        {

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
           
            frmClientInformation frmclient = new frmClientInformation(0);
            frmclient.Show();
        }

        private void btnExportClients_Click(object sender, EventArgs e)
        {

        }

        private void dgvClientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int ClientID = 1;
            frmClientInformation frmclient = new frmClientInformation(ClientID);
            frmclient.Show();
        }
    }
}
