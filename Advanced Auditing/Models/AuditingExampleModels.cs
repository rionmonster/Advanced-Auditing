using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Web;
using System.Web.Routing;
using System.Web.Script.Serialization;

namespace Advanced_Auditing.Models
{
    public class SimpleViewModel
    {
        public string Property { get; set; }

        public SimpleViewModel() { }
    }

    public class IntermediateViewModel
    {
        public string StringProperty { get; set; }
        public int IntegerProperty { get; set; }

        public IntermediateViewModel() { }
    }

    public class AdvancedViewModel
    {
        public Guid ModelID { get; set; }
        public string StringProperty { get; set; }
        public int IntegerProperty { get; set; }
        public List<string> Collection { get; set; }

        public AdvancedViewModel() { }
    }
}