using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocadoraClasses
{
    public class LocadoraClasses
    {

        public class Categoria
        {


            public Categoria() { }
            public Categoria(int id, string nome, decimal valordiaria)
            {
                Id = id;
                Nome = nome;
                ValorDiaria = valordiaria;

            }



            public int Id { get; set; }
            public string Nome { get; set; }
            public decimal ValorDiaria { get; set; }

        }
    }

    public class Genero
    {


        public Genero() { }
        public Genero(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }



        public int Id { get; set; }
        public string Nome { get; set; }

    }

    public class Cliente
    {


        public Cliente() { }
        public Cliente(int id, string nome, string endereco, string telefone, string rg, string cpf)
        {
            Id = id;
            Nome = nome;
            Endereço = endereco;
            Telefone = telefone;
            RG = rg;
            CPF = cpf;



        }



        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereço { get; set; }
        public string Telefone { get; set; }
        public string RG { get; set; }
        public string CPF { get; set; }

    }

}

