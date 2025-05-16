using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Business.Dtos.Requests.Applicant;
using Business.Dtos.Responses.Applicant;
using Entity;

namespace Business.Profiles.Applicants
{
    public class MappingProfiles:Profile
    {
        public MappingProfiles()
        {
            CreateMap<Applicant, CreateApplicantRequest>().ReverseMap();
            CreateMap<Applicant, CreatedApplicantResponse>().ReverseMap();
            CreateMap<Applicant, GetListApplicantResponse>().ReverseMap();
        }
    }
}
