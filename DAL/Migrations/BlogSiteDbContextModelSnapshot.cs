﻿// <auto-generated />
using System;
using DAL.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(BlogSiteDbContext))]
    partial class BlogSiteDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parent_id");

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasColumnName("author_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parent_id");

                    b.Property<int?>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.Property<DateTime>("PostedDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("posted_date");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId");

                    b.HasIndex("PostId");

                    b.ToTable("Comment");
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AuthorId")
                        .IsRequired()
                        .HasColumnType("varchar(128)")
                        .HasColumnName("author_id");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("content");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("created_date");

                    b.Property<int?>("ParentId")
                        .HasColumnType("int")
                        .HasColumnName("parent_id");

                    b.Property<string>("Permalink")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("permalink");

                    b.Property<DateTime?>("PublishedDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("published_date");

                    b.Property<byte?>("StatusId")
                        .HasColumnType("tinyint")
                        .HasColumnName("status_id");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("title");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("updated_date");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.HasIndex("ParentId");

                    b.HasIndex("StatusId");

                    b.ToTable("Post");
                });

            modelBuilder.Entity("DAL.Entities.PostCategory", b =>
                {
                    b.Property<int>("CategoryId")
                        .HasColumnType("int")
                        .HasColumnName("category_id");

                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.HasKey("CategoryId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("PostCategory");
                });

            modelBuilder.Entity("DAL.Entities.PostStatus", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("PostStatus");
                });

            modelBuilder.Entity("DAL.Entities.PostTag", b =>
                {
                    b.Property<int>("TagId")
                        .HasColumnType("int")
                        .HasColumnName("tag_id");

                    b.Property<int>("PostId")
                        .HasColumnType("int")
                        .HasColumnName("post_id");

                    b.HasKey("TagId", "PostId");

                    b.HasIndex("PostId");

                    b.ToTable("PostTag");
                });

            modelBuilder.Entity("DAL.Entities.Sex", b =>
                {
                    b.Property<byte>("Id")
                        .HasColumnType("tinyint")
                        .HasColumnName("id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(64)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Sex");
                });

            modelBuilder.Entity("DAL.Entities.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("id");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("name");

                    b.HasKey("Id");

                    b.ToTable("Tag");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(128)")
                        .HasColumnName("id");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("created_date");

                    b.Property<string>("DisplayName")
                        .IsRequired()
                        .HasColumnType("nvarchar(128)")
                        .HasColumnName("display_name");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("Intro")
                        .IsRequired()
                        .HasColumnType("nvarchar(255)")
                        .HasColumnName("intro");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit")
                        .HasColumnName("is_admin");

                    b.Property<DateTime>("LastLogin")
                        .HasColumnType("datetime2(7)")
                        .HasColumnName("last_login");

                    b.Property<string>("Profile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("profile");

                    b.Property<byte?>("SexId")
                        .IsRequired()
                        .HasColumnType("tinyint")
                        .HasColumnName("sex_id");

                    b.HasKey("Id");

                    b.HasIndex("SexId");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.HasOne("DAL.Entities.Category", "ParentCategory")
                        .WithMany("ChildCategories")
                        .HasForeignKey("ParentId");

                    b.Navigation("ParentCategory");
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.HasOne("DAL.Entities.User", "Author")
                        .WithMany("Comments")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Comment", "ParentComment")
                        .WithMany("ChildComments")
                        .HasForeignKey("ParentId");

                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany("Comments")
                        .HasForeignKey("PostId");

                    b.Navigation("Author");

                    b.Navigation("ParentComment");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.HasOne("DAL.Entities.User", "Author")
                        .WithMany("Posts")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Post", "ParentPost")
                        .WithMany("ChildPosts")
                        .HasForeignKey("ParentId");

                    b.HasOne("DAL.Entities.PostStatus", "PostStatus")
                        .WithMany("Posts")
                        .HasForeignKey("StatusId");

                    b.Navigation("Author");

                    b.Navigation("ParentPost");

                    b.Navigation("PostStatus");
                });

            modelBuilder.Entity("DAL.Entities.PostCategory", b =>
                {
                    b.HasOne("DAL.Entities.Category", "Category")
                        .WithMany("PostCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany("PostCategories")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");

                    b.Navigation("Post");
                });

            modelBuilder.Entity("DAL.Entities.PostTag", b =>
                {
                    b.HasOne("DAL.Entities.Post", "Post")
                        .WithMany("PostTags")
                        .HasForeignKey("PostId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Entities.Tag", "Tag")
                        .WithMany("PostTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.HasOne("DAL.Entities.Sex", "Sex")
                        .WithMany("Users")
                        .HasForeignKey("SexId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Sex");
                });

            modelBuilder.Entity("DAL.Entities.Category", b =>
                {
                    b.Navigation("ChildCategories");

                    b.Navigation("PostCategories");
                });

            modelBuilder.Entity("DAL.Entities.Comment", b =>
                {
                    b.Navigation("ChildComments");
                });

            modelBuilder.Entity("DAL.Entities.Post", b =>
                {
                    b.Navigation("ChildPosts");

                    b.Navigation("Comments");

                    b.Navigation("PostCategories");

                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("DAL.Entities.PostStatus", b =>
                {
                    b.Navigation("Posts");
                });

            modelBuilder.Entity("DAL.Entities.Sex", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("DAL.Entities.Tag", b =>
                {
                    b.Navigation("PostTags");
                });

            modelBuilder.Entity("DAL.Entities.User", b =>
                {
                    b.Navigation("Comments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
