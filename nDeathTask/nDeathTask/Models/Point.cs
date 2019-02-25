using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;


namespace nDeathTask.Models
{
    [DataContract]
    public class Point
    {
        public Point(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        [DataMember(Name = "x")]
        public double x { get; set; }

        [DataMember(Name = "y")]
        public double y { get; set; }
    }
}