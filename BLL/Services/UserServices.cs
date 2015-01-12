using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    class UserServices
    {
        private readonly IUnitOfWork uow;
        private readonly IUserRepository userRepository;
        public UserService(IUnitOfWork uow, IUserRepository repository)
        {
            this.uow = uow;
            this.userRepository = repository;
            //Debug.WriteLine("service create!");
        }
        public IEnumerable<UserEntity> GetAllUserEntities()
        {
            //using (uow)
            {
                return userRepository.GetAll().Select(user => user.ToBllUser());
            }
        }
        public void CreateUser(UserEntity user)
        {
            userRepository.Create(user.ToDalUser());
            uow.Commit();
        }
    }
}
