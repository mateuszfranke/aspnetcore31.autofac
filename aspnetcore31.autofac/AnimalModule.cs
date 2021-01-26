using aspnetcore31.autofac.model;
using Autofac;

namespace aspnetcore31.autofac
{
    public class AnimalModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // builder.RegisterType<Cat>().As<IAnimal>().InstancePerLifetimeScope();
            builder.RegisterType<Cat>()
                .As<IAnimal>()
                .Keyed<IAnimal>("cat");
            builder.RegisterType<Dog>()
                .As<IAnimal>()
                .Keyed<IAnimal>("dog");
        }
    }
}