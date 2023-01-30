using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace Model.Entity
{
    [SugarTable("sys_user")]//当和数据库名称不一样可以设置表别名 指定表明
    public class SysUser
    {
        
            [SugarColumn(IsPrimaryKey = true)]
            public long user_id { get; set; }

            [SugarColumn(ColumnDataType = "varchar(100)")]
            public string? real_name { get; set; }

            [SugarColumn(ColumnDataType = "varchar(30)")]
            public string? nick_name { get; set; }

            public long? role_id { get; set; }


            [SugarColumn(ColumnDataType = "varchar(30)")]
            public string? account { get; set; }


            [SugarColumn(ColumnDataType = "varchar(100)")]
            public string? password { get; set; }

            public long? avatar { get; set; }

            public DateTime? birthday { get; set; }

            public string? sex { get; set; }

            [SugarColumn(ColumnDataType = "varchar(50)")]
            public string? email { get; set; }

            [SugarColumn(ColumnDataType = "varchar(50)")]
            public string? phone { get; set; }

            [SugarColumn(ColumnDataType = "varchar(50)")]
            public string? tel { get; set; }

            public string? super_admin_flag { get; set; }

            public int? status_flag { get; set; }


            [SugarColumn(ColumnDataType = "varchar(100)")]
            public string? last_login_ip { get; set; }

            public DateTime? last_login_time { get; set; }


            public string? user_type { get; set; }

            [SugarColumn(ColumnDataType = "varchar(255)")]
            public string? cabinet_id { get; set; }


            [SugarColumn(ColumnDataType = "varchar(255)")]
            public string? cabinet_code { get; set; }

            public DateTime? create_time { get; set; }

            public long? create_user { get; set; }

            public DateTime? update_time { get; set; }

            public long? update_user { get; set; }


            public string? del_flag { get; set; }

            public DateTime? del_time { get; set; }

            public long? del_user { get; set; }

            [SugarColumn(ColumnDataType = "varchar(500)")]
            public string? portrait { get; set; }
    }
}
