//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LABA_TOKAr_2_4
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductModel
    {
        public ProductModel()
        {
            this.Product = new HashSet<Product>();
            this.ProductModelProductDescription = new HashSet<ProductModelProductDescription>();
        }
    
        public int ProductModelID { get; set; }
        public string Name { get; set; }
        public string CatalogDescription { get; set; }
        public System.Guid rowguid { get; set; }
        public System.DateTime ModifiedDate { get; set; }
    
        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<ProductModelProductDescription> ProductModelProductDescription { get; set; }
    }
}
