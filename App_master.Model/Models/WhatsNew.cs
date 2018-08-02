using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_master.Model.Models
{
   public class WhatsNew
    {
        public int Id { get; set; }
        public DateTime currentDate { get; set; }

        public string heading { get; set; }

        public string description { get; set; }

    }
}
