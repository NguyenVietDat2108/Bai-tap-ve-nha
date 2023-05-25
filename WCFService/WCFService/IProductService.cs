using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace WCFService
{
    [ServiceContract]
    interface IProductService
    {
        [OperationContract]
        List<Product> GetProducts();
        [OperationContract]
        Product GetProduct(int productId);
    }

    [DataContract]
    public class Product
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public int Price { get; set; }
    }
    }
