using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    internal class Invoice
    {
        public int Invoice_id { get; set; }
        public int Customer_id { get; set; }
        public DateTime Date { get; set; }
        public double Total { get; set; }

    }
}
