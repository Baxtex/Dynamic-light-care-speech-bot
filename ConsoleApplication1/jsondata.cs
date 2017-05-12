using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ConsoleApplication1
{
    [DataContract]
    public class jsondata
    {
        [DataMember]
        public string Id { get; set; }
        [DataMember]
        public string message { get; set; }

    }
}
