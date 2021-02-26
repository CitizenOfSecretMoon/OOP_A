using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_A
{
    //Второй уровень вложенности Питание<--Продукция
    public class Made : Food
    {
        public virtual string date { get; set; }
    }
}