using Microsoft.EntityFrameworkCore;

namespace WebIotMonitoringApplication.Data;

public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : DbContext(options)
{
}
