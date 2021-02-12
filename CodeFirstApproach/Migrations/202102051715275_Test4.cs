namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Test4 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        DeparttId = c.Int(nullable: false, identity: true),
                        DeptName = c.String(),
                    })
                .PrimaryKey(t => t.DeparttId);
            
            AddColumn("dbo.EmployeeModels", "DepartRefId", c => c.Int(nullable: false));
            CreateIndex("dbo.EmployeeModels", "DepartRefId");
            AddForeignKey("dbo.EmployeeModels", "DepartRefId", "dbo.Departments", "DeparttId", cascadeDelete: true);
            DropColumn("dbo.EmployeeModels", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.EmployeeModels", "Address", c => c.String());
            DropForeignKey("dbo.EmployeeModels", "DepartRefId", "dbo.Departments");
            DropIndex("dbo.EmployeeModels", new[] { "DepartRefId" });
            DropColumn("dbo.EmployeeModels", "DepartRefId");
            DropTable("dbo.Departments");
        }
    }
}
