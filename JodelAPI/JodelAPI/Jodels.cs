﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JodelAPI
{
    public class Jodels
    {
        //postid, message, hexcolor, isImage, votecount, lat, lng, name
        public string PostId { get; set; }

        public string Message { get; set; }

        public string HexColor { get; set; }

        public bool IsImage { get; set; }

        public int VoteCount { get; set; }

        public string Latitude { get; set; }

        public string Longitude { get; set; }

        public string LocationName { get; set; }
    }
}
