using System;

class MinhaClasse {
  public static void Main (string[] args) {
    var numerosDaLista = int.Parse(Console.ReadLine());


        string[] valores = Console.ReadLine().Split();

        int contagemMultiplos2 = 0;
        int contagemMultiplos3 = 0;
        int contagemMultiplos4 = 0;
        int contagemMultiplos5 = 0;
    
    for (int i = 0; i < (valores.GetLength(0)) ; i++)
    {
        int valoresInt = int.Parse(valores[i]);
        double valoresDouble = double.Parse(valores[i]);

        if ((valoresInt/2) == (valoresDouble/2))
        {
          contagemMultiplos2 = contagemMultiplos2 + 1;
        }

        if ((valoresInt/3) == (valoresDouble/3))
        {
          contagemMultiplos3 = contagemMultiplos3 + 1;
        }

        if ((valoresInt/4) == (valoresDouble/4))
        {
          contagemMultiplos4 = contagemMultiplos4 + 1;
        }

        if ((valoresInt/5) == (valoresDouble/5))
        {
          contagemMultiplos5 = contagemMultiplos5 + 1;
        }
    }
     
    Console.WriteLine(" {0} Multiplo(s) de 2", contagemMultiplos2);
    Console.WriteLine(" {0} Multiplo(s) de 3", contagemMultiplos3);
    Console.WriteLine(" {0} Multiplo(s) de 4", contagemMultiplos4);
    Console.WriteLine(" {0} Multiplo(s) de 5", contagemMultiplos5);
    
  }
}