
//#region METHODS 
// Console.Write("Quanto tempo em segundos?: ");
// int timeResponse = int.Parse(Console.ReadLine());
// Start(timeResponse);
Menu();

static void Menu() {
    Console.WriteLine("S = Segundos => 10s = 10 segundos");
    Console.WriteLine("M = Minutos => 1m = 1 minuto");
    Console.WriteLine("0 = Sair");
    Console.Write("Quanto tempo deseja contar? ");

    string dados = Console.ReadLine().ToLower();
    char type = char.Parse(dados.Substring(dados.Length - 1, 1));
    int time = int.Parse(dados.Substring(0, dados.Length - 1));

    if(time == 0)
        System.Environment.Exit(0);
    if(type == 's')
        PreStart(time);
    if(type == 'm')
        PreStart(RetornoMinutos(time));
}

static void PreStart(int time){
    Console.Clear();
    Console.WriteLine("Iniciando o cronômetro...");
    Thread.Sleep(1000);
    Start(time);
}

static int RetornoMinutos(int time) {
    return time * 60;
}

static void Start(int time) {
    int currentTime = 0;
    while(currentTime != time){
        Console.Clear();
        currentTime++;
        Console.WriteLine("Tempo restante: " + currentTime);
        Thread.Sleep(1000);
    }
    Console.Clear();
    Console.WriteLine("Temporizador finalizado");
    Thread.Sleep(2500);
    Console.Clear();
    Menu();
}
//#endregion