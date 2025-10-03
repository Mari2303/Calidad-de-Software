//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using Entity.Model.School;
//using Entity.ConfigModels.global;

//namespace Entity.ConfigModels.School
//{
//    public class MatriculaConfig : IEntityTypeConfiguration<Matricula>
//    {
//        public void Configure(EntityTypeBuilder<Matricula> builder)
//        {
//            builder.ToTable("matricula", schema: "school");

//            builder.HasKey(p => p.Id);

//            builder.Property(p => p.Id)
//                .HasColumnName("id")
//                .IsRequired();

//            builder.Property(p => p.EstudentId)
//                .HasColumnName("student_id")
//                .IsRequired();

//            builder.Property(p => p.CourseId)
//                .HasColumnName("course_id")
//                .IsRequired();

//            builder.HasOne(ur => ur.Courses)
//             .WithMany(r => r.Matricula)
//             .HasForeignKey(ur => ur.CourseId)
//             .OnDelete(DeleteBehavior.Restrict);

//            builder.HasOne(ur => ur.Estudens)
//             .WithMany(r => r.Matricula)
//             .HasForeignKey(ur => ur.EstudentId)
//             .OnDelete(DeleteBehavior.Restrict);


//            builder.MapBaseModel();
//        }
//    }
//}
