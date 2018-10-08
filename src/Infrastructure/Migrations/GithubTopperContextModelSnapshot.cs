﻿// <auto-generated />
using System;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Infrastructure.Migrations
{
    [DbContext(typeof(GithubTopperContext))]
    partial class GithubTopperContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ApplicationCore.Entities.License", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("Key");

                    b.Property<string>("Name");

                    b.Property<string>("NodeId");

                    b.Property<long>("RepositoriesId");

                    b.Property<string>("SpdxId");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.HasIndex("RepositoriesId")
                        .IsUnique();

                    b.ToTable("License");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Owner", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("AvatarUrl");

                    b.Property<string>("EventsUrl");

                    b.Property<string>("FollowersUrl");

                    b.Property<string>("FollowingUrl");

                    b.Property<string>("GistsUrl");

                    b.Property<string>("GravatarId");

                    b.Property<string>("HtmlUrl");

                    b.Property<string>("Login");

                    b.Property<string>("NodeId");

                    b.Property<string>("OrganizationsUrl");

                    b.Property<string>("ReceivedEventsUrl");

                    b.Property<string>("ReposUrl");

                    b.Property<bool>("SiteAdmin");

                    b.Property<string>("StarredUrl");

                    b.Property<string>("SubscriptionsUrl");

                    b.Property<string>("Type");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("Owner");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Permissions", b =>
                {
                    b.Property<long>("Id");

                    b.Property<bool>("Admin");

                    b.Property<bool>("Pull");

                    b.Property<bool>("Push");

                    b.Property<long>("RepositoriesId");

                    b.HasKey("Id");

                    b.HasIndex("RepositoriesId")
                        .IsUnique();

                    b.ToTable("Permissions");
                });

            modelBuilder.Entity("ApplicationCore.Entities.Repositories", b =>
                {
                    b.Property<long>("Id");

                    b.Property<string>("ArchiveUrl");

                    b.Property<bool>("Archived");

                    b.Property<string>("AssigneesUrl");

                    b.Property<string>("BlobsUrl");

                    b.Property<string>("BranchesUrl");

                    b.Property<string>("CloneUrl");

                    b.Property<string>("CollaboratorsUrl");

                    b.Property<string>("CommentsUrl");

                    b.Property<string>("CommitsUrl");

                    b.Property<string>("CompareUrl");

                    b.Property<string>("ContentsUrl");

                    b.Property<string>("ContributorsUrl");

                    b.Property<DateTime>("CreatedAt");

                    b.Property<string>("DefaultBranch");

                    b.Property<string>("DeploymentsUrl");

                    b.Property<string>("Description");

                    b.Property<string>("DownloadsUrl");

                    b.Property<string>("EventsUrl");

                    b.Property<bool>("Fork");

                    b.Property<int>("Forks");

                    b.Property<int>("ForksCount");

                    b.Property<string>("ForksUrl");

                    b.Property<string>("FullName");

                    b.Property<string>("GitCommitsUrl");

                    b.Property<string>("GitRefsUrl");

                    b.Property<string>("GitTagsUrl");

                    b.Property<string>("GitUrl");

                    b.Property<bool>("HasDownloads");

                    b.Property<bool>("HasIssues");

                    b.Property<bool>("HasPages");

                    b.Property<bool>("HasProjects");

                    b.Property<bool>("HasWiki");

                    b.Property<string>("Homepage");

                    b.Property<string>("HooksUrl");

                    b.Property<string>("HtmlUrl");

                    b.Property<bool>("IsPrivate");

                    b.Property<string>("IssueCommentUrl");

                    b.Property<string>("IssueEventsUrl");

                    b.Property<string>("IssuesUrl");

                    b.Property<string>("KeysUrl");

                    b.Property<string>("LabelsUrl");

                    b.Property<string>("Language");

                    b.Property<string>("LanguagesUrl");

                    b.Property<string>("MergesUrl");

                    b.Property<string>("MilestonesUrl");

                    b.Property<string>("Name");

                    b.Property<string>("NodeId");

                    b.Property<string>("NotificationsUrl");

                    b.Property<int>("OpenIssues");

                    b.Property<int>("OpenIssuesCount");

                    b.Property<long>("OwnerId");

                    b.Property<string>("PullsUrl");

                    b.Property<DateTime>("PushedAt");

                    b.Property<string>("ReleasesUrl");

                    b.Property<int>("Size");

                    b.Property<string>("SshUrl");

                    b.Property<int>("StargazersCount");

                    b.Property<string>("StargazersUrl");

                    b.Property<string>("StatusesUrl");

                    b.Property<string>("SubscribersUrl");

                    b.Property<string>("SubscriptionUrl");

                    b.Property<string>("SvnUrl");

                    b.Property<string>("TagsUrl");

                    b.Property<string>("TeamsUrl");

                    b.Property<string>("TreesUrl");

                    b.Property<DateTime>("UpdatedAt");

                    b.Property<string>("Url");

                    b.Property<int>("Watchers");

                    b.Property<int>("WatchersCount");

                    b.HasKey("Id");

                    b.HasIndex("OwnerId");

                    b.ToTable("Repositories");
                });

            modelBuilder.Entity("ApplicationCore.Entities.License", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Repositories", "Repositories")
                        .WithOne("License")
                        .HasForeignKey("ApplicationCore.Entities.License", "RepositoriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApplicationCore.Entities.Permissions", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Repositories", "Repositories")
                        .WithOne("Permissions")
                        .HasForeignKey("ApplicationCore.Entities.Permissions", "RepositoriesId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ApplicationCore.Entities.Repositories", b =>
                {
                    b.HasOne("ApplicationCore.Entities.Owner", "Owner")
                        .WithMany("Repositories")
                        .HasForeignKey("OwnerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
