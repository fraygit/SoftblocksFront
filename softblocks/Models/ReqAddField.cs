﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softblocks.Models
{
    public class ReqAddField
    {
        public string AppId { get; set; }
        public string DocumentTypeId { get; set; }
        public string Name { get; set; }
        public string DataType { get; set; }
        public string Parent { get; set; }
    }
}