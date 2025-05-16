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
    public class EmployeeService : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;
        public EmployeeService(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;

        }

        
        public void Add(Employee entity)
        {
            _service.Add(entity);
        }

        public void Delete(Employee entity)
        {
            _service?.Delete(entity);       
        }

        public List<Employee> GetAll()
        {
            return _service.GetAll();
        }

        public Employee GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Employee entity)
        {
           _service.Update(entity);
        }
    }
}
