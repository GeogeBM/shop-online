using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace shopInlineApi.Models
{
    public partial class Shop_OnlineContext : DbContext
    {
        public Shop_OnlineContext()
        {
        }

        public Shop_OnlineContext(DbContextOptions<Shop_OnlineContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Accesorio> Accesorios { get; set; }
        public virtual DbSet<Bolsa> Bolsas { get; set; }
        public virtual DbSet<Calzado> Calzados { get; set; }
        public virtual DbSet<Departement> Departements { get; set; }
        public virtual DbSet<Marca> Marcas { get; set; }
        public virtual DbSet<Producto> Productos { get; set; }
        public virtual DbSet<Ropa> Ropas { get; set; }
        public virtual DbSet<SubDepartament> SubDepartaments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=JBETANCOURT;Initial Catalog=Shop_Online;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Accesorio>(entity =>
            {
                entity.Property(e => e.AccesorioId).HasColumnName("accesorio_Id");

                entity.Property(e => e.AccesorioDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("accesorio_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                entity.HasOne(d => d.SubDepartament)
                    .WithMany(p => p.Accesorios)
                    .HasForeignKey(d => d.SubDepartamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Accesorio__sub_d__5441852A");
            });

            modelBuilder.Entity<Bolsa>(entity =>
            {
                entity.Property(e => e.BolsaId).HasColumnName("bolsa_id");

                entity.Property(e => e.BolsaDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("bolsa_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                entity.HasOne(d => d.SubDepartament)
                    .WithMany(p => p.Bolsas)
                    .HasForeignKey(d => d.SubDepartamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Bolsas__sub_depa__4E88ABD4");
            });

            modelBuilder.Entity<Calzado>(entity =>
            {
                entity.ToTable("Calzado");

                entity.Property(e => e.CalzadoId).HasColumnName("calzado_Id");

                entity.Property(e => e.CalzadoDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("calzado_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                entity.HasOne(d => d.SubDepartament)
                    .WithMany(p => p.Calzados)
                    .HasForeignKey(d => d.SubDepartamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Calzado__sub_dep__48CFD27E");
            });

            modelBuilder.Entity<Departement>(entity =>
            {
                entity.HasKey(e => e.DepartamentId)
                    .HasName("PK__Departem__061E0A7BDC764417");

                entity.ToTable("Departement");

                entity.Property(e => e.DepartamentId).HasColumnName("departament_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartamentDescripcion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("departament_descripcion")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Marca>(entity =>
            {
                entity.ToTable("Marca");

                entity.Property(e => e.MarcaId).HasColumnName("marca_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MarcaDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("marca_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Producto>(entity =>
            {
                entity.ToTable("Producto");

                entity.Property(e => e.ProductoId).HasColumnName("producto_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartamentId).HasColumnName("departament_Id");

                entity.Property(e => e.MarcaId).HasColumnName("marca_id");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PrecioBrutoVenta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio_bruto_venta");

                entity.Property(e => e.PrecioCompra)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio_compra");

                entity.Property(e => e.PrecioNetoVenta)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("precio_neto_venta");

                entity.Property(e => e.ProductoCantidad).HasColumnName("producto_cantidad");

                entity.Property(e => e.ProductoDesc)
                    .IsRequired()
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("producto_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.ProductoImpuesto)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("producto_impuesto");

                entity.Property(e => e.ProductoImpuestoPorc)
                    .HasColumnType("decimal(18, 0)")
                    .HasColumnName("producto_impuesto_porc");

                entity.Property(e => e.ProductoNombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("producto_nombre")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                //entity.HasOne(d => d.Departament)
                //    .WithMany(p => p.Productos)
                //    .HasForeignKey(d => d.DepartamentId)
                //    .HasConstraintName("FK__Producto__depart__5DCAEF64");

                //entity.HasOne(d => d.Marca)
                //    .WithMany(p => p.Productos)
                //    .HasForeignKey(d => d.MarcaId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Producto__marca___619B8048");

                //entity.HasOne(d => d.SubDepartament)
                //    .WithMany(p => p.Productos)
                //    .HasForeignKey(d => d.SubDepartamentId)
                //    .OnDelete(DeleteBehavior.ClientSetNull)
                //    .HasConstraintName("FK__Producto__sub_de__5EBF139D");
            });

            modelBuilder.Entity<Ropa>(entity =>
            {
                entity.ToTable("Ropa");

                entity.Property(e => e.RopaId).HasColumnName("ropa_id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.RopaDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ropa_desc")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                entity.HasOne(d => d.SubDepartament)
                    .WithMany(p => p.Ropas)
                    .HasForeignKey(d => d.SubDepartamentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Ropa__sub_depart__4316F928");
            });

            modelBuilder.Entity<SubDepartament>(entity =>
            {
                entity.ToTable("Sub_Departament");

                entity.Property(e => e.SubDepartamentId).HasColumnName("sub_departament_Id");

                entity.Property(e => e.CreateDate)
                    .HasColumnType("datetime")
                    .HasColumnName("create_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.DepartamentId).HasColumnName("Departament_Id");

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime")
                    .HasColumnName("modify_date")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.SubDepartamentDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("sub_departament_desc")
                    .HasDefaultValueSql("('')");

                entity.HasOne(d => d.Departament)
                    .WithMany(p => p.SubDepartaments)
                    .HasForeignKey(d => d.DepartamentId)
                    .HasConstraintName("FK__Sub_Depar__Depar__3D5E1FD2");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
