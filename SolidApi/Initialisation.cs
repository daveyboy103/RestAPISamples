using System;
using Autofac;
using SolidApi.Interfaces;
using SolidApi.Microservices;

namespace SolidApi
{
    public static class Initialisation
    {
        public static Autofac.IContainer Container { get; }

        static Initialisation()
        {
            Container = ContainerConfiguration.Configure();
        }
    }

    public static class ContainerConfiguration
    {
        public static IContainer Configure()
        {
            var builder = new Autofac.ContainerBuilder();

            builder.RegisterType<DataAccess.DataAccess>().As<IDataAccess>();
            builder.RegisterType<PersonCreationManagementService>().As<IPersonCreationManagement>().SingleInstance();
            builder.RegisterType<PersonDeletionManagementService>().As<IPersonDeletionManagement>().SingleInstance();
            builder.RegisterType<PersonRetrievalManagementService>().As<IPersonRetrievalManagement>().SingleInstance();
            builder.RegisterType<PersonUpdateManagementService>().As<IPersonUpdateManagement>().SingleInstance();

            return builder.Build();
        }
    }
}