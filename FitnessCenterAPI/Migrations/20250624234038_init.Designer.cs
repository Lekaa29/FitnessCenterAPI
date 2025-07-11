﻿// <auto-generated />
using System;
using FitnessCenterApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FitnessCenterApi.Migrations
{
    [DbContext(typeof(FitnessCenterDbContext))]
    [Migration("20250624234038_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.4");

            modelBuilder.Entity("FitnessCenterApi.Models.Article", b =>
                {
                    b.Property<int>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CoverPictureLink")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdArticle");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Attendance", b =>
                {
                    b.Property<int>("IdAttendance")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_attendance");

                    b.Property<int>("FitnessCentarId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_fitness_centar");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT")
                        .HasColumnName("timestamp");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_user");

                    b.HasKey("IdAttendance");

                    b.HasIndex("FitnessCentarId");

                    b.HasIndex("UserId");

                    b.ToTable("Attendances");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Coach", b =>
                {
                    b.Property<int>("IdCoach")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BannerPictureLink")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("FitnessCentarIdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdCoach");

                    b.HasIndex("FitnessCentarIdFitnessCentar");

                    b.HasIndex("IdUser");

                    b.ToTable("Coaches");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.CoachProgram", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdCoach")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("WeekDuration")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("IdCoach");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("CoachPrograms");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Conversation", b =>
                {
                    b.Property<int>("IdConversation")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsGroup")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .HasColumnType("TEXT");

                    b.Property<int>("groupOwnerId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdConversation");

                    b.ToTable("Conversations");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Event", b =>
                {
                    b.Property<int>("IdEvent")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<int>("MaxParticipants")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("IdEvent");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("Events");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.EventParticipant", b =>
                {
                    b.Property<int>("IdEvent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdEvent", "IdUser");

                    b.HasIndex("IdUser");

                    b.ToTable("EventParticipants");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.FitnessCentar", b =>
                {
                    b.Property<int>("IdFitnessCentar")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_fitness_centar");

                    b.Property<string>("BannerUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Latitude")
                        .HasColumnType("REAL");

                    b.Property<string>("LogoUrl")
                        .HasColumnType("TEXT");

                    b.Property<double>("Longitude")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("name");

                    b.HasKey("IdFitnessCentar");

                    b.HasIndex(new[] { "Name" }, "IX_Fitness_Centar_name")
                        .IsUnique();

                    b.ToTable("Fitness_Centar", (string)null);
                });

            modelBuilder.Entity("FitnessCenterApi.Models.FitnessCenterUser", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdUser", "IdFitnessCentar");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("FitnessCenterUsers");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Membership", b =>
                {
                    b.Property<int>("IdMembership")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_membership");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_fitness_centar");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("LoyaltyPoints")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("loyalty_points");

                    b.Property<DateTime?>("MembershipDeadline")
                        .HasColumnType("TEXT")
                        .HasColumnName("membershipDeadline");

                    b.Property<int?>("Points")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("points");

                    b.Property<int?>("StreakRunCount")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasDefaultValue(0)
                        .HasColumnName("streak_run_count");

                    b.HasKey("IdMembership");

                    b.HasIndex("IdFitnessCentar");

                    b.HasIndex("IdUser");

                    b.ToTable("Membership", (string)null);
                });

            modelBuilder.Entity("FitnessCenterApi.Models.MembershipPackage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Days")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Discount")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Price")
                        .HasColumnType("REAL");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("MembershipPackages");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Message", b =>
                {
                    b.Property<int>("IdMessage")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConversationIdConversation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdConversation")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdSender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isPinned")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdMessage");

                    b.HasIndex("ConversationIdConversation");

                    b.HasIndex("IdSender");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Notification", b =>
                {
                    b.Property<int>("IdNotification")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("IdNotification");

                    b.HasIndex("IdUser");

                    b.ToTable("Notifications");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.ShopItem", b =>
                {
                    b.Property<int>("IdShopItem")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdFitnessCentar")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("LoyaltyPrice")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PictureUrl")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.HasKey("IdShopItem");

                    b.HasIndex("IdFitnessCentar");

                    b.ToTable("ShopItems");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER")
                        .HasColumnName("id_user");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("DATE")
                        .HasColumnName("birthday");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("DATE")
                        .HasColumnName("creation_date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("email");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("first_name");

                    b.Property<int?>("IsStudent")
                        .HasColumnType("INTEGER")
                        .HasColumnName("is_student");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("last_name");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("Phone")
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("phone");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PictureLink")
                        .HasColumnType("VARCHAR(2048)")
                        .HasColumnName("picture_link");

                    b.Property<string>("SecretKey")
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("secret_key");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<int>("Status")
                        .HasColumnType("INTEGER")
                        .HasColumnName("status");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("VARCHAR(255)")
                        .HasColumnName("username");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.HasIndex(new[] { "Email" }, "IX_User_email")
                        .IsUnique();

                    b.HasIndex(new[] { "PictureLink" }, "IX_User_picture_link")
                        .IsUnique();

                    b.HasIndex(new[] { "SecretKey" }, "IX_User_secret_key")
                        .IsUnique();

                    b.HasIndex(new[] { "UserName" }, "IX_User_username")
                        .IsUnique();

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserConversation", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ConversationId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("JoinedAt")
                        .HasColumnType("TEXT");

                    b.Property<bool>("isDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "ConversationId");

                    b.HasIndex("ConversationId");

                    b.ToTable("UserConversations");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserItems", b =>
                {
                    b.Property<int>("IdUser")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdShopItem")
                        .HasColumnType("INTEGER");

                    b.HasKey("IdUser", "IdShopItem");

                    b.HasIndex("IdShopItem");

                    b.ToTable("UserItems");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserMessage", b =>
                {
                    b.Property<int>("MessageId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("isRead")
                        .HasColumnType("INTEGER");

                    b.HasKey("MessageId", "UserId");

                    b.HasIndex("UserId");

                    b.ToTable("UserMessages");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("RoleId")
                        .HasColumnType("INTEGER");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Article", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Attendance", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("FitnessCentarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Coach", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("FitnessCentarIdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.CoachProgram", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.Coach", "Coach")
                        .WithMany()
                        .HasForeignKey("IdCoach")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coach");

                    b.Navigation("FitnessCentar");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Event", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.EventParticipant", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.Event", "Event")
                        .WithMany("Participants")
                        .HasForeignKey("IdEvent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Event");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.FitnessCenterUser", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Membership", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "IdFitnessCentarNavigation")
                        .WithMany("Memberships")
                        .HasForeignKey("IdFitnessCentar")
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "IdUserNavigation")
                        .WithMany("Memberships")
                        .HasForeignKey("IdUser")
                        .IsRequired();

                    b.Navigation("IdFitnessCentarNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.MembershipPackage", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany("MembershipPackages")
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Message", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.Conversation", "Conversation")
                        .WithMany("Messages")
                        .HasForeignKey("ConversationIdConversation")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "Sender")
                        .WithMany()
                        .HasForeignKey("IdSender")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("Sender");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Notification", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.ShopItem", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.FitnessCentar", "FitnessCentar")
                        .WithMany()
                        .HasForeignKey("IdFitnessCentar")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("FitnessCentar");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserConversation", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.Conversation", "Conversation")
                        .WithMany("Participants")
                        .HasForeignKey("ConversationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany("UserConversations")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Conversation");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserItems", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.ShopItem", "ShopItem")
                        .WithMany()
                        .HasForeignKey("IdShopItem")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("IdUser")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ShopItem");

                    b.Navigation("User");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.UserMessage", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.Message", "Message")
                        .WithMany()
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FitnessCenterApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("FitnessCenterApi.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Conversation", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("Participants");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.Event", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.FitnessCentar", b =>
                {
                    b.Navigation("MembershipPackages");

                    b.Navigation("Memberships");
                });

            modelBuilder.Entity("FitnessCenterApi.Models.User", b =>
                {
                    b.Navigation("Memberships");

                    b.Navigation("UserConversations");
                });
#pragma warning restore 612, 618
        }
    }
}
