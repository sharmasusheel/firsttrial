using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Configuration;

namespace WebApplication1
{
    public class ConString
    {
        public string stringDbCon
        {
            get { return ConfigurationManager.ConnectionStrings["conn"].ConnectionString; }
        }
    }
    public class PropertyService : DataService
    {

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
}