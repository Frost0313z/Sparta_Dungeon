using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Sparta_Dungeon_v1.Program;

namespace Sparta_Dungeon_v1
{
    public class Item
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public int Value { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public bool IsEquipped { get; set; } = false;
        public bool IsPurchase { get; set; } = false;
        public static List<Item> Items { get; set; } = new List<Item>(); // 글로벌로 사용할 빈 아이템 리스트 생성

        public Item(string name, string type, int value, string description, int price) 
        {
            Name = name; 
            Type = type;
            Value = value;
            Description = description;
            Price = price;
        }

        public static void InitItemList() // 아이템 리스트에 항목 추가됨
        {
            Items.Add(new Item("불멸자의 검", "공격력", 20, "죽음을 수백 번 베었으나, 정작 자신의 죽음은 막지 못했다.", 2000));
            Items.Add(new Item("무쇠갑옷", "방어력", 5, "묵직한 철의 중량은 공포와 함께 다가왔다.", 1500));
            Items.Add(new Item("스파르타의 창", "공격력", 10, "전장에서 흘린 스파르타 형제들의 피를 기억한다.", 1200));
            Items.Add(new Item("낡은 검", "공격력", 5, "수없이 벼려졌으나, 끝내 날이 서지 않았다.", 500));
            Items.Add(new Item("사슬갑옷", "방어력", 3, "마지막 전장에서 주인을 잃었다. 녹은 틈새마다, 숨죽인 울음이 스며 있다. ", 800));
        }


        public void ShowShopMenu()
        {

        }
    }
}
