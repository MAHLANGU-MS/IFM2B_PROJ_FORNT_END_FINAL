using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TeamweDev_GP_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public User Login(string email, string password)
        {
            var sysuser = (from s in db.Users
                           where s.Email.Equals(email) &&
                           s.Password.Equals(password)
                           select s).FirstOrDefault();

            if (sysuser != null)
            {
                var tempUser = new User
                {
                    Id = sysuser.Id,
                    Email = sysuser.Email,
                    UserType = sysuser.UserType,
                };
                return tempUser;
            }
            else
            {
                return null;
            }
        }

        public int register(string name,string surname, string email, string password , string user)
        {

                var newUser = new User
                {
                    Name = name,
                    Surname = surname,
                    Email = email,
                    Password = password,
                    UserType = user
                };

                db.Users.InsertOnSubmit(newUser);
                try
                {
                    db.SubmitChanges();
                    //success
                    return 1;
                }
                catch (Exception ex)
                {
                    ex.GetBaseException();
                    //error
                    return -1;
                }
            
        }

        public List<Product> getAllProducts()
        {
            var Prods = new List<Product>();

            var Prod = (from p in db.Products
                        where p.PrQuantity > 0
                        select p).DefaultIfEmpty();

            foreach (Product p in Prod)
            {
                var product = new Product
                {
                    Id = p.Id,
                    PrName = p.PrName,
                    PrCategory = p.PrCategory,
                    PrRating = p.PrRating,
                    PrPrice = p.PrPrice,
                    PrOldPrice = p.PrOldPrice,
                    PrImage = p.PrImage
                };

                Prods.Add(product);
            }

            return Prods;
        }

        public Product getProduct(int ID)
        {
            var Prod = (from p in db.Products
                        where p.Id.Equals(ID)
                        select p).FirstOrDefault();

            if (Prod != null)
            {
                var tempProd = new Product
                {
                    Id = Prod.Id,
                    PrCategory = Prod.PrCategory,
                    PrDescription = Prod.PrDescription,
                    PrImage = Prod.PrImage,
                    PrName = Prod.PrName,
                    PrOldPrice = Prod.PrOldPrice,
                    PrPrice = Prod.PrPrice,
                    PrQuantity = Prod.PrQuantity,
                    PrRating = Prod.PrRating,
                };
                return tempProd;
            }
            else
            {
                return null;
            }
        }
    }
}
