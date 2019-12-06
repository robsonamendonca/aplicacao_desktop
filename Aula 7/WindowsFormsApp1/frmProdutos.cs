﻿using Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frmProdutos : Form
    {
        public frmProdutos()
        {
            InitializeComponent();
        }

        private void frmProdutos_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPessoa.frmProds = null;
        }

        private void frmProdutos_Load(object sender, EventArgs e)
        {
            dgvProdutos.DataSource = Produto.Lista();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmProduto frm = new FrmProduto();
            frm.MdiParent = this.MdiParent;
            frm.Show();
        }
    }
}
