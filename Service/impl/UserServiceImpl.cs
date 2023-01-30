using Model.Dao;
using Model.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.impl
{
    public class UserServiceImpl : UserService
    {
        public UserDao userDao;
        public UserServiceImpl(UserDao userDao)
        {
            this.userDao = userDao;
        }

        /**
         * 通过账号查找用户
         * @param account 账号
         * @return
         */
        public SysUser findSysUserByAccount(string account)
        {
            return userDao.selectSysUserByAccount(account);
        }
    }
}
