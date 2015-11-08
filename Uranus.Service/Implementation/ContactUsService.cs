using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;

namespace Uranus.Service.Implementation
{
    public class ContactUsService : IContactUsService
    {
        private readonly IContactUsRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public ContactUsService(IContactUsRepository contactUsRepository, IUnitOfWork unitOfWork)
        {
            this.repository = contactUsRepository;
            this.unitOfWork = unitOfWork;
        }
       

        public ContactUs Add(ContactUs objContactUs)
        {
            objContactUs = repository.Add(objContactUs);
            unitOfWork.Commit();
            return objContactUs;
        }

        public ContactUs Update(ContactUs entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(ContactUs entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<ContactUs> GetAll()
        {
            return repository.GetAll();
        }

        public ContactUs GetById(int id)
        {
            return repository.GetById(id); 
        }
    }
}
