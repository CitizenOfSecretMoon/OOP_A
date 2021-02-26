using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_A
{
    //Первый уровень вложенности Хозяйственная
    public class HomeActivity : Production
    {
        public virtual bool dangercomponent { get; set; }
    }
}
