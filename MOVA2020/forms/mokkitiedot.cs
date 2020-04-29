﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MOVA2020;
using MOVA2020.objs.dbitems;
namespace MOVA2020.forms
{
    public partial class mokkitiedot : Form
    {
        private Primary p;
        private Mokki m;
        public mokkitiedot(Primary p, Mokki m)
        {
            InitializeComponent();
            this.p = p;
            this.m = m;
            tbNimi.Text = m.Mokkinimi;
            tbToimintaalue.Text = m.Toimintaalue.Nimi;

            tbKatuosoite.Text = m.Katuosoite;
            tbPostinumero.Text = m.Posti.Postinro;
            tbPaikkakunta.Text = m.Posti.Toimipaikka;

            tbHinta.Text = m.Hinta.ToString();
            nmrHenkilomaara.Value = m.Henkilomaara;

            rtbVarustelu.Text = m.Varustelu;
            rtbKuvaus.Text = m.Kuvaus;

            this.paivita();
            
        }
        public void paivita()
        {
            this.p.paivita();
            dgvVaraukset.DataSource = null;
            dgvVaraukset.DataSource = this.Varaukset;
        }
        public List<Varaus> Varaukset => p.Varaukset.FindAll(i => i.Mokki.Mokki_id == this.m.Mokki_id);
    }
}
