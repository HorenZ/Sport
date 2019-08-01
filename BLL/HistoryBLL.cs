﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL;
using Model;

namespace BLL
{
    public class HistoryBLL
    {
        /// <summary>
        /// 保存订单  返回true为失败
        /// </summary>
        /// <param name="his"></param>
        /// <returns></returns>
        public bool SaveHistory(History his)
        {
            int e = new HistoryDAL().SaveHistory(his);
            if (e!=1)
            {
                return true;
            }

            return false;
        }

        public int GetNewHID()
        {
            return new HistoryDAL().GetNewHID();
        }
    }
}
