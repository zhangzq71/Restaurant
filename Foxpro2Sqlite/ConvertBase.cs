using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Foxpro2Sqlite
{
    public abstract class ConvertBase : IConvertBase
    {
        public string FoxproConnStr
        {
            get;
            set;
        }

        public string DbConnStr
        {
            get;
            set;
        }

        public virtual void Convert(int branchId)
        {
        }

        abstract public bool IsSetmeal(string prodNo);
    }
}
