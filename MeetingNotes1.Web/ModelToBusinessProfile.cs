using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using MeetingNotes1.Web.Models;

namespace MeetingNotes1.Web
{
    public class ModelToBusinessProfile : Profile
    {
        public ModelToBusinessProfile()
        {
            CreateMap<MeetingModel, BusinessRules.Meeting>();
            CreateMap<BusinessRules.Meeting, MeetingModel>();
        }
    }
}