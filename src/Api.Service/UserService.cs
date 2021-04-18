using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Api.Domain.Entities;
using Api.Domain.Interfaces;
using Api.Domain.Interfaces.Services.User;

namespace Api.Service
{
    public class UserService : IUserService
    {
        private readonly IRepository<UserEntity> _repository;
        public UserService(IRepository<UserEntity> repository)
        {
            _repository = repository;
        }
        public async Task<bool> Delete(Guid id)
        {
            return await _repository.DeleteAsync(id).ConfigureAwait(false);
        }

        public async Task<UserEntity> Get(Guid id)
        {
            return await _repository.SelectAsync(id).ConfigureAwait(false);
        }

        public async Task<IEnumerable<UserEntity>> GetAlll()
        {
            return await _repository.SelectAsync().ConfigureAwait(false);
        }

        public async Task<UserEntity> Post(UserEntity user)
        {
            return await _repository.InsertAsync(user).ConfigureAwait(false);
        }

        public async Task<UserEntity> Put(UserEntity user)
        {
            return await _repository.UpdateAsync(user).ConfigureAwait(false);
        }
    }
}