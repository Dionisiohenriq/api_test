using api_test.Domain.Commands.Inputs;
using api_test.Domain.Commands.Results;
using api_test.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace api_test.Domain.Handlers
{
    public class GenerateVirtualCardHandler
    {
        // Validate Command
        // Generate a random card number 
        // Create the entity and save in the db
        // Create command result and return
        public GenerateVirtualCardCommandResult? Handle(GenerateVirtualCardCommand command)
        {

            command.Validate();

            if (!command.IsValid)
                return null;


            string cardNumber = string.Empty;

            for(int i = 0; i < 4; i++)
            {
                Random random = new Random();
                string cardBlock = $"{random.Next(1000, 9999)}";
                cardNumber = $"{cardNumber + cardBlock}";
            }

            VirtualCard virtualCard = new VirtualCard(command.Email, cardNumber);
            var result = new GenerateVirtualCardCommandResult(command.Email, cardNumber);

            return result;
        }
    }
}
