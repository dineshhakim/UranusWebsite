using System;
using System.Collections.Generic;
using Uranus.Data.Abstract;
using Uranus.Data.Infrastucture;
using Uranus.Domain.Entities;
using Uranus.Service.Abstract;
using Uranus.Service.Utility;

namespace Uranus.Service.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository repository;
        private readonly IUnitOfWork unitOfWork;
        public UserService(IUserRepository repository, IUnitOfWork unitOfWork)
        {
            this.repository = repository;
            this.unitOfWork = unitOfWork;
        }


        public User Add(User entity)
        {

            entity.Password = EncryptionHelper.Encrypt(entity.Password);
            User entity1 = entity;
            var user = repository.Get(x => (x.UserName == entity1.UserName));
            if (user != null)
            {
                user.UserName = CustomErrorHelper.UserAlreadyExist;
                return user;
            }
            user = repository.Get(x => (x.EmailId == entity1.EmailId));
            if (user != null)
            {
                user.EmailId = CustomErrorHelper.EmailAlreadyExist;
                return user;
            }
            entity = repository.Add(entity);
            unitOfWork.Commit();
            return entity;
        }

        public User Update(User entity)
        {
            entity = repository.Update(entity);
            unitOfWork.Commit();
            return entity;
        }

        public void Delete(User entity)
        {
            repository.Delete(entity);
            unitOfWork.Commit();
        }

        public IEnumerable<User> GetAll()
        {
            return repository.GetAll();
        }

        public User GetById(int id)
        {
            return repository.GetById(id);
        }

        public bool CheckLogin(User entity)
        {
            // Func<User, bool> userfunc = x => (entity.UserName == x.UserName) ;
            var user = repository.Get(x => (entity.UserName == x.UserName));
            if (user == null)
            {
                return false;
            }
            if (user.Active == false)
            {
                return false;
            }
            return EncryptionHelper.Encrypt(entity.Password) == user.Password;
        }
    }
}