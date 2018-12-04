using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;

namespace ListaDeCompras
{
    class MP2032
    {
        //funcao para enviar comandos para a impressora
        [DllImport("MP2032")]
        public static extern int ComandoTX(string comando, int tComando);
        //funcao utilizada para abrir a porta de comunicação
        [DllImport("MP2032")]
        public static extern int IniciaPorta(string porta);
        //funcao utilizada para fechar a porta de comunicação
        [DllImport("MP2032")]
        public static extern int FechaPorta();

        //funcao utilizada para configurar o modelo da impressora
        [DllImport("MP2032")]
        public static extern int ConfiguraModeloImpressora(int iModelo);

        //funcao para acionamento da guilhotinha de papel
        [DllImport("MP2032")]
        public static extern int AcionaGuilhotina(int guilhotina);

        //funcao para impresao de texto formatado
        [DllImport("MP2032")]
        public static extern int FormataTX(string texto, int tipoLetra, int italico, int sublinhado, int expandido, int enfatizado);
    }
}