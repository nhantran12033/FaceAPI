using FaceAPI.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace FaceAPI.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(FaceAPIEntityFrameworkCoreModule),
    typeof(FaceAPIApplicationContractsModule)
)]
public class FaceAPIDbMigratorModule : AbpModule
{
}
