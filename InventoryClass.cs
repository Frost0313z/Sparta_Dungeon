using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sparta_Dungeon_v1
{
    public class Inventory
    {
        public void ShowInventory()
        {
            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");

            if (Item.Items.Count > 0)
            {
                // - [E]무쇠갑옷 | 방어력 +5 | 무쇠로 만들어져 튼튼한 갑옷입니다.
                for (int i = 0; i < Item.Items.Count; i++)
                {
                    Item inventory = Item.Items[i]; // item 변수에 전역 리스트 데이터를 넣어버림
                    string equipMark = inventory.IsEquipped ? "[E]" : "";
                    string stat = $"{inventory.Type} +{inventory.Value}";
                    Console.WriteLine($"- {equipMark}{inventory.Name} | {stat} | {inventory.Description}");
                }
            }
            else
            {
                Console.WriteLine("--- 보유한 아이템이 없습니다 --- \n");
            }

            Console.WriteLine("1. 장착관리");
            Console.WriteLine("0. 나가기");
            Console.WriteLine("원하시는 행동을 입력해주세요\n");
            Console.Write(">>");
            string input = Console.ReadLine();

            if (input == "1")
            {
                Console.Clear();
                Program.StartMenu(); // 장착관리 출력 코드로 바꾸기
            }

            if (input == "0")
            {
                Console.Clear();
                Program.StartMenu(); 
            }
        }
        public void EquipManager() // 장착하면 Player도 영향을 미침
        {
            // IsEquipped가 true면 같은 번호 누르면 false로 바뀜 반대도 마찬가지
            // IsEquipped가 true면 해당 아이템을 필터링한 후 능력치를 Player에도 갱신함
            // Switch 활용한 조건 분기 필요 > 

            Console.WriteLine("인벤토리");
            Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.\n");

            Console.WriteLine("[아이템 목록]\n");
            while (true)
            { 
                if (Item.Items.Count > 0)
                {
                    // 일단 메뉴는 출력함
                    for (int i = 0; i < Item.Items.Count; i++)
                    {
                        Item inventory = Item.Items[i];
                        string equipMark = inventory.IsEquipped ? "[E]" : "";
                        string stat = $"{inventory.Type} +{inventory.Value}";
                        Console.WriteLine($"{i+1}.{equipMark}{inventory.Name} | {stat} | {inventory.Description}");
                    }

                    Console.WriteLine("원하시는 행동을 입력해주세요\n");
                    Console.Write(">>");
                    string input = Console.ReadLine();

                    if (input == "0")
                    {
                    }
                    // 
                }
                else
                {
                    Console.WriteLine("--- 보유한 아이템이 없습니다 --- \n");
                }
            }
        }

        
    }
}
