using System.Threading.Tasks;

namespace MyCompany.MyProject.Data
{
    public interface IMyProjectDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
