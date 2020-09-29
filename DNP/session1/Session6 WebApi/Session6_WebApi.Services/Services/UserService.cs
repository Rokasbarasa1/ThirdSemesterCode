using AutoMapper;
using Session6_WebApi.API.Common.Settings;
using Session6_WebApi.Services.Contracts;
using Session6_WebApi.Services.Model;
using Microsoft.Extensions.Options;
using System;
using System.Threading.Tasks;

namespace Session6_WebApi.Services
{
    public class UserService : IUserService
    {
        private AppSettings _settings;
        private readonly IMapper _mapper;

        public UserService(IOptions<AppSettings> settings, IMapper mapper)
        {
            _settings = settings?.Value;
            _mapper = mapper;
        }

        public async Task<User> CreateAsync(User user)
        {
            return user;
        }

        public async Task<bool> UpdateAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<bool> DeleteAsync(string id)
        {
            throw new NotImplementedException();
        }

        public async Task<User> GetAsync(string id)
        {
            throw new NotImplementedException();
        }
    }
}
