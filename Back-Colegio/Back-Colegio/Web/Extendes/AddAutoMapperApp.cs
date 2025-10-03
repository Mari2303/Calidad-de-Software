namespace Web.Extendes
{
    public static class AddAutoMapperApp
    {
        public static IServiceCollection AddMapperApp(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(Utilities.MappersApp.School.CourseMap)); //agreagar el mappper
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            return services;
        }
    }
}
