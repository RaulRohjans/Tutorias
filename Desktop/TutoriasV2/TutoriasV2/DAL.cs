using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TutoriasV2
{
    public class DAL
    {
        SqlConnection db = new SqlConnection(Properties.Settings.Default.DB_CONNECTION);
        SqlCommand ocm;
        SqlDataReader reader;

        public DAL(List<Disciplinas> disciplinas, List<Alunos> alunos, List<Apoios> apoios)
        {
            //Disciplinas
            Refresh(disciplinas);

            //Alunos
            Refresh(alunos);

            //Apoios
            Refresh(apoios);
        }

        #region Metodos

        public void Refresh(List<Alunos> alunos)
        {
            alunos.Clear();
            db.Open();
            //Adquirir quantidade de registos
            int qtd = 0;

            ocm = new SqlCommand("Select count(*) from Aluno", db);
            reader = ocm.ExecuteReader();

            while (reader.Read())
                qtd = Convert.ToInt32(reader.GetValue(0));
            reader.Close();

            if (qtd > 0)
            {
                ocm = new SqlCommand("Select * from Aluno", db);
                reader = ocm.ExecuteReader();

                while (reader.Read())
                {
                    Alunos aluno = new Alunos();
                    aluno.AlunoID = reader.GetValue(0).ToString();
                    aluno.Nome = reader.GetValue(1).ToString();
                    aluno.Turma = reader.GetValue(2).ToString();
                    aluno.DataNasc = reader.GetDateTime(3);
                    aluno.Telefone = reader.GetValue(4).ToString();
                    aluno.Morada = reader.GetValue(5).ToString();
                    aluno.Password = reader.GetValue(6).ToString();

                    if (reader.GetValue(7).ToString() == "Aluno")
                        aluno.Tipo = Alunos.enumTipo.Aluno;
                    if (reader.GetValue(7).ToString() == "Tutor")
                        aluno.Tipo = Alunos.enumTipo.Tutor;
                    if (reader.GetValue(7).ToString() == "Admin")
                        aluno.Tipo = Alunos.enumTipo.Admin;

                    aluno.Aprovado = Convert.ToBoolean(reader.GetValue(8));
                    alunos.Add(aluno);

                }

            }
            db.Close();
        }

        public void Refresh(List<Disciplinas> disciplinas)
        {
            disciplinas.Clear();
            db.Open();
            //Adquirir quantidade de registos
            int qtd = 0;

            ocm = new SqlCommand("Select count(*) from Disciplina", db);
            reader = ocm.ExecuteReader();

            while (reader.Read())
                qtd = Convert.ToInt32(reader.GetValue(0));
            reader.Close();

            if (qtd > 0)
            {
                ocm = new SqlCommand("Select * from Disciplina", db);
                reader = ocm.ExecuteReader();

                while (reader.Read())
                {
                    Disciplinas disciplina = new Disciplinas(reader.GetValue(0).ToString(), reader.GetValue(1).ToString(), reader.GetValue(2).ToString());
                    disciplinas.Add(disciplina);
                }
            }
            db.Close();
        }

        public void Refresh(List<Apoios> apoios)
        {
            apoios.Clear();
            db.Open();
            //Adquirir quantidade de registos
            int qtd = 0;

            ocm = new SqlCommand("Select count(*) from Apoio", db);
            reader = ocm.ExecuteReader();

            while (reader.Read())
                qtd = Convert.ToInt32(reader.GetValue(0));
            reader.Close();

            if (qtd > 0)
            {
                ocm = new SqlCommand("Select * from Apoio", db);
                reader = ocm.ExecuteReader();

                while (reader.Read())
                {
                    Apoios apoio = new Apoios();
                    apoio.ApoioID = Convert.ToInt32(reader.GetValue(0));
                    apoio.Sigla = reader.GetValue(1).ToString();
                    apoio.Descricao = reader.GetValue(2).ToString();
                    apoio.ReqDate = reader.GetDateTime(3);
                    apoio.AlunoID = reader.GetValue(4).ToString();
                    apoio.TutorID = reader.GetValue(5).ToString();

                    if (reader.GetValue(6).ToString() == "Pendente")
                        apoio.Estado = Apoios.enumEstado.Pendente;
                    if (reader.GetValue(6).ToString() == "Aceite")
                        apoio.Estado = Apoios.enumEstado.Aceite;
                    if (reader.GetValue(6).ToString() == "Concluido")
                        apoio.Estado = Apoios.enumEstado.Concluido;

                    apoio.Local = reader.GetValue(7).ToString();
                    apoio.Avaliacao = reader.GetValue(8).ToString();
                    apoio.Criado = reader.GetValue(9).ToString();
                    apoios.Add(apoio);
                }
            }
            db.Close();
        }

        public void AddAl(List<Alunos> alunos, Alunos aluno)
        {
            db.Open();
            ocm = new SqlCommand("InsertAl", db);
            ocm.CommandType = System.Data.CommandType.StoredProcedure;

            ocm.Parameters.AddWithValue("@AlunoID", aluno.AlunoID);
            ocm.Parameters.AddWithValue("@Nome", aluno.Nome);
            ocm.Parameters.AddWithValue("@Turma", aluno.Turma);
            ocm.Parameters.AddWithValue("@DataNasc", aluno.DataNasc);

            if (aluno.Telefone == null)
                ocm.Parameters.AddWithValue("@Telefone", DBNull.Value);
            else
                ocm.Parameters.AddWithValue("@Telefone", aluno.Telefone);

            if (aluno.Morada == null)
                ocm.Parameters.AddWithValue("@Morada", DBNull.Value);
            else
                ocm.Parameters.AddWithValue("@Morada", aluno.Morada);

            ocm.Parameters.AddWithValue("@Password", aluno.Password);

            if (aluno.Tipo == Alunos.enumTipo.Aluno)
            {
                ocm.Parameters.AddWithValue("@Tipo", "Aluno");
            }
            else
            {
                if (aluno.Tipo == Alunos.enumTipo.Tutor)
                {
                    ocm.Parameters.AddWithValue("@Tipo", "Tutor");
                }
                else
                {
                    if (aluno.Tipo == Alunos.enumTipo.Admin)
                        ocm.Parameters.AddWithValue("@Tipo", "Admin");
                }
            }


            ocm.Parameters.AddWithValue("@Aprovado", aluno.Aprovado);
            ocm.ExecuteNonQuery();
            db.Close();

            Refresh(alunos);
        }

        public void AddAp(List<Apoios> apoios, Apoios apoio)
        {
            db.Open();
            ocm = new SqlCommand("InsertAp", db);
            ocm.CommandType = System.Data.CommandType.StoredProcedure;

            ocm.Parameters.AddWithValue("@ApoioID", apoio.ApoioID);
            ocm.Parameters.AddWithValue("@Sigla", apoio.Sigla);

            if (apoio.Descricao == null)
                ocm.Parameters.AddWithValue("@Descricao", DBNull.Value);
            else
                ocm.Parameters.AddWithValue("@Descricao", apoio.Descricao);

            ocm.Parameters.AddWithValue("@ReqDate", apoio.ReqDate);
            ocm.Parameters.AddWithValue("@AlunoID", apoio.AlunoID);
            ocm.Parameters.AddWithValue("@TutorID", apoio.TutorID);

            switch (apoio.Estado)
            {
                case Apoios.enumEstado.Aceite:
                    ocm.Parameters.AddWithValue("@Estado", "Aceite");
                    break;

                case Apoios.enumEstado.Concluido:
                    ocm.Parameters.AddWithValue("@Estado", "Concluido");
                    break;

                case Apoios.enumEstado.Pendente:
                    ocm.Parameters.AddWithValue("@Estado", "Pendente");
                    break;

                case Apoios.enumEstado.NULL:
                    ocm.Parameters.AddWithValue("@Estado", DBNull.Value);
                    break;
            }

            ocm.Parameters.AddWithValue("@Local", apoio.Local);

            if (apoio.Avaliacao == null)
                ocm.Parameters.AddWithValue("@Avaliacao", DBNull.Value);
            else
                ocm.Parameters.AddWithValue("@Avaliacao", apoio.Avaliacao);

            ocm.Parameters.AddWithValue("@Criado", apoio.Criado);
            ocm.ExecuteNonQuery();
            db.Close();

            Refresh(apoios);
        }

        public void DelAl(List<Alunos> alunos, Alunos aluno)
        {
            db.Open();
            ocm = new SqlCommand("RemoveAl", db);
            ocm.CommandType = System.Data.CommandType.StoredProcedure;

            ocm.Parameters.AddWithValue("@AlunoID", aluno.AlunoID);
            ocm.ExecuteNonQuery();
            db.Close();

            Refresh(alunos);
        }

        public void DelAp(List<Apoios> apoios, Apoios apoio)
        {
            db.Open();
            ocm = new SqlCommand("RemoveAp", db);
            ocm.CommandType = System.Data.CommandType.StoredProcedure;

            ocm.Parameters.AddWithValue("@ApoioID", apoio.ApoioID);
            ocm.ExecuteNonQuery();
            db.Close();

            Refresh(apoios);
        }

        public void EditAl(List<Alunos> alunos, string AlunoID, string Nome, string Turma, string Telefone, string Morada, string Password, string Tipo)
        {
            db.Open();
            if (Nome != null)
            {
                ocm = new SqlCommand("update Aluno set Nome=\'" + Nome + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Turma != null)
            {
                ocm = new SqlCommand("update Aluno set Turma=\'" + Turma + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Telefone != null)
            {
                ocm = new SqlCommand("update Aluno set Telefone=\'" + Telefone + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Morada != null)
            {
                ocm = new SqlCommand("update Aluno set Morada=\'" + Morada + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Password != null)
            {
                ocm = new SqlCommand("update Aluno set Password=\'" + Password + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Tipo != null)
            {
                ocm = new SqlCommand("update Aluno set Tipo=\'" + Tipo + "\' where AlunoID=\'" + AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }



            db.Close();
            Refresh(alunos);
        }

        public void EditAl(List<Alunos> alunos, string AlunoID, DateTime DataNasc)
        {
            db.Open();

            ocm = new SqlCommand("update Aluno set DataNasc=\'" + DataNasc.ToShortDateString() + "\' where AlunoID=\'" + AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            db.Close();
            Refresh(alunos);
        }

        public void EditAl(List<Alunos> alunos, Alunos aluno)
        {
            db.Open();
            ocm = new SqlCommand("update Aluno set Aprovado=\'" + aluno.Aprovado + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            ocm = new SqlCommand("update Aluno set DataNasc=\'" + aluno.DataNasc.ToShortDateString() + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            if (aluno.Morada != null && aluno.Morada != "")
            {
                ocm = new SqlCommand("update Aluno set Morada=\'" + aluno.Morada + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }

            ocm = new SqlCommand("update Aluno set Nome=\'" + aluno.Nome + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            ocm = new SqlCommand("update Aluno set Password=\'" + aluno.Password + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            if (aluno.Telefone != null && aluno.Telefone != "")
            {
                ocm = new SqlCommand("update Aluno set Telefone=\'" + aluno.Telefone + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
                ocm.ExecuteNonQuery();
            }

            switch (aluno.Tipo)
            {
                case Alunos.enumTipo.Admin:
                    ocm = new SqlCommand("update Aluno set Tipo=\'" + "Admin" + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;

                case Alunos.enumTipo.Aluno:
                    ocm = new SqlCommand("update Aluno set Tipo=\'" + "Aluno" + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;

                case Alunos.enumTipo.Tutor:
                    ocm = new SqlCommand("update Aluno set Tipo=\'" + "Tutor" + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;
            }

            ocm = new SqlCommand("update Aluno set Turma=\'" + aluno.Turma + "\' where AlunoID=\'" + aluno.AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            db.Close();
            Refresh(alunos);
        }

        public void EditAl(List<Alunos> alunos, string AlunoID, bool Aprovado)
        {
            db.Open();

            //Aprovado
            ocm = new SqlCommand("update Aluno set Aprovado=\'" + Aprovado + "\' where AlunoID=\'" + AlunoID + "\'", db);
            ocm.ExecuteNonQuery();

            db.Close();
            Refresh(alunos);
        }

        public void EditAp(List<Apoios> apoios, int ApoioID, string Sigla, string Descricao, string AlunoID, string TutorID, string Estado, string Local, string Avaliacao, string Criado)
        {
            db.Open();
            if (Sigla != null)
            {
                ocm = new SqlCommand("update Apoio set Sigla=\'" + Sigla + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Descricao != null)
            {
                ocm = new SqlCommand("update Apoio set Descricao=\'" + Descricao + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (AlunoID != null)
            {
                ocm = new SqlCommand("update Apoio set AlunoID=\'" + AlunoID + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (TutorID != null)
            {
                ocm = new SqlCommand("update Apoio set TutorID=\'" + TutorID + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Estado != null)
            {
                ocm = new SqlCommand("update Apoio set Estado=\'" + Estado + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Local != null)
            {
                ocm = new SqlCommand("update Apoio set Local=\'" + Local + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if (Avaliacao != null)
            {
                ocm = new SqlCommand("update Apoio set Avaliacao=\'" + Avaliacao + "\' where ApoioID=\'" + ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            if(Criado != null)
            {
                ocm = new SqlCommand("update Apoio set Criado=\'" + Criado + "\' where ApoioID=\'" + ApoioID + "\'", db);
            }
            db.Close();
            Refresh(apoios);
        }

        public void EditAp(List<Apoios> apoios, int ApoioID, DateTime ReqDate)
        {
            db.Open();

            ocm = new SqlCommand("update Apoio set ReqDate=\'" + ReqDate.ToShortDateString() + "\' where ApoioID=\'" + ApoioID + "\'", db);
            ocm.ExecuteNonQuery();

            db.Close();
            Refresh(apoios);
        }

        public void EditAp(List<Apoios> apoios, Apoios apoio)
        {
            db.Open();
            ocm = new SqlCommand("update Apoio set Sigla=\'" + apoio.Sigla + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
            ocm.ExecuteNonQuery();

            if (apoio.Descricao != null && apoio.Descricao != "")
            {
                ocm = new SqlCommand("update Apoio set Descricao=\'" + apoio.Descricao + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }


            ocm = new SqlCommand("update Apoio set AlunoID=\'" + apoio.AlunoID + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
            ocm.ExecuteNonQuery();

            ocm = new SqlCommand("update Apoio set ReqDate=\'" + apoio.ReqDate.ToShortDateString() + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
            ocm.ExecuteNonQuery();


            ocm = new SqlCommand("update Apoio set TutorID=\'" + apoio.TutorID + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
            ocm.ExecuteNonQuery();

            switch (apoio.Estado)
            {
                case Apoios.enumEstado.Aceite:
                    ocm = new SqlCommand("update Apoio set Estado=\'" + "Aceite" + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;

                case Apoios.enumEstado.Concluido:
                    ocm = new SqlCommand("update Apoio set Estado=\'" + "Concluido" + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;

                case Apoios.enumEstado.Pendente:
                    ocm = new SqlCommand("update Apoio set Estado=\'" + "Pendente" + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                    ocm.ExecuteNonQuery();
                    break;
            }

            ocm = new SqlCommand("update Apoio set Local=\'" + apoio.Local + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
            ocm.ExecuteNonQuery();

            if (apoio.Avaliacao != null && apoio.Avaliacao != "" && apoio.Avaliacao != "NULL")
            {
                ocm = new SqlCommand("update Apoio set Avaliacao=\'" + apoio.Avaliacao + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }
            else
            {
                if(apoio.Avaliacao == "NULL")
                {
                    ocm = new SqlCommand("update Apoio set Avaliacao=\'" + DBNull.Value + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                    ocm.ExecuteNonQuery();
                }
            }

            if (apoio.Criado != null && apoio.Criado != "")
            {
                ocm = new SqlCommand("update Apoio set Criado=\'" + apoio.Criado + "\' where ApoioID=\'" + apoio.ApoioID + "\'", db);
                ocm.ExecuteNonQuery();
            }

            db.Close();
            Refresh(apoios);
        }

        #endregion


    }
}
