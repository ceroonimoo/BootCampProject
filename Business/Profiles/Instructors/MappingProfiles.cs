using AutoMapper;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Requests.Instructor;
using Business.Dtos.Responses;
using Business.Dtos.Responses.Instructor;
using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Instructors
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Instructor, CreateInstructorRequest>().ReverseMap();
            CreateMap<Instructor, CreatedInstructorResponse>().ReverseMap();
            CreateMap<Instructor, GetListInstructorResponse>().ReverseMap();
        }
    }
}
