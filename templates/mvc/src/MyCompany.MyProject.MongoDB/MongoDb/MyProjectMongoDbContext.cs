using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace MyCompany.MyProject.MongoDB
{
    [ConnectionStringName("Default")]
    public class MyProjectMongoDbContext : AbpMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            //builder.Entity<YourEntity>(b =>
            //{
            //    //...
            //});
        }
    }
}
