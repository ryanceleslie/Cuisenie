﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(CuisenieContext))]
    [Migration("20190126144042_NutritionTypeUpdate")]
    partial class NutritionTypeUpdate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.0-rtm-35687")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<string>("Name");

                    b.Property<int>("ShiptId");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<int?>("FoodId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<int>("Quantity");

                    b.Property<int?>("RecipeId");

                    b.Property<int>("ServingSize");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<int?>("RecipeId");

                    b.Property<int>("Step");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Nutrition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<int?>("IngredientId");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<int>("Value");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Cook");

                    b.Property<DateTime>("Created");

                    b.Property<string>("CreatedBy");

                    b.Property<string>("ExternalUrl");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("ModifiedBy");

                    b.Property<TimeSpan>("Prep");

                    b.Property<int>("Rating");

                    b.Property<TimeSpan>("Ready");

                    b.Property<int>("Servings");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Ingredient", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("Core.Entities.RecipeAggregate.Recipe")
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");

                    b.OwnsOne("Core.Entities.RecipeAggregate.Measurement", "Measurement", b1 =>
                        {
                            b1.Property<int>("IngredientId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Type");

                            b1.HasKey("IngredientId");

                            b1.ToTable("Ingredients");

                            b1.HasOne("Core.Entities.RecipeAggregate.Ingredient")
                                .WithOne("Measurement")
                                .HasForeignKey("Core.Entities.RecipeAggregate.Measurement", "IngredientId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Instruction", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Recipe")
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Nutrition", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Ingredient")
                        .WithMany("Nutrition")
                        .HasForeignKey("IngredientId");

                    b.OwnsOne("Core.Entities.RecipeAggregate.NutritionType", "Type", b1 =>
                        {
                            b1.Property<int>("NutritionId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Name");

                            b1.HasKey("NutritionId");

                            b1.ToTable("Nutrition");

                            b1.HasOne("Core.Entities.RecipeAggregate.Nutrition")
                                .WithOne("Type")
                                .HasForeignKey("Core.Entities.RecipeAggregate.NutritionType", "NutritionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });

                    b.OwnsOne("Core.Entities.RecipeAggregate.Measurement", "Measurement", b1 =>
                        {
                            b1.Property<int>("NutritionId")
                                .ValueGeneratedOnAdd()
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Type");

                            b1.HasKey("NutritionId");

                            b1.ToTable("Nutrition");

                            b1.HasOne("Core.Entities.RecipeAggregate.Nutrition")
                                .WithOne("Measurement")
                                .HasForeignKey("Core.Entities.RecipeAggregate.Measurement", "NutritionId")
                                .OnDelete(DeleteBehavior.Cascade);
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
