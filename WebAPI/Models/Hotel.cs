using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Hotel
    {

        public int Id { get; set; }
        [Required, StringLength(80)]
        public string Name { get; set; }
        [Required, StringLength(120)]
        public string Address { get; set; }
        [Required, StringLength(80)]
        public string City { get; set; }
        [Required, StringLength(80)]
        public string County { get; set; }
        [Required, StringLength(20)]
        public string Phone { get; set; }


        public string UserId { get; set; }
        [ForeignKey("UserId")]
        public ApplicationUser User { get; set; }

    }
}