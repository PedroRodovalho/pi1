using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    public partial class Form1 : Form
    {
        Banco bd = new Banco();
        double precoTotal = 0, precoPrioridade = 0;
        int quantidadeItens = 0, quantidadePrioridade = 0;
        Object itemSelecionado;       

        public Form1()
        {
            InitializeComponent();
            panelNovaLista.Hide();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNovaLista_Click(object sender, EventArgs e)
        {
            panelNovaLista.Show();
            if (panelFinalizado.IsAccessible)
            {
                panelFinalizado.Hide();
            }
            int id = bd.getLastIdList() + 1;
            txtIdLista.Enabled = false;
            txtIdLista.Text = id.ToString();
            btnRemoverLista.Enabled = false;
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            string nomeItem = txtNomeItem.Text;
            string categoria = comboCategoria.Text;
            string quantidade = comboQuantidade.Text;
            string preco = txtPreco.Text;
            string prioridade;

        
            {

            }
            bool dados = true;
            double dPreco;
            

         
            preco =  preco.Replace(".",",");   
            

            if (nomeItem.Equals(null) || nomeItem.Equals(""))
            {
                MessageBox.Show("Insira o nome do item antes de adicionar!");
                txtNomeItem.Focus();

            }else if(!double.TryParse(preco, out dPreco)){
                MessageBox.Show("Preço inserido invalido!");
                txtPreco.Text = "";
            }else if (categoria.Equals(null) || categoria.Equals("")) 
            {
                MessageBox.Show("Por favor, informe a categoria do produto!");
                
            }else if (quantidade.Equals(null) || quantidade.Equals(""))
            {
                quantidade = "1";
                double quant;
                double.TryParse(quantidade, out quant);
                dPreco = (double)dPreco * (double)quant;
                precoTotal = (double)precoTotal + (double)dPreco;
                quantidadeItens++;
                if (checkPrioridade.Checked)
                {
                    prioridade = "Sim";
                    quantidadePrioridade++;
                    
                    precoPrioridade = (double)precoPrioridade + (double)dPreco;
                    lblQuantidadePrioridade.Text = quantidadePrioridade.ToString();
                    lblTotalPrioridade.Text = precoPrioridade.ToString();
                }
                else
                {
                    prioridade = "Não";
                }
                ListViewItem item = new ListViewItem(nomeItem);
                item.SubItems.Add(categoria);
                item.SubItems.Add(quantidade);
                item.SubItems.Add(dPreco.ToString());
                item.SubItems.Add(prioridade);
                listNovaLista.Items.Add(item);
                lblPrecoTotal.Text = precoTotal.ToString();
                lblQuantidadeItens.Text = quantidadeItens.ToString();
                lblStatus.Text = "ITEM: " + nomeItem + " ADICIONADO";
            }
            else
            {
                double quant;
                double.TryParse(quantidade, out quant);
                dPreco = (double)dPreco * (double)quant;
                precoTotal = (double)precoTotal + (double)dPreco;
                quantidadeItens++;

                if (checkPrioridade.Checked)
                {
                    prioridade = "Sim";
                    quantidadePrioridade++;
                    precoPrioridade = (double)precoPrioridade + (double)dPreco;
                    lblQuantidadePrioridade.Text = quantidadePrioridade.ToString();
                    lblTotalPrioridade.Text = precoPrioridade.ToString();

                }
                else
                {
                    prioridade = "Não";
                }
                ListViewItem item = new ListViewItem(nomeItem);
                item.SubItems.Add(categoria);
                item.SubItems.Add(quantidade);
                item.SubItems.Add(dPreco.ToString());
                item.SubItems.Add(prioridade);
                
                listNovaLista.Items.Add(item);
                lblPrecoTotal.Text = precoTotal.ToString();
                lblQuantidadeItens.Text = quantidadeItens.ToString();
                lblStatus.Text = "ITEM: " + nomeItem + " ADICIONADO";
            }
        }

        private void btnRemoverLista_Click(object sender, EventArgs e)
        {
            string nomeItem = txtNomeItem.Text;
            string categoria = comboCategoria.Text;
            string quantidade = comboQuantidade.Text;
            string preco = txtPreco.Text;
            string prioridade;
            double dPreco;

            preco = preco.Replace(".", ",");


            if (nomeItem.Equals(null) || nomeItem.Equals(""))
            {
                MessageBox.Show("Insira o nome do item antes de adicionar!");
                txtNomeItem.Focus();

            }
            else if (!double.TryParse(preco, out dPreco))
            {
                MessageBox.Show("Preço inserido invalido!");
                txtPreco.Text = "";
            }
            else if (categoria.Equals(null) || categoria.Equals(""))
            {
                MessageBox.Show("Por favor, informe a categoria do produto!");

            }
            else if (quantidade.Equals(null) || quantidade.Equals(""))
            {
                quantidade = "1";
                double quant;
                double.TryParse(quantidade, out quant);
                dPreco = (double)dPreco * (double)quant;
                precoTotal = (double)precoTotal + (double)dPreco;
                quantidadeItens++;
                if (checkPrioridade.Checked)
                {
                    prioridade = "Sim";
                    quantidadePrioridade++;

                    precoPrioridade = (double)precoPrioridade + (double)dPreco;
                    lblQuantidadePrioridade.Text = quantidadePrioridade.ToString();
                    lblTotalPrioridade.Text = precoPrioridade.ToString();
                }
                else
                {
                    prioridade = "Não";
                }

                listNovaLista.Items.Add((ListViewItem)itemSelecionado);
                ListViewItem item = new ListViewItem(nomeItem);
                item.SubItems.Add(categoria);
                item.SubItems.Add(quantidade);
                item.SubItems.Add(dPreco.ToString());
                item.SubItems.Add(prioridade);
                listNovaLista.Items.Add(item);
                lblPrecoTotal.Text = precoTotal.ToString();
                lblQuantidadeItens.Text = quantidadeItens.ToString();

                listNovaLista.Items.Add((ListViewItem)itemSelecionado);

            }
        }

        private void listNovaLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (listNovaLista.SelectedItems.Count != 0) { 
                    itemSelecionado = listNovaLista.SelectedItems[0]; 
                    int linha;
                    int.TryParse(itemSelecionado.ToString(), out linha);
                    
                    if (itemSelecionado != null)
                    {
                        btnRemoverLista.Enabled = true;
                        btnEditar.Enabled = true;
                    }
                    else
                    {
                        btnRemoverLista.Enabled = false;
                        btnEditar.Enabled = false;
                    }
            }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            int retornoImpressora;
            MP2032.ConfiguraModeloImpressora(7);
            retornoImpressora = MP2032.IniciaPorta("COM3");
            if(retornoImpressora != 1)
            {
                MessageBox.Show("Impressora não detectada. Verifica se a impressora esta devidamente conectada.");
            }
            int idLista;
            int.TryParse(txtIdLista.Text, out idLista);
            if(idLista == 0)
            {
                idLista = 1;
            }

            List<Itens> listaItens = new List<Itens>();
            listaItens = bd.listarItensLista(idLista);
            retornoImpressora = MP2032.FormataTX(txtNomeLista.Text + "\n", 2, 0, 1, 1, 1);
            retornoImpressora = MP2032.FormataTX("ITENS:", 1, 0, 0, 1, 1);
            for (int i = 0; i < listaItens.Count; i++)
            {
                Itens itens = listaItens[i];
                retornoImpressora = MP2032.FormataTX("\nITEM: " + itens.Nome +" QUANTIDADE: "+ itens.Quantidade + "PRECO: " + itens.Preco+ "\n",2,0,0,0,0);
                
            }
           
            retornoImpressora = MP2032.AcionaGuilhotina(1);


        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtNomeLista.Text = String.Empty;
            txtNomeItem.Text = String.Empty;
            txtPreco.Text = String.Empty;
            comboCategoria.SelectedIndex = -1;
            comboQuantidade.SelectedIndex = -1;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            //listNovaLista.Enabled;
        }

        private void comboCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {

            
            string nomeItem, categoria;
            int quantidade;
            double preco;
            string nomeLista = txtNomeLista.Text;
            double disponivel = 0,precoT = 0, precoP = 0;
           
            
            Lista lista = new Lista();
            lista.Nome = nomeLista;
            if (double.TryParse(txtDisponivel.Text, out disponivel)) lista.Disponivel = disponivel;
            if (double.TryParse(lblPrecoTotal.Text, out precoT)) lista.PrecoTotal = precoT;
            if (double.TryParse(lblTotalPrioridade.Text, out precoP)) lista.PrecoPrioridade = precoP;
            bd.criarNovaLista(lista);
            int id = bd.getLastIdList();
            // btnAdicionar.Text = id.ToString();
            
            
            

            
            for (int i = 0; i< listNovaLista.Items.Count; i++)
            {
                nomeItem = listNovaLista.Items[i].SubItems[0].Text;
                categoria = listNovaLista.Items[i].SubItems[1].Text;
             
                int.TryParse(listNovaLista.Items[i].SubItems[2].Text, out quantidade);
                double.TryParse(listNovaLista.Items[i].SubItems[3].Text, out preco);
                Itens itens = new Itens();
                itens.Nome = nomeItem;
                itens.Categoria = categoria;
                itens.Quantidade = quantidade;
                itens.Preco = preco;
                itens.IdLista = id;
                bd.inserirLista(itens);

            }
            panelNovaLista.Visible = false;
            panelFinalizado.Visible = true;

            listNovaLista.Items.Clear();
            


            txtNomeItem.Text = "";
            txtNomeLista.Text = "";
            txtPreco.Text = "";
            comboQuantidade.ResetText();
            comboCategoria.ResetText();
            checkPrioridade.Checked = false;






        }

       
    }
}
