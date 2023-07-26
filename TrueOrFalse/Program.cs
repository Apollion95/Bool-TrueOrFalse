using System.Collections.Specialized;

class Program
{
    static void Main(string[] args)
    {
        int trueVal = 0;
        int rekord = 0;
        int lenght = 0;

        List<bool> listaBooli= new List<bool>();
        listaBooli.Add(false);
        listaBooli.Add(true);
        listaBooli.Add(true);
        listaBooli.Add(true);
        listaBooli.Add(true);
        listaBooli.Add(false);
        listaBooli.Add(true);
        listaBooli.Add(false);
        listaBooli.Add(false);
        listaBooli.Add(true);
        listaBooli.Add(true);
 
        for (int x = 0; x < listaBooli.Count; x++)
            lenght++;
        for (int i = 0; i < lenght; i++) {
            if (listaBooli[i] == true) { trueVal++; }
            if (trueVal > rekord) { rekord = trueVal; }
            if (listaBooli[i] == false) { trueVal = 0; }
        }       

        Console.WriteLine("total"+trueVal);
        Console.WriteLine("trueVals"+rekord);
    }

}