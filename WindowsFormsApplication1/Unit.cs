using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Unit
    {
        public string var1;
        public string var2;
        public string var3;

        //////////////////////////////////

        public Unit (string var1 , string var2 , string var3)
        {
            this.var1 = var1;
            this.var2 = var2;
            this.var3 = var3;

        }


        public Unit()
        {
            this.var1 = "";
            this.var2 = "";
            this.var3 = "";

        }

    }
}
