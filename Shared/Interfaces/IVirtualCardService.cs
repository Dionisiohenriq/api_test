using api_test.Domain.Entities;
using apit_test.Application.ViewModels;
using System.ComponentModel.DataAnnotations;

namespace apit_test.Application.Interfaces
{
    public interface IVirtualCardService : IDisposable
    {
        Task<IEnumerable<VirtualCardViewModel>> GetAll();
        Task<VirtualCardViewModel> GetById(Guid id);
        Task<IEnumerable<VirtualCardViewModel>> GetAllBy(Func<VirtualCard, bool> exp);
        Task<ValidationResult> Add(VirtualCardViewModel vm);
        Task<ValidationResult> Update(VirtualCardViewModel vm);
        Task<ValidationResult> Remove(Guid id);
    }
}
