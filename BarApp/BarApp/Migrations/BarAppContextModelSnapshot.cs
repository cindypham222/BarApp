using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using BarApp.Models;

namespace BarApp.Migrations
{
    [DbContext(typeof(BarAppContext))]
    partial class BarAppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.2")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BarApp.Models.orderDrinks", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerName")
                        .IsRequired();

                    b.Property<string>("DrinkName")
                        .IsRequired();

                    b.Property<string>("DrinkStatus");

                    b.Property<string>("PaidStatus");

                    b.HasKey("ID");

                    b.ToTable("orderDrinks");
                });
        }
    }
}
