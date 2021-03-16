using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BTVN1.Models
{
    [DataContract]
    public class Student

    {
        [DataMember(Name = "Name")]
        public String Name { get; set; }
        [DataMember(Name ="MSV")]
        public double MSV { get; set; }
        [DataMember (Name ="Age")]
        public int Age { get; set; }


    }
}