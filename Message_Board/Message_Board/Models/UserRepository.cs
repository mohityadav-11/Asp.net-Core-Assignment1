using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Message_Board.Models
{
    public class UserRepository: IUserRepository
    {
        private readonly AppDbContext _appDbContext;

        public UserRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<Users> AllUsers
        {
            get
            {
                return _appDbContext.Users;
            }
        }
    }
}
