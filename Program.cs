using static Sparta_Dungeon_v1.Program;

namespace Sparta_Dungeon_v1
{
    internal class Program
    {
        static void Main(string[] args) // 스태틱은 인스턴스가 없어도 호출되는 것
        {
            StartMenu();
        }
        static public void StartMenu() // 객체를 생성할 필요가 없으니 함수로
        {
            Player player = new Player("모험가");
            Inventory inventory = new Inventory();

            Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
            Console.WriteLine("이곳에서 던전으로 들어가기 전 활동을 할 수 있습니다.\n");
            Console.WriteLine("1. 상태 보기\n2. 인벤토리 확인\n3. 상점\n");

            while (true) // 화면이 전환되기 전까지 선택지를 반복해서 출력 해야하니 While문 이용
            {
                Console.Write("\n원하시는 행동을 입력해주세요: ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int selectNumber)) // 입력 받은 값이 int로 변환이 안된다면(String, float등)
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    continue;
                }

                switch (selectNumber) // 입력받은 값이 정수로 변환이 되어 selectNumber에 저장이 된다면 (int)
                {
                    case 1:
                        Console.Clear();
                        player.ShowStatus();
                        return;

                    case 2:
                        Console.Clear();
                        inventory.ShowInventory(); 
                        return;

                    case 3:
                        Console.WriteLine("상점으로 이동합니다.");
                        return;

                    default: // 다 안되면 잘못된 입력이라고 출력하기
                        Console.WriteLine("잘못된 입력입니다. 1~3 중에서 선택해주세요.");
                        break;
                }
            }
        }  
    }
}
