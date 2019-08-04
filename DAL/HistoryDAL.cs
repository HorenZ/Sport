﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Model;

namespace DAL
{
    public class HistoryDAL
    {
        /// <summary>
        /// 保存订单信息
        /// </summary>
        /// <param name="his"></param>
        /// <returns></returns>
        public int SaveHistory(History his)
        {
            SqlParameter[] paras = new SqlParameter[10];
            paras[0] = new SqlParameter("@PortName", his.PortName);
            paras[1] = new SqlParameter("@StartTime", his.StartTime);
            paras[2] = new SqlParameter("@EndTime", his.EndTime);
            paras[3] = new SqlParameter("@AllTime", his.AllTime);
            paras[4] = new SqlParameter("@Cost", his.Cost);
            paras[5] = new SqlParameter("@PortPrice", his.PortPrice);
            paras[6] = new SqlParameter("@UserName", his.UserName);
            paras[7] = new SqlParameter("@State", his.State);
            paras[8] = new SqlParameter("@CarNum", his.CarNum);
            paras[10] = new SqlParameter("@ParkPosintion", his.ParkPosintion);
            string sqlcmd =
                "Insert into History Values(@PortName,@StartTime,@EndTime,@AllTime,@Cost,@PortPrice,@UserName,@State,@CarNum,@ParkPosintion)";
            return SqlHelper.ExecuteNonQuery(SqlHelper.ConnectionString,
                CommandType.Text,
                sqlcmd,
                paras);
        }

        //获取最新ID
        public int GetNewHID()
        {
            string sqltxt = "Select Max(HID) From History";
            return (int)SqlHelper.ExecuteScalar(
                SqlHelper.ConnectionString,
                CommandType.Text,
                sqltxt);
        }
    }
}
