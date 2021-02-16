using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace try_db_code_web.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
    }
}
