using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using The_Cinema_Bucket.Models;

namespace The_Cinema_Bucket.ViewModel
{
    public class MovieViewModel
    {
        public int actorId { get; set; }
       
        public string actorName { get; set; }
        [Required]
        public string actorSex { get; set; }
        [Required]
        public DateTime actorDob { get; set; }
        [Required]
        public string actorBio { get; set; }

        public int producerId { get; set; }
        [Required]
        public string producerName { get; set; }
        [Required]
        public string producerSex { get; set; }
        [Required]
        public DateTime produerDob { get; set; }
      
        public string producerbio { get; set; }

        
        public string movieName { get; set; }
        [Required, DataType(dataType: DataType.PhoneNumber, ErrorMessage = "enter a year")]
        public int year { get; set; }
        [Required, DataType(dataType: DataType.Text, ErrorMessage = "enter valid plot")]
        public string plot { get; set; }
        public string posterurl { get; set; }
        public string actor1 { get; set; }
        public string actor2 { get; set; }
        public string actor3 { get; set; }
        [Required,DataType(dataType:DataType.Text,ErrorMessage = "enter valid producer name")]
        public string producer { get; set; }
        public IEnumerable<movie> lisstMovies { get; set; }
        [NotMapped]
        public HttpPostedFileBase posterName { get; set; }



    }
}