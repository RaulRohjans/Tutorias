using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoriasV2
{
    public class Alunos
    {
        #region Campos
        private string mAlunoID;
        private string mNome;
        private string mTurma;
        private DateTime mDataNasc;
        private string mTelefone;
        private string mMorada;
        private string mPassword;
        private enumTipo mTipo;
        private bool mAprovado;
        #endregion

        #region Construtores

        //Default
        public Alunos()
        {
            mAlunoID = "";
            mNome = "";
            mTurma = "";
            mDataNasc = DateTime.Now;
            mTelefone = "";
            mMorada = "";
            mPassword = "";
            mTipo = enumTipo.NULL;
            mAprovado = false;
        }

        //Non Default
        public Alunos(string AlunoID, string Nome, string Turma, DateTime DataNasc, string Telefone, string Morada, string Password, enumTipo Tipo, bool Aprovado)
        {
            mAlunoID = AlunoID;
            mNome = Nome;
            mTurma = Turma;
            mDataNasc = DataNasc;
            mTelefone = Telefone;
            mMorada = Morada;
            mPassword = Password;
            mTipo = Tipo;
            mAprovado = Aprovado;
        }
        #endregion

        #region Propriedades

        public string AlunoID
        {
            get { return mAlunoID; }
            set { mAlunoID = value; }
        }

        public string Nome
        {
            get { return mNome; }
            set { mNome = value; }
        }

        public string Turma
        {
            get { return mTurma; }
            set { mTurma = value; }
        }

        public DateTime DataNasc
        {
            get { return mDataNasc; }
            set { mDataNasc = value; }
        }

        public string Telefone
        {
            get { return mTelefone; }
            set { mTelefone = value; }
        }

        public string Morada
        {
            get { return mMorada; }
            set { mMorada = value; }
        }

        public string Password
        {
            get { return mPassword; }
            set { mPassword = value; }
        }

        public enumTipo Tipo
        {
            get { return mTipo; }
            set { mTipo = value; }
        }

        public bool Aprovado
        {
            get { return mAprovado; }
            set { mAprovado = value; }
        }
        #endregion

        #region Enumerators
        public enum enumTipo
        {
            NULL,
            Aluno,
            Tutor,
            Admin,
        }

        #endregion
    }
}
