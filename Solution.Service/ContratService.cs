using Service.Pattern;
using Solution.Data.Infrastructure;
using Solution.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solution.Service
{
    public class ContratService : Service<Contrat>, IServiceContrat
    {

        private static IDataBaseFactory f = new DataBaseFactory();
        private static IUnitOfWork ut = new UnitOfWork(f);

        public ContratService() : base(ut) { }

        public Contrat GetContrat(int IDClient, int IDAnnonce)
        {
            string connectionString = @"Data Source =(LocalDb)\MSSQLLocalDB; Initial Catalog=base_Arctic_Dari;  Integrated Security=True";
            using (SqlConnection s = new SqlConnection(connectionString))
            {
                s.Open();
                using (SqlCommand cmdSelect =
                    new SqlCommand($"SELECT ClientID,AnnonceId,DateContrat,DateFinContrat,Description,PrixContrat,motif  from Contrats where ClientID={IDClient} and AnnonceID={IDAnnonce};", s))
                {
                    cmdSelect.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader sqlDataReader = cmdSelect.ExecuteReader())
                    {
                        sqlDataReader.Read();
                        if (sqlDataReader.FieldCount == 0)
                        {
                            return null;
                        }
                        else
                        {
                            Contrat contrat = new Contrat { };

                            contrat.ClientID = sqlDataReader.GetInt32(0);
                            contrat.AnnonceId = sqlDataReader.GetInt32(1);
                            contrat.DateContrat = sqlDataReader.GetDateTime(2);
                            contrat.DateFinContrat = sqlDataReader.GetDateTime(3);
                            contrat.Description = sqlDataReader.GetString(4);
                            contrat.PrixContrat = sqlDataReader.GetFloat(5);
                            contrat.motif = (Contrat.Motif)sqlDataReader.GetValue(6);

                            sqlDataReader.Close();

                            return contrat;
                        }
                    }
                }
            }
        }

        public Contrat ModContrat(int IDClient, int IDAnnonce, Contrat contrat)
        {
            if (contrat.motif.Equals("Location"))
            {
                contrat.motif = 0;
            }
            else if (contrat.motif.Equals("Vente"))
                contrat.motif = (Contrat.Motif)1;


            string connectionString = @"Data Source =(LocalDb)\MSSQLLocalDB; Initial Catalog=base_Arctic_Dari;  Integrated Security=True";
            using (SqlConnection s = new SqlConnection(connectionString))
            {
                s.Open();

                using (SqlCommand cmdSelect =
                    new SqlCommand($"UPDATE Contrats SET DateContrat ='{contrat.DateContrat}',DateFinContrat='{contrat.DateFinContrat}',Description='{contrat.Description}',PrixContrat='{contrat.PrixContrat}',motif='{(int)contrat.motif}' where ClientID={IDClient} and AnnonceID={IDAnnonce};", s))
                {
                    cmdSelect.CommandType = System.Data.CommandType.Text;
                    using (SqlDataReader sqlDataReader = cmdSelect.ExecuteReader())
                    {
                        sqlDataReader.Read();

                        if (sqlDataReader.RecordsAffected == 0)
                        {
                            return null;
                        }
                        else
                        {
                            Contrat contratUpdated = GetContrat(IDClient, IDAnnonce);
                            return contratUpdated;
                        }
                    }
                }
            }

        }

        public bool RemoveContrat(int IDClient, int IDAnnonce)
        {

            Contrat contrat = GetContrat(IDClient, IDAnnonce);
            if (contrat == null) { return false; }
            else
            { 
                string connectionString = @"Data Source =(LocalDb)\MSSQLLocalDB; Initial Catalog=base_Arctic_Dari;  Integrated Security=True";
                using (SqlConnection s = new SqlConnection(connectionString))
                {
                    s.Open();

                    using (SqlCommand cmdSelect =
                        new SqlCommand($"DELETE FROM Contrats  where ClientID={IDClient} and AnnonceID={IDAnnonce};", s))
                    {
                        cmdSelect.CommandType = System.Data.CommandType.Text;
                        using (SqlDataReader sqlDataReader = cmdSelect.ExecuteReader())
                        {
                            sqlDataReader.Read();

                            if (sqlDataReader.RecordsAffected == 0)
                            {
                                return false;
                            }
                            else
                            {
                                return true;
                            }
                        }
                    }
                }
            }
        }



    }
}
