using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserService _service;
        public void Add(User entity)
        {
            _service.Add(entity);
        }

        public void Delete(User entity)
        {
            _service?.Delete(entity);
        }

        public List<User> GetAll()
        {
            return _service.GetAll();
        }

        public User GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(User entity)
        {
            _service.Update(entity);
        }
    }
}
