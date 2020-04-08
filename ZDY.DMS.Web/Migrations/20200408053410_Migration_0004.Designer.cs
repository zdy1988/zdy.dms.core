﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZDY.DMS.Web.Repositories.EntityFramework;

namespace ZDY.DMS.Web.Migrations
{
    [DbContext(typeof(DMSDbContext))]
    [Migration("20200408053410_Migration_0004")]
    partial class Migration_0004
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.DictionaryKey", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dictionary_Key");
                });

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.DictionaryValue", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("DictionaryKey")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("ParentValue")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Value")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Dictionary_Value");
                });

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.File", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("BusinessID")
                        .HasColumnType("char(36)");

                    b.Property<string>("ExtensionName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FileName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<long>("FileSize")
                        .HasColumnType("bigint");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("OriginalName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Path")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("File");
                });

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.Log", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Message")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Log");
                });

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.Page", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Icon")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsInMenu")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsPassed")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<string>("MenuName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("PageCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("PageName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Src")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Type")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Page");
                });

            modelBuilder.Entity("ZDY.DMS.Services.AdminService.Models.PageAction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Code")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("PageId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Page_Action");
                });

            modelBuilder.Entity("ZDY.DMS.Services.Common.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("Avatar")
                        .HasColumnType("char(36)");

                    b.Property<string>("AvatarUrl")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Country")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("DepartmentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Email")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Gender")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("LastLoginIp")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("LastLoginTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Mobile")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("NickName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Position")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Province")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Session")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("WeChatOpenId")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ZDY.DMS.Services.MessageService.Models.Message", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Content")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsSended")
                        .HasColumnType("tinyint(1)");

                    b.Property<int>("Level")
                        .HasColumnType("int");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("char(36)");

                    b.Property<string>("SenderName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Message");
                });

            modelBuilder.Entity("ZDY.DMS.Services.MessageService.Models.MessageInbox", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsReaded")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("MessageId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Message_Inbox");
                });

            modelBuilder.Entity("ZDY.DMS.Services.OrganizationService.Models.Company", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Address")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("City")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("CompanyName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fax")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Province")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Company");
                });

            modelBuilder.Entity("ZDY.DMS.Services.OrganizationService.Models.Department", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DepartmentName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Fax")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<Guid>("ParentId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Phone")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ZDY.DMS.Services.PermissionService.Models.UserGroup", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<string>("GroupCode")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("GroupName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("User_Group");
                });

            modelBuilder.Entity("ZDY.DMS.Services.PermissionService.Models.UserGroupActionPermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PageActionId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PageId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("User_Group_Action_Permission");
                });

            modelBuilder.Entity("ZDY.DMS.Services.PermissionService.Models.UserGroupMember", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("User_Group_Member");
                });

            modelBuilder.Entity("ZDY.DMS.Services.PermissionService.Models.UserGroupPagePermission", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PageId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("User_Group_Page_Permission");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CreaterId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DesignJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("FormId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("InstallTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("InstallerId")
                        .HasColumnType("char(36)");

                    b.Property<string>("InstanceManagers")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsRemoveCompletedInstance")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Managers")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("RuntimeJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowComment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Comment");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowDelegation", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("DelegaterId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("EndTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("FlowId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("PublisherId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("SetTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("StartTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Delegation");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowForm", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CreaterId")
                        .HasColumnType("char(36)");

                    b.Property<string>("DesignFieldJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("DesignJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Form");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowInstance", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CreaterId")
                        .HasColumnType("char(36)");

                    b.Property<string>("CreaterName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FlowDesignJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("FlowId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FlowName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FlowRuntimeJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FormDataJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("FormJson")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<Guid>("LastExecuteStepId")
                        .HasColumnType("char(36)");

                    b.Property<string>("LastExecuteStepName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("LastExecuteTaskId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Instance");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowSignature", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("LastModifyTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("UserId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Signature");
                });

            modelBuilder.Entity("ZDY.DMS.Services.WorkFlowService.Models.WorkFlowTask", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Comment")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("CompanyId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime?>("ExecutedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("FlowId")
                        .HasColumnType("char(36)");

                    b.Property<string>("FlowName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("GroupId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("InstanceId")
                        .HasColumnType("char(36)");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("tinyint(1)");

                    b.Property<bool>("IsNeedSign")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Note")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime?>("OpenedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<DateTime?>("PlannedTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("PrevStepId")
                        .HasColumnType("char(36)");

                    b.Property<Guid>("PrevTaskId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("ReceiveTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("ReceiverId")
                        .HasColumnType("char(36)");

                    b.Property<string>("ReceiverName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<DateTime>("SendTime")
                        .HasColumnType("datetime(6)");

                    b.Property<Guid>("SenderId")
                        .HasColumnType("char(36)");

                    b.Property<string>("SenderName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Sort")
                        .HasColumnType("int");

                    b.Property<int>("State")
                        .HasColumnType("int");

                    b.Property<Guid>("StepId")
                        .HasColumnType("char(36)");

                    b.Property<string>("StepName")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<Guid>("SubFlowInstanceId")
                        .HasColumnType("char(36)");

                    b.Property<DateTime>("TimeStamp")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Title")
                        .HasColumnType("longtext CHARACTER SET utf8mb4");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Work_Flow_Task");
                });
#pragma warning restore 612, 618
        }
    }
}
