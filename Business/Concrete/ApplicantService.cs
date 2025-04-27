using Business.Abstract;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicantService : IApplicantService
    {private readonly IApplicantService _service;
        public void Add(Applicant entity)
        {
            _service.Add(entity);
        }

        public void Delete(Applicant entity)
        {
            _service?.Delete(entity);
        }

        public List<Applicant> GetAll()
        {
           return _service.GetAll();
        }

        public Applicant GetById(int id)
        {
            return _service.GetById(id);
        }

        public void Update(Applicant entity)
        {
            _service.Update(entity);
        }
    }
}
