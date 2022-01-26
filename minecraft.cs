 using System;
 using System.Collections.Generic;
 using System.Linq;
 using System.Threading.Tasks;
 using projeto_api;


 class Program {
   static void Main (string[] args) {
   Personagem person1= new Personagem("ExemploA","Ficcao",1998,0);
   Personagem person2 = new Personagem("ExemploB","Romance",2018,0);
   Personagem person3 = new Personagem("ExemploC","Ficcao",2018,0);
   Personagem person4 = new Personagem("ExemploD","Academico",2017,0);
   Personagem person5 = new Personagem("ExemploE","Ficcao",1998,0);
    
    
    Console.WriteLine(person1);
    Console.WriteLine(person2);
    Console.WriteLine(person3);
    Console.WriteLine(person4);
    Console.WriteLine(person5);
  }
}

  
