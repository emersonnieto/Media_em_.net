using System;

namespace Media
{
    class Program
    {

        static void Main(string[] args)
        {
            //Instanciar obj Aluno
            Aluno alu = new Aluno();
            alu.nome = "Emerson";
            alu.nota1 = 7;
            alu.nota2 = 3;
            
        

            alu.mostramedia();
        }
    }
}
