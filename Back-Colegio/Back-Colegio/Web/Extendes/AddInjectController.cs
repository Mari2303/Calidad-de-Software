using Business.Implements.Bases;
using Business.Implements.CQRS.Command;
using Business.Implements.Querys.Security;
using Business.Interfaces.Commands;
using Business.Interfaces.Querys;
using Data.Implements.Command;
using Data.Implements.Commands;
using Data.Implements.Querys;
using Data.Implements.Querys.Security;
using Data.Interfaces.Group.Commands;
using Data.Interfaces.Group.Querys;
using Utilities.Helpers.Validations;
using Utilities.Helpers.Validations.implemets;

namespace Web.Extendes
{
    public static class AddInjectController
    {
        public static IServiceCollection AddInject(this IServiceCollection services)
        {

            services.AddScoped(
                  typeof(IQuerys<>),
                  typeof(BaseGenericQuerysData<>)
            );




            services.AddScoped(
                typeof(ICommands<>),
                typeof(BaseGenericCommandsData<>)
            );

            services.AddScoped(
                  typeof(IQueryServices<,>),
                  typeof(BaseQueryBusiness<,>)
            );


            services.AddScoped(
                typeof(ICommandService<,>),
                typeof(BaseCommandsBusiness<,>)
            );


            // muncipality
            //services.AddScoped<IQuerysMunicipality, MunicipalityQueryData>();
            //services.AddScoped<IQueryMunicipalityServices, MunicipalityQueryBusiness>();


            services.AddScoped<IQuerysTution, TutuionQueryData>();
            services.AddScoped<IQueryTutionServices, TutionQueryBusiness>();

            services.AddScoped<ICommandStuden, StudentCommandData>();

            services.AddScoped<IQuerysCourse, CourseQueryData>();
            services.AddScoped<IQueryCourseServices, CourseQueryBusiness>();
        
            services.AddScoped<RepartoCommandBusiness>();


            //IQuerysTution
            //ICommandStuden
            //IQuerysCourse



            services.AddScoped<IGenericHerlpers, GenericHelpers>();
            //services.AddScoped(typeof(IBaseBusiness<,>), typeof(BaseQueryBusiness<,>));
            //services.AddScoped(typeof(IBaseModelData<>), typeof(BaseModelData<>));
            //services.AddScoped<IBaseModelData<RolFormPermission>, RolFormPermissionData>();
            //services.AddScoped<IBaseBusiness<RolFormPermission, RolFormPermissionDto>, RolFormPermissionBussines>();
            //services.AddScoped<RolFormPermissionBussines>();


            return services;

        }
    }
}
