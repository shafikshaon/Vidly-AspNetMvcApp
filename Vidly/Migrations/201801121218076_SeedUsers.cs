namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedUsers : DbMigration
    {
        public override void Up()
        {
            Sql(@"
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'9c2652be-1bc2-4011-be97-266314478e15', N'guest@vidly.com', 0, N'AOrh5CkI7zqYYkuspb3XW86t3nt8OAoFD1o6uA+Xm+f6hJs/4wKGM8LoMGCco1U4tg==', N'aecdf8fe-67f5-480f-8725-357043fb89fd', NULL, 0, 0, NULL, 1, 0, N'guest@vidly.com')
INSERT INTO [dbo].[AspNetUsers] ([Id], [Email], [EmailConfirmed], [PasswordHash], [SecurityStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEndDateUtc], [LockoutEnabled], [AccessFailedCount], [UserName]) VALUES (N'd856130e-f143-4711-9115-8cf01fa4e5be', N'admin@vidly.com', 0, N'APsQR30dSzAtHrvuYn1gRpNmcSJzQIXBbcAFjLJq54w8qFMKr5FJJRolUjVQC+opmg==', N'98ee60a6-fc98-45c7-82e0-771be7c137d4', NULL, 0, 0, NULL, 1, 0, N'admin@vidly.com')

INSERT INTO [dbo].[AspNetRoles] ([Id], [Name]) VALUES (N'a1113e41-7836-4746-9da1-e061f25c638b', N'CanManageMovies')

INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'd856130e-f143-4711-9115-8cf01fa4e5be', N'a1113e41-7836-4746-9da1-e061f25c638b')
");
        }
        
        public override void Down()
        {
        }
    }
}
