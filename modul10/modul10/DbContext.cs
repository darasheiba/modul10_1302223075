internal class DbContext
{
    private DbContextOptions<DBMahasiswa> options;

    public DbContext(DbContextOptions<DBMahasiswa> options)
    {
        this.options = options;
    }
}