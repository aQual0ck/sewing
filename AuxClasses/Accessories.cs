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
    
    public partial class Accessories
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Accessories()
        {
            this.AccessoryProduct = new HashSet<AccessoryProduct>();
            this.StorageAccessories = new HashSet<StorageAccessories>();
        }
    
        public int Id { get; set; }
        public string ItemNumber { get; set; }
        public string AccessoryName { get; set; }
        public int TypeId { get; set; }
        public double Width { get; set; }
        public Nullable<double> Length { get; set; }
        public Nullable<double> Weight { get; set; }
        public string Image { get; set; }
        public int Price { get; set; }
    
        public virtual AccessoryType AccessoryType { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AccessoryProduct> AccessoryProduct { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<StorageAccessories> StorageAccessories { get; set; }
    }
}
