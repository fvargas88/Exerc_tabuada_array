using System;

class Program {
  public static void Main (string[] args) {
    Console.WriteLine ("Informe um número para calcular a tabuada:");
    int n = int.Parse(Console.ReadLine());

    int[] tabuada = new int[11];

    for(int pos =0; pos <=10; pos++){
      int x = pos * n;
      tabuada[pos] = x;
    }
    for (int pos =0; pos < tabuada.Length; pos++){
      int t = tabuada[pos];
      Console.WriteLine("{0} x {1} = {2}", n, pos, t);
    }
  }
}