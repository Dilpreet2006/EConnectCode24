﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eConnect.DataAccess
{
   public interface IUserCSPDetailRepository : IRepository<tblUserCSPDetail>
    {
        IList<tblUserCSPDetail> GetAllUserCSPDetail();
        IEnumerable<tblUserCSPDetail> GetUserCSPDetail();
        tblUserCSPDetail GetUserCSPDetailByID(int CSPId);
        void InsertUserCSPDetail(tblUserCSPDetail tblUserCSPDetail);
        void DeleteUserCSPDetail(int CSPId);
        void UpdateUserCSPDetail(tblUserCSPDetail tblUserCSPDetail);
        void Save();
    }
}
