﻿using WindowsFormsApp1.Controls;
namespace WindowsFormsApp1
{
    partial class FrmOrder
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmOrder));
            this.lst_produtos = new System.Windows.Forms.ListBox();
            this.lst_compras = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnQuantidade = new System.Windows.Forms.Button();
            this.btnFinzaliar = new System.Windows.Forms.Button();
            this.lblQuantidade = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtQuantity = new WindowsFormsApp1.Controls.txtInt();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSelectUser = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lst_produtos
            // 
            this.lst_produtos.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_produtos.BackColor = System.Drawing.Color.Gray;
            this.lst_produtos.Font = new System.Drawing.Font("Consolas", 10F, System.Drawing.FontStyle.Bold);
            this.lst_produtos.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lst_produtos.FormattingEnabled = true;
            this.lst_produtos.ItemHeight = 15;
            this.lst_produtos.Location = new System.Drawing.Point(12, 98);
            this.lst_produtos.Name = "lst_produtos";
            this.lst_produtos.Size = new System.Drawing.Size(342, 319);
            this.lst_produtos.TabIndex = 0;
            this.lst_produtos.DoubleClick += new System.EventHandler(this.lst_produtos_DoubleClick);
            // 
            // lst_compras
            // 
            this.lst_compras.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lst_compras.BackColor = System.Drawing.Color.Gray;
            this.lst_compras.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold);
            this.lst_compras.ForeColor = System.Drawing.Color.Black;
            this.lst_compras.FormattingEnabled = true;
            this.lst_compras.ItemHeight = 14;
            this.lst_compras.Location = new System.Drawing.Point(433, 98);
            this.lst_compras.Name = "lst_compras";
            this.lst_compras.Size = new System.Drawing.Size(323, 326);
            this.lst_compras.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblTotal.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTotal.Font = new System.Drawing.Font("Consolas", 11F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(433, 429);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(323, 41);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total R$";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnQuantidade
            // 
            this.btnQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnQuantidade.Image = ((System.Drawing.Image)(resources.GetObject("btnQuantidade.Image")));
            this.btnQuantidade.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuantidade.Location = new System.Drawing.Point(256, 2);
            this.btnQuantidade.Name = "btnQuantidade";
            this.btnQuantidade.Size = new System.Drawing.Size(82, 31);
            this.btnQuantidade.TabIndex = 3;
            this.btnQuantidade.Text = "button1";
            this.btnQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuantidade.UseVisualStyleBackColor = true;
            this.btnQuantidade.Click += new System.EventHandler(this.btnIniciarCompra_Click);
            // 
            // btnFinzaliar
            // 
            this.btnFinzaliar.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnFinzaliar.BackColor = System.Drawing.Color.Transparent;
            this.btnFinzaliar.Image = ((System.Drawing.Image)(resources.GetObject("btnFinzaliar.Image")));
            this.btnFinzaliar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFinzaliar.Location = new System.Drawing.Point(430, 483);
            this.btnFinzaliar.Name = "btnFinzaliar";
            this.btnFinzaliar.Size = new System.Drawing.Size(323, 31);
            this.btnFinzaliar.TabIndex = 5;
            this.btnFinzaliar.Text = "button3";
            this.btnFinzaliar.UseVisualStyleBackColor = false;
            this.btnFinzaliar.Click += new System.EventHandler(this.btnFinzaliar_Click);
            // 
            // lblQuantidade
            // 
            this.lblQuantidade.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblQuantidade.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantidade.Location = new System.Drawing.Point(1, 8);
            this.lblQuantidade.Name = "lblQuantidade";
            this.lblQuantidade.Size = new System.Drawing.Size(132, 23);
            this.lblQuantidade.TabIndex = 7;
            this.lblQuantidade.Text = "label1";
            this.lblQuantidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.lblCustomer);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnSelectUser);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lst_produtos);
            this.panel1.Controls.Add(this.lst_compras);
            this.panel1.Controls.Add(this.lblTotal);
            this.panel1.Controls.Add(this.btnFinzaliar);
            this.panel1.Location = new System.Drawing.Point(7, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 514);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(289, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(49, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.lblQuantidade);
            this.panel2.Controls.Add(this.txtQuantity);
            this.panel2.Controls.Add(this.btnQuantidade);
            this.panel2.Location = new System.Drawing.Point(12, 423);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 47);
            this.panel2.TabIndex = 15;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.txtQuantity.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(149, 8);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(48, 22);
            this.txtQuantity.TabIndex = 8;
            // 
            // lblCustomer
            // 
            this.lblCustomer.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCustomer.BackColor = System.Drawing.Color.White;
            this.lblCustomer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCustomer.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.ForeColor = System.Drawing.SystemColors.InfoText;
            this.lblCustomer.Location = new System.Drawing.Point(259, 18);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(497, 40);
            this.lblCustomer.TabIndex = 14;
            this.lblCustomer.Text = "label";
            this.lblCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(430, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "Produtos Adicionados";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelectUser
            // 
            this.btnSelectUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnSelectUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSelectUser.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectUser.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectUser.Image")));
            this.btnSelectUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectUser.Location = new System.Drawing.Point(12, 17);
            this.btnSelectUser.Name = "btnSelectUser";
            this.btnSelectUser.Size = new System.Drawing.Size(185, 40);
            this.btnSelectUser.TabIndex = 12;
            this.btnSelectUser.Text = "Iniciar uma compra";
            this.btnSelectUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelectUser.UseVisualStyleBackColor = false;
            this.btnSelectUser.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Produtos disponíveis";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FrmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.panel1);
            this.Name = "FrmOrder";
            this.Size = new System.Drawing.Size(794, 517);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst_produtos;
        private System.Windows.Forms.ListBox lst_compras;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Button btnQuantidade;
        private System.Windows.Forms.Button btnFinzaliar;
        private System.Windows.Forms.Label lblQuantidade;
        private Controls.txtInt txtQuantity;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelectUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
    }
}
