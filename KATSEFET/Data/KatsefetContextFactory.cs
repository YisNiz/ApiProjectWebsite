using KATSEFET.Data;
using Microsoft.EntityFrameworkCore;
using System;

public class KatsefetContextFactory
{

            private const string ConnectionString = "Server=srv2\\pupils;DataBase=216259986KATSEFET;Integrated Security=SSPI;" +
            "Persist Security Info=False;TrustServerCertificate=true";

    public static KATSEFETContext CreateContext()
    {
        var optionsBuilder = new DbContextOptionsBuilder<KATSEFETContext>();
        optionsBuilder.UseSqlServer(ConnectionString);
        return new KATSEFETContext(optionsBuilder.Options);
    }
}

