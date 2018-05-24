 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Higgs.Mbale.BAL.Interface;
using Higgs.Mbale.BAL.Concrete;
using Higgs.Mbale.DAL.Concrete;
using Higgs.Mbale.DAL.Interface;
using Ninject.Modules;

namespace Higgs.Mbale.DependencyResolver
{
 public   class ServiceDependencyResolver : NinjectModule
    {
       
     public override void Load()
     {
         //BAL
         Bind(typeof(IUserService)).To(typeof(UserService));



         //DAL
         Bind(typeof(IUserDataService)).To(typeof(UserDataService));
     } 
        
          
    }
}
