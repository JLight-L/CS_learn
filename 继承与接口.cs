using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStudy
{
    /*继承与接口*/
    public class InheritanceAndInterface
    {
        public class Base1
        {
            public static int Method1() => 1;
            public int Method0() => 0; 
        }

        //interface IBase1:Base1 —— X
        //接口不能继承自类

        public interface IBase2
        {
            public static abstract int Method1();
            public int Method2();
            public int Method3();
        }

        public class A : Base1, IBase2
        {
            //这里Method1已经被自动实现了
            public int level = 1;
            public void LevelUp()
            {
                this.level += 1;
            }
            public int Method2() => 2;
            public int Method3()
            {
                return this.level;
            }
        }
    }
}
