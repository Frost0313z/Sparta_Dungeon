using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon_v1
{
    public class ItemData // 자료형 클래스로 만들어서 관리하면 데이터 추가할때 편할거다! (확장성 고려) + item 클래스에 넣어면 메모리 낭비가 우려됨
    {
        public List<Item> Items { get; private set; } = new List<Item>(); // 변수 프로퍼티로 관리해서 캡슐화한다!

    }
}
