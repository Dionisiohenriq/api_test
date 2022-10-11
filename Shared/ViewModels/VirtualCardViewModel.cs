using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apit_test.Application.ViewModels
{
    public class VirtualCardViewModel
    {
        [Key]
        public int Id { get; set; }
        public string Email { get; set; }
        public string CardNumber { get; set; }
    }
}
