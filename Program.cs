namespace StopWatch{

    class Program{

        static void Main (string[] args){
            Menu();

        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("=========== BEM VINDO A CRONÔMETRO ===========");
            Console.WriteLine("");
            Thread.Sleep(1000);
            Console.WriteLine("Como deseja cronometrar?");
            Console.WriteLine("------------------------");
            Console.WriteLine("[S] - Cronometrar em Segundos || 10s = 10 segundos");
            Console.WriteLine("[M] - Cronometrar em Minutos || 1m = 1 minuto");
            Console.WriteLine("[0] - Sair");

            string data = Console.ReadLine().ToLower(); //opções de menu
            char type = char.Parse(data.Substring(data.Length-1,1));

            //Console.WriteLine(data);
            //Console.WriteLine(type);
            
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



