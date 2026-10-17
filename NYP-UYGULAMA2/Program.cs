using System;
using System.Collections.Generic;
class Program
{
    static bool NumaraVarMi(List<string> liste, string aranan)

    {
        foreach (string numara in liste)
        {
            if (numara == aranan)

            { return true; }
        }
        return false;
    }
    static void Main()
    {
        List<string> liste = new List<string>()
    { "111",
        "222",
        "333" };

        //ilk eleman

        Console.WriteLine(NumaraVarMi(liste, "111"));

        //son eleman

        Console.WriteLine(NumaraVarMi(liste, "333"));

        //listede olmayan

        Console.WriteLine(NumaraVarMi(liste, "555"));

        //boş liste

        List<string> bosListe = new List<string>();

        Console.WriteLine(NumaraVarMi(bosListe, "111"));

    }
}


    
        
            
    
        
        
        
        
        
            
            
                
                
            
        
        
        
            
        
        
        
    








    
    
        
        
        
    

