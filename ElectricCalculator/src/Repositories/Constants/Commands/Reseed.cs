namespace Repositories.Constants.Commands;

/// <summary>
/// Class contains constants and methods for raw queries
/// </summary>
public class Reseed
{
    public const string TablePrefix = "Electric.dbo";

    /// <summary>
    /// Command to reset the auto increment to 1
    /// </summary>
    /// <param name="tableName"></param>
    /// <param name="number">To have the index reset to 1, number must be 0</param>
    /// <returns></returns>
    public static string ResetAutoIncrement(string tableName, int number = 0)
    {
        return $"DBCC CHECKIDENT('{TablePrefix}.{tableName}', RESEED, {number})";
    }
}