﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ADM.Funcionarios
{
  public class Diretor:Funcionario
  {
      public override double GetBonificacao()
      {
          return this.Salario + base.GetBonificacao();
      }

    public string Senha { get; set; }
    public bool Autenticar(string senha)
    {
      return this.Senha == senha;
    }
  }    
}
