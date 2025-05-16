using AutoMapper;
using Business.Abstract;
using Entity;
using Repositories;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ApplicantService : IApplicantService
    {private readonly IApplicantRepository _applicantRepository; 
        private readonly IMapper _mapper;
        public ApplicantService(IApplicantRepository applicantRepository , IMapper mapper)
        {
            _applicantRepository = applicantRepository;
            _mapper = mapper;
            
        }
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
