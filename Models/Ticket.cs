using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TicketManager.Models
{
    public class Ticket
    {
        [Key]
        [Display(Name = "Ticket ID")]
        public int TicketID { get; set; }
        
        [Required]
        public string Title { get; set; }
        [Display(Name = "Ticket Type")]
        public TicketTypeEnum WOTicketType { get; set; }
        [Display(Name = "Assigned To")]
        public string AssignedTo { get; set; }
        [Display(Name = "Requested By")]
        public string RequestedBy { get; set; }
        public string Notes { get; set; }
        public string Status { get; set; }

        public Ticket()
        {

        }
    }
    public enum TicketTypeEnum
    {
        Preventative,
        Inspection,
        Repair
    }
}
