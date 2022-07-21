using Autofac;
using Blogden.Core.Repositories;
using Blogden.Core.Services;
using Blogden.Core.UnitOfWork;
using Blogden.Repository.DbContexts;
using Blogden.Repository.Repositories;
using Blogden.Repository.UnitOfWorks;
using Blogden.Service.Mappings;
using Blogden.Service.Services;
using System.Reflection;
using Module = Autofac.Module;

namespace Blogme.Web.API.Modules
{
    public class DbTransferModule : Module
    {
        protected override void Load(Autofac.ContainerBuilder builder)
        {
            // To register a generic type like Repository<> we need to use builder.RegisterGeneric(). Otherwise use builder.RegisterType() instead.
            builder.RegisterGeneric(typeof(GenericRepository<>)).As(typeof(IGenericRepository<>)).InstancePerLifetimeScope();
            builder.RegisterGeneric(typeof(GenericService<>)).As(typeof(IGenericService<>)).InstancePerLifetimeScope();

            builder.RegisterType(typeof(AuthorRepository)).As(typeof(IAuthorRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(AuthorService)).As(typeof(IAuthorService)).InstancePerLifetimeScope();

            builder.RegisterType(typeof(BlogRepository)).As(typeof(IBlogRepository)).InstancePerLifetimeScope();
            builder.RegisterType(typeof(BlogService)).As(typeof(IBlogService)).InstancePerLifetimeScope();

            builder.RegisterType<UnitOfWork>().As<IUnitOfWork>().InstancePerLifetimeScope();

            // types must be a constant member of those assemblies.
            var apiAssembly = Assembly.GetExecutingAssembly();
            var repositoryAssembly = Assembly.GetAssembly(typeof(MSSqlDbContext));
            var serviceAssembly = Assembly.GetAssembly(typeof(MapProfile));
        }
    }
}
