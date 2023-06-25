using ApiAuto.Modelos;
using Microsoft.EntityFrameworkCore;

namespace ApiAuto.Data
{
    public class VentasAutoContext : DbContext
    {
        public VentasAutoContext(DbContextOptions<VentasAutoContext> options) : base(options)
        {

        }

        public DbSet<Compra> Compras { get; set; }
        public DbSet<Auto> Autos { get; set; }
        public DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Auto>().HasData(
                new Auto()
                {
                    IdAuto = 1,
                    Marca = "Ford",
                    Motor = "V8",
                    puertas = 4,
                    AñoFabricación = 2000,
                    kilometrage = 450,
                    chaces = "---",
                    capacidadPasajeros = 4,
                    Precio = 45000
                },
                                new Auto()
                                {
                                    IdAuto = 2,
                                    Marca = "Chevy, Camaro",
                                    Motor = "V6",
                                    puertas = 2,
                                    AñoFabricación = 2000,
                                    kilometrage = 56443,
                                    chaces = "---",
                                    capacidadPasajeros = 4,
                                    Precio = 8900
                                },
                                                new Auto()
                                                {
                                                    IdAuto = 3,
                                                    Marca = "Ford Raptor",
                                                    Motor = "V6, twin turbo",
                                                    puertas = 4,
                                                    AñoFabricación = 2015,
                                                    kilometrage = 450,
                                                    chaces = "---",
                                                    capacidadPasajeros = 4,
                                                    Precio = 50000
                                                },
                                                                new Auto()
                                                                {
                                                                    IdAuto = 4,
                                                                    Marca = "Porsche 911 turbo s",
                                                                    Motor = "Boxer 6 cilindros",
                                                                    puertas = 2,
                                                                    AñoFabricación = 2009,
                                                                    kilometrage = 450,
                                                                    chaces = "---",
                                                                    capacidadPasajeros = 4,
                                                                    Precio = 150000
                                                                },
                                new Auto()
                                {
                                    IdAuto = 5,
                                    Marca = "Ford, fiesta",
                                    Motor = "V8",
                                    puertas = 4,
                                    AñoFabricación = 2005,
                                    kilometrage = 450,
                                    chaces = "---",
                                    capacidadPasajeros = 4,
                                    Precio = 25000
                                },
                                                new Auto()
                                                {
                                                    IdAuto = 6,
                                                    Marca = "Toyota, corolla",
                                                    Motor = "Motor en linea 6 cilindros",
                                                    puertas = 4,
                                                    AñoFabricación = 2010,
                                                    kilometrage = 450,
                                                    chaces = "---",
                                                    capacidadPasajeros = 4,
                                                    Precio = 4000
                                                },
                                                                new Auto()
                                                                {
                                                                    IdAuto = 7,
                                                                    Marca = "Hyundai, i10",
                                                                    Motor = "1.2 litros",
                                                                    puertas = 4,
                                                                    AñoFabricación = 2020,
                                                                    kilometrage = 450,
                                                                    chaces = "---",
                                                                    capacidadPasajeros = 4,
                                                                    Precio = 6000
                                                                },
                                                                new Auto()
                                                                {
                                                                    IdAuto = 8,
                                                                    Marca = "Hyundai, i20",
                                                                    Motor = "1.0 litros",
                                                                    puertas = 4,
                                                                    AñoFabricación = 2020,
                                                                    kilometrage = 450,
                                                                    chaces = "---",
                                                                    capacidadPasajeros = 4,
                                                                    Precio = 11000
                                                                }




                );

            modelBuilder.Entity<Persona>().HasData(
                new Persona()
                {
                    IdPersona = 1,
                    Nombre = "Davis",
                    Apellidos = "Muñoz",
                    Cedula = "001-160305-1059V",
                    Telefono = "89689588",
                    Correo = "davismunoz165@gmail.com",
                    UsserName = "TheAdmin",
                    Password = "12345",
                    Tipo = "Admin"
                });

            //modelBuilder.Entity<Usuario>().HasData(
            //    new Usuario()
            //    {
            //        IdUsuario = 1,
            //        UsserName = "DeyMuO16",
            //        Password = "12345",
            //        Tipo = "Empleado",
            //        IdPersona = 1,
            //    });

            //modelBuilder.Entity<Cliente>().HasData(
            //    new Cliente()
            //    {
            //        IdCliente = 1,
            //        IdUsuario = 1
            //    });


            modelBuilder.Entity<Compra>().HasData(
                new Compra()
                {
                    IdCompra = 1,
                    codigoFact = "120-93782-11",
                    Total = 89000,
                    Concepto = "Compra de un Ford",
                    Date = DateTime.Parse("16-06-2023"),
                    IdAuto = 1,
                    IdPersona = 1
                });

        }

    }
}
