using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Modulos
{
    public class ApplicationModule
    {
        public static Container RegisterServices(Container containerToInject)
        {
            //containerToInject.Register<IYourAppServiceInterface, YourAppServiceImplementation>();            
            return containerToInject;
        }
    }
}
