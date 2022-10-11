using api_test.Domain.Entities;
using apit_test.Application.Interfaces;
using apit_test.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apit_test.Application.Services
{
    public class VirtualCardService : IVirtualCardService
    {
        public Task<ValidationResult> Add(VirtualCardViewModel vm)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VirtualCardViewModel>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<VirtualCardViewModel>> GetAllBy(Func<VirtualCard, bool> exp)
        {
            throw new NotImplementedException();
        }

        public Task<VirtualCardViewModel> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<ValidationResult> Update(VirtualCardViewModel vm)
        {
            throw new NotImplementedException();
        }
    }
}
