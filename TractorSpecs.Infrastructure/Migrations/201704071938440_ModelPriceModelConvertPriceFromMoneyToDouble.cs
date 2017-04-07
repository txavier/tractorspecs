namespace TractorSpecs.Infrastructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelPriceModelConvertPriceFromMoneyToDouble : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.modelPrice", "price", c => c.Double());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.modelPrice", "price", c => c.Decimal(storeType: "money"));
        }
    }
}
