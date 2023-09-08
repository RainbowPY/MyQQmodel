using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQModel
{
    public class QuEntity
    {
        private string _qq区编号;
        private string _qq区名称;
        private string _qq所属市_编号;

        public string Qq区编号 { get => _qq区编号; set => _qq区编号 = value; }
        public string Qq区名称 { get => _qq区名称; set => _qq区名称 = value; }
        public string Qq所属市_编号 { get => _qq所属市_编号; set => _qq所属市_编号 = value; }
    }
}
