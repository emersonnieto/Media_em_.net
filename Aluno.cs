using System;

class Aluno
{
    public string nome;
    public double nota1, nota2;
    

    //Calcula a média
    public double media()
    {
        return (nota1+nota2)/2;
    }

    //Mostra a média
    public void mostramedia()
    {
        double obtermedia = media();
        string obtersituacao = situacao(obtermedia);

        Console.WriteLine("A média do Aluno "+nome+" é: "+obtermedia+" = " +obtersituacao);
    }

    public string situacao(double media)
    {
       /*  if (media >=6){
             return "Aprovado";
        }else {
            return "Reprovado";
        } */

        return media >= 6 ? "Aprovado" : "Reprovado";
    }
} 