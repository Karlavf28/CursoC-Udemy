using System;
namespace Modelo_Console_POO
{
    public class DadosEmpresa
    {

        //Utilizando uma classe encapsulada com Propriedades e Auto Propriedades

        private string _nome;

        public string Cnpj { get; private set;}

        public string Status { get; set; }


      

        public DadosEmpresa( string nome, string Cnpj, string Status)
        {
            _nome = nome;
            this.Cnpj = Cnpj;
            this.Status = Status;
        
          

        }


        //Utilizando Propriedades, como possui implementação especifica nao utiliza-se auto-propriedade

        public string Nome
        {
            get { return _nome;  }

            set { if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
                }
        }

        //Para retornar string de dados completa

        public override string ToString()
        {

            return Nome + "  " + "CNPJ: " + Cnpj + " Status:  " + Status;
        }
    }
}
