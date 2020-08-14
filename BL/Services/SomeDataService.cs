using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;
using AutoMapper;
using BL.Dto;
using Data;
using Data.Entities;
using Data.Repository;

namespace BL.Services
{
    public class SomeDataService : ISomeDataService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;
        public SomeDataService(IMapper mapper, IUnitOfWork unitOfWork, DatabaseContext context)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }
        public SomeDataDto GetById(int id)
        {
            var data = _unitOfWork.SomeDataRepository.GetById(id);
            if(data == null) throw new Exception("Data not found");
            return _mapper.Map<SomeDataDto>(data);
        }

        public List<SomeDataDto> GetAll()
        {
            var data = _unitOfWork.SomeDataRepository.GetAll();
            if(data == null) throw new Exception("Data not found");
            return _mapper.Map<List<SomeDataDto>>(data);
        }

        public SomeDataUpdateDto Update(SomeDataUpdateDto model)
        {
            try
            {
                var data = _mapper.Map<SomeData>(model);
                _unitOfWork.SomeDataRepository.Update(data);
                return model;
            }
            catch (DbException)
            {
                throw new Exception("Update exception");
            }
        }

        public SomeDataAddDto Add(SomeDataAddDto model)
        {
            try
            {
                var data = _mapper.Map<SomeData>(model);
                _unitOfWork.SomeDataRepository.Add(data);
                return model;
            }
            catch (DbException)
            {
                throw new Exception("Add exception");
            }
        }

        public void Remove(int id)
        {
            try
            {
                var data = _unitOfWork.SomeDataRepository.GetById(id);
                if(data == null) throw new Exception("Data not found");
                _unitOfWork.SomeDataRepository.Remove(data);
            }
            catch (DbException)
            {
                throw new Exception("Remove exception");
            }
        }
    }
}
