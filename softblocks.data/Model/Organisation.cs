﻿using softblocks.data.Entities.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softblocks.data.Model
{
    public class Organisation : MongoEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<string> Users { get; set; }
    }
}
