using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoriasV2
{
    public class Apoios
    {
        #region Campos
        private int mApoioID;
        private string mSigla;
        private string mDescricao;
        private DateTime mReqDate;
        private string mAlunoID;
        private string mTutorID;
        private enumEstado mEstado;
        private string mLocal;
        private string mAvaliacao;
        private string mCriado;
        #endregion

        #region Construtores

        //Default
        public Apoios()
        {
            mApoioID = -1;
            mSigla = "";
            mDescricao = "";
            mReqDate = DateTime.Now;
            mAlunoID = "";
            mTutorID = "";
            mEstado = enumEstado.NULL;
            mLocal = "";
            mAvaliacao = "";
            mCriado = "";
        }

        //Non default
        public Apoios(int ApoioID, string Sigla, string Descricao, DateTime ReqDate, string AlunoID, string TutorID, enumEstado Estado, string Local, string Avaliacao, string Criado)
        {
            mApoioID = ApoioID;
            mSigla = Sigla;
            mDescricao = Descricao;
            mReqDate = ReqDate;
            mAlunoID = AlunoID;
            mTutorID = TutorID;
            mEstado = Estado;
            mLocal = Local;
            mAvaliacao = Avaliacao;
            mCriado = Criado;
        }
        #endregion

        #region Propriedades

        public int ApoioID
        {
            get { return mApoioID; }
            set { mApoioID = value; }
        }

        public string Sigla
        {
            get { return mSigla; }
            set { mSigla = value; }
        }

        public string Descricao
        {
            get { return mDescricao; }
            set { mDescricao = value; }
        }

        public DateTime ReqDate
        {
            get { return mReqDate; }
            set { mReqDate = value; }
        }

        public string AlunoID
        {
            get { return mAlunoID; }
            set { mAlunoID = value; }
        }

        public string TutorID
        {
            get { return mTutorID; }
            set { mTutorID = value; }
        }

        public enumEstado Estado
        {
            get { return mEstado; }
            set { mEstado = value; }
        }

        public string Local
        {
            get { return mLocal; }
            set { mLocal = value; }
        }

        public string Avaliacao
        {
            get { return mAvaliacao; }
            set { mAvaliacao = value; }
        }

        public string Criado
        {
            get { return mCriado; }
            set { mCriado = value; }
        }
        #endregion

        #region Enumerators
        public enum enumEstado
        {
            NULL,
            Pendente,
            Aceite,
            Concluido,
        }

        #endregion
    }
}
