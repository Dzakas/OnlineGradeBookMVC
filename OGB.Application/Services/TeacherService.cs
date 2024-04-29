using AutoMapper;
using AutoMapper.QueryableExtensions;
using OGB.Application.Interfaces;
using OGB.Application.ViewModels.Class1A;
using OGB.Application.ViewModels.Teachers;
using OGB.Domain.Interfaces;
using OGB.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OGB.Application.Services
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        private readonly IMapper _mapper;

        public TeacherService(ITeacherRepository teacherRepository, IMapper mapper)
        {
            _teacherRepository = teacherRepository;
            _mapper = mapper;
        }
        public ListTeacherForListVm GetAllTeachers()
        {
            var teachers = _teacherRepository.GetAllTeachersInfo()
                .ProjectTo<TeacherForListVm>(_mapper.ConfigurationProvider).ToList();

            var teachersList = new ListTeacherForListVm()
            {
                _Teachers = teachers,
                Count = teachers.Count
            };
            return teachersList;
        }

        public ListTeacherAddressForListVm GetAllTeachersAddress()
        {
            var teachersAddress = _teacherRepository.GetAllTeachersInfo()
                .ProjectTo<TeacherAddressForListVm>(_mapper.ConfigurationProvider).ToList();

            var teachersAddressList = new ListTeacherAddressForListVm()
            {
                TeacherAddresses = teachersAddress,
                Count = teachersAddress.Count
            };
            return teachersAddressList;
        }

        public ListTeacherContactInfoForListVm GetAllTeachersContactInfo()
        {
            var teachersContactInfo = _teacherRepository.GetAllTeachersInfo()
                 .ProjectTo<TeacherContactInfoForListVm>(_mapper.ConfigurationProvider).ToList();

            var teachersContactInfoList = new ListTeacherContactInfoForListVm()
            {
                TeacherContactInfos = teachersContactInfo,
                Count = teachersContactInfo.Count
            };
            return teachersContactInfoList;
        }
    }
}
