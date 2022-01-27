using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace projeto_api
{
  public class Personagem 
  {
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int Poder { get; set; }
    public int Nivel { get; set; }
    
    
  }
  public Livro(string Nome,string Genero,int poder,int nivel)
  {
    this.Nome=Nome;
    this.Genero=Genero;
    this.poder=Poder;
    this.nivel=Nivel;
  }
  public override string ToString()
  {
    return "O Nome é: "+ this.Nome +"\n"
    + "Genero: "+this.Genero+"\n"
    + "Poder: "+this.Poder+"\n"
    +"Nivel: "+Nivel;
  }
 }
