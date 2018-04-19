namespace maptest
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class MapContext : DbContext
    {
        // Контекст настроен для использования строки подключения "MapContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "maptest.MapContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "MapContext" 
        // в файле конфигурации приложения.
        public MapContext()
            : base("name=MapContext")
        {

        }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<BillingInfo> BillingInfos { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Driver> Drivers { get; set; }
        public DbSet<GPSDevice> GPSDevices { get; set; }
        public DbSet<Map> Maps { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Recepient> Recepients { get; set; }
        public DbSet<Route> Routes { get; set; }
        public DbSet<User> Users { get; set; }

        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}