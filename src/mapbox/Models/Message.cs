using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mapbox.Models
{
    public class Message
    {
        [Key]
        public int Id { get; set; }
        public string Locaton { get; set; }
        public string When { get; set; }
        public string Comment { get; set; }

        public Message() { }
    }
}
