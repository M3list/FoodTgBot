using ConsoleApp1.DB.Table;

namespace ConsoleApp1.DB;

public class DbManager
{
    private static DbManager _dbManager = null;
    
    public TableTypesDishes TableTypesDishes { get; private set; }

    private DbManager()
    {
        TableTypesDishes = new TableTypesDishes();
    }

    public static DbManager GetInstance()
    {
        if (_dbManager == null)
        {
            _dbManager = new DbManager();
        }

        return _dbManager;
    }
}