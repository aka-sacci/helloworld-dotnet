using helloworld_dotnet.Models; //Caminho do namespace

//Introdução a classes
//string? Label;
//int? Size;
//string? Model;
//Boot myBoot = new Boot(); //Instância da classe

//Console.WriteLine("Boot Label:");
//Label = Console.ReadLine();
//Console.WriteLine("Boot Model:");
//Model = Console.ReadLine();
//Console.WriteLine("Boot Size:");
//Size = int.Parse(Console.ReadLine());

//myBoot.Label = Label;
//myBoot.Model = Model;
//myBoot.Size = Size;

//myBoot.ShowBoot();


//Calculadora
Calculadora myCalculadora = new Calculadora();

//Soma
double[] numerosASeremSomados = {3.1, 1.9, 5};
double resutadoSoma = myCalculadora.Somar(numerosASeremSomados);
Console.WriteLine(string.Join(" + ", numerosASeremSomados) + " = " + resutadoSoma);

//Multiplicação
double[] numerosASeremMultiplicados = {2, 2, 2};
double resutadoMultiplicacao = myCalculadora.Multiplicar(numerosASeremMultiplicados);
Console.WriteLine(string.Join(" * ", numerosASeremMultiplicados) + " = " + resutadoMultiplicacao);

//Subtração
double[] numerosASeremSubtraidos = {50, 10, 50};
double resutadoSubtracao = myCalculadora.Subtrair(numerosASeremSubtraidos);
Console.WriteLine(string.Join(" - ", numerosASeremSubtraidos) + " = " + resutadoSubtracao);

//Divisão
double[] numerosASeremDivididos = {50, 50};
double resutadoDivisao = myCalculadora.Dividir(numerosASeremDivididos);
Console.WriteLine(string.Join(" / ", numerosASeremDivididos) + " = " + resutadoDivisao);

//Potência (Exponenciação)
double[] numerosASeremExponenciados = {5, 3, 2};
double resultadoExponenciacao = myCalculadora.Exponenciar(numerosASeremExponenciados);
Console.WriteLine(string.Join(" ^ ", numerosASeremExponenciados) + " = " + resultadoExponenciacao);

//Seno
double numeroASerTiradoOSeno = 77;
double resultadoSeno = myCalculadora.Seno(numeroASerTiradoOSeno);
Console.WriteLine($"O seno de {numeroASerTiradoOSeno}° é {resultadoSeno}");

//Cosseno
double numeroASerTiradoOConseno = 176;
double resultadoCoseno = myCalculadora.Coseno(numeroASerTiradoOConseno);
Console.WriteLine($"O cosseno de {numeroASerTiradoOConseno}° é {resultadoCoseno}");


//Tangente
double numeroASerTiradoATangente = 40;
double resultadoTangente = myCalculadora.Tangente(numeroASerTiradoATangente);
Console.WriteLine($"O tangente de {numeroASerTiradoATangente}° é {resultadoTangente}");