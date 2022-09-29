using System;
using System.Collections.Generic;

namespace Circa.Core.AppService.Models
{
    public partial class TaxSetting
    {
        public TaxSetting()
        {
            InvoiceDetailItems = new HashSet<InvoiceDetailItem>();
            ItemMasters = new HashSet<ItemMaster>();
            PurchaseDetailItems = new HashSet<PurchaseDetailItem>();
            PurchaseReturnDetailItems = new HashSet<PurchaseReturnDetailItem>();
            QuotationDetailItems = new HashSet<QuotationDetailItem>();
            SalesDetailItems = new HashSet<SalesDetailItem>();
            SalesReturnDetailItems = new HashSet<SalesReturnDetailItem>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string TaxHead { get; set; } = null!;
        public decimal Sgst { get; set; }
        public decimal Cgst { get; set; }
        public decimal Igst { get; set; }
        public string Gst { get; set; } = null!;
        public int CompanyId { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<InvoiceDetailItem> InvoiceDetailItems { get; set; }
        public virtual ICollection<ItemMaster> ItemMasters { get; set; }
        public virtual ICollection<PurchaseDetailItem> PurchaseDetailItems { get; set; }
        public virtual ICollection<PurchaseReturnDetailItem> PurchaseReturnDetailItems { get; set; }
        public virtual ICollection<QuotationDetailItem> QuotationDetailItems { get; set; }
        public virtual ICollection<SalesDetailItem> SalesDetailItems { get; set; }
        public virtual ICollection<SalesReturnDetailItem> SalesReturnDetailItems { get; set; }
    }
}
