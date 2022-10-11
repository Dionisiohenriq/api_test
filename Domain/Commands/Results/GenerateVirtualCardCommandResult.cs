using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.Domain.Commands.Results
{
    public class GenerateVirtualCardCommandResult
    {
        public GenerateVirtualCardCommandResult(string email, string cardNumber)
        {
            Email = email;
            CardNumber = cardNumber;
        }

        public string Email { get; set; }
        public string CardNumber{ get; set; }
    }
}
