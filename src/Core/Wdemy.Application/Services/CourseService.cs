﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wdemy.Application.Dtos.Course;
using Wdemy.Application.Interfaces.Services;
using Wdemy.Domain.Entities;
using Wdemy.Application.Utilities.Result;
using AutoMapper;
using Wdemy.Application.Interfaces.Repository;
using Wdemy.Application.Utilities.Result.Concrete;
using Wdemy.Application.Constant;
using Wdemy.Domain.Enums;

namespace Wdemy.Application.Services
{
    public class CourseService : ICourseService
    {
        private readonly IMapper _mapper;
        private readonly ICourseRepository _courseRepository;
        private readonly ITrainerService _trainerService;

        public CourseService(IMapper mapper, ICourseRepository courseRepository, ITrainerService trainerService)
        {
            _mapper = mapper;
            _courseRepository = courseRepository;
            _trainerService = trainerService;
        }

        public async Task<IDataResult<CourseDto>> GetByIdAsync(Guid id)
        {
            var course = await _courseRepository.GetByIdAsync(id);
            if (course == null)
            {
                return new ErrorDataResult<CourseDto>(Messages.CourseNotFound);
            }
            return new SuccessDataResult<CourseDto>(_mapper.Map<CourseDto>(course), Messages.FoundSuccess);

        }

        public async Task<IDataResult<CourseDto>> AddAsync(CourseCreateDto courseCreateDto)
        {
            var course = _mapper.Map<Course>(courseCreateDto);  

            try
            {
                var result = await _courseRepository.AddAsync(course);
            }
            catch (Exception)
            {
                return new ErrorDataResult<CourseDto>(Messages.AddFail);
            }

            return new SuccessDataResult<CourseDto>(_mapper.Map<CourseDto>(course), Messages.AddSuccess);
        }

        public Task<IResult> DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<CourseDto>>> GetAllAsync()
        {
            var allCourses = await _courseRepository.GetAllAsync();
            
            if(allCourses == null)
            {
                return new ErrorDataResult<List<CourseDto>>(Messages.CourseNotFound);
            }

            return new SuccessDataResult<List<CourseDto>>(_mapper.Map<List<CourseDto>>(allCourses), Messages.ListedSuccess);
        }

        public async Task<IDataResult<CourseDto>> UpdateAsync(CourseDto courseDto)
        {
            var updatedCourse = _mapper.Map<Course>(courseDto);
            await _courseRepository.UpdateAsync(updatedCourse);

            return new SuccessDataResult<CourseDto>(_mapper.Map<CourseDto>(updatedCourse), Messages.UpdateSuccess);
        }
    }
}
