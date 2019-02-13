using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace jmdbase.Models
{
    public class Client
    {
        public int ClientId { get; set; }

        [Required]
        [Display(Name = "Customer Name")]
        public string CustomerName { get; set; }
        [Display(Name = "Date Of Birth")]
        public DateTimeOffset DateOfBirth { get; set; }        
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        [Display(Name = "Mobile No.")]
        public string Phone { get; set; }
        public string Email { get; set; }
        [Display(Name = "Pin Code")]
        public int ACCNO { get; set; }
        [Display(Name = "Pan No.")]
        public string PanNo { get; set; }
        [Display(Name = "Father's Name")]
        public string FatherName { get; set; }
        public decimal Balance { get; set; }
    }

}


