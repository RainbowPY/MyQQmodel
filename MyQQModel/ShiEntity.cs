using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQQModel
{
    public class ShiEntity
    {
        private string _qq市编号;
        private string _qq市名称;
        private string _qq所属省_编号;

        public string Qq市编号 { get => _qq市编号; set => _qq市编号 = value; }
        public string Qq市名称 { get => _qq市名称; set => _qq市名称 = value; }
        public string Qq所属省_编号 { get => _qq所属省_编号; set => _qq所属省_编号 = value; }
    }
}
