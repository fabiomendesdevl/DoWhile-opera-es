
using System.ComponentModel.Design;

class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }
    static void Menu(){
      Console.Clear();
      Console.WriteLine("1 - somar");
      Console.WriteLine("2 - Subtrair");
      Console.WriteLine("3 - Multiplicar");
      Console.WriteLine("4 - Dividir");

      int op =  int.Parse(Console.ReadLine());

    do{
        switch (op){
            case 1:
            somar();
            break;
            case 2:
            subtrair();
            break;
            case 3: 
            Multiplicar();
            break;
            case 4:
            Dividir();
            break;
            default:
            
            break;
        }
    void somar(){
        
        Console.WriteLine("insira o primeiro numero");
        float num = float.Parse(Console.ReadLine());
        Console.WriteLine("incira o segundo numero");
        float num2 = float.Parse(Console.ReadLine());
        float resultado = num + num2;
        Console.WriteLine(resultado);
        Console.ReadKey();
        Menu();
        
    }
    void subtrair(){
        
        Console.WriteLine("insira o primeiro numero");
        float num = float.Parse(Console.ReadLine());
        Console.WriteLine("incira o segundo numero");
        double num2 = float.Parse(Console.ReadLine());
        double resultado = num - num2;
        Console.WriteLine(resultado);
        Console.ReadKey();
        Menu();
    }
    void Multiplicar(){
        
        Console.WriteLine("insira o primeiro numero");
        float num = float.Parse(Console.ReadLine());
        Console.WriteLine("incira o segundo numero");
        float num2 = float.Parse(Console.ReadLine());
        float resultado = num * num2;
        Console.WriteLine(resultado);
        Console.ReadKey();
        Menu();
    }
    void Dividir(){
        
        Console.WriteLine("insira o primeiro numero");
        float num = float.Parse(Console.ReadLine());
        Console.WriteLine("incira o segundo numero");
        float num2 = float.Parse(Console.ReadLine());
       float resultado = num / num2;
        Console.WriteLine(resultado);
        Console.ReadKey();
        Menu();
    }
    }while(op != 0);
    }
}
