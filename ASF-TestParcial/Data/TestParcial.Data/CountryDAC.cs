using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using TestParcial.Entities;

namespace TestParcial.Data
{
    public class CountryDAC : DataAccessComponent
    {
        private Country LoadCountry(IDataReader dr)
        {
            Country country = new Country();

            country.Id = GetDataValue<int>(dr, "Id");
            country.Name = GetDataValue<string>(dr, "Name");
           

            return country;
        }

        public List<Country> Select()
        {
            const string sql = "SELECT * FROM dbo.Country";

            var result = new List<Country>();

            var db = DatabaseFactory.CreateDatabase(CONNECTION_NAME);

            using (var cmd = db.GetSqlStringCommand(sql))
            {
                using (var dr = db.ExecuteReader(cmd))
                {
                    while (dr.Read())
                    {
                        var country = LoadCountry(dr);
                        result.Add(country);
                    }
                }
            }
            return result;
        }
    }
}
