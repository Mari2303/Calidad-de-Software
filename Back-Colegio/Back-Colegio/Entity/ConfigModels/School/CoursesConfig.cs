//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using Entity.Model.School;
//using Entity.ConfigModels.global;

//namespace Entity.ConfigModels.School
//{
//    public class CoursesConfig : IEntityTypeConfiguration<Courses>
//    {
//        public void Configure(EntityTypeBuilder<Courses> builder)
//        {
//            builder.ToTable("courses", schema: "school");

//            builder.HasKey(p => p.Id);

//            builder.Property(p => p.Id)
//                .HasColumnName("id")
//                .IsRequired();
//            builder.Property(p => p.Name)
//                .HasColumnName("name")
//                .IsRequired()
//                .HasMaxLength(100);
//            builder.Property(p => p.descripcion)
//                .HasColumnName("description")
//                .IsRequired()
//                .HasMaxLength(100);

//            builder.Property(p => p.StartDate)
//               .HasColumnName("start_date")
//               .IsRequired();

//            builder.Property(p => p.EndDate)
//              .HasColumnName("end_date")
//              .IsRequired()
//              .HasMaxLength(100);

//            builder.MapBaseModel();
//        }
//    }
//}
