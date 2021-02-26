using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_A
{
    //Второй уровень вложенности Питание<--Продукция
    public class Grown : Food
    {
        public virtual bool condition { get; set; }

    }
    
}
