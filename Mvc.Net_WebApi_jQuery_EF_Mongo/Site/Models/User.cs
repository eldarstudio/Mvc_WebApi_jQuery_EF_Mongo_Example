using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Site.Models
{
    public class User
    {
        [Key]
        [BsonId]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "50 chars string only")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "50 chars string only")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Required")]
        [EmailAddress(ErrorMessage="Email not valid")]
        [StringLength(200, ErrorMessage = "200 chars string only")]
        public string Email { get; set; }

        public DateTime? InsertDate { get; set; }
    }
}
