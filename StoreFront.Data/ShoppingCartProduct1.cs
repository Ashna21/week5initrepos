//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StoreFront.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShoppingCartProduct1
    {
        public int ShoppingCartProductID { get; set; }
        public int ShoppingCartID { get; set; }
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public System.DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> DateModified { get; set; }
        public string ModifiedBy { get; set; }
    
        public virtual Product1 Product { get; set; }
        public virtual ShoppingCart1 ShoppingCart { get; set; }
    }
}
