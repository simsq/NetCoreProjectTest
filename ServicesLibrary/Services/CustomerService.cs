using ServicesLibrary.IServices;
using System.Collections.Generic;
using DataLibrary.Domain;
using DataLibrary.EFRepository;
using System.Linq;
using ServicesLibrary.Dto;
using AutoMapper;

namespace ServicesLibrary.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly IMapper _mapper;
        private readonly IRepository<Customer> _customerRepository;

        #region ctor

        public CustomerService(IMapper mapper, IRepository<Customer> customerRepository)
        {
            _mapper = mapper;
            _customerRepository = customerRepository;
        }
        #endregion 

        public void Add(CustomerDto customerDto)
        {
            var entity = _mapper.Map<CustomerDto, Customer>(customerDto);
            _customerRepository.Insert(entity);
        }

        public void Delete(CustomerDto customerDto)
        {
            var entity = _mapper.Map<CustomerDto, Customer>(customerDto);

            _customerRepository.Delete(entity);
        }

        public CustomerDto GetById(int id)
        {
            var data = _customerRepository.GetById(id);
            return _mapper.Map<Customer, CustomerDto>(data);

        }

        public List<CustomerDto> GetList()
        {
            var data = _customerRepository.Tabel.ToList();
            var result = _mapper.Map<List<Customer>, List<CustomerDto>>(data);
            return result;
        }

        public void Update(CustomerDto customerDto)
        {
            var entity = _mapper.Map<CustomerDto, Customer>(customerDto);
            _customerRepository.Update(entity);
        }
    }
}
