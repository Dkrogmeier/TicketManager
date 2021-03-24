using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace TicketManager.Models
{
    public class Ticket
    {
        [Key]
        [Display(Name = "Ticket ID")]
        public int TicketID { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Ticket Type")]
        public string WOTicketType { get; set; }

        //public List<SelectListItem> TicketTypes { get; } = new List<SelectListItem>
        //{
        //    new SelectListItem { Value = "request", Text = "Request" },
        //    new SelectListItem { Value = "repair", Text = "Repair" },
        //    new SelectListItem { Value = "preventative", Text = "Preventative" },
        //    new SelectListItem { Value = "inspection", Text = "Inspection" },
        //};

        //public IEnumerable<SelectListItem> WOTypes { get; set; }

        [Display(Name = "Assigned To")]
        public string AssignedTo { get; set; }

        [Display(Name = "Requested By")]
        public string RequestedBy { get; set; }
        
        [StringLength(75)]
        public string Notes { get; set; }

        [Display(Name = "Date Created")]
        public string DateAdded { get; set; }



        public Ticket()
            {

            }
    }
}
