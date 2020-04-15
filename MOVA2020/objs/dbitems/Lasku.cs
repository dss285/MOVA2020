﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOVA2020.objs.dbitems
{
    public class Lasku
    {
        private long lasku_id;
        private Varaus varaus;
        private double summa, alv;

        public Lasku(long lasku_id, double summa, double alv, Varaus varaus)
        {
            this.lasku_id = lasku_id;
            Summa = summa;
            Alv = alv;
            Varaus = varaus;
        }

        public long Lasku_id { get => lasku_id;}
        public double Summa { get => summa; set => summa = value; }
        public double Alv { get => alv; set => alv = value; }
        public Varaus Varaus { get => varaus; set => varaus = value; }
    }
}
