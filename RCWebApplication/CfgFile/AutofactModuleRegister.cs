using Autofac;
using System.Reflection;

namespace RCWebApplication.CfgFile
{
    public class AutofactModuleRegister : Autofac.Module
    {
        public AutofactModuleRegister() { }
        // 注册接口和实现之间的关系，将interface和service关联起来
        protected override void Load(ContainerBuilder builder)
        {
            Assembly interfaceAssembly = Assembly.Load("Interface");
            Assembly serviceAssembly = Assembly.Load("Service");
            builder.RegisterAssemblyTypes(interfaceAssembly, serviceAssembly).AsImplementedInterfaces();

        }

    }
}
