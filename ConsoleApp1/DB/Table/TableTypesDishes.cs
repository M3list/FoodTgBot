using ConsoleApp1.DB.Connection;
using ConsoleApp1.DB.Model;
using Npgsql;

namespace ConsoleApp1.DB.Table;

public class TableTypesDishes
{
    private NpgsqlConnection _connection;
    
    public TableTypesDishes()
    {
        _connection = DbConnector.GetConnection();
    }

    public List<TypeDIsh> SelectAllTypesDishes()
    {
        List<TypeDIsh> typesDishes = new List<TypeDIsh>();
        
        string sqlRequest = "SELECT * FROM type_dishes";
        NpgsqlCommand command = new NpgsqlCommand(sqlRequest, _connection);

        NpgsqlDataReader dataReader = command.ExecuteReader();
        while (dataReader.Read())
        {
            int id = dataReader.GetInt32(dataReader.GetOrdinal("id"));
            string name = dataReader.GetString(dataReader.GetOrdinal("name"));

            TypeDIsh typeDIsh = new TypeDIsh()
            {
                Id = id,
                Name = name
            };
            
            typesDishes.Add(typeDIsh);
        }

        return typesDishes;
    }
}