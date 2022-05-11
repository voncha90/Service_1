using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Service_1
{
    public class ServiceAClass
    {

        public string GetServiceAClassData()
        {
            string result = string.Empty;
            Account account = new Account
            {
                Email = "james@example.com",
                Active = true,
                CreatedDate = new DateTime(2013, 1, 20, 0, 0, 0, DateTimeKind.Utc),
                Roles = new List<string>
    {
        "User",
        "Admin"
    }
            };

            result = JsonConvert.SerializeObject(account, Formatting.Indented);

            return result;
        }
    }

    public class Account
    {
        public string Email { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public IList<string> Roles { get; set; }
    }
}
