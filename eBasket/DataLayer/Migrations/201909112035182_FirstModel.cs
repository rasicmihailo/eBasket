namespace DataLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FirstModel : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        ClubId = c.Int(nullable: false),
                        PG_X = c.Double(nullable: false),
                        PG_Y = c.Double(nullable: false),
                        SG_X = c.Double(nullable: false),
                        SG_Y = c.Double(nullable: false),
                        SF_X = c.Double(nullable: false),
                        SF_Y = c.Double(nullable: false),
                        PF_X = c.Double(nullable: false),
                        PF_Y = c.Double(nullable: false),
                        C_X = c.Double(nullable: false),
                        C_Y = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.Clubs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 64),
                        Location = c.String(),
                        State = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Jerseys",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JerseyTop = c.Int(nullable: false),
                        ColorTop = c.String(),
                        ColorDown = c.String(),
                        ClubId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .Index(t => t.ClubId);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.Trainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ActionId = c.Int(nullable: false),
                        CurrentTrainingID = c.Int(nullable: false),
                        TrainingDate = c.DateTime(nullable: false),
                        ActionCheckpoint = c.Int(nullable: false),
                        TrainingStatus = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Actions", t => t.ActionId, cascadeDelete: true)
                .Index(t => t.ActionId);
            
            CreateTable(
                "dbo.UserBoards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Shape = c.String(nullable: false),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(nullable: false, maxLength: 64),
                        LastName = c.String(nullable: false, maxLength: 64),
                        UserType = c.Int(nullable: false),
                        UserStatus = c.Int(nullable: false),
                        UserLevel = c.Int(nullable: false),
                        ClubId = c.Int(nullable: false),
                        CoachId = c.String(maxLength: 128),
                        UserBoardId = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clubs", t => t.ClubId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.CoachId)
                .ForeignKey("dbo.UserBoards", t => t.UserBoardId, cascadeDelete: true)
                .Index(t => t.ClubId)
                .Index(t => t.CoachId)
                .Index(t => t.UserBoardId)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.UserTrainings",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(maxLength: 128),
                        TrainingId = c.Int(nullable: false),
                        Accuracy = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Trainings", t => t.TrainingId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId)
                .Index(t => t.UserId)
                .Index(t => t.TrainingId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.UserTrainings", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.UserTrainings", "TrainingId", "dbo.Trainings");
            DropForeignKey("dbo.AspNetUsers", "UserBoardId", "dbo.UserBoards");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "CoachId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUsers", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.Trainings", "ActionId", "dbo.Actions");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.Jerseys", "ClubId", "dbo.Clubs");
            DropForeignKey("dbo.Actions", "ClubId", "dbo.Clubs");
            DropIndex("dbo.UserTrainings", new[] { "TrainingId" });
            DropIndex("dbo.UserTrainings", new[] { "UserId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUsers", new[] { "UserBoardId" });
            DropIndex("dbo.AspNetUsers", new[] { "CoachId" });
            DropIndex("dbo.AspNetUsers", new[] { "ClubId" });
            DropIndex("dbo.Trainings", new[] { "ActionId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Jerseys", new[] { "ClubId" });
            DropIndex("dbo.Actions", new[] { "ClubId" });
            DropTable("dbo.UserTrainings");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.UserBoards");
            DropTable("dbo.Trainings");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Jerseys");
            DropTable("dbo.Clubs");
            DropTable("dbo.Actions");
        }
    }
}
