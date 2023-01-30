using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public interface UserService
    {
        /**
         * 通过账号查找用户
         * @param account 账号
         * @return
         */
        SysUser findSysUserByAccount(string account);
    }
}
