using Newtonsoft.Json;

namespace CustomerDetails.Model
{
    public class Dbhandle
    {
        public string viewcustomer()
        {
            EFDbhandle context = new EFDbhandle();
            var listP = from e in context.Users
                        select new
                        {
                            CustomerID = e.CustomerID,
                            FirstName = e.FirstName,
                            LastName = e.LastName,
                            Country = e.Country,
                            CreatedDate = e.CreatedDate
                        };
            List<User> listS = new List<User>();
            foreach (var listE in listP)
            {
                User e = new User();
                e.CustomerID = listE.CustomerID;
                e.FirstName = listE.FirstName;
                e.LastName = listE.LastName;
                e.Country = listE.Country;
                e.CreatedDate = listE.CreatedDate;
                listS.Add(e);
            }

            return JsonConvert.SerializeObject(listS);
        }

        public void DeleteCus(int id)
        {
            EFDbhandle context = new EFDbhandle();
            context.Users.Remove(context.Users.FirstOrDefault(e => e.CustomerID == id));
            context.SaveChanges();
            return;
        }

        public void addcustomer(User c)
        {
            EFDbhandle context = new EFDbhandle();
            c.CreatedDate = DateTime.Now;
            context.Users.Add(c);
            context.SaveChanges();
            return;
        }
        public User getcusonID(int CustomerID)
        {
            EFDbhandle context = new EFDbhandle();
            var cus = context.Users.Find(CustomerID);
            return cus;
        }

        public void updatecustomer(User c)
        {
            EFDbhandle context = new EFDbhandle();
            User cus = context.Users.Find(c.CustomerID);
            cus.FirstName = c.FirstName;
            cus.LastName = c.LastName;
            cus.Country = c.Country;

            context.SaveChanges();
            return;
        }
    }
}

