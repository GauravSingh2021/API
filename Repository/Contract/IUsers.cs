using DemoAPI.Contracts.Request;
using DemoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoAPI.Repository.Contract
{
    public interface IUsers
    {
        Users SignIn(SignInModel model);
        Users SignUp(SignUpModel model);
    }
}
