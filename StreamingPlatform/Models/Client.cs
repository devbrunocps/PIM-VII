using System;
using System.ComponentModel.DataAnnotations;

namespace StreamingPlatform.Models
{
    public class Client
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string RG { get; set; }
        [Required]
        public string CPF { get; set; }
        [Required]
        public string Name { get; set; }
        public DateTime RegistrationDate { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Phone { get; set; }
        [Required]
        public string Email { get; set; }
    }
}
