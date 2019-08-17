using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWForm.Models
{
   public class CB_CustomerID_class
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string IDCard { get; set; }

        public override string ToString()
        {
            return IDCard;
        }
    }
}
