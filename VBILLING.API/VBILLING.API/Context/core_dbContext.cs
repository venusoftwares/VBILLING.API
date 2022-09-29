using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using VBILLING.API.Models;

namespace VBILLING.API.Context
{
    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AttendanceDaily> AttendanceDailies { get; set; } = null!;
        public virtual DbSet<BrandDetail> BrandDetails { get; set; } = null!;
        public virtual DbSet<BuildingSqfeetInvoice> BuildingSqfeetInvoices { get; set; } = null!;
        public virtual DbSet<CategoryMaster> CategoryMasters { get; set; } = null!;
        public virtual DbSet<ColorMaster> ColorMasters { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyName> CompanyNames { get; set; } = null!;
        public virtual DbSet<CustomerAdvance> CustomerAdvances { get; set; } = null!;
        public virtual DbSet<CustomerDebit> CustomerDebits { get; set; } = null!;
        public virtual DbSet<CustomerDetail> CustomerDetails { get; set; } = null!;
        public virtual DbSet<CustomerDiscount> CustomerDiscounts { get; set; } = null!;
        public virtual DbSet<DashboardMaster> DashboardMasters { get; set; } = null!;
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; } = null!;
        public virtual DbSet<DesignationMaster> DesignationMasters { get; set; } = null!;
        public virtual DbSet<DyeingDetail> DyeingDetails { get; set; } = null!;
        public virtual DbSet<DyeingDetailItem> DyeingDetailItems { get; set; } = null!;
        public virtual DbSet<DyingMaster> DyingMasters { get; set; } = null!;
        public virtual DbSet<EmployeeAdvance> EmployeeAdvances { get; set; } = null!;
        public virtual DbSet<EmployeeAdvancePayment> EmployeeAdvancePayments { get; set; } = null!;
        public virtual DbSet<EmployeeDetail> EmployeeDetails { get; set; } = null!;
        public virtual DbSet<EmployeeInfo> EmployeeInfos { get; set; } = null!;
        public virtual DbSet<ExpenseDetail> ExpenseDetails { get; set; } = null!;
        public virtual DbSet<ExpenseDetailItem> ExpenseDetailItems { get; set; } = null!;
        public virtual DbSet<FabricMaster> FabricMasters { get; set; } = null!;
        public virtual DbSet<GarmentsOrderDetail> GarmentsOrderDetails { get; set; } = null!;
        public virtual DbSet<GarmentsOrderDetailItem> GarmentsOrderDetailItems { get; set; } = null!;
        public virtual DbSet<GarmentsPurchaseDetailItem> GarmentsPurchaseDetailItems { get; set; } = null!;
        public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; } = null!;
        public virtual DbSet<InvoiceDetailItem> InvoiceDetailItems { get; set; } = null!;
        public virtual DbSet<ItemMaster> ItemMasters { get; set; } = null!;
        public virtual DbSet<KnittingDetail> KnittingDetails { get; set; } = null!;
        public virtual DbSet<KnittingDetailItem> KnittingDetailItems { get; set; } = null!;
        public virtual DbSet<KnittingMaster> KnittingMasters { get; set; } = null!;
        public virtual DbSet<LaborType> LaborTypes { get; set; } = null!;
        public virtual DbSet<MainMenu> MainMenus { get; set; } = null!;
        public virtual DbSet<MeterialMaster> MeterialMasters { get; set; } = null!;
        public virtual DbSet<NewRegistration> NewRegistrations { get; set; } = null!;
        public virtual DbSet<Operation> Operations { get; set; } = null!;
        public virtual DbSet<OrderInvoiceDetail> OrderInvoiceDetails { get; set; } = null!;
        public virtual DbSet<OrderWisePurchaseDetail> OrderWisePurchaseDetails { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PieceRateMaster> PieceRateMasters { get; set; } = null!;
        public virtual DbSet<PieceTypeMaster> PieceTypeMasters { get; set; } = null!;
        public virtual DbSet<Prefix> Prefixes { get; set; } = null!;
        public virtual DbSet<ProcessMaster> ProcessMasters { get; set; } = null!;
        public virtual DbSet<ProcessingDetail> ProcessingDetails { get; set; } = null!;
        public virtual DbSet<ProcessingDetailItem> ProcessingDetailItems { get; set; } = null!;
        public virtual DbSet<PurchaseDetail> PurchaseDetails { get; set; } = null!;
        public virtual DbSet<PurchaseDetailItem> PurchaseDetailItems { get; set; } = null!;
        public virtual DbSet<PurchaseReturnDetail> PurchaseReturnDetails { get; set; } = null!;
        public virtual DbSet<PurchaseReturnDetailItem> PurchaseReturnDetailItems { get; set; } = null!;
        public virtual DbSet<QuotationDetail> QuotationDetails { get; set; } = null!;
        public virtual DbSet<QuotationDetailItem> QuotationDetailItems { get; set; } = null!;
        public virtual DbSet<QuotationSupplyMaster> QuotationSupplyMasters { get; set; } = null!;
        public virtual DbSet<Receipt> Receipts { get; set; } = null!;
        public virtual DbSet<RefreshToken> RefreshTokens { get; set; } = null!;
        public virtual DbSet<Role> Roles { get; set; } = null!;
        public virtual DbSet<RolePermission> RolePermissions { get; set; } = null!;
        public virtual DbSet<RolePermissionMaster> RolePermissionMasters { get; set; } = null!;
        public virtual DbSet<SalaryStatement> SalaryStatements { get; set; } = null!;
        public virtual DbSet<SalesDetail> SalesDetails { get; set; } = null!;
        public virtual DbSet<SalesDetailItem> SalesDetailItems { get; set; } = null!;
        public virtual DbSet<SalesReturnDetail> SalesReturnDetails { get; set; } = null!;
        public virtual DbSet<SalesReturnDetailItem> SalesReturnDetailItems { get; set; } = null!;
        public virtual DbSet<SchedulerJobStockItem> SchedulerJobStockItems { get; set; } = null!;
        public virtual DbSet<SchedulerJobStockItemV2> SchedulerJobStockItemV2s { get; set; } = null!;
        public virtual DbSet<Setting> Settings { get; set; } = null!;
        public virtual DbSet<ShippingAddress> ShippingAddresses { get; set; } = null!;
        public virtual DbSet<StockItemDetail> StockItemDetails { get; set; } = null!;
        public virtual DbSet<StyleDetail> StyleDetails { get; set; } = null!;
        public virtual DbSet<SubMenu> SubMenus { get; set; } = null!;
        public virtual DbSet<SuffixItem> SuffixItems { get; set; } = null!;
        public virtual DbSet<SupplierDetail> SupplierDetails { get; set; } = null!;
        public virtual DbSet<SupplyMaster> SupplyMasters { get; set; } = null!;
        public virtual DbSet<SupplyRateMaster> SupplyRateMasters { get; set; } = null!;
        public virtual DbSet<SupplyReturnMaster> SupplyReturnMasters { get; set; } = null!;
        public virtual DbSet<TaskDetails> TaskDetails { get; set; } = null!;
        public virtual DbSet<TaxSetting> TaxSettings { get; set; } = null!;
        public virtual DbSet<TermsAndCondition> TermsAndConditions { get; set; } = null!;
        public virtual DbSet<UnitMeasurement> UnitMeasurements { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserDetail> UserDetails { get; set; } = null!;
        public virtual DbSet<WorkEntryDetail> WorkEntryDetails { get; set; } = null!;
        public virtual DbSet<YarnDetail> YarnDetails { get; set; } = null!;
        public virtual DbSet<YarnDetailItem> YarnDetailItems { get; set; } = null!;
        public virtual DbSet<YarnMaster> YarnMasters { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=103.196.29.171;Database=VBILLING;user id=sa; password=venu@123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttendanceDaily>(entity =>
            {
                entity.ToTable("AttendanceDaily");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Present).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AttendanceDailies)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttendanceDaily_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AttendanceDailies)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AttendanceDaily_EmployeeDetails");
            });

            modelBuilder.Entity<BrandDetail>(entity =>
            {
                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Sqrate)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("SQRate");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BrandDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BrandDetails_Company");
            });

            modelBuilder.Entity<BuildingSqfeetInvoice>(entity =>
            {
                entity.ToTable("BuildingSQFeetInvoice");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.HeightFt)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("HeightFT");

                entity.Property(e => e.HeightIn)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("HeightIN");

                entity.Property(e => e.InvoiceDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TotalSqfeet)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("TotalSQFeet");

                entity.Property(e => e.TotalSqfeetRate)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("TotalSQFeetRate");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.WidthFt)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("WidthFT");

                entity.Property(e => e.WidthIn)
                    .HasColumnType("decimal(9, 2)")
                    .HasColumnName("WidthIN");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.BuildingSqfeetInvoices)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingSQFeetInvoice_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.BuildingSqfeetInvoices)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingSQFeetInvoice_CustomerDetails");

                entity.HasOne(d => d.Prefix)
                    .WithMany(p => p.BuildingSqfeetInvoices)
                    .HasForeignKey(d => d.PrefixId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingSQFeetInvoice_Prefix");

                entity.HasOne(d => d.SuffixItem)
                    .WithMany(p => p.BuildingSqfeetInvoices)
                    .HasForeignKey(d => d.SuffixItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BuildingSQFeetInvoice_SuffixItem");
            });

            modelBuilder.Entity<CategoryMaster>(entity =>
            {
                entity.ToTable("CategoryMaster");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Status).HasDefaultValueSql("('false')");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CategoryMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CategoryMaster_Company");
            });

            modelBuilder.Entity<ColorMaster>(entity =>
            {
                entity.ToTable("ColorMaster");

                entity.Property(e => e.Colors).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ColorMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ColorMaster_Company");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.ACno)
                    .HasMaxLength(50)
                    .HasColumnName("A/CNo");

                entity.Property(e => e.AccountHolderName).HasMaxLength(50);

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Address3).HasMaxLength(50);

                entity.Property(e => e.BankName).HasMaxLength(50);

                entity.Property(e => e.BranchName).HasMaxLength(50);

                entity.Property(e => e.CompanyName).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.Cstdate)
                    .HasColumnType("datetime")
                    .HasColumnName("CSTDate");

                entity.Property(e => e.Cstno)
                    .HasMaxLength(50)
                    .HasColumnName("CSTNo");

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.Eccdate)
                    .HasColumnType("datetime")
                    .HasColumnName("ECCDate");

                entity.Property(e => e.Eccno)
                    .HasMaxLength(50)
                    .HasColumnName("ECCNo");

                entity.Property(e => e.EmailId).HasMaxLength(50);

                entity.Property(e => e.FaxNo).HasMaxLength(50);

                entity.Property(e => e.FinanceYearEnd).HasColumnType("datetime");

                entity.Property(e => e.FinanceYearStart).HasColumnType("datetime");

                entity.Property(e => e.Gst)
                    .HasMaxLength(50)
                    .HasColumnName("GST");

                entity.Property(e => e.Ibanno)
                    .HasMaxLength(50)
                    .HasColumnName("IBANNo");

                entity.Property(e => e.Ifsccode)
                    .HasMaxLength(50)
                    .HasColumnName("IFSCCode");

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Logo).HasColumnType("image");

                entity.Property(e => e.ManufactureOffice).HasMaxLength(50);

                entity.Property(e => e.MobileNo).HasMaxLength(50);

                entity.Property(e => e.OpeningBalance).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PanNo).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);

                entity.Property(e => e.PrintCompanyName).HasMaxLength(50);

                entity.Property(e => e.ServiceTaxNo).HasMaxLength(50);

                entity.Property(e => e.ShippingAddress).HasMaxLength(250);

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.StateCode).HasMaxLength(50);

                entity.Property(e => e.Swiftcode)
                    .HasMaxLength(50)
                    .HasColumnName("SWIFTCode");

                entity.Property(e => e.TanNo).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<CompanyName>(entity =>
            {
                entity.ToTable("CompanyName");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CompanyName1)
                    .HasMaxLength(50)
                    .HasColumnName("CompanyName");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyNames)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyName_Company");
            });

            modelBuilder.Entity<CustomerAdvance>(entity =>
            {
                entity.ToTable("CustomerAdvance");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.AdvanceDate).HasColumnType("datetime");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.ConCodeNavigation)
                    .WithMany(p => p.CustomerAdvances)
                    .HasForeignKey(d => d.ConCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAdvance_Company");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.CustomerAdvances)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerAdvance_CustomerDetails");
            });

            modelBuilder.Entity<CustomerDebit>(entity =>
            {
                entity.ToTable("CustomerDebit");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DebitDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.ConCodeNavigation)
                    .WithMany(p => p.CustomerDebits)
                    .HasForeignKey(d => d.ConCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDebit_Company");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.CustomerDebits)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDebit_CustomerDetails");
            });

            modelBuilder.Entity<CustomerDetail>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CustomerName).HasMaxLength(50);

                entity.Property(e => e.Gst)
                    .HasMaxLength(50)
                    .HasColumnName("GST");

                entity.Property(e => e.ShippingAddress).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CustomerDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDetails_CustomerDetails");
            });

            modelBuilder.Entity<CustomerDiscount>(entity =>
            {
                entity.ToTable("CustomerDiscount");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DiscountDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.ConCodeNavigation)
                    .WithMany(p => p.CustomerDiscounts)
                    .HasForeignKey(d => d.ConCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDiscount_Company");

                entity.HasOne(d => d.CustomerCodeNavigation)
                    .WithMany(p => p.CustomerDiscounts)
                    .HasForeignKey(d => d.CustomerCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerDiscount_CustomerDetails");
            });

            modelBuilder.Entity<DashboardMaster>(entity =>
            {
                entity.ToTable("DashboardMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Dashboard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<DepartmentMaster>(entity =>
            {
                entity.ToTable("DepartmentMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasDefaultValueSql("('false')");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DepartmentMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DepartmentMaster_Company");
            });

            modelBuilder.Entity<DesignationMaster>(entity =>
            {
                entity.ToTable("DesignationMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<DyeingDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DyeingDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DyeingDetails_Company");

                entity.HasOne(d => d.GarmentDetail)
                    .WithMany(p => p.DyeingDetails)
                    .HasForeignKey(d => d.GarmentDetailId)
                    .HasConstraintName("FK_DyeingDetails_GarmentsOrderDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.DyeingDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DyeingDetails_SupplierDetails");
            });

            modelBuilder.Entity<DyeingDetailItem>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RatePerKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DyeingDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DyeingDetailItems_Company");

                entity.HasOne(d => d.DyeingDetail)
                    .WithMany(p => p.DyeingDetailItems)
                    .HasForeignKey(d => d.DyeingDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DyeingDetailItems_DyeingDetails");
            });

            modelBuilder.Entity<DyingMaster>(entity =>
            {
                entity.ToTable("DyingMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DyingName).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DyingMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DyingMaster_Company");
            });

            modelBuilder.Entity<EmployeeAdvance>(entity =>
            {
                entity.ToTable("EmployeeAdvance");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EmployeeAdvances)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdvance_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAdvances)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdvance_EmployeeDetails");
            });

            modelBuilder.Entity<EmployeeAdvancePayment>(entity =>
            {
                entity.ToTable("EmployeeAdvancePayment");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EmployeeAdvancePayments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdvancePayment_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAdvancePayments)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeAdvancePayment_EmployeeDetails");
            });

            modelBuilder.Entity<EmployeeDetail>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.AdvanceLimit).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Dob)
                    .HasColumnType("datetime")
                    .HasColumnName("DOB");

                entity.Property(e => e.Doj)
                    .HasColumnType("datetime")
                    .HasColumnName("DOJ");

                entity.Property(e => e.Dor)
                    .HasColumnType("datetime")
                    .HasColumnName("DOR");

                entity.Property(e => e.EmpName).HasMaxLength(50);

                entity.Property(e => e.EmpNumber).HasMaxLength(50);

                entity.Property(e => e.EmployeeType).HasMaxLength(50);

                entity.Property(e => e.FatherName).HasMaxLength(50);

                entity.Property(e => e.Gender).HasMaxLength(12);

                entity.Property(e => e.PerDaySalary).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.WeekOff)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("weekOff");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.EmployeeDetails)
                    .HasForeignKey(d => d.CategoryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDetails_CategoryMaster");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.EmployeeDetails)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDetails_DepartmentMaster");

                entity.HasOne(d => d.Designation)
                    .WithMany(p => p.EmployeeDetails)
                    .HasForeignKey(d => d.DesignationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeDetails_DesignationMaster");
            });

            modelBuilder.Entity<EmployeeInfo>(entity =>
            {
                entity.HasKey(e => e.EmpNo)
                    .HasName("PK__Employee__AF2D66D3642C103B");

                entity.ToTable("EmployeeInfo");

                entity.Property(e => e.Da)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("DA")
                    .HasComputedColumnSql("([Salary]*(0.18))", false);

                entity.Property(e => e.DeptName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Designation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GrossSalary)
                    .HasColumnType("numeric(16, 2)")
                    .HasComputedColumnSql("((([Salary]+[Salary]*(0.2))+[Salary]*(0.15))+[Salary]*(0.18))", false);

                entity.Property(e => e.Hra)
                    .HasColumnType("numeric(12, 1)")
                    .HasColumnName("HRA")
                    .HasComputedColumnSql("([Salary]*(0.2))", false);

                entity.Property(e => e.NetSalary)
                    .HasColumnType("numeric(20, 4)")
                    .HasComputedColumnSql("(((([Salary]+[Salary]*(0.2))+[Salary]*(0.15))+[Salary]*(0.18))-((([Salary]+[Salary]*(0.2))+[Salary]*(0.15))+[Salary]*(0.18))*(0.25))", false);

                entity.Property(e => e.Ta)
                    .HasColumnType("numeric(13, 2)")
                    .HasColumnName("TA")
                    .HasComputedColumnSql("([Salary]*(0.15))", false);

                entity.Property(e => e.Tds)
                    .HasColumnType("numeric(19, 4)")
                    .HasColumnName("TDS")
                    .HasComputedColumnSql("(((([Salary]+[Salary]*(0.2))+[Salary]*(0.15))+[Salary]*(0.18))*(0.25))", false);
            });

            modelBuilder.Entity<ExpenseDetail>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ExpenseDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseDetails_Company");

                entity.HasOne(d => d.GarmentOrderDetail)
                    .WithMany(p => p.ExpenseDetails)
                    .HasForeignKey(d => d.GarmentOrderDetailId)
                    .HasConstraintName("FK_ExpenseDetails_GarmentsOrderDetails");
            });

            modelBuilder.Entity<ExpenseDetailItem>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ExpenseDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseDetailItems_Company");

                entity.HasOne(d => d.ExpenseDetails)
                    .WithMany(p => p.ExpenseDetailItems)
                    .HasForeignKey(d => d.ExpenseDetailsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ExpenseDetailItems_ExpenseDetails");
            });

            modelBuilder.Entity<FabricMaster>(entity =>
            {
                entity.ToTable("FabricMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.FabricName).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FabricMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FabricMaster_Company");
            });

            modelBuilder.Entity<GarmentsOrderDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FreightCost).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.FreightDescription).HasMaxLength(150);

                entity.Property(e => e.Lrno)
                    .HasMaxLength(20)
                    .HasColumnName("LRNo");

                entity.Property(e => e.OrderDate).HasColumnType("datetime");

                entity.Property(e => e.OtherExpenses).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.ShippingAddress1).HasMaxLength(150);

                entity.Property(e => e.ShippingAddress2).HasMaxLength(150);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GarmentsOrderDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.GarmentsOrderDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetails_CustomerDetails");
            });

            modelBuilder.Entity<GarmentsOrderDetailItem>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PieceRateJson).HasColumnName("PieceRateJSON");

                entity.Property(e => e.PricePerPiece).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Qty).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.GarmentsOrderDetailItems)
                    .HasForeignKey(d => d.ColorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetailItems_ColorMaster");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GarmentsOrderDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetailItems_Company");

                entity.HasOne(d => d.GarmentsOrderDetail)
                    .WithMany(p => p.GarmentsOrderDetailItems)
                    .HasForeignKey(d => d.GarmentsOrderDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetailItems_GarmentsOrderDetails");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.GarmentsOrderDetailItems)
                    .HasForeignKey(d => d.StyleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GarmentsOrderDetailItems_StyleDetails");
            });

            modelBuilder.Entity<GarmentsPurchaseDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Color)
                    .WithMany(p => p.GarmentsPurchaseDetailItems)
                    .HasForeignKey(d => d.ColorId)
                    .HasConstraintName("FK_GarmentsPurchaseDetailItems_ColorMaster");

                entity.HasOne(d => d.Style)
                    .WithMany(p => p.GarmentsPurchaseDetailItems)
                    .HasForeignKey(d => d.StyleId)
                    .HasConstraintName("FK_GarmentsPurchaseDetailItems_StyleDetails");
            });

            modelBuilder.Entity<InvoiceDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceType).HasMaxLength(50);

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.InvoiceDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetails_CustomerDetails");
            });

            modelBuilder.Entity<InvoiceDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OurDcno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("OurDCNo");

                entity.Property(e => e.PartyDcno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("PartyDCNo");

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.InvoiceDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetailItems_Company");

                entity.HasOne(d => d.InvoiceDetail)
                    .WithMany(p => p.InvoiceDetailItems)
                    .HasForeignKey(d => d.InvoiceDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetailItems_InvoiceDetails");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.InvoiceDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetailItems_ItemMaster");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.InvoiceDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.InvoiceDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<ItemMaster>(entity =>
            {
                entity.ToTable("ItemMaster");

                entity.Property(e => e.Barcode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ExpDate).HasColumnType("datetime");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Hsncode)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("HSNCode");

                entity.Property(e => e.ItemCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MarginAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.MarginPercent).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ProductName).HasMaxLength(50);

                entity.Property(e => e.PurchasePriceInr).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Qty)
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SalesPriceInr).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Brand)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.BrandId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemMaster_BrandDetails");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemMaster_Company");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemMaster_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ItemMasters)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ItemMaster_UnitMeasurements");
            });

            modelBuilder.Entity<KnittingDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.KnittingDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnittingDetails_Company");

                entity.HasOne(d => d.GarmentDetail)
                    .WithMany(p => p.KnittingDetails)
                    .HasForeignKey(d => d.GarmentDetailId)
                    .HasConstraintName("FK_KnittingDetails_GarmentsOrderDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.KnittingDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnittingDetails_SupplierDetails");
            });

            modelBuilder.Entity<KnittingDetailItem>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RatePerKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.KnittingDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnittingDetailItems_Company");

                entity.HasOne(d => d.KnittingDetail)
                    .WithMany(p => p.KnittingDetailItems)
                    .HasForeignKey(d => d.KnittingDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnittingDetailItems_KnittingDetails");
            });

            modelBuilder.Entity<KnittingMaster>(entity =>
            {
                entity.ToTable("KnittingMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.KnittingName).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.KnittingMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_KnittingMaster_Company");
            });

            modelBuilder.Entity<LaborType>(entity =>
            {
                entity.ToTable("LaborType");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.LaborType1)
                    .HasMaxLength(50)
                    .HasColumnName("LaborType");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.LaborTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LaborType_Company");
            });

            modelBuilder.Entity<MainMenu>(entity =>
            {
                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Menu)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MainMenus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MainMenus_Company");
            });

            modelBuilder.Entity<MeterialMaster>(entity =>
            {
                entity.ToTable("MeterialMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.MaterialName).HasMaxLength(250);

                entity.Property(e => e.OpenStock).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(18, 2)");

                entity.Property(e => e.ReminderStock).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MeterialMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MeterialMaster_Company");
            });

            modelBuilder.Entity<NewRegistration>(entity =>
            {
                entity.ToTable("NewRegistration");

                entity.Property(e => e.BusinessType).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNo).HasMaxLength(50);
            });

            modelBuilder.Entity<Operation>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Operations).HasMaxLength(50);

                entity.Property(e => e.Qty).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Operations)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Operations_Company");
            });

            modelBuilder.Entity<OrderInvoiceDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceType).HasMaxLength(50);

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.OrderInvoiceDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderInvoiceDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.OrderInvoiceDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderInvoiceDetails_CustomerDetails");
            });

            modelBuilder.Entity<OrderWisePurchaseDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.OrderWisePurchaseDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderWisePurchaseDetails_Company");

                entity.HasOne(d => d.OrderDetailItem)
                    .WithMany(p => p.OrderWisePurchaseDetails)
                    .HasForeignKey(d => d.OrderDetailItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OrderWisePurchaseDetails_GarmentsOrderDetailItems");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(250);

                entity.Property(e => e.Narration)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentReminderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Payment_CustomerDetails");

                entity.HasOne(d => d.GarmentOrderDetail)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.GarmentOrderDetailId)
                    .HasConstraintName("FK_Payment_GarmentsOrderDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Payment_SupplierDetails");
            });

            modelBuilder.Entity<PieceRateMaster>(entity =>
            {
                entity.ToTable("PieceRateMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PieceRate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Qty).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PieceRateMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PieceRateMaster_Company");

                entity.HasOne(d => d.OrderDetailItem)
                    .WithMany(p => p.PieceRateMasters)
                    .HasForeignKey(d => d.OrderDetailItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PieceRateMaster_GarmentsOrderDetailItems");
            });

            modelBuilder.Entity<PieceTypeMaster>(entity =>
            {
                entity.ToTable("PieceTypeMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.PieceType).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PieceTypeMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PieceTypeMaster_Company");
            });

            modelBuilder.Entity<Prefix>(entity =>
            {
                entity.ToTable("Prefix");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dprefix).HasMaxLength(50);

                entity.Property(e => e.Sqrate)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("SQRate");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Prefixes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prefix_Company");
            });

            modelBuilder.Entity<ProcessMaster>(entity =>
            {
                entity.ToTable("ProcessMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ProcessName).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProcessMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessMaster_Company");
            });

            modelBuilder.Entity<ProcessingDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProcessingDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessingDetails_Company");

                entity.HasOne(d => d.GarmentDetail)
                    .WithMany(p => p.ProcessingDetails)
                    .HasForeignKey(d => d.GarmentDetailId)
                    .HasConstraintName("FK_ProcessingDetails_GarmentsOrderDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.ProcessingDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessingDetails_SupplierDetails");
            });

            modelBuilder.Entity<ProcessingDetailItem>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RatePerKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProcessingDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessingDetailItems_Company");

                entity.HasOne(d => d.ProcessMaster)
                    .WithMany(p => p.ProcessingDetailItems)
                    .HasForeignKey(d => d.ProcessMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessingDetailItems_ProcessMaster");

                entity.HasOne(d => d.ProcessingDetail)
                    .WithMany(p => p.ProcessingDetailItems)
                    .HasForeignKey(d => d.ProcessingDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProcessingDetailItems_ProcessingDetails");
            });

            modelBuilder.Entity<PurchaseDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Freight).HasColumnType("decimal(9, 2)");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.PoDate).HasColumnType("datetime");

                entity.Property(e => e.PoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_Company");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetails_SupplierDetails");
            });

            modelBuilder.Entity<PurchaseDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetailItems_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.PurchaseDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetailItems_ItemMaster");

                entity.HasOne(d => d.PurchaseDetail)
                    .WithMany(p => p.PurchaseDetailItems)
                    .HasForeignKey(d => d.PurchaseDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetailItems_PurchaseDetails");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.PurchaseDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PurchaseDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<PurchaseReturnDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.PoDate).HasColumnType("datetime");

                entity.Property(e => e.PoNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReturnDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetails_Company");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.PurchaseReturnDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetails_SupplierDetails");
            });

            modelBuilder.Entity<PurchaseReturnDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PurchaseReturnDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetailItems_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.PurchaseReturnDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetailItems_ItemMaster");

                entity.HasOne(d => d.PurchaseReturnDetail)
                    .WithMany(p => p.PurchaseReturnDetailItems)
                    .HasForeignKey(d => d.PurchaseReturnDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetailItems_PurchaseReturnDetails");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.PurchaseReturnDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PurchaseReturnDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PurchaseReturnDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<QuotationDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.QuotationDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.QuotationDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetails_CustomerDetails");
            });

            modelBuilder.Entity<QuotationDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.QuotationDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetailItems_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.QuotationDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetailItems_ItemMaster");

                entity.HasOne(d => d.QuotationDetail)
                    .WithMany(p => p.QuotationDetailItems)
                    .HasForeignKey(d => d.QuotationDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetailItems_QuotationDetails");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.QuotationDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.QuotationDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<QuotationSupplyMaster>(entity =>
            {
                entity.ToTable("QuotationSupplyMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CustomerAddress).HasMaxLength(150);

                entity.Property(e => e.CustomerName).HasMaxLength(150);

                entity.Property(e => e.CustomerNumber).HasMaxLength(150);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.SupplyDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.QuotationSupplyMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationSupplyMaster_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.QuotationSupplyMasters)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuotationSupplyMaster_MeterialMaster");
            });

            modelBuilder.Entity<Receipt>(entity =>
            {
                entity.ToTable("Receipt");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Account)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.BankName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ChequeType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Narration)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentReminderDate).HasColumnType("datetime");

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Receipt_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Receipt_CustomerDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.Receipts)
                    .HasForeignKey(d => d.SupplierId)
                    .HasConstraintName("FK_Receipt_SupplierDetails");
            });

            modelBuilder.Entity<RefreshToken>(entity =>
            {
                entity.ToTable("RefreshToken");

                entity.Property(e => e.ExpiryDate).HasColumnType("smalldatetime");

                entity.Property(e => e.TokenHash).HasMaxLength(1000);

                entity.Property(e => e.TokenSalt).HasMaxLength(50);

                entity.Property(e => e.Ts)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.RefreshTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RefreshToken_User");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Dashboard)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RoleName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Roles)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Roles_Company");
            });

            modelBuilder.Entity<RolePermission>(entity =>
            {
                entity.ToTable("RolePermission");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Privilege).IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_RolePermission_Company");

                entity.HasOne(d => d.Menu)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.MenuId)
                    .HasConstraintName("FK_RolePermission_MainMenus");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RolePermission_Roles");

                entity.HasOne(d => d.SubMenu)
                    .WithMany(p => p.RolePermissions)
                    .HasForeignKey(d => d.SubMenuId)
                    .HasConstraintName("FK_RolePermission_SubMenus");
            });

            modelBuilder.Entity<RolePermissionMaster>(entity =>
            {
                entity.ToTable("RolePermissionMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<SalaryStatement>(entity =>
            {
                entity.ToTable("SalaryStatement");

                entity.Property(e => e.AdvanceAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.AdvancePayments).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.EarnAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.FromDate).HasColumnType("datetime");

                entity.Property(e => e.GrossAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PerDaySalary).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ToDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalaryStatements)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalaryStatement_Company");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.SalaryStatements)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalaryStatement_EmployeeDetails");
            });

            modelBuilder.Entity<SalesDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetails_CustomerDetails");
            });

            modelBuilder.Entity<SalesDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalesDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetailItems_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SalesDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetailItems_ItemMaster");

                entity.HasOne(d => d.SalesDetail)
                    .WithMany(p => p.SalesDetailItems)
                    .HasForeignKey(d => d.SalesDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetailItems_SalesDetails");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.SalesDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SalesDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<SalesReturnDetail>(entity =>
            {
                entity.Property(e => e.BillDate).HasColumnType("datetime");

                entity.Property(e => e.BillNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("LRNo");

                entity.Property(e => e.Remarks)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Transport)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalesReturnDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetails_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SalesReturnDetails)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetails_CustomerDetails");
            });

            modelBuilder.Entity<SalesReturnDetailItem>(entity =>
            {
                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Cgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.HsnCode)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Quantity).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Sgst).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SalesReturnDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetailItems_Company");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SalesReturnDetailItems)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetailItems_ItemMaster");

                entity.HasOne(d => d.SalesReturnDetail)
                    .WithMany(p => p.SalesReturnDetailItems)
                    .HasForeignKey(d => d.SalesReturnDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetailItems_SalesReturnDetails");

                entity.HasOne(d => d.Tax)
                    .WithMany(p => p.SalesReturnDetailItems)
                    .HasForeignKey(d => d.TaxId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetailItems_TaxSettings");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SalesReturnDetailItems)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SalesReturnDetailItems_UnitMeasurements");
            });

            modelBuilder.Entity<SchedulerJobStockItem>(entity =>
            {
                entity.ToTable("SchedulerJobStockItem");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.OpenStock).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SchedulerJobStockItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchedulerJobStockItem_Company");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.SchedulerJobStockItems)
                    .HasForeignKey(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchedulerJobStockItem_ItemMaster");
            });

            modelBuilder.Entity<SchedulerJobStockItemV2>(entity =>
            {
                entity.ToTable("SchedulerJobStockItemV2");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.OpenStock).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Rate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Source).HasMaxLength(50);

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SchedulerJobStockItemV2s)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SchedulerJobStockItemV2_Company");
            });

            modelBuilder.Entity<Setting>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ProformaInvoice)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ProformaInvoiceExpenses)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ProformaInvoicePayment)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.ProformaInvoiceStatement)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Settings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Settings_Company");
            });

            modelBuilder.Entity<ShippingAddress>(entity =>
            {
                entity.ToTable("ShippingAddress");

                entity.Property(e => e.Address1).HasMaxLength(150);

                entity.Property(e => e.Address2).HasMaxLength(150);

                entity.Property(e => e.Address3).HasMaxLength(150);

                entity.Property(e => e.ContactName).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ShippingAddresses)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_ShippingAddress_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShippingAddresses)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ShippingAddress_CustomerDetails");
            });

            modelBuilder.Entity<StockItemDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.OpenStock).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ReminderStock).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StockItemDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemDetails_Company");

                entity.HasOne(d => d.ItemCodeNavigation)
                    .WithMany(p => p.StockItemDetails)
                    .HasForeignKey(d => d.ItemCode)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StockItemDetails_ItemMaster");
            });

            modelBuilder.Entity<StyleDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Style).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.StyleDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_StyleDetails_Company");
            });

            modelBuilder.Entity<SubMenu>(entity =>
            {
                entity.Property(e => e.Action)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasDefaultValueSql("((3))");

                entity.Property(e => e.ControllerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Icon)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasDefaultValueSql("('false')");

                entity.Property(e => e.SubMenu1)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("SubMenu");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SubMenus)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubMenus_Company");
            });

            modelBuilder.Entity<SuffixItem>(entity =>
            {
                entity.ToTable("SuffixItem");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DsuffixItem)
                    .HasMaxLength(50)
                    .HasColumnName("DSuffixItem");

                entity.Property(e => e.Sqrate)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("SQRate");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SuffixItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SuffixItem_Company");
            });

            modelBuilder.Entity<SupplierDetail>(entity =>
            {
                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.ContactNumber).HasMaxLength(50);

                entity.Property(e => e.ContactPerson).HasMaxLength(50);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Gst)
                    .HasMaxLength(50)
                    .HasColumnName("GST");

                entity.Property(e => e.ShippingAddress).HasMaxLength(50);

                entity.Property(e => e.SupplierName).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplierDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplierDetails_Company");
            });

            modelBuilder.Entity<SupplyMaster>(entity =>
            {
                entity.ToTable("SupplyMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount)
                    .HasColumnType("numeric(9, 2)")
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.ContactNumber).HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FreightCharges).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.LoadingCharges).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .HasColumnName("LRNo");

                entity.Property(e => e.ManualRate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.ShippingAddress1).HasMaxLength(250);

                entity.Property(e => e.ShippingAddress2).HasMaxLength(250);

                entity.Property(e => e.SupplyDate).HasColumnType("datetime");

                entity.Property(e => e.UnloadingCharges).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplyMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyMaster_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SupplyMasters)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyMaster_CustomerDetails");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SupplyMasters)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyMaster_MeterialMaster");
            });

            modelBuilder.Entity<SupplyRateMaster>(entity =>
            {
                entity.ToTable("SupplyRateMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Amount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Discount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.PerDayRate).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.SupplyDate).HasColumnType("datetime");

                entity.Property(e => e.SupplyReturnDate).HasColumnType("datetime");

                entity.Property(e => e.Total).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplyRateMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyRateMaster_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SupplyRateMasters)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyRateMaster_CustomerDetails");
            });

            modelBuilder.Entity<SupplyReturnMaster>(entity =>
            {
                entity.ToTable("SupplyReturnMaster");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ContactNumber).HasMaxLength(250);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Lrno)
                    .HasMaxLength(50)
                    .HasColumnName("LRNo");

                entity.Property(e => e.ShippingAddress1).HasMaxLength(250);

                entity.Property(e => e.ShippingAddress2).HasMaxLength(250);

                entity.Property(e => e.SupplyReturnDate).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SupplyReturnMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyReturnMaster_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.SupplyReturnMasters)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyReturnMaster_CustomerDetails");

                entity.HasOne(d => d.Material)
                    .WithMany(p => p.SupplyReturnMasters)
                    .HasForeignKey(d => d.MaterialId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SupplyReturnMaster_MeterialMaster");
            });

            modelBuilder.Entity<TaskDetails>(entity =>
            {
                entity.ToTable("TaskDetails");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Ts)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TS");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaskDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Task_User");
            });

            modelBuilder.Entity<TaxSetting>(entity =>
            {
                entity.Property(e => e.Cgst)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("CGST");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Gst)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("GST");

                entity.Property(e => e.Igst)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("IGST");

                entity.Property(e => e.Sgst)
                    .HasColumnType("numeric(9, 2)")
                    .HasColumnName("SGST");

                entity.Property(e => e.TaxHead)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TaxSettings)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TaxSettings_Company");
            });

            modelBuilder.Entity<TermsAndCondition>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SalesTax)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Type)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TermsAndConditions)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TermsAndConditions_Company");
            });

            modelBuilder.Entity<UnitMeasurement>(entity =>
            {
                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UnitName).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UnitMeasurements)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UnitMeasurements_Company");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(255);

                entity.Property(e => e.LastName).HasMaxLength(255);

                entity.Property(e => e.Password).HasMaxLength(255);

                entity.Property(e => e.PasswordSalt).HasMaxLength(255);

                entity.Property(e => e.Ts)
                    .HasColumnType("smalldatetime")
                    .HasColumnName("TS");
            });

            modelBuilder.Entity<UserDetail>(entity =>
            {
                entity.Property(e => e.ConfirmPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Image).HasColumnType("image");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OldPassword)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDetails_Company");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserDetails)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserDetails_Roles");
            });

            modelBuilder.Entity<WorkEntryDetail>(entity =>
            {
                entity.ToTable("WorkEntryDetail");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.WorkEntryDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkEntryDetail_Company");

                entity.HasOne(d => d.OrderDetailItem)
                    .WithMany(p => p.WorkEntryDetails)
                    .HasForeignKey(d => d.OrderDetailItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WorkEntryDetail_GarmentsOrderDetailItems");
            });

            modelBuilder.Entity<YarnDetail>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Payment).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.YarnDetails)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YarnDetails_Company");

                entity.HasOne(d => d.GarmentDetail)
                    .WithMany(p => p.YarnDetails)
                    .HasForeignKey(d => d.GarmentDetailId)
                    .HasConstraintName("FK_YarnDetails_GarmentsOrderDetails");

                entity.HasOne(d => d.Supplier)
                    .WithMany(p => p.YarnDetails)
                    .HasForeignKey(d => d.SupplierId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YarnDetails_SupplierDetails");
            });

            modelBuilder.Entity<YarnDetailItem>(entity =>
            {
                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.RatePerKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalAmount).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.TotalKg).HasColumnType("numeric(9, 2)");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.YarnDetailItems)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_2_Company");

                entity.HasOne(d => d.YarnDetail)
                    .WithMany(p => p.YarnDetailItems)
                    .HasForeignKey(d => d.YarnDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YarnDetailItems_YarnDetails");

                entity.HasOne(d => d.YarnMaster)
                    .WithMany(p => p.YarnDetailItems)
                    .HasForeignKey(d => d.YarnMasterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Table_2_YarnMaster");
            });

            modelBuilder.Entity<YarnMaster>(entity =>
            {
                entity.ToTable("YarnMaster");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.Property(e => e.YarnName).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.YarnMasters)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_YarnMaster_Company");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
