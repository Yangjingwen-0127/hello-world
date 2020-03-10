using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Student
    {
        /// <summary>
        /// 给属性设置默认值
        /// </summary>
        public string Name { get; set; } = "yjw";

        /// <summary>
        /// 此写法表示该属性为只读
        /// </summary>
        public string Sex => "女";
    }
}
