namespace MundoMascotaRosario.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class se_va_tipo_de_doc : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Usuario", "TipoDeDocumento");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Usuario", "TipoDeDocumento", c => c.Int(nullable: false));
        }
    }
}
