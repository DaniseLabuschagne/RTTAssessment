using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClientInformation.ClientInformationService;

namespace ClientInformation
{    
    public partial class frmClientInformation : Form
    {
        ClientInformationModel CIM = new ClientInformationModel();
        
        public frmClientInformation(int ClientID)
        {
            InitializeComponent();
            if (ClientID > 0) {
                //Retrieve all client information
            } 
        }

        private void frmClientInformation_Load(object sender, EventArgs e)
        {
            GetAllLookups();
        }

        private void GetAllLookups() {
            GetGenderLookup();
            GetAddressTypeLookup();
            GetContactTypeLookup();
        }

        private void GetGenderLookup() {
            DataSet dsGender = new DataSet();
            Service1Client srvClient = new Service1Client();
            dsGender = srvClient.GetGenderLookup();

            cboGender.DisplayMember = "Description";
            cboGender.ValueMember = "ID";
            cboGender.DataSource = dsGender.Tables[0];                      
        }

        private void GetAddressTypeLookup() {
            DataSet ds = new DataSet();
            Service1Client srvClient = new Service1Client();
            ds = srvClient.GetAddressTypeLookup();

            cboAddrType.DisplayMember = "Description";
            cboAddrType.ValueMember = "ID";
            cboAddrType.DataSource = ds.Tables[0];
        }

        private void GetContactTypeLookup()
        {
            DataSet ds = new DataSet();
            Service1Client srvClient = new Service1Client();
            ds = srvClient.GetContactNumberTypeLookup();

            cboContactType.DisplayMember = "Description";
            cboContactType.ValueMember = "ID";
            cboContactType.DataSource = ds.Tables[0];
        }

        private void ClientInformation_IU() {
        }

        private void btnAddContactInfo_Click(object sender, EventArgs e)
        {
          
        }      

        private void btnAddressInfo_Click(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MapClientInformation();

            Service1Client srvClient = new Service1Client();
            //srvClient.SaveClientInformation(model)
        }

        private void MapClientInformation() {
            CIM.UserName = txtName.Text;
            CIM.UserSurname = txtSurname.Text;
            CIM.GenderID = Convert.ToInt32(cboGender.SelectedValue);
            CIM.IDPassportNr = txtIDPassNr.Text;            
        }
    }
}
