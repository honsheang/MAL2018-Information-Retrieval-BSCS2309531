using System.ComponentModel.DataAnnotations;

namespace ProfileService.Model
{
    public class EmergencyContact
    {
        [Key]
        public string eContactID { get; set; }
        public string eContactName { get; set; }
        public string mobileNo { get; set; }
        public string gender { get; set; }
        public string relationship { get; set; }
        public string userID { get; set; }
    }

    public class EmergencyContactCollection
    {
        public List<EmergencyContact> EmergencyContact { get; set; }

        public List<EmergencyContact> GetEmergencyContacts()
        {
            return new List<EmergencyContact>
            {
                new EmergencyContact()
                {
                    eContactID = "1",
                    eContactName = "Tim Burton",
                    mobileNo = "+60129384930",
                    gender = "Male",
                    relationship = "Husband",
                    userID = "1"
                },
                new EmergencyContact()
                {
                    eContactID = "2",
                    eContactName = "Kaylee",
                    mobileNo = "+1231231123",
                    gender = "Female",
                    relationship = "Sister",
                    userID = "2"
                },
                new EmergencyContact()
                {
                    eContactID = "3",
                    eContactName = "Roiley",
                    mobileNo = "+987654321",
                    gender = "Female",
                    relationship = "Wife",
                    userID = "3"
                }
            };
        }
    }
}
