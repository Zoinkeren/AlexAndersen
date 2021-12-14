using Alex_Andersen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Alex_Andersen.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();
        
        public SecurityService()
        {
          
        }

        public bool IsValid(User user)
        {
            return usersDAO.FindUserByNameAndPassword(user);
            //return true if found in the list
        
        }

    }
        
    
}
