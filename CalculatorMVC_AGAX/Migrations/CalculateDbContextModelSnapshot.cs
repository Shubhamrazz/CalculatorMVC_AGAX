// <auto-generated />
using CalculatorMVC_AGAX.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CalculatorMVC_AGAX.Migrations
{
    [DbContext(typeof(CalculateDbContext))]
    partial class CalculateDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CalculatorMVC_AGAX.Models.CalculateModel", b =>
                {
                    b.Property<int>("Add")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<decimal>("Divide")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Multiply")
                        .HasColumnType("int");

                    b.Property<int>("Substract")
                        .HasColumnType("int");

                    b.HasKey("Add");

                    b.ToTable("Numbers");
                });
#pragma warning restore 612, 618
        }
    }
}
