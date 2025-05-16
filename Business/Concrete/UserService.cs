using AutoMapper;
using Business.Abstract;
using Entity;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;
        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;

        }
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
