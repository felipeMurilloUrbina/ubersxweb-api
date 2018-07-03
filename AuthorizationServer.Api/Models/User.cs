using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AuthorizationServer.Api.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }

        public string LastName { get; set; }

        [Required]
        public DateTime JoinDate { get; set; }
        public string Language { get; set; }

        public string Avatar { get; set; }
    }
}