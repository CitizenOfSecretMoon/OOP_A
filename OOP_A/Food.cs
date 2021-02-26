using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_A
{
    //Первый уровень вложенности Питание
    public class Food : Production
    {
        public virtual string energy { get; set; }
        
    }

    
}
