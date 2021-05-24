using System;
using System.Collections.Generic;
using System.Text;

namespace saladeaula
{
 public class base_aluno
 {
        string nome;
        double faltas;
        double notas;

    public string Nome
    {
            get { return nome; }
            set { nome = value; }


    }

        public double Faltas
        {
            get { return faltas; }
            set { faltas = value; }

        }

        public double Notas
        {
            get { return notas; }
            set { faltas = value; }

        }
    } 
}
