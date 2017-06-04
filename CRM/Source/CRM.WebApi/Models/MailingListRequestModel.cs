﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRM.WebApi.Models
{
    public class MailingListRequestModel
    {
        [Required(ErrorMessage = "Name is required for mailing list"), StringLength(200, MinimumLength = 1, ErrorMessage = "The full name must be specified.")]

        public string MailingListName { get; set; }
    }
}