using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// 인터페이스 생성할 땐 이름  대문자 I로 시작
namespace Ch06.sub2
{
    // 인터페이스 : 오직 추상메서드만 갖는 구조체
    internal interface IRemoteControl
    {
        public abstract void PowerOn();
        public abstract void PowerOff();


        //abstract 생략
        public void ChUp();
        public void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
