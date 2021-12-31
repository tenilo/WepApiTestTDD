﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SelfieAwokie.Domain
{
    public class Wookie
    {
        #region Properties
        public int Id { get; set; }
        [JsonIgnore]
        public List<Selfie> Selfies { get; set; }

        #endregion
    }
}
