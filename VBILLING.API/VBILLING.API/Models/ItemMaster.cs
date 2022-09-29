using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class ItemMaster
    {
        public ItemMaster()
        {
            InvoiceDetailItems = new HashSet<InvoiceDetailItem>();
            PurchaseDetailItems = new HashSet<PurchaseDetailItem>();
            PurchaseReturnDetailItems = new HashSet<PurchaseReturnDetailItem>();
            QuotationDetailItems = new HashSet<QuotationDetailItem>();
            SalesDetailItems = new HashSet<SalesDetailItem>();
            SalesReturnDetailItems = new HashSet<SalesReturnDetailItem>();
            SchedulerJobStockItems = new HashSet<SchedulerJobStockItem>();
            StockItemDetails = new HashSet<StockItemDetail>();
        }

        public int Id { get; set; }
        public string? ItemCode { get; set; }
        public string ProductName { get; set; } = null!;
        public string? Description { get; set; }
        public int BrandId { get; set; }
        public string GroupName { get; set; } = null!;
        public string? Hsncode { get; set; }
        public string? Barcode { get; set; }
        public int UnitId { get; set; }
        public int TaxId { get; set; }
        public int OpenStock { get; set; }
        public decimal Qty { get; set; }
        public decimal MarginPercent { get; set; }
        public decimal MarginAmount { get; set; }
        public decimal PurchasePriceInr { get; set; }
        public decimal SalesPriceInr { get; set; }
        public int BatchNo { get; set; }
        public DateTime ExpDate { get; set; }
        public bool Status { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual BrandDetail Brand { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual TaxSetting Tax { get; set; } = null!;
        public virtual UnitMeasurement Unit { get; set; } = null!;
        public virtual ICollection<InvoiceDetailItem> InvoiceDetailItems { get; set; }
        public virtual ICollection<PurchaseDetailItem> PurchaseDetailItems { get; set; }
        public virtual ICollection<PurchaseReturnDetailItem> PurchaseReturnDetailItems { get; set; }
        public virtual ICollection<QuotationDetailItem> QuotationDetailItems { get; set; }
        public virtual ICollection<SalesDetailItem> SalesDetailItems { get; set; }
        public virtual ICollection<SalesReturnDetailItem> SalesReturnDetailItems { get; set; }
        public virtual ICollection<SchedulerJobStockItem> SchedulerJobStockItems { get; set; }
        public virtual ICollection<StockItemDetail> StockItemDetails { get; set; }
    }
}
