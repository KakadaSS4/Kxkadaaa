using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConnectToSQLServer
{
    internal class ClassLuckyDraw
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ClassLuckyDraw(string id, string name, string gender, string email, string phone)
        {
            Id=id;
            Name=name;
            Gender=gender;
            Email=email;
            Phone=phone;
        }
    }
}
