namespace StopWatch{

    class Program{

        static void Main (string[] args){
            Menu();

        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("=========== BEM VINDO A CRONÔMETRO ===========");
            Console.WriteLine("");
            Thread.Sleep(500);
            Console.WriteLine("Como deseja cronometrar?");
            Console.WriteLine("------------------------");
            Console.WriteLine("[S] - Cronometrar em Segundos");
            Console.WriteLine("[M] - Cronometrar em Minutos");
            Console.WriteLine("[0] - Sair");
        }

        static void Start(int time){
            int currentTime = 0;

            while(currentTime != time){

                Console.Clear(); //a cada iteração limpe o histórico

                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //durma
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Console.WriteLine("");
            Console.WriteLine("Retornando para o Menu..");
            Thread.Sleep(1500);
        }
    }
}



