using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.Domain.Model
{
    public class EmailTemplateParams
    {
        public string Tittle { get; set; }
        public string LineOne { get; set; }
        public string LineTwo { get; set; }
        public string ActionLink { get; set; }
        public string ActionName { get; set; }
    }
}
