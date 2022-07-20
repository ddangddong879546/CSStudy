using Ch06.sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/07/20 
 * 이름 : 이세연
 * 내용 : 추상클래스 실습하기 교재 p230
 * 
 * 추상클래스(Abstract Class)
 * - 공통의 기능은 하나의 메서드로 정의하고 개별적인 기능은 상속 받아 override 메서드로 정의하는 추상메서드를 갖는 클래스
 * - 오직 상속을 목적으로 설계되는 클래스 
 */

namespace Ch06
{
    internal class _1_추상클래스
    {
        static void Main1(string[] args)
        {
            //추상클래스는 객체 생성할 수 없음
            //Car car = new Car("소나타", "흰색", 0); (이렇게는 불가)

            Car sedan = new Sedan("그랜져", "검정", 0, 2000);
            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            Car truck = new Truck("포터", "파랑", 0, 1);
            truck.SpeedUp(80);
            truck.SpeedDown(20);
            truck.Show();

            //Sedan sedan = new Sedan 보다는 Car(같은 Car를 상속받았다는 걸 알 수 있음(같은 부모)) sedan으로 바꿔서 다형성을 쓰는 게 좀 더 유연하다
        }
    }
}
