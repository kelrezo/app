﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Serialization;
using BasicApi.Services;
namespace BasicApi.Models
{
 
    public class Entity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public bool Dead { get; set; }
    }
}