﻿using softblocks.data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace softblocks.Models
{
    public class ResRenderForm
    {
        public ModuleForm Form { get; set; }
        public List<Field> DocumentFields { get; set; }
    }
}