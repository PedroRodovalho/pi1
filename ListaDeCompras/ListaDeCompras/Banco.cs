using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaDeCompras
{
    class Banco
    {
        public void verificaTabela()
        {
            var connString = "Server=localhost;Database=test;Uid=root;Password=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();

           
        }
        
        public int getLastIdList()
        {
            var connString = "Server=localhost;Database=ListaCompras;Uid=root;Password=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            int lastId = -1;
            try
            {

                connection.Open();
             
                command.CommandText = "SELECT MAX(id) from tb_lista";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    lastId = result.GetInt32("MAX(id)");

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema na conexão ao banco de dados!\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return lastId;
        }
        public void criarNovaLista(Lista lista)
        {
            var connString = "Server=localhost;Database=ListaCompras;Uid=root;Password=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO tb_lista(nome,disponivel,precoPrioridade,precoTotal) VALUES('" + lista.Nome + "','"+ lista.Disponivel+"','"
                    +lista.PrecoPrioridade+"','"+lista.PrecoTotal+"')";
                command.ExecuteNonQuery();
               
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Houve um problema na conexão ao banco de dados!\n"+ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            
            
        }
        public List<Itens> listarItensLista(int idLista)
        {
            var connString = "Server=localhost;Database=ListaCompras;Uid=root;Password=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            List<Itens> listaItens = new List<Itens>();
            try
            {
                connection.Open();
                command.CommandText = "SELECT * FROM tb_itens where idLista ='" + idLista + "'";
                var result = command.ExecuteReader();
                while (result.Read())
                {
                    Itens itens = new Itens();
                    itens.IdLista = 1;
                    itens.Nome = result.GetString("nome");
                    itens.Categoria = result.GetString("categoria");
                    itens.Quantidade = result.GetInt32("quantidade");
                    itens.QuantidadePrioridade = result.GetInt32("quantidadePrioridade");
                    itens.Preco = result.GetDouble("preco");
                    itens.Prioridade = result.GetString("prioridade");

                    listaItens.Add(itens);

                }

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }
            return listaItens;
        }
        public void inserirLista(Itens itens)
        {
            var connString = "Server=localhost;Database=ListaCompras;Uid=root;Password=";
            var connection = new MySqlConnection(connString);
            var command = connection.CreateCommand();
            try
            {
                connection.Open();
                command.CommandText = "INSERT INTO tb_itens(idLista,nome,categoria,quantidade,quantidadePrioridade,preco,prioridade) values('" 
                    + itens.IdLista + "','"+itens.Nome+"','"+itens.Categoria+"','"+itens.Quantidade+"','"+itens.QuantidadePrioridade+"','"+itens.Preco+"','"+itens.Prioridade+"')";
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Houve um problema na conexão ao banco de dados!\n" + ex.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open) connection.Close();
            }


        }
    }
}
