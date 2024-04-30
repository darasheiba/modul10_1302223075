using System;
using static modul10.Mahasiswa;
using System.Collections.Generic;
using modul10;

class DBMahasiswa : DbContext
{
    public DBMahasiswa(DbContextOptions<DBMahasiswa> options)
        : base(options) { }
    public DbSet<Mahasiswa> mhs => ISet<Mahasiswa>();

    internal object Entry(Mahasiswa mhs)
    {
        throw new NotImplementedException();
    }

    internal Task SaveChangesAsync()
    {
        throw new NotImplementedException();
    }

    private DbSet<T> ISet<T>()
    {
        throw new NotImplementedException();
    }
}

public class DbSet<T>
{
    internal Task<object?> FindAsync(int id)
    {
        throw new NotImplementedException();
    }

    internal void Remove(object mhs)
    {
        throw new NotImplementedException();
    }

    internal Task<object?> ToListAsync()
    {
        throw new NotImplementedException();
    }
}