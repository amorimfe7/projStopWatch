namespace StopWatch{

    class Program{

        static void Main (string[] args){

            Start();

        }

        static void Start(){
            int time = 10;
            int currentTime = 0;

            while(currentTime != time){

                Console.Clear(); //a cada iteração limpe o histórico

                currentTime++;
                Console.WriteLine(currentTime);
                Thread.Sleep(1000); //durma

            }
        }
    }
}



