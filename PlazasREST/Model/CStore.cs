﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace PlazasREST.Model
{
    [DataContract]
    public class CStore
    {
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string name { get; set; }
    }
}