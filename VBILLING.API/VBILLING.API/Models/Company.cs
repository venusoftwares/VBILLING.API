using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class Company
    {
        public Company()
        {
            AttendanceDailies = new HashSet<AttendanceDaily>();
            BrandDetails = new HashSet<BrandDetail>();
            BuildingSqfeetInvoices = new HashSet<BuildingSqfeetInvoice>();
            CategoryMasters = new HashSet<CategoryMaster>();
            ColorMasters = new HashSet<ColorMaster>();
            CompanyNames = new HashSet<CompanyName>();
            CustomerAdvances = new HashSet<CustomerAdvance>();
            CustomerDebits = new HashSet<CustomerDebit>();
            CustomerDetails = new HashSet<CustomerDetail>();
            CustomerDiscounts = new HashSet<CustomerDiscount>();
            DepartmentMasters = new HashSet<DepartmentMaster>();
            DyeingDetailItems = new HashSet<DyeingDetailItem>();
            DyeingDetails = new HashSet<DyeingDetail>();
            DyingMasters = new HashSet<DyingMaster>();
            EmployeeAdvancePayments = new HashSet<EmployeeAdvancePayment>();
            EmployeeAdvances = new HashSet<EmployeeAdvance>();
            ExpenseDetailItems = new HashSet<ExpenseDetailItem>();
            ExpenseDetails = new HashSet<ExpenseDetail>();
            FabricMasters = new HashSet<FabricMaster>();
            GarmentsOrderDetailItems = new HashSet<GarmentsOrderDetailItem>();
            GarmentsOrderDetails = new HashSet<GarmentsOrderDetail>();
            InvoiceDetailItems = new HashSet<InvoiceDetailItem>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            ItemMasters = new HashSet<ItemMaster>();
            KnittingDetailItems = new HashSet<KnittingDetailItem>();
            KnittingDetails = new HashSet<KnittingDetail>();
            KnittingMasters = new HashSet<KnittingMaster>();
            LaborTypes = new HashSet<LaborType>();
            MainMenus = new HashSet<MainMenu>();
            MeterialMasters = new HashSet<MeterialMaster>();
            Operations = new HashSet<Operation>();
            OrderInvoiceDetails = new HashSet<OrderInvoiceDetail>();
            OrderWisePurchaseDetails = new HashSet<OrderWisePurchaseDetail>();
            Payments = new HashSet<Payment>();
            PieceRateMasters = new HashSet<PieceRateMaster>();
            PieceTypeMasters = new HashSet<PieceTypeMaster>();
            Prefixes = new HashSet<Prefix>();
            ProcessMasters = new HashSet<ProcessMaster>();
            ProcessingDetailItems = new HashSet<ProcessingDetailItem>();
            ProcessingDetails = new HashSet<ProcessingDetail>();
            PurchaseDetailItems = new HashSet<PurchaseDetailItem>();
            PurchaseDetails = new HashSet<PurchaseDetail>();
            PurchaseReturnDetailItems = new HashSet<PurchaseReturnDetailItem>();
            PurchaseReturnDetails = new HashSet<PurchaseReturnDetail>();
            QuotationDetailItems = new HashSet<QuotationDetailItem>();
            QuotationDetails = new HashSet<QuotationDetail>();
            QuotationSupplyMasters = new HashSet<QuotationSupplyMaster>();
            Receipts = new HashSet<Receipt>();
            RolePermissions = new HashSet<RolePermission>();
            Roles = new HashSet<Role>();
            SalaryStatements = new HashSet<SalaryStatement>();
            SalesDetailItems = new HashSet<SalesDetailItem>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesReturnDetailItems = new HashSet<SalesReturnDetailItem>();
            SalesReturnDetails = new HashSet<SalesReturnDetail>();
            SchedulerJobStockItemV2s = new HashSet<SchedulerJobStockItemV2>();
            SchedulerJobStockItems = new HashSet<SchedulerJobStockItem>();
            Settings = new HashSet<Setting>();
            ShippingAddresses = new HashSet<ShippingAddress>();
            StockItemDetails = new HashSet<StockItemDetail>();
            StyleDetails = new HashSet<StyleDetail>();
            SubMenus = new HashSet<SubMenu>();
            SuffixItems = new HashSet<SuffixItem>();
            SupplierDetails = new HashSet<SupplierDetail>();
            SupplyMasters = new HashSet<SupplyMaster>();
            SupplyRateMasters = new HashSet<SupplyRateMaster>();
            SupplyReturnMasters = new HashSet<SupplyReturnMaster>();
            TaxSettings = new HashSet<TaxSetting>();
            TermsAndConditions = new HashSet<TermsAndCondition>();
            UnitMeasurements = new HashSet<UnitMeasurement>();
            UserDetails = new HashSet<UserDetail>();
            WorkEntryDetails = new HashSet<WorkEntryDetail>();
            YarnDetailItems = new HashSet<YarnDetailItem>();
            YarnDetails = new HashSet<YarnDetail>();
            YarnMasters = new HashSet<YarnMaster>();
        }

        public int Id { get; set; }
        public string CompanyName { get; set; } = null!;
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string PrintCompanyName { get; set; } = null!;
        public string? ShippingAddress { get; set; }
        public DateTime FinanceYearStart { get; set; }
        public DateTime FinanceYearEnd { get; set; }
        public string Gst { get; set; } = null!;
        public string EmailId { get; set; } = null!;
        public string ContactPerson { get; set; } = null!;
        public string MobileNo { get; set; } = null!;
        public string? ManufactureOffice { get; set; }
        public string? Cstno { get; set; }
        public DateTime? Cstdate { get; set; }
        public string? Eccno { get; set; }
        public DateTime? Eccdate { get; set; }
        public string? PhoneNo { get; set; }
        public string? FaxNo { get; set; }
        public string State { get; set; } = null!;
        public string StateCode { get; set; } = null!;
        public string? District { get; set; }
        public int PinCode { get; set; }
        public string? BankName { get; set; }
        public string? ACno { get; set; }
        public string? Ifsccode { get; set; }
        public string? BranchName { get; set; }
        public decimal? OpeningBalance { get; set; }
        public byte[]? Logo { get; set; }
        public string? TanNo { get; set; }
        public string? Ibanno { get; set; }
        public string? AccountHolderName { get; set; }
        public string? Swiftcode { get; set; }
        public string? ServiceTaxNo { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string AccessCode { get; set; } = null!;
        public string? PanNo { get; set; }
        public byte[]? Image { get; set; }

        public virtual ICollection<AttendanceDaily> AttendanceDailies { get; set; }
        public virtual ICollection<BrandDetail> BrandDetails { get; set; }
        public virtual ICollection<BuildingSqfeetInvoice> BuildingSqfeetInvoices { get; set; }
        public virtual ICollection<CategoryMaster> CategoryMasters { get; set; }
        public virtual ICollection<ColorMaster> ColorMasters { get; set; }
        public virtual ICollection<CompanyName> CompanyNames { get; set; }
        public virtual ICollection<CustomerAdvance> CustomerAdvances { get; set; }
        public virtual ICollection<CustomerDebit> CustomerDebits { get; set; }
        public virtual ICollection<CustomerDetail> CustomerDetails { get; set; }
        public virtual ICollection<CustomerDiscount> CustomerDiscounts { get; set; }
        public virtual ICollection<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual ICollection<DyeingDetailItem> DyeingDetailItems { get; set; }
        public virtual ICollection<DyeingDetail> DyeingDetails { get; set; }
        public virtual ICollection<DyingMaster> DyingMasters { get; set; }
        public virtual ICollection<EmployeeAdvancePayment> EmployeeAdvancePayments { get; set; }
        public virtual ICollection<EmployeeAdvance> EmployeeAdvances { get; set; }
        public virtual ICollection<ExpenseDetailItem> ExpenseDetailItems { get; set; }
        public virtual ICollection<ExpenseDetail> ExpenseDetails { get; set; }
        public virtual ICollection<FabricMaster> FabricMasters { get; set; }
        public virtual ICollection<GarmentsOrderDetailItem> GarmentsOrderDetailItems { get; set; }
        public virtual ICollection<GarmentsOrderDetail> GarmentsOrderDetails { get; set; }
        public virtual ICollection<InvoiceDetailItem> InvoiceDetailItems { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<KnittingDetailItem> KnittingDetailItems { get; set; }
        public virtual ICollection<KnittingDetail> KnittingDetails { get; set; }
        public virtual ICollection<KnittingMaster> KnittingMasters { get; set; }
        public virtual ICollection<LaborType> LaborTypes { get; set; }
        public virtual ICollection<MainMenu> MainMenus { get; set; }
        public virtual ICollection<MeterialMaster> MeterialMasters { get; set; }
        public virtual ICollection<Operation> Operations { get; set; }
        public virtual ICollection<OrderInvoiceDetail> OrderInvoiceDetails { get; set; }
        public virtual ICollection<OrderWisePurchaseDetail> OrderWisePurchaseDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PieceRateMaster> PieceRateMasters { get; set; }
        public virtual ICollection<PieceTypeMaster> PieceTypeMasters { get; set; }
        public virtual ICollection<Prefix> Prefixes { get; set; }
        public virtual ICollection<ProcessMaster> ProcessMasters { get; set; }
        public virtual ICollection<ProcessingDetailItem> ProcessingDetailItems { get; set; }
        public virtual ICollection<ProcessingDetail> ProcessingDetails { get; set; }
        public virtual ICollection<PurchaseDetailItem> PurchaseDetailItems { get; set; }
        public virtual ICollection<PurchaseDetail> PurchaseDetails { get; set; }
        public virtual ICollection<PurchaseReturnDetailItem> PurchaseReturnDetailItems { get; set; }
        public virtual ICollection<PurchaseReturnDetail> PurchaseReturnDetails { get; set; }
        public virtual ICollection<QuotationDetailItem> QuotationDetailItems { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ICollection<QuotationSupplyMaster> QuotationSupplyMasters { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<RolePermission> RolePermissions { get; set; }
        public virtual ICollection<Role> Roles { get; set; }
        public virtual ICollection<SalaryStatement> SalaryStatements { get; set; }
        public virtual ICollection<SalesDetailItem> SalesDetailItems { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesReturnDetailItem> SalesReturnDetailItems { get; set; }
        public virtual ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
        public virtual ICollection<SchedulerJobStockItemV2> SchedulerJobStockItemV2s { get; set; }
        public virtual ICollection<SchedulerJobStockItem> SchedulerJobStockItems { get; set; }
        public virtual ICollection<Setting> Settings { get; set; }
        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public virtual ICollection<StockItemDetail> StockItemDetails { get; set; }
        public virtual ICollection<StyleDetail> StyleDetails { get; set; }
        public virtual ICollection<SubMenu> SubMenus { get; set; }
        public virtual ICollection<SuffixItem> SuffixItems { get; set; }
        public virtual ICollection<SupplierDetail> SupplierDetails { get; set; }
        public virtual ICollection<SupplyMaster> SupplyMasters { get; set; }
        public virtual ICollection<SupplyRateMaster> SupplyRateMasters { get; set; }
        public virtual ICollection<SupplyReturnMaster> SupplyReturnMasters { get; set; }
        public virtual ICollection<TaxSetting> TaxSettings { get; set; }
        public virtual ICollection<TermsAndCondition> TermsAndConditions { get; set; }
        public virtual ICollection<UnitMeasurement> UnitMeasurements { get; set; }
        public virtual ICollection<UserDetail> UserDetails { get; set; }
        public virtual ICollection<WorkEntryDetail> WorkEntryDetails { get; set; }
        public virtual ICollection<YarnDetailItem> YarnDetailItems { get; set; }
        public virtual ICollection<YarnDetail> YarnDetails { get; set; }
        public virtual ICollection<YarnMaster> YarnMasters { get; set; }
    }
}
