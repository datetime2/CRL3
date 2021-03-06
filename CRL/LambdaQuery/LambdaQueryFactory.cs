/**
* CRL 快速开发框架 V4.0
* Copyright (c) 2016 Hubro All rights reserved.
* GitHub https://github.com/hubro-xx/CRL3
* 主页 http://www.cnblogs.com/hubro
* 在线文档 http://crl.changqidongli.com/
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRL.LambdaQuery
{
    public class LambdaQueryFactory
    {
        public static LambdaQuery<T> CreateLambdaQuery<T>(DbContext _dbContext) where T : IModel, new()
        {
            if (_dbContext.DBHelper.CurrentDBType == CoreHelper.DBType.MongoDB)
            {
                return new MongoDBLambdaQuery<T>(_dbContext);
            }
            return new RelationLambdaQuery<T>(_dbContext);
        }
    }
}
