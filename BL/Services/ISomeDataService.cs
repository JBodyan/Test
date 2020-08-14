using System;
using System.Collections.Generic;
using System.Text;
using BL.Dto;

namespace BL.Services
{
    public interface ISomeDataService
    {
        SomeDataDto GetById(int id);
        List<SomeDataDto> GetAll();
        SomeDataUpdateDto Update(SomeDataUpdateDto model);
        SomeDataAddDto Add(SomeDataAddDto model);
        void Remove(int id);
    }
}
