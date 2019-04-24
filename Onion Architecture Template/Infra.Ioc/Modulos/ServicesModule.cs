using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Modulos
{
    public class ServicesModule
    {
        public static Container RegisterServices(Container containerToInject)
        {
            //containerToInject.Register<IYourServiceInterface, YourServiceImplementation>();            
            return containerToInject;
        }
    }
}
