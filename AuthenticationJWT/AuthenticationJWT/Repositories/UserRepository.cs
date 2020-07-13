using System.Linq;
using AuthenticationJWT.Models;
using System.Collections.Generic;

namespace AuthenticationJWT.Repositories
{
    public class UserRepository
    {

        /*
         * 1 - Diretor
         * 2 - Gerente
         * 3 - Colaborador
         */

        public static IList<User> Users = new List<User>
        {

            new User
            {
                Type = 1,
                Email = "lucas@eu.com",
                Name = "Lucas",
                Password = "123"
            },

            new User
            {
                Type = 2,
                Email = "mariana@eu.com",
                Name = "Mariana",
                Password = "123"
            },

            new User
            {
                Type = 2,
                Email = "gabriel@eu.com",
                Name = "Gabriel",
                Password = "123"
            },
        };


        public User GetByEmail(string email)
        {
            return Users.Where(x => x.Email.ToLower() == email.ToLower())
                .FirstOrDefault();
        }
    }
}
