//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CAR_RENTAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class TypeCarDamage
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeCarDamage()
        {
            this.ReturnCarHaveDamages = new HashSet<ReturnCarHaveDamage>();
        }
    
        public int TypeCarDamageId { get; set; }
        public string TypeCarDamageName { get; set; }
        public int TypeCarDamagePrice { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnCarHaveDamage> ReturnCarHaveDamages { get; set; }
    }
}
