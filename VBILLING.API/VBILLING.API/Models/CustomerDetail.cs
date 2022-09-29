using System;
using System.Collections.Generic;

namespace VBILLING.API.Models
{
    public partial class CustomerDetail
    {
        public CustomerDetail()
        {
            BuildingSqfeetInvoices = new HashSet<BuildingSqfeetInvoice>();
            CustomerAdvances = new HashSet<CustomerAdvance>();
            CustomerDebits = new HashSet<CustomerDebit>();
            CustomerDiscounts = new HashSet<CustomerDiscount>();
            GarmentsOrderDetails = new HashSet<GarmentsOrderDetail>();
            InvoiceDetails = new HashSet<InvoiceDetail>();
            OrderInvoiceDetails = new HashSet<OrderInvoiceDetail>();
            Payments = new HashSet<Payment>();
            QuotationDetails = new HashSet<QuotationDetail>();
            Receipts = new HashSet<Receipt>();
            SalesDetails = new HashSet<SalesDetail>();
            SalesReturnDetails = new HashSet<SalesReturnDetail>();
            ShippingAddresses = new HashSet<ShippingAddress>();
            SupplyMasters = new HashSet<SupplyMaster>();
            SupplyRateMasters = new HashSet<SupplyRateMaster>();
            SupplyReturnMasters = new HashSet<SupplyReturnMaster>();
        }

        public long Id { get; set; }
        public string CustomerName { get; set; } = null!;
        public string Address1 { get; set; } = null!;
        public string? Address2 { get; set; }
        public string ContactPerson { get; set; } = null!;
        public string ContactNumber { get; set; } = null!;
        public string ShippingAddress { get; set; } = null!;
        public string? Gst { get; set; }
        public bool ActiveStatus { get; set; }
        public int CompanyId { get; set; }
        public DateTime CreatedAt { get; set; }
        public long CreatedBy { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public long? UpdatedBy { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<BuildingSqfeetInvoice> BuildingSqfeetInvoices { get; set; }
        public virtual ICollection<CustomerAdvance> CustomerAdvances { get; set; }
        public virtual ICollection<CustomerDebit> CustomerDebits { get; set; }
        public virtual ICollection<CustomerDiscount> CustomerDiscounts { get; set; }
        public virtual ICollection<GarmentsOrderDetail> GarmentsOrderDetails { get; set; }
        public virtual ICollection<InvoiceDetail> InvoiceDetails { get; set; }
        public virtual ICollection<OrderInvoiceDetail> OrderInvoiceDetails { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<QuotationDetail> QuotationDetails { get; set; }
        public virtual ICollection<Receipt> Receipts { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
        public virtual ICollection<SalesReturnDetail> SalesReturnDetails { get; set; }
        public virtual ICollection<ShippingAddress> ShippingAddresses { get; set; }
        public virtual ICollection<SupplyMaster> SupplyMasters { get; set; }
        public virtual ICollection<SupplyRateMaster> SupplyRateMasters { get; set; }
        public virtual ICollection<SupplyReturnMaster> SupplyReturnMasters { get; set; }
    }
}
