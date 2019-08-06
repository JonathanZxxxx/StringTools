using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringTools
{
    public class Function
    {
        /// <summary>
        /// 分割字符串
        /// </summary>
        /// <param name="input"></param>
        /// <param name="select"></param>
        /// <returns></returns>
        public List<string> SplitString(string input, int select, string splitBox)
        {
            var split = "";
            switch (select)
            {
                case 0://换行符
                    input = input.Replace("\t", "").Replace("\n", "^");
                    split = "^";
                    break;
                case 1://空格
                    split = " ";
                    break;
                case 2://输入字符
                    split = splitBox;
                    break;
            }
            var outPut = input.Split(Convert.ToChar(split));
            return outPut.ToList();
        }
    }
}
