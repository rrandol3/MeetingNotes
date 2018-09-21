using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;

namespace MeetingNotes1.DataAccess.EntityFramework
{
    public class EntityToBusinessProfile : Profile
    {
        public EntityToBusinessProfile()
        {
            CreateMap<Meeting, BusinessRules.Meeting>();
            CreateMap<BusinessRules.Meeting, Meeting>();
        }
    }
}
