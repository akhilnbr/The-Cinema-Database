using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace The_Cinema_Bucket.Models
{
    [Table("movieTb")]
    public class movie
    {

        public movie()
        {
            lisstMovies = new List<movie>();
        }


        [Key]
        public int id { get; set; }
        [DataType(DataType.Text, ErrorMessage = "enter a valid movie name")]
        public string movieName { get; set; }
        public int year { get; set; }
        public string plot { get; set; }
        public string posterurl { get; set; }
        public string actor1 { get; set; }
        public string actor2 { get; set; }
        public string actor3 { get; set; }
        public string producer { get; set; }
        public IEnumerable<movie> lisstMovies { get; set; }
        [NotMapped]
        public HttpPostedFileBase posterName { get; set; }

      
        
    }
    [Table("actors_tb")]
    public class Actors
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public DateTime dob { get; set; }
        public string bio { get; set; }
    }
    [Table("producer_tb")]

    public class Producers
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public DateTime dob { get; set; }
        public string bio { get; set; }
    }

}