namespace ListaDeCompras
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNovaLista = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnProcurar = new System.Windows.Forms.Button();
            this.panelNovaLista = new System.Windows.Forms.Panel();
            this.label24 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblQuantidadeItens = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblQuantidadePrioridade = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTotalPrioridade = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDisponivel = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.checkPrioridade = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPrecoTotal = new System.Windows.Forms.Label();
            this.btnRemoverLista = new System.Windows.Forms.Button();
            this.separator = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdLista = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboCategoria = new System.Windows.Forms.ComboBox();
            this.comboQuantidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomeItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeLista = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.listNovaLista = new System.Windows.Forms.ListView();
            this.nomeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.categoriaItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.quantidadeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.precoItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.prioridadeItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label18 = new System.Windows.Forms.Label();
            this.panelFinalizado = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.label26 = new System.Windows.Forms.Label();
            this.label25 = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panelNovaLista.SuspendLayout();
            this.panelFinalizado.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNovaLista
            // 
            this.btnNovaLista.Location = new System.Drawing.Point(3, 34);
            this.btnNovaLista.Name = "btnNovaLista";
            this.btnNovaLista.Size = new System.Drawing.Size(75, 23);
            this.btnNovaLista.TabIndex = 0;
            this.btnNovaLista.Text = "Nova Lista";
            this.btnNovaLista.UseVisualStyleBackColor = true;
            this.btnNovaLista.Click += new System.EventHandler(this.btnNovaLista_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnListar);
            this.panel1.Controls.Add(this.btnProcurar);
            this.panel1.Controls.Add(this.btnNovaLista);
            this.panel1.Location = new System.Drawing.Point(12, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(93, 314);
            this.panel1.TabIndex = 1;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(3, 92);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 44);
            this.btnListar.TabIndex = 2;
            this.btnListar.Text = "Listar todas as listas";
            this.btnListar.UseVisualStyleBackColor = true;
            // 
            // btnProcurar
            // 
            this.btnProcurar.Location = new System.Drawing.Point(3, 63);
            this.btnProcurar.Name = "btnProcurar";
            this.btnProcurar.Size = new System.Drawing.Size(75, 23);
            this.btnProcurar.TabIndex = 1;
            this.btnProcurar.Text = "Procurar";
            this.btnProcurar.UseVisualStyleBackColor = true;
            // 
            // panelNovaLista
            // 
            this.panelNovaLista.Controls.Add(this.btnEditar);
            this.panelNovaLista.Controls.Add(this.label24);
            this.panelNovaLista.Controls.Add(this.lblStatus);
            this.panelNovaLista.Controls.Add(this.label23);
            this.panelNovaLista.Controls.Add(this.label22);
            this.panelNovaLista.Controls.Add(this.label20);
            this.panelNovaLista.Controls.Add(this.label21);
            this.panelNovaLista.Controls.Add(this.label19);
            this.panelNovaLista.Controls.Add(this.label17);
            this.panelNovaLista.Controls.Add(this.label16);
            this.panelNovaLista.Controls.Add(this.label15);
            this.panelNovaLista.Controls.Add(this.label14);
            this.panelNovaLista.Controls.Add(this.label13);
            this.panelNovaLista.Controls.Add(this.label12);
            this.panelNovaLista.Controls.Add(this.lblQuantidadeItens);
            this.panelNovaLista.Controls.Add(this.label10);
            this.panelNovaLista.Controls.Add(this.lblQuantidadePrioridade);
            this.panelNovaLista.Controls.Add(this.label11);
            this.panelNovaLista.Controls.Add(this.lblTotalPrioridade);
            this.panelNovaLista.Controls.Add(this.label9);
            this.panelNovaLista.Controls.Add(this.txtDisponivel);
            this.panelNovaLista.Controls.Add(this.label8);
            this.panelNovaLista.Controls.Add(this.checkPrioridade);
            this.panelNovaLista.Controls.Add(this.label7);
            this.panelNovaLista.Controls.Add(this.lblPrecoTotal);
            this.panelNovaLista.Controls.Add(this.btnRemoverLista);
            this.panelNovaLista.Controls.Add(this.separator);
            this.panelNovaLista.Controls.Add(this.btnLimpar);
            this.panelNovaLista.Controls.Add(this.btnAdicionar);
            this.panelNovaLista.Controls.Add(this.label6);
            this.panelNovaLista.Controls.Add(this.txtIdLista);
            this.panelNovaLista.Controls.Add(this.label5);
            this.panelNovaLista.Controls.Add(this.txtPreco);
            this.panelNovaLista.Controls.Add(this.label4);
            this.panelNovaLista.Controls.Add(this.comboCategoria);
            this.panelNovaLista.Controls.Add(this.comboQuantidade);
            this.panelNovaLista.Controls.Add(this.label3);
            this.panelNovaLista.Controls.Add(this.txtNomeItem);
            this.panelNovaLista.Controls.Add(this.label2);
            this.panelNovaLista.Controls.Add(this.txtNomeLista);
            this.panelNovaLista.Controls.Add(this.label1);
            this.panelNovaLista.Controls.Add(this.btnFinalizar);
            this.panelNovaLista.Controls.Add(this.listNovaLista);
            this.panelNovaLista.Location = new System.Drawing.Point(171, 23);
            this.panelNovaLista.Name = "panelNovaLista";
            this.panelNovaLista.Size = new System.Drawing.Size(696, 502);
            this.panelNovaLista.TabIndex = 2;
            this.panelNovaLista.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Enabled = false;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(185, 371);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(157, 13);
            this.label24.TabIndex = 41;
            this.label24.Text = "Manter 0 para não atribuir limite.";
            // 
            // lblStatus
            // 
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Crimson;
            this.lblStatus.Location = new System.Drawing.Point(17, 476);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(370, 20);
            this.lblStatus.TabIndex = 40;
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label23.Location = new System.Drawing.Point(529, 466);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(163, 2);
            this.label23.TabIndex = 39;
            // 
            // label22
            // 
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label22.Location = new System.Drawing.Point(404, 466);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(117, 2);
            this.label22.TabIndex = 38;
            // 
            // label20
            // 
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label20.Location = new System.Drawing.Point(530, 412);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(15, 2);
            this.label20.TabIndex = 36;
            // 
            // label21
            // 
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label21.Location = new System.Drawing.Point(577, 412);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(112, 2);
            this.label21.TabIndex = 37;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Enabled = false;
            this.label19.Location = new System.Drawing.Point(544, 405);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(35, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Preço";
            // 
            // label17
            // 
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label17.Location = new System.Drawing.Point(529, 412);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(2, 55);
            this.label17.TabIndex = 34;
            // 
            // label16
            // 
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(519, 412);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(2, 55);
            this.label16.TabIndex = 33;
            // 
            // label15
            // 
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label15.Location = new System.Drawing.Point(404, 413);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(2, 55);
            this.label15.TabIndex = 32;
            // 
            // label14
            // 
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label14.Location = new System.Drawing.Point(404, 412);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 2);
            this.label14.TabIndex = 31;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Enabled = false;
            this.label13.Location = new System.Drawing.Point(419, 405);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Quantidade";
            // 
            // label12
            // 
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label12.Location = new System.Drawing.Point(480, 412);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(40, 2);
            this.label12.TabIndex = 29;
            // 
            // lblQuantidadeItens
            // 
            this.lblQuantidadeItens.AutoSize = true;
            this.lblQuantidadeItens.Location = new System.Drawing.Point(483, 445);
            this.lblQuantidadeItens.Name = "lblQuantidadeItens";
            this.lblQuantidadeItens.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidadeItens.TabIndex = 28;
            this.lblQuantidadeItens.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(411, 445);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "ITENS:";
            // 
            // lblQuantidadePrioridade
            // 
            this.lblQuantidadePrioridade.AutoSize = true;
            this.lblQuantidadePrioridade.Location = new System.Drawing.Point(483, 421);
            this.lblQuantidadePrioridade.Name = "lblQuantidadePrioridade";
            this.lblQuantidadePrioridade.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidadePrioridade.TabIndex = 26;
            this.lblQuantidadePrioridade.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(411, 421);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "PRIORIDADE:";
            // 
            // lblTotalPrioridade
            // 
            this.lblTotalPrioridade.AutoSize = true;
            this.lblTotalPrioridade.Location = new System.Drawing.Point(646, 421);
            this.lblTotalPrioridade.Name = "lblTotalPrioridade";
            this.lblTotalPrioridade.Size = new System.Drawing.Size(13, 13);
            this.lblTotalPrioridade.TabIndex = 24;
            this.lblTotalPrioridade.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(534, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "TOTAL PRIORIDADE:";
            // 
            // txtDisponivel
            // 
            this.txtDisponivel.Location = new System.Drawing.Point(118, 367);
            this.txtDisponivel.Name = "txtDisponivel";
            this.txtDisponivel.Size = new System.Drawing.Size(61, 20);
            this.txtDisponivel.TabIndex = 22;
            this.txtDisponivel.Text = "0";
            this.txtDisponivel.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Dinheiro Disponivel";
            // 
            // checkPrioridade
            // 
            this.checkPrioridade.AutoSize = true;
            this.checkPrioridade.Location = new System.Drawing.Point(354, 67);
            this.checkPrioridade.Name = "checkPrioridade";
            this.checkPrioridade.Size = new System.Drawing.Size(73, 17);
            this.checkPrioridade.TabIndex = 20;
            this.checkPrioridade.Text = "Prioridade";
            this.checkPrioridade.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 445);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "TOTAL:";
            // 
            // lblPrecoTotal
            // 
            this.lblPrecoTotal.AutoSize = true;
            this.lblPrecoTotal.Location = new System.Drawing.Point(646, 445);
            this.lblPrecoTotal.Name = "lblPrecoTotal";
            this.lblPrecoTotal.Size = new System.Drawing.Size(13, 13);
            this.lblPrecoTotal.TabIndex = 18;
            this.lblPrecoTotal.Text = "0";
            // 
            // btnRemoverLista
            // 
            this.btnRemoverLista.Location = new System.Drawing.Point(537, 476);
            this.btnRemoverLista.Name = "btnRemoverLista";
            this.btnRemoverLista.Size = new System.Drawing.Size(75, 23);
            this.btnRemoverLista.TabIndex = 16;
            this.btnRemoverLista.Text = "Remover";
            this.btnRemoverLista.UseVisualStyleBackColor = true;
            this.btnRemoverLista.Click += new System.EventHandler(this.btnRemoverLista_Click);
            // 
            // separator
            // 
            this.separator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator.Location = new System.Drawing.Point(-4, 99);
            this.separator.Name = "separator";
            this.separator.Size = new System.Drawing.Size(705, 2);
            this.separator.TabIndex = 15;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(519, 103);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(89, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar campos";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(614, 104);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Categoria";
            // 
            // txtIdLista
            // 
            this.txtIdLista.Location = new System.Drawing.Point(618, 7);
            this.txtIdLista.Name = "txtIdLista";
            this.txtIdLista.Size = new System.Drawing.Size(71, 20);
            this.txtIdLista.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(565, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Nº. Lista";
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(506, 37);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(55, 20);
            this.txtPreco.TabIndex = 10;
            this.txtPreco.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(417, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Preço estimado:";
            // 
            // comboCategoria
            // 
            this.comboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCategoria.FormattingEnabled = true;
            this.comboCategoria.Items.AddRange(new object[] {
            "Alimentos"});
            this.comboCategoria.Location = new System.Drawing.Point(91, 63);
            this.comboCategoria.Name = "comboCategoria";
            this.comboCategoria.Size = new System.Drawing.Size(121, 21);
            this.comboCategoria.TabIndex = 8;
            this.comboCategoria.SelectedIndexChanged += new System.EventHandler(this.comboCategoria_SelectedIndexChanged);
            // 
            // comboQuantidade
            // 
            this.comboQuantidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboQuantidade.FormattingEnabled = true;
            this.comboQuantidade.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.comboQuantidade.Location = new System.Drawing.Point(286, 63);
            this.comboQuantidade.Name = "comboQuantidade";
            this.comboQuantidade.Size = new System.Drawing.Size(50, 21);
            this.comboQuantidade.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Quantidade";
            // 
            // txtNomeItem
            // 
            this.txtNomeItem.Location = new System.Drawing.Point(91, 37);
            this.txtNomeItem.Name = "txtNomeItem";
            this.txtNomeItem.Size = new System.Drawing.Size(320, 20);
            this.txtNomeItem.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome do item";
            // 
            // txtNomeLista
            // 
            this.txtNomeLista.Location = new System.Drawing.Point(91, 7);
            this.txtNomeLista.Name = "txtNomeLista";
            this.txtNomeLista.Size = new System.Drawing.Size(468, 20);
            this.txtNomeLista.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome da lista";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(618, 476);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(75, 23);
            this.btnFinalizar.TabIndex = 1;
            this.btnFinalizar.Text = "Finalizar";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // listNovaLista
            // 
            this.listNovaLista.BackColor = System.Drawing.Color.White;
            this.listNovaLista.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nomeItem,
            this.categoriaItem,
            this.quantidadeItem,
            this.precoItem,
            this.prioridadeItem});
            this.listNovaLista.FullRowSelect = true;
            this.listNovaLista.GridLines = true;
            this.listNovaLista.Location = new System.Drawing.Point(3, 133);
            this.listNovaLista.Name = "listNovaLista";
            this.listNovaLista.Size = new System.Drawing.Size(690, 223);
            this.listNovaLista.TabIndex = 0;
            this.listNovaLista.UseCompatibleStateImageBehavior = false;
            this.listNovaLista.View = System.Windows.Forms.View.Details;
            this.listNovaLista.SelectedIndexChanged += new System.EventHandler(this.listNovaLista_SelectedIndexChanged);
            // 
            // nomeItem
            // 
            this.nomeItem.Text = "Nome Item";
            this.nomeItem.Width = 323;
            // 
            // categoriaItem
            // 
            this.categoriaItem.Text = "Categoria";
            this.categoriaItem.Width = 120;
            // 
            // quantidadeItem
            // 
            this.quantidadeItem.Text = "Quantidade";
            this.quantidadeItem.Width = 80;
            // 
            // precoItem
            // 
            this.precoItem.Text = "Preço";
            this.precoItem.Width = 76;
            // 
            // prioridadeItem
            // 
            this.prioridadeItem.Text = "Prioridade";
            this.prioridadeItem.Width = 86;
            // 
            // label18
            // 
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label18.Location = new System.Drawing.Point(859, 435);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(2, 55);
            this.label18.TabIndex = 35;
            // 
            // panelFinalizado
            // 
            this.panelFinalizado.Controls.Add(this.btnImprimir);
            this.panelFinalizado.Controls.Add(this.label26);
            this.panelFinalizado.Controls.Add(this.label25);
            this.panelFinalizado.Location = new System.Drawing.Point(167, 23);
            this.panelFinalizado.Name = "panelFinalizado";
            this.panelFinalizado.Size = new System.Drawing.Size(705, 502);
            this.panelFinalizado.TabIndex = 36;
            this.panelFinalizado.Visible = false;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(302, 104);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 2;
            this.btnImprimir.Text = "imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(275, 73);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(148, 13);
            this.label26.TabIndex = 1;
            this.label26.Text = "Deseja imprimir a lista criada ?";
            // 
            // label25
            // 
            this.label25.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.Lime;
            this.label25.Location = new System.Drawing.Point(73, 17);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(558, 23);
            this.label25.TabIndex = 0;
            this.label25.Text = "LISTA FINALIZADA E CRIADA COM SUCESSO.";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(456, 475);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 42;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 537);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panelNovaLista);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelFinalizado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panelNovaLista.ResumeLayout(false);
            this.panelNovaLista.PerformLayout();
            this.panelFinalizado.ResumeLayout(false);
            this.panelFinalizado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNovaLista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnProcurar;
        private System.Windows.Forms.Panel panelNovaLista;
        private System.Windows.Forms.TextBox txtNomeItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeLista;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.ListView listNovaLista;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdLista;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboCategoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label separator;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ColumnHeader nomeItem;
        private System.Windows.Forms.ColumnHeader categoriaItem;
        private System.Windows.Forms.ColumnHeader quantidadeItem;
        private System.Windows.Forms.ColumnHeader precoItem;
        private System.Windows.Forms.Button btnRemoverLista;
        private System.Windows.Forms.ComboBox comboQuantidade;
        private System.Windows.Forms.Label lblPrecoTotal;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblQuantidadePrioridade;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalPrioridade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDisponivel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox checkPrioridade;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ColumnHeader prioridadeItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblQuantidadeItens;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Panel panelFinalizado;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Button btnEditar;
    }
}

