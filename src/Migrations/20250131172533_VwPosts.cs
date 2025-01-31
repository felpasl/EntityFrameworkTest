using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityTest.Migrations
{
    /// <inheritdoc />
    public partial class VwPosts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"            
                CREATE OR REPLACE VIEW public.vw_posts
                AS 
                select
                    b.""BlogId"" ,
                    b.""Url"",
                    p.""PostId"",
                    p.""Title"" ,
                    c.""CategoryId"",
                    c.""Name"" as ""CategoryName""
                from
                    public.""Blogs"" b
                inner join public.""Posts"" p on
                    b.""BlogId"" = p.""BlogId""
                inner join category.""Category"" c on
                    b.""CategoryId"" = c.""CategoryId""
                ;
            ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("drop view public.vw_posts");
        }
    }
}
