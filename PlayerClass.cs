using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Sparta_Dungeon_v1
{
    public class Player
    {
        public int Level { get; set; } 
        public string ClassName { get; set; } // 쓰는 이유는 로직활용 및 값위변조 가능성을 차단하기 위해서임!
        public int Atk { get; set; }
        public int Def { get; set; }
        public int Hp { get; set; }
        public int Gold { get; set; }
        public List<Item> HasItems { get; set; } = new List<Item>();
        public Player(string Name) // 플레이어 클래스 생성자만들어서 기본값 세팅하기!
        {
            Level = 01;
            ClassName = "전사";
            Atk = 10;
            Def = 5;
            Hp = 100;
            Gold = 3000;
            HasItems = HasItems ?? new List<Item>(); // 보유 아이템 리스트 만들고 비어있으면 생성해라
        }

        public void ShowStatus()
        {
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.\n");

            Console.WriteLine($"Level: {Level}");
            Console.WriteLine($"Chad ( {ClassName} )");
            Console.WriteLine($"공격력: {Atk}");
            Console.WriteLine($"방어력: {Def}");
            Console.WriteLine($"체력: {Hp}");
            Console.WriteLine($"Gold : {Gold} G\n");

            Console.WriteLine("0. 나가기");
            Console.Write(">>");
            string input = Console.ReadLine();

            if (input == "0")
            {
                Console.Clear();
                Program.StartMenu(); // 다른 파일에 있는 녀석이니 명시적 호출 사용!
            }
        }
    }
}

