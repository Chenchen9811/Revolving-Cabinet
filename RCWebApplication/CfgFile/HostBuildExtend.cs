using Autofac;
using Autofac.Extensions.DependencyInjection;
using SqlSugar;


namespace RCWebApplication.CfgFile
{
    public static class HostBuildExtend
    {
        public static void Register(this WebApplicationBuilder app)
        {
            app.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            app.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                #region 注册sqlsugar
                builder.Register<ISqlSugarClient>(context =>
                {
                    SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
                    {
                        // 连接字符串
                        ConnectionString = "server=localhost;Port=3306;Database=revolving_cabinet1;Uid=root;Pwd=password;",
                        DbType = DbType.MySql,
                        IsAutoCloseConnection = true
                    });
                    // aop打印sql语句
                    db.Aop.OnLogExecuted = (sql, par) =>
                    {
                        Console.WriteLine("\r\n");
                        Console.WriteLine($"{DateTime.Now.ToString("yyyyMMdd HH:mm:ss")},Sql语句：{sql}");
                        Console.WriteLine("===============================");
                    };
                    return db;
                });
                #endregion
            });
        }
    }
}
