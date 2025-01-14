﻿using DigiBank.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigiBank.Classes
{
    public class Pessoa
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Senha { get; private set; }
        public IConta Conta { get; set; }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
        public void SetCPF(string cpf)
        {
            CPF = cpf;
        }
        public void SetSenha(string senha)
        {
            Senha = senha;
        }
    }
}
