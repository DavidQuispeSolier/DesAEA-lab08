using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity;
using System.Data;
using Data;

namespace Bussiness
{
    public class BProduct
    {
        public List<Product> GetByName(string Name)
        {

            DProduct data = new DProduct();
            var products = data.Get();

            var result = products.Where(x => x.Name.Contains(Name)).ToList();
            //lambda
            //flecha


            return result;
        }
    }
}
