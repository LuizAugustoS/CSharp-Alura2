﻿namespace ExportarJson
{
    internal class Pessoa
    {
        public Pessoa(string nome, int idade, string email)
        {
            Nome = nome;
            Idade = idade;
            Email = email;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        public string Email { get; set; }
    }
}
