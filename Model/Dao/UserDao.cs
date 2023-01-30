using Model.Entity;
using SqlSugar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Dao
{
    public class UserDao
    {
        private readonly ISqlSugarClient db;
        public UserDao(ISqlSugarClient db)
        {
            this.db = db;
        }

        /**
     * 通过账号查找用户
     * @param account 账号
     * @return
     */
        public SysUser selectSysUserByAccount(String account)
        {
            List<SysUser> list = db.Queryable<SysUser>().Where(user => user.account == account).ToList();
            return list[0];
        }
    }
}
