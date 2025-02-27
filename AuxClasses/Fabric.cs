//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace sewing.AuxClasses
{
    using System;
    using System.Collections.Generic;
    
    public partial class Fabric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Fabric()
        {
            this.StorageFabric = new HashSet<StorageFabric>();
            this.Product = new HashSet<Product>();
        }
    
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public string FabricName { get; set; }
        public string Color { get; set; }
        public string Pattern { get; set; }
        public string Image { get; set; }
        public string Composition { get; set; }
        public double Width { get; set; }
        public double? Length { get; set; }
        public int Price { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorageFabric> StorageFabric { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Product { get; set; }
    }
}
