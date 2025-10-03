//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.EntityFrameworkCore;
//using Entity.Model.School;
//using Entity.ConfigModels.global;

//namespace Entity.ConfigModels.School
//{
//    public class EstudenstConfig : IEntityTypeConfiguration<Estudens>
//    {
//        public void Configure(EntityTypeBuilder<Estudens> builder)
//        {
//            builder.ToTable("estudens", schema: "school");

//            builder.HasKey(p => p.Id);

//            builder.Property(p => p.Id)
//                .HasColumnName("id")
//                .IsRequired();
//            builder.Property(p => p.Name)
//                .HasColumnName("name")
//                .IsRequired()
//                .HasMaxLength(100);
//            builder.Property(p => p.LastName)
//                .HasColumnName("lastName")
//                .IsRequired()
//                .HasMaxLength(100);

//            builder.Property(p => p.Birhtdate)
//               .HasColumnName("birhtdate")
//               .IsRequired()
//                .HasMaxLength(100);

//            builder.Property(p => p.Email)
//              .HasColumnName("email")
//              .IsRequired()
//              .HasMaxLength(100);

//            builder.MapBaseModel();

//            builder.HasData(
//                    new Estudens
//                    {
//                        Id = 1,
//                        Name = "Jesus",
//                        LastName = "Carvajal",
//                        Birhtdate = "1990-01-01",
//                        Email = "email@gmail.com",
//                    }
//              );
//        }
//    }
//}
