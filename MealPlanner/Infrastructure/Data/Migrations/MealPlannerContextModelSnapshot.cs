﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Data.Migrations
{
    [DbContext(typeof(MealPlannerContext))]
    partial class MealPlannerContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Food", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BrandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ShiptId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Food");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Ingredient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FoodId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Quantity")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("ServingSize")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FoodId");

                    b.HasIndex("RecipeId");

                    b.ToTable("Ingredients");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("Step")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Nutrition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("IngredientId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Value")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("IngredientId");

                    b.ToTable("Nutrition");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Recipe", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<TimeSpan>("Cook")
                        .HasColumnType("time");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ExternalUrl")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Prep")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("Ready")
                        .HasColumnType("time");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<int>("Servings")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("Recipes");
                });

            modelBuilder.Entity("Core.Entities.SuggestionAggregate.RecipePreference", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Frequency")
                        .HasColumnType("time");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("datetime2");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Rating")
                        .HasColumnType("int");

                    b.Property<int?>("RecipeId")
                        .HasColumnType("int");

                    b.Property<string>("User")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("RecipeId");

                    b.ToTable("RecipePreference");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Equipment", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Recipe", null)
                        .WithMany("Equipment")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Ingredient", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Food", "Food")
                        .WithMany()
                        .HasForeignKey("FoodId");

                    b.HasOne("Core.Entities.RecipeAggregate.Recipe", null)
                        .WithMany("Ingredients")
                        .HasForeignKey("RecipeId");

                    b.OwnsOne("Core.Entities.RecipeAggregate.Measurement", "Measurement", b1 =>
                        {
                            b1.Property<int>("IngredientId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Type")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("IngredientId");

                            b1.ToTable("Ingredients");

                            b1.WithOwner()
                                .HasForeignKey("IngredientId");
                        });
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Instruction", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Recipe", null)
                        .WithMany("Instructions")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Nutrition", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Ingredient", null)
                        .WithMany("Nutrition")
                        .HasForeignKey("IngredientId");

                    b.OwnsOne("Core.Entities.RecipeAggregate.Measurement", "Measurement", b1 =>
                        {
                            b1.Property<int>("NutritionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Type")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NutritionId");

                            b1.ToTable("Nutrition");

                            b1.WithOwner()
                                .HasForeignKey("NutritionId");
                        });

                    b.OwnsOne("Core.Entities.RecipeAggregate.NutritionType", "Type", b1 =>
                        {
                            b1.Property<int>("NutritionId")
                                .ValueGeneratedOnAdd()
                                .HasColumnType("int")
                                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                            b1.Property<string>("Name")
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("NutritionId");

                            b1.ToTable("Nutrition");

                            b1.WithOwner()
                                .HasForeignKey("NutritionId");
                        });
                });

            modelBuilder.Entity("Core.Entities.RecipeAggregate.Recipe", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Recipe", null)
                        .WithMany("RelatedRecipes")
                        .HasForeignKey("RecipeId");
                });

            modelBuilder.Entity("Core.Entities.SuggestionAggregate.RecipePreference", b =>
                {
                    b.HasOne("Core.Entities.RecipeAggregate.Recipe", "Recipe")
                        .WithMany()
                        .HasForeignKey("RecipeId");
                });
#pragma warning restore 612, 618
        }
    }
}
