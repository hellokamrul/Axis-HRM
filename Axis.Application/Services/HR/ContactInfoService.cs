﻿using AutoMapper;
using Axis.Application.DTOs.HR;
using Axis.Application.Services.IServices;
using Axis.Application.Services.IServices.HR;
using Axis.Core.Models.HR;
using Axis.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.HR.Services
{
    public class ContactInfoService : IContactInfoService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ContactInfoService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<bool> Add(ContactInfoDTO model)
        {
            try
            {
                ContactInfo data =  _mapper.Map<ContactInfo>(model);
                data.Id = Guid.NewGuid().ToString();
                _unitOfWork.ContactInfo.Add(data);
                _unitOfWork.save();
                return true;

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding employee: {ex.Message}");
                return false;
            }
        }

        public async Task<ContactInfo> Update(ContactInfoDTO model)
        {
            try
            {
                var empData = _unitOfWork.ContactInfo.GetById(model.Id);

                if (empData != null)
                {
                    // Update existing employee fields
                    // empData.ComId = employee.ComId;

                    empData.Notes = model.Notes;

                    _unitOfWork.ContactInfo.Edit(empData);
                }
                else
                {
                    // If employee does not exist, create a new one
                    empData = _mapper.Map<ContactInfo>(model);
                    _unitOfWork.ContactInfo.Add(empData);
                }


                _unitOfWork.save();

                return empData;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error updating employee: {ex.Message}");
                return null;
            }
        }

        public async Task<ContactInfoDTO> GetById(string id)
        {
            try
            {
                var data = _unitOfWork.ContactInfo.GetById(id);
                ContactInfoDTO employee = _mapper.Map<ContactInfoDTO>(data);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public Task<IEnumerable<ContactInfo>> GetListByComid(string comid)
        {
            try
            {
                var data = _unitOfWork.ContactInfo.GetAll().Where(x => x.EmpId == comid);
                return Task.FromResult(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public async Task<bool> Delete(string id)
        {
            try
            {
                var data = _unitOfWork.ContactInfo.GetById(id);
                if (data != null)
                {
                    _unitOfWork.ContactInfo.Remove(data);
                    _unitOfWork.save();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public (IList<ContactInfo> data, int total, int totalDisplay) GetListWithCount(string comid, int pageIndex = 1, int pageSize = 10, bool isTrackingOff = false)
        {
            throw new NotImplementedException();
        }
    }
}
