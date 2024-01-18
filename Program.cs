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
            Console.WriteLine("[S] - Segundos || 10s = 10 segundos");
            Console.WriteLine("[M] - Minutos || 1m = 1 minuto");
            Console.WriteLine("[0] - Sair");
            Console.WriteLine("------------------------");
            Console.WriteLine("");
            Console.WriteLine("Quanto tempo deseja cronometrar?");

            string data = Console.ReadLine().ToLower();
            
            if (data == "0"){
                System.Environment.Exit(0);
            }

            char type = char.Parse(data.Substring(data.Length - 1,1));
            int time = int.Parse(data.Substring(0, data.Length - 1));
            int multiplier = 1;

            if(type == 'm'){
                multiplier = 60;
            } 
            
            
            PreStart(time*multiplier);
        }

        static void PreStart(int time){
            Console.Clear();

            Console.WriteLine("Preparar...");
            Thread.Sleep(1000);
            Console.WriteLine("Apontar...");
            Thread.Sleep(1000);
            Console.WriteLine("Fogo!");
            Thread.Sleep(1700);

            Start(time);
        }

        static void Start(int time){
            int currentTime = 0;

            while(currentTime != time){

                Console.Clear();

                currentTime++;
                Console.WriteLine($"Cronometrando: {currentTime}");
                Thread.Sleep(1000);
            }

            Console.Clear();
            Console.WriteLine("StopWatch finalizado!");
            Console.WriteLine("");
            Console.WriteLine("Retornando para o Menu..");
            Thread.Sleep(1500);
            Menu();
        }
    }
}



