using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;
using ClientInformationDL;
using System.Configuration;

namespace ClientInfoService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
      
    public class Service1 : IService1
    {
        string strcon = ConfigurationManager.AppSettings["connectionString"];
        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        public DataSet GetGenderLookup()
        {
            try
            {
                Utils utl = new Utils();
                return utl.ExecuteDataSet("Select ID, Description From lkGender", strcon);
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }

        public DataSet GetAddressTypeLookup()
        {
            try
            {                
                Utils utl = new Utils();
                return utl.ExecuteDataSet("Select ID, Description From lkAddressType", strcon);
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }
        public DataSet GetContactNumberTypeLookup()
        {
            try
            {
                Utils utl = new Utils();
                return utl.ExecuteDataSet("Select ID, Description From lkContactNumberType", strcon);
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }

        public DataSet GetAllUserForExport(int UserID)
        {
            try
            {
                Utils utl = new Utils();
                return utl.ExecuteDataSet(@"Select * 
                                            From[User] usr
                                            Inner join lkGender gen ON gen.ID = usr.ID
                                            Inner join UserAddress usradr ON usradr.userID = usr.ID
                                            Inner Join Addres adr On adr.ID = usradr.AddressID
                                            Where usr.ID = [UserID]", strcon);
            }
            catch (Exception)
            {
                return new DataSet();
            }
        }
    }
}

