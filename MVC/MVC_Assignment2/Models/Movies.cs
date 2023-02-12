
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace MVC_Assignment2.Models
{
    [Table("Movie")]
    public class Movies
    {
        [Key]
        public int Mid { get; set; }
        [DisplayName("Movie")]
        public string Moviename { get; set; }
        [DisplayName("Release Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateofRelease { get; set; }
    }
}