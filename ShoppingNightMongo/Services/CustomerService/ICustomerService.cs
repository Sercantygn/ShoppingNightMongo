﻿using ShoppingNightMongo.Dtos.CustomerDtos;

namespace ShoppingNightMongo.Services.CustomerService
{
    public interface ICustomerService
    {
        Task<List<ResultCustomerDto>> GetAllCustomerAsync();
        Task CreateCustomerAsync(CreateCustomerDto createCustomerDto);
        Task UpdateCustomerAsync(UpdateCustomerDto updateCustomerDto);
        Task DeleteCustomerAsync(string customerId);
        Task<GetCustomerByIdDto> GetCustomerByIdAsync(string customerId);

    }
}
