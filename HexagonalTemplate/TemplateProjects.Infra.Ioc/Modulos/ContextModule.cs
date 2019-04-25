using $ext_projectname$.Infra.Data;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace $safeprojectname$.Modulos
{
    public class ContextModule
    {
        public static Container RegisterContexts(Container containerToInject)
        {
            containerToInject.Register<IDbConnectionFactory>(() => new SqlConnectionFactory());
            return containerToInject;
        }
    }
}
