﻿using bytebank_ADM.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.SistemaInterno
{
  public class SistemaInterno
  {
    public bool Logar(Diretor funcionario, string senha)
    {
      bool usuarioAutenticado = funcionario.Autenticar(senha);
      if(usuarioAutenticado)
      {
        Console.WriteLine("Sejá bem vindo!");
        return true;
      }
      else
      {
        Console.WriteLine("Senha incorreta");
        return false;
      }
    }


  }
}