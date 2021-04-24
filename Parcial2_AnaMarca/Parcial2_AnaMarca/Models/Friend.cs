using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Parcial2_AnaMarca.Models
{
    public class Friend
    {
        [Key]
        public int FriendId { get; set; }

        [Required]
        public string Nombre { get; set; }
        public string Nickname { get; set; }
        public string Birthday { get; set; }

    }
}