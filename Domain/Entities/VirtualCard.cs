using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace api_test.Domain.Entities
{
    public class VirtualCard : Entity, IEntityTypeConfiguration<VirtualCard>
    {
        public string Email { get; private set; }
        public string CardNumber { get; private set; }

        public VirtualCard(Guid id) => Id = id;
        public VirtualCard(string email, string cardNumber)
        {
            Email = email;
            CardNumber = cardNumber;
        }   

        public void Configure(EntityTypeBuilder<VirtualCard> builder)
        {
            builder.HasKey(_ => _.Id);
            builder.Property(_ => _.Email).IsRequired();
        } 
    }
}
