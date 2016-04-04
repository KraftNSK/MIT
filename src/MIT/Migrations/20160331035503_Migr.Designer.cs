using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MIT.Models;

namespace MIT.Migrations
{
    [DbContext(typeof(MITContext))]
    [Migration("20160331035503_Migr")]
    partial class Migr
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MIT.Models.Category", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("Parentid");

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isGroup");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Departament", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("Parentid");

                    b.Property<int>("idUserManager");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.FileObject", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Path");

                    b.Property<int?>("Requestid");

                    b.Property<string>("Type");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.History", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Date");

                    b.Property<string>("Description");

                    b.Property<int?>("Responsibleid");

                    b.Property<int?>("Statusid");

                    b.Property<int?>("UserChangeid");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.MethodFeed", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Method");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Organization", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Position", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Priority", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("Ratio");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Request", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("BaseRequestid");

                    b.Property<int?>("Clientid");

                    b.Property<DateTime>("Date");

                    b.Property<DateTime>("Deadline");

                    b.Property<string>("Description");

                    b.Property<int?>("Method_Feedid");

                    b.Property<DateTime>("ReactionTime");

                    b.Property<int?>("Request_Typeid");

                    b.Property<int?>("Responsibleid");

                    b.Property<int?>("Stateid");

                    b.Property<string>("Topic");

                    b.Property<int?>("Urgencyid");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.RequestState", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Status");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.RequestType", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Type");

                    b.Property<bool>("isDeleted");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Service", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int?>("Parentid");

                    b.Property<int?>("Responsibleid");

                    b.Property<int>("SLA_MinReactionTimeMinutes");

                    b.Property<int>("SLA_TimeDone");

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isGroup");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.User", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<byte>("AccessLevel");

                    b.Property<string>("Email");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<string>("Login");

                    b.Property<string>("LoginAD");

                    b.Property<string>("OfficeNumber");

                    b.Property<string>("Password");

                    b.Property<string>("PhoneNumbers");

                    b.Property<int?>("Requestid");

                    b.Property<int?>("Requestid1");

                    b.Property<int?>("UserDepartametid");

                    b.Property<int?>("UserOrganizationid");

                    b.Property<int?>("UserPositionid");

                    b.Property<bool>("isDeleted");

                    b.Property<bool>("isVIP");

                    b.HasKey("id");
                });

            modelBuilder.Entity("MIT.Models.Category", b =>
                {
                    b.HasOne("MIT.Models.Category")
                        .WithMany()
                        .HasForeignKey("Parentid");
                });

            modelBuilder.Entity("MIT.Models.Departament", b =>
                {
                    b.HasOne("MIT.Models.Departament")
                        .WithMany()
                        .HasForeignKey("Parentid");
                });

            modelBuilder.Entity("MIT.Models.FileObject", b =>
                {
                    b.HasOne("MIT.Models.Request")
                        .WithMany()
                        .HasForeignKey("Requestid");
                });

            modelBuilder.Entity("MIT.Models.History", b =>
                {
                    b.HasOne("MIT.Models.User")
                        .WithMany()
                        .HasForeignKey("Responsibleid");

                    b.HasOne("MIT.Models.RequestState")
                        .WithMany()
                        .HasForeignKey("Statusid");

                    b.HasOne("MIT.Models.User")
                        .WithMany()
                        .HasForeignKey("UserChangeid");
                });

            modelBuilder.Entity("MIT.Models.Request", b =>
                {
                    b.HasOne("MIT.Models.Request")
                        .WithMany()
                        .HasForeignKey("BaseRequestid");

                    b.HasOne("MIT.Models.User")
                        .WithMany()
                        .HasForeignKey("Clientid");

                    b.HasOne("MIT.Models.MethodFeed")
                        .WithMany()
                        .HasForeignKey("Method_Feedid");

                    b.HasOne("MIT.Models.RequestType")
                        .WithMany()
                        .HasForeignKey("Request_Typeid");

                    b.HasOne("MIT.Models.User")
                        .WithMany()
                        .HasForeignKey("Responsibleid");

                    b.HasOne("MIT.Models.RequestState")
                        .WithMany()
                        .HasForeignKey("Stateid");

                    b.HasOne("MIT.Models.Priority")
                        .WithMany()
                        .HasForeignKey("Urgencyid");
                });

            modelBuilder.Entity("MIT.Models.Service", b =>
                {
                    b.HasOne("MIT.Models.Service")
                        .WithMany()
                        .HasForeignKey("Parentid");

                    b.HasOne("MIT.Models.User")
                        .WithMany()
                        .HasForeignKey("Responsibleid");
                });

            modelBuilder.Entity("MIT.Models.User", b =>
                {
                    b.HasOne("MIT.Models.Request")
                        .WithMany()
                        .HasForeignKey("Requestid");

                    b.HasOne("MIT.Models.Request")
                        .WithMany()
                        .HasForeignKey("Requestid1");

                    b.HasOne("MIT.Models.Departament")
                        .WithMany()
                        .HasForeignKey("UserDepartametid");

                    b.HasOne("MIT.Models.Organization")
                        .WithMany()
                        .HasForeignKey("UserOrganizationid");

                    b.HasOne("MIT.Models.Position")
                        .WithMany()
                        .HasForeignKey("UserPositionid");
                });
        }
    }
}
