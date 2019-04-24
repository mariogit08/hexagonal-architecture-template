using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Modulos
{
    public class RepositoryModule
    {
        public static Container RegisterRepositories(Container containerToInject)
        {

            //containerToInject.Register<IYourInterfaceRepository, YourRepositoryImplementation>();
            return containerToInject;
        }
    }
}