using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWForm.Models
{
    public class ListClass
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal? Price { get; set; }

        public int? Count { get; set; }

        public override string ToString()
        {
            return Name+" - "+ 1 + " " + "ədəd";
        }
    }
}
