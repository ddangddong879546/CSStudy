using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/19
 * 이름 : 이세연
 * 내용 : 클래스 상속 실습하기 교재 p331
 * 
 * 
 * 
 */
namespace Ch05
{
    class Parent 
    {
        private int num1;
        private int num2;

        public Parent(int num1, int num2)
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        public int Plus()
        {
            return num1 + num2;
        }
    }
    
    class Child : Parent
    {
        private int num3;
        private int num4;



        public Child(int num1, int num2, int num3, int num4) : base(num1, num2)
        {
            this.num3 = num3;
            this.num4 = num4;
        }

        public int Minus()
        {
            return num3 - num4;
        }
    }

    internal class _4_상속
    {
        static void Main(string[] args)
        {
            //상속 객체 생성
            Child c1 = new Child(1, 2, 3, 4);
            Child c2 = new Child(5, 6, 7, 8);

            Console.WriteLine("c1 Plus :" +c1.Plus());
            Console.WriteLine("c1 Minus :" +c1.Minus());
            Console.WriteLine("c2 Plus :" +c2.Plus());
            Console.WriteLine("c2 Minus :" +c2.Minus());
        }
    }
}
