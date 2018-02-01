using DataLibrary.Domain;
using ServicesLibrary.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServicesLibrary.IServices
{
    public interface ICustomerService
    {

        void Add(Customer entity);

        void Delete(CustomerDto entity);

        void Update(CustomerDto customer);

        CustomerDto GetById(int id);

        List<CustomerDto> GetList();
    }
}
