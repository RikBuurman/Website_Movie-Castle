﻿using MySql.Data.MySqlClient;

namespace Website_Movie_Castle.Database

    {
        public static class DatabaseConnector
        {

            public static List<Dictionary<string, object>> GetRows(string query)
            {
                // stel in waar de database gevonden kan worden
                // string connectionString = "Server=informatica.st-maartenscollege.nl;Port=3306;Database=fastfood;Uid=lgg;Pwd=<jouwwachtwoordhier>;";
                string connectionString = "Server=172.16.160.21;Port=3306;Database=111919;Uid=111919;Pwd=Inf2022sql;";

                // maak een lege lijst waar we de namen in gaan opslaan
                List<Dictionary<string, object>> rows = new List<Dictionary<string, object>>();


                // verbinding maken met de database
                /*using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    // verbinding openen
                    conn.Open();

                    // SQL query die we willen uitvoeren
                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // resultaat van de query lezen
                    using (var reader = cmd.ExecuteReader())
                    {
                        var tableData = reader.GetSchemaTable();

                        // elke keer een regel (of eigenlijk: database rij) lezen
                        while (reader.Read())
                        {
                            var row = new Dictionary<string, object>();

                            // haal voor elke kolom de waarde op en voeg deze toe
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                row[reader.GetName(i)] = reader.GetValue(i);
                            }

                            rows.Add(row);
                        }
                    }
                }*/

                // return de lijst met namen
                return rows;
            }

        }
    }