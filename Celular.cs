using System;

namespace AulaPOOCelular
{
    public class Celular
    {
        public string color;
        public string model;
        public string size;
        public bool ligado;
        public bool emligacao = false;

        public void LigarDesligar() {
            if (this.ligado) {
                Console.WriteLine("Desligando");
                this.ligado = false;
            } else {
                if (emligacao) {
                    Console.WriteLine("Ligação encerrada");
                }
                Console.WriteLine("Celular ligado");
                this.ligado = true;
            }
        }

        public void Ligacao(){
            if(this.emligacao) {
                Console.WriteLine("Ligação encerrada");
                this.emligacao = false;
            } else {
                Console.WriteLine("Ligação iniciada. Apenas viva voz");
                this.emligacao = true;
            }
        }

        public void MandarMensagem() {
            Console.WriteLine("DIgite a mensagem");
            string mensagem = Console.ReadLine();
            Console.WriteLine("Mensagem enviada");
        }
    }
}