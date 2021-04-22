using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoriasV2
{
    public class Disciplinas
    {
        #region Campos
        private string mSigla;
        private string mDesignacao;
        private string mComponente;
        #endregion

        #region Construtores
        //Default
        public Disciplinas()
        {
            mSigla = "";
            mDesignacao = "";
            mComponente = "";
        }

        //Non default
        public Disciplinas(string sigla, string designacao, string componente)
        {
            mSigla = sigla;
            mDesignacao = designacao;
            mComponente = componente;
        }
        #endregion

        #region Propriedades

        public string Sigla
        {
            get { return mSigla; }
            set { mSigla = value; }
        }

        public string Designacao
        {
            get { return mDesignacao; }
            set { mDesignacao = value; }
        }

        public string Componente
        {
            get { return mComponente; }
            set { mComponente = value; }
        }
        #endregion
    }
}
