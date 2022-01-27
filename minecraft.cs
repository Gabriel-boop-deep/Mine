 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 using projeto_api;


 class Program {
   static void Main (string[] args) {
   Personagem person1= new Personagem("Bob","Masculino",1998,0);
   Personagem person2 = new Personagem("Steve","Masculino",2018,0);
   Personagem person3 = new Personagem("Charl","Feminino",2018,0);
   Personagem person4 = new Personagem("D","Feminino",2017,0);
   Personagem person5 = new Personagem("Elloy","Masculino",1998,0);
    
    
    Console.WriteLine(person1);
    Console.WriteLine(person2);
    Console.WriteLine(person3);
    Console.WriteLine(person4);
    Console.WriteLine(person5);
  }
}

  
