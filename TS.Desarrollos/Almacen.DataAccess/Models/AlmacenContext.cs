using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Almacen.DataAccess.Models
{
    public partial class AlmacenContext : DbContext
    {
        public AlmacenContext()
        {
        }

        public AlmacenContext(DbContextOptions<AlmacenContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Chofere> Choferes { get; set; }
        public virtual DbSet<Domicilio> Domicilios { get; set; }
        public virtual DbSet<OrdenEntrega> OrdenEntregas { get; set; }
        public virtual DbSet<OrdenProducto> OrdenProductos { get; set; }
        public virtual DbSet<Ordene> Ordenes { get; set; }
        public virtual DbSet<RutaEntrega> RutaEntregas { get; set; }
        public virtual DbSet<RutaEntregaOrdene> RutaEntregaOrdenes { get; set; }
        public virtual DbSet<Sucursale> Sucursales { get; set; }
        public virtual DbSet<TAlmacene> TAlmacenes { get; set; }
        public virtual DbSet<TGenero> TGeneros { get; set; }
        public virtual DbSet<TTipoAlmacen> TTipoAlmacens { get; set; }
        public virtual DbSet<Tempresa> Tempresas { get; set; }
        public virtual DbSet<Tgrupo> Tgrupos { get; set; }
        public virtual DbSet<Tmacro> Tmacros { get; set; }
        public virtual DbSet<Tproducto> Tproductos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("data source=localhost;initial catalog=Almacen;User ID=sa;Password=data;persist security info=False;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Modern_Spanish_CI_AS");

            modelBuilder.Entity<Chofere>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Domicilio>(entity =>
            {
                entity.Property(e => e.Direccion)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Referencia)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenEntrega>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MontoAcobrar)
                    .HasColumnType("money")
                    .HasColumnName("MontoACobrar");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Origen)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OrdenProducto>(entity =>
            {
                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Producto)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.Orden)
                    .WithMany(p => p.OrdenProductos)
                    .HasForeignKey(d => d.OrdenId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrdenProductos_Ordenes");
            });

            modelBuilder.Entity<Ordene>(entity =>
            {
                entity.Property(e => e.AlmacenDestino)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.AlmacenOrigen)
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.MontoAcobrar)
                    .HasColumnType("money")
                    .HasColumnName("MontoACobrar");

                entity.Property(e => e.Observaciones)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.Sucursal)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Tipo)
                    .IsRequired()
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RutaEntrega>(entity =>
            {
                entity.Property(e => e.Chofer)
                    .IsRequired()
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fecha).HasColumnType("datetime");
            });

            modelBuilder.Entity<RutaEntregaOrdene>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<Sucursale>(entity =>
            {
                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TAlmacene>(entity =>
            {
                entity.HasKey(e => e.AlmIclave);

                entity.ToTable("tAlmacenes");

                entity.Property(e => e.AlmIclave)
                    .ValueGeneratedNever()
                    .HasColumnName("AlmIClave");

                entity.Property(e => e.AlmAcliente)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .HasColumnName("AlmACliente");

                entity.Property(e => e.AlmAletra)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("AlmALetra");

                entity.Property(e => e.AlmAnombre)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("AlmANombre");

                entity.Property(e => e.AlmItipo).HasColumnName("AlmITipo");

                entity.Property(e => e.AlmLordenTrabajo).HasColumnName("AlmLOrdenTrabajo");

                entity.Property(e => e.AlmLtrasPerAnt)
                    .HasColumnName("AlmLTrasPerAnt")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AlmMobservaciones)
                    .HasColumnType("text")
                    .HasColumnName("AlmMObservaciones");

                entity.Property(e => e.AlmStipoArea).HasColumnName("AlmSTipoArea");

                entity.HasOne(d => d.AlmItipoNavigation)
                    .WithMany(p => p.TAlmacenes)
                    .HasForeignKey(d => d.AlmItipo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tAlmacenes_tTipoAlmacen");
            });

            modelBuilder.Entity<TGenero>(entity =>
            {
                entity.HasKey(e => e.GenIclave);

                entity.ToTable("tGenero");

                entity.Property(e => e.GenIclave)
                    .ValueGeneratedNever()
                    .HasColumnName("GenIClave");

                entity.Property(e => e.GenAdescripcion)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("GenADescripcion");

                entity.Property(e => e.GenLatri)
                    .HasColumnName("GenLAtri")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<TTipoAlmacen>(entity =>
            {
                entity.HasKey(e => e.TipAclave);

                entity.ToTable("tTipoAlmacen");

                entity.Property(e => e.TipAclave)
                    .ValueGeneratedNever()
                    .HasColumnName("TipAClave");

                entity.Property(e => e.TipAdescripcion)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("TipADescripcion");

                entity.Property(e => e.TipBexistencia).HasColumnName("TipBExistencia");
            });

            modelBuilder.Entity<Tempresa>(entity =>
            {
                entity.HasKey(e => e.Comnid);

                entity.ToTable("TEmpresa");

                entity.Property(e => e.Comnid).HasColumnName("comnid");

                entity.Property(e => e.EmpAciudad)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmpACiudad");

                entity.Property(e => e.EmpAclaveProd)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("EmpAClaveProd");

                entity.Property(e => e.EmpAdireccion)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EmpADireccion");

                entity.Property(e => e.EmpAemail)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empAEmail");

                entity.Property(e => e.EmpAestado)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmpAEstado");

                entity.Property(e => e.EmpAlicencia)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("empALicencia");

                entity.Property(e => e.EmpAmunicipio)
                    .HasMaxLength(55)
                    .IsUnicode(false)
                    .HasColumnName("EmpAMunicipio");

                entity.Property(e => e.EmpAnoExt)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("EmpANoExt");

                entity.Property(e => e.EmpAnombre)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("empANombre");

                entity.Property(e => e.EmpApais)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmpAPais");

                entity.Property(e => e.EmpArazon)
                    .HasMaxLength(80)
                    .IsUnicode(false)
                    .HasColumnName("EmpARazon");

                entity.Property(e => e.EmpArfc)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("EmpARfc");

                entity.Property(e => e.EmpAtelefonos)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("EmpATelefonos");

                entity.Property(e => e.Empacolonia)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("empacolonia");

                entity.Property(e => e.Empicodpos).HasColumnName("empicodpos");
            });

            modelBuilder.Entity<Tgrupo>(entity =>
            {
                entity.HasKey(e => e.GruIclave);

                entity.ToTable("tgrupos");

                entity.Property(e => e.GruIclave)
                    .ValueGeneratedNever()
                    .HasColumnName("GruIClave");

                entity.Property(e => e.GruAnombre)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false)
                    .HasColumnName("GruANombre");

                entity.Property(e => e.GruBmedidas).HasColumnName("GruBMedidas");

                entity.Property(e => e.GruIpadre).HasColumnName("GruIPadre");

                entity.Property(e => e.GruLasignarCosto)
                    .HasColumnName("GruLAsignarCosto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GruMobservaciones)
                    .HasColumnType("text")
                    .HasColumnName("GruMObservaciones");

                entity.Property(e => e.GruNcolor)
                    .HasColumnType("numeric(18, 0)")
                    .HasColumnName("GruNColor")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<Tmacro>(entity =>
            {
                entity.HasKey(e => e.Comnid);

                entity.ToTable("TMacros");

                entity.Property(e => e.Comnid).HasColumnName("comnid");

                entity.Property(e => e.MacAcve)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("MacACve");

                entity.Property(e => e.MacAdesc)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("MacADesc");

                entity.Property(e => e.MacAxml)
                    .HasMaxLength(2000)
                    .IsUnicode(false)
                    .HasColumnName("MacAXML");

                entity.Property(e => e.MacNvalor).HasColumnName("MacNValor");
            });

            modelBuilder.Entity<Tproducto>(entity =>
            {
                entity.HasKey(e => e.ProAclave);

                entity.ToTable("tproductos");

                entity.Property(e => e.ProAclave)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("ProAClave");

                entity.Property(e => e.ProAcodigoDeBarras)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProACodigoDeBarras");

                entity.Property(e => e.ProAcolor)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasColumnName("ProAColor");

                entity.Property(e => e.ProAcveProdSer)
                    .HasMaxLength(8)
                    .IsUnicode(false)
                    .HasColumnName("ProACveProdSer");

                entity.Property(e => e.ProAcveUmedida)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("ProACveUMedida");

                entity.Property(e => e.ProAgenericoPadre)
                    .HasMaxLength(15)
                    .IsUnicode(false)
                    .HasColumnName("ProAGenericoPadre");

                entity.Property(e => e.ProAnombre)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false)
                    .HasColumnName("ProANombre");

                entity.Property(e => e.ProCosto)
                    .HasColumnType("money")
                    .HasColumnName("Pro$Costo");

                entity.Property(e => e.ProFcantPerfil)
                    .HasColumnName("ProFCantPerfil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProFcostoColor)
                    .HasColumnName("ProFCostoColor")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProFcostoPerfil)
                    .HasColumnName("ProFCostoPerfil")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProFcostoPromedio).HasColumnName("ProFCostoPromedio");

                entity.Property(e => e.ProFfactorGenerico).HasColumnName("ProFFactorGenerico");

                entity.Property(e => e.ProFieps).HasColumnName("ProFIeps");

                entity.Property(e => e.ProFiva).HasColumnName("ProFIVA");

                entity.Property(e => e.ProFpeso).HasColumnName("ProFPeso");

                entity.Property(e => e.ProFpiezasAtado)
                    .HasColumnName("ProFPiezasAtado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProFutilidad).HasColumnName("ProFUtilidad");

                entity.Property(e => e.ProIcaduca).HasColumnName("ProICaduca");

                entity.Property(e => e.ProIcodBar).HasColumnName("ProICodBar");

                entity.Property(e => e.ProIcostoPp).HasColumnName("ProICostoPP");

                entity.Property(e => e.ProIdivisa)
                    .HasColumnName("ProIDivisa")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProIempaque).HasColumnName("ProIEmpaque");

                entity.Property(e => e.ProIgenero).HasColumnName("ProIGenero");

                entity.Property(e => e.ProIgrupo).HasColumnName("ProIGrupo");

                entity.Property(e => e.ProImarca)
                    .HasColumnName("ProIMarca")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProIuni).HasColumnName("ProIUni");

                entity.Property(e => e.ProLgenerico).HasColumnName("ProLGenerico");

                entity.Property(e => e.ProLlote)
                    .HasColumnName("ProLLote")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ProMdescripcion)
                    .HasColumnType("text")
                    .HasColumnName("ProMDescripcion");

                entity.Property(e => e.ProPfoto)
                    .HasColumnType("image")
                    .HasColumnName("ProPFoto");

                entity.Property(e => e.Proiservicio).HasColumnName("PROISERVICIO");

                entity.Property(e => e.VenNid)
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("VenNId");

                entity.HasOne(d => d.ProIgeneroNavigation)
                    .WithMany(p => p.Tproductos)
                    .HasForeignKey(d => d.ProIgenero)
                    .HasConstraintName("FK_tproductos_tGenero");

                entity.HasOne(d => d.ProIgrupoNavigation)
                    .WithMany(p => p.Tproductos)
                    .HasForeignKey(d => d.ProIgrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_tproductos_tgrupos");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
