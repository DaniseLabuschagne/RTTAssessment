using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientInformation
{
    public class ClientInformationModel
    {
        public string UserName { get; set; }
        public string UserSurname { get; set; }
        public string IDPassportNr { get; set; }

        public int GenderID { get; set; }
        public List<ClientContactModel> contactList { get; set; }
        public List<ClientAddressModel> addressList { get; set; }
    }

    public class ClientContactModel
    {
        public int Code { get; set; }
        public int Number { get; set; }
    }

    public class ClientAddressModel {
        public string ComplexBussNr { get; set; }
        public string ComplexBussName { get; set; }
        public string StreetNr { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string City { get; set; }
    }
}
