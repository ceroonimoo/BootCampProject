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
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        private readonly IMapper _mapper;
        public InstructorService(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;

        }
        public void Add(Instructor entity)
        {
            _service.Add(entity);
        }

        public void Delete(Instructor entity)
        {
            _service?.Delete(entity);
        }

        public List<Instructor> GetAll()
        {
            return _service.GetAll();
        }

        public Instructor GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Instructor entity)
        {
            _service.Update(entity);
        }
    }
}
