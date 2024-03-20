using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloodManagementSystem.BLL
{
    internal class userBLL
    {
        public int user_id { get; set; }
        public string user_name{ get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string full_name { get; set;}
        public string contact { get; set; }
        public string address { get; set; }
        public DateTime added_by { get; set; }
        public string image_name { get;  set; }
    }
}
