﻿using AutoMapper;
using MongoDB.Driver;
using ShoppingNightMongo.Dtos.CategoryDtos;
using ShoppingNightMongo.Entities;
using ShoppingNightMongo.Settings;

namespace ShoppingNightMongo.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly IMapper _mapper;
        private readonly IMongoCollection<Category> _categoryCollection;

        public CategoryService(IMapper mapper,IDatabaseSetting _databaseSettings)
        {
            var clint = new MongoClient(_databaseSettings.ConnectionString);
            var database = clint.GetDatabase(_databaseSettings.DatabaseName);
            _categoryCollection = database.GetCollection<Category>(_databaseSettings.CategoryCollectionName);
            _mapper = mapper;
        }
        public async Task CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
           var value=_mapper.Map<Category>(createCategoryDto);
            await _categoryCollection.InsertOneAsync(value);
        }
        public async Task DeleteCategoryDto(string id)
        {
            await _categoryCollection.DeleteOneAsync(id);
        }
        public async Task<List<ResultCategoryDto>> GetAllCategoryAsync()
        {
            var value = await _categoryCollection.Find(x => true).ToListAsync();
            return _mapper.Map<List<ResultCategoryDto>>(value);
            
        }
        public async Task<GetCategoryByIdDto> GetCategoryByIdAsync(string id)
        {
            var value = await _categoryCollection.Find(x => x.CategoryId == id).FirstOrDefaultAsync();
            return _mapper.Map<GetCategoryByIdDto>(value);
        }

        public Task<List<ResultCategoryDto>> GetResultCategoryDtosAsync()
        {
            throw new NotImplementedException();
        }

        public async Task UpdateCategoryDto(UpdateCategoryDto UpdateCategoryDto)
        {
           var value = _mapper.Map<Category>(UpdateCategoryDto);
            await _categoryCollection.FindOneAndReplaceAsync(x=>x.CategoryId==UpdateCategoryDto.CategoryId, value);
        }
    }
}
