﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ed2_project5
{
    class Senha
    {
        #region atributos
        private int id;
        private DateTime dataGerac;
        private DateTime horaGerac;
        private DateTime dataAtend;
        private DateTime horaAtend;
        #endregion

        #region propriedades
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public DateTime DataGerac
        {
            get { return dataGerac; }
            set { dataGerac = value; }
        }
        public DateTime HoraGerac
        {
            get { return horaGerac; }
            set { horaGerac = value; }
        }
        public DateTime DataAtend
        {
            get { return dataAtend; }
            set { dataAtend = value; }
        }
        public DateTime HoraAtend
        {
            get { return horaAtend; }
            set { horaAtend = value; }
        }

        #endregion

            #region construtor
        public Senha(int id)
        {
            this.id = id;
            this.dataGerac = DateTime.Now.Date;
            this.horaGerac = new DateTime(DateTime.Now.Ticks - DataGerac.Ticks);

        }
        #endregion

        #region metodos
        public string dadosParciais()
        {
            return this.id.ToString() + "-" + this.dataGerac.ToShortDateString() + "-" + this.horaGerac.ToLongTimeString();
        }

        public string dadosCompletos()
        {
            return dadosParciais() + "-" + this.dataAtend.ToShortDateString() + "-" + this.horaAtend.ToLongTimeString();

        }
        #endregion
    }
}
