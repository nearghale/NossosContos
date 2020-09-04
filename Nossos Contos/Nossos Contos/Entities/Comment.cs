﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nossos_Contos.Entities
{
    public class Comment : MongoDB.Base
    {
        [JsonProperty("id_tale")]
        public string IDTale { get; set; }

        [JsonProperty("title_comment")]
        public string TitleComment { get; set; }

        [JsonProperty("commentary")]
        public string Commentary { get; set; }


    }
}