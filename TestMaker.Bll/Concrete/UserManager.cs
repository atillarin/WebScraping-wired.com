using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestMaker.Bll.Abstract;
using TestMaker.Dal.Abstract;
using TestMaker.Dal.Concrete.EntityFramework.Repository;
using TestMaker.Entity.Concrete;
using TestMaker.Entity.Concrete.Dto;
using TestMaker.Entity.Concrete.Mapper;
using TestMaker.Entity.Concrete.Model;

namespace TestMaker.Bll.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;
        
        public UserManager(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public Response Add(UserDto dto)
        {
            throw new NotImplementedException();
        }

        public Response Delete(long id)
        {
            throw new NotImplementedException();
        }

        public Response<UserSessionDto> Find(string user, string pass)
        {
            try
            {
                var result= userRepository.Find(user, pass);
                if (result != null)
                {
                    return new Response<UserSessionDto>
                    {
                        StatusCode = StatusCodes.Status200OK,
                        Message = "Giriş Başarılı",
                        Data = ObjectMapper.Mapper.Map<UserSessionDto>(result)
                    };
                }else
                {
                    return new Response<UserSessionDto>
                    {
                        StatusCode = StatusCodes.Status401Unauthorized,
                        Message = "Kullanıcı veya Şifre Hatalı",
                        Data = null
                    };
                }
                
            }
            catch (Exception ex)
            {
               return new Response<UserSessionDto>
               {
                    StatusCode = StatusCodes.Status500InternalServerError,
                    Message = $"Error:{ex.Message}",
                    Data = null
                };
            }
            
        }
    }
}
