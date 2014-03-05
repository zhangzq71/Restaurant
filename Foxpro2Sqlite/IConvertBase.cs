﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foxpro2Sqlite
{
    interface IConvertBase
    {
        /// <summary>
        /// Foxpro连接字符串
        /// </summary>
        string FoxproConnStr
        {
            get;
            set;
        }

        string DbConnStr
        {
            get;
            set;
        }

        void Convert(int branchId);

        /// <summary>
        /// prodNo是否套餐
        /// </summary>
        /// <param name="prodNo"></param>
        /// <returns></returns>
        bool IsSetmeal(string prodNo);
    }
}
