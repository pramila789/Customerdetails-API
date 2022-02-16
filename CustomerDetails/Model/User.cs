using System.ComponentModel.DataAnnotations;

namespace CustomerDetails.Model
{
    public class User
    {
        [Key]
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Country { get; set; }
        public DateTime CreatedDate { get; set; }
       

    }
}

    

