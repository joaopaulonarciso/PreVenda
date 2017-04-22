﻿using MySql.Data.MySqlClient;
using PreVendaJP.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreVendaJP.Data.Repositories
{
    public class DataContext : IDataContext
    {
        public static MySqlConnection MySqlConnection { get; set; }
        public static MySqlTransaction MySqlTransaction { get; set; }

        public void BeginTransaction()
        {
            MySqlConnection = new MySqlConnection(ConfigurationManager.ConnectionStrings["MySqlConnectionStringSrv"].ConnectionString);
            MySqlConnection.Open();
            MySqlTransaction = MySqlConnection.BeginTransaction();
        }

        public void Commit()
        {
            MySqlTransaction.Commit();
        }

        public void Rollback()
        {
            MySqlTransaction.Rollback();
        }

        public void Finally()
        {
            if (MySqlConnection != null)
            {
                MySqlTransaction.Dispose();
                MySqlConnection.Dispose();
                MySqlConnection.Close();
            }
        }
    }
}
