using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public static class CommonConstants
    {
        /**
     * 档案盒状态：在库
     */
        public const int ARCHIVE_BOX_STATUS_IN_CABINET = 4;

        /**
         * 档案盒状态：标签损坏
         */
        public const int ARCHIVE_BOX_STATUS_RFID_BROKEN = 10;

        /**
         * 档案盒状态：已借出
         */
        public const int ARCHIVE_BOX_STATUS_BORROWED = 12;

        /**
         * 盘库后的储位状态：该储位的天线是坏的
         */
        public const string INVENTORY_POS_STATUS_ANTENNA_BROKEN = "该储位的天线是坏的!";

        /**
         * 盘库后的储位状态：该储位是空的
         */
        public const string INVENTORY_POS_STATUS_IS_EMPTY = "该储位是空的!";

        /**
         * 盘库后的储位状态：该储位有档案盒没有标签或者档案盒的标签是坏的
         */
        public const string INVENTORY_POS_STATUS_EXCEPTION = "档案盒没有标签或者标签是坏的!";

        /**
         * 盘库后的储位状态；该储位有档案盒并且标签是正常的
         */
        public const string INVENTORY_POS_STATUS_NORMAL = "该储位有档案盒并且标签是正常的!";

        /**
         * 储位状态1：正常
         */
        public const int DEV_POS_STATUS_NORMAL = 1;

        /**
         * 储位状态2：未扫描
         */
        public const int DEV_POS_STATUS_NOT_SCANNED = 2;

        /**
         * 储位状态3：异常
         */
        public const int DEV_POS_STATUS_EXCEPTION = 3;

        /**
         * 储位状态4：锁定
         */
        public const int DEV_POS_STATUS_LOCKED = 4;

        /**
         * 储位状态5：保留
         */
        public const int DEV_POS_STATUS_RETAINED = 5;

        /**
         * 储位盘点状态1：待盘点
         */
        public const int INVENTORY_STATUS_POS_WAIT_CHECK = 1;

        /**
         * 储位盘点状态2：盘点中
         */
        public const int INVENTORY_STATUS_POS_CHECKING = 2;

        /**
         * 储位盘点状态3：盘点成功
         */
        public const int INVENTORY_STATUS_POS_SUCCESS = 3;

        /**
         * 储位盘点状态4：盘点异常
         */
        public const int INVENTORY_STATUS_POS_EXCEPTION = 4;


        /**
         * 档案柜编号
         */
        public const string CABINET_CODE = "abc123456cabinet";

        public const string MSG_E_LOG_001 = "参数验证失败。";
        public const string MSG_E_LOG_002 = "数据查找失败。";
        public const string MSG_E_LOG_003 = "找不到该文件。";
        public const string MSG_E_LOG_004 = "文件流关闭异常。";
        public const string MSG_E_LOG_005 = "token生成失败。";
        public const string MSG_E_LOG_006 = "数据插入失败。";
        public const string MSG_E_LOG_007 = "数据更新失败。";
        public const string MSG_E_LOG_008 = "数据库操作失败。";
        public const string MSG_E_LOG_009 = "字符串匹配失败，请检查您的输入。";
        public const string MSG_E_LOG_010 = "ModBus获取当前层失败！";
        public const string MSG_E_LOG_011 = "ModBus获取最大RFID数量失败！";
        public const string MSG_E_LOG_012 = "ModBus获取总层数失败！";
        public const string MSG_E_LOG_013 = "ModBus修改目标层失败！";
        public const string MSG_E_LOG_014 = "ModBus移层失败";
        public const string MSG_E_LOG_015 = "ModBus获取当前列RFID失败！";
        public const string MSG_E_LOG_016 = "ModBus获取当前层失败!";
        public const string MSG_E_LOG_017 = "ModBus获取当前列RFID失败！";
    }
}
