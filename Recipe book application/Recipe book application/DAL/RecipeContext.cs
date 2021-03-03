using System.Data.Entity;



namespace Recipe_book_application.DAL
{
    public class RecipeContext : DbContext
    {
        public RecipeContext() : base("RecipeContext")
        {
                
        }
        //
        //DbSets
        //
        //https://docs.microsoft.com/en-us/aspnet/mvc/overview/getting-started/getting-started-with-ef-using-mvc/creating-an-entity-framework-data-model-for-an-asp-net-mvc-application

        protected override void OnModelCreating(DbModelBuilder dbModelBuilder)
        {

        }
    }
}
