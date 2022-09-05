using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace TeamweDev_GP_Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        User Login(string email, string password);

        [OperationContract]
        int register(string name,string surname, string email, string password, string user);

        [OperationContract]
        List<Product> getAllProducts();

        [OperationContract]
        Product getProduct(int ID);
    }
}
