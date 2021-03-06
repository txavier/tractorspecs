﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TractorSpecs.Core.Models
{
    [MetadataType(typeof(userMetaData))]
    public partial class user
    {
        internal bool? topLevelRole;

        private class userMetaData
        {
            [DisplayName("user name")]
            public string userName { get; set; }

            [DisplayName("phone number")]
            public string phoneNumber { get; set; }

            [DisplayName("email address")]
            public string emailAddress { get; set; }
        }

        public override string ToString()
        {
            return "User " + this.name;
        }
    }
}
