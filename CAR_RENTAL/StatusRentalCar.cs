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
    
    public partial class StatusRentalCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public StatusRentalCar()
        {
            this.RentalCars = new HashSet<RentalCar>();
        }
    
        public int StatusRentalCarId { get; set; }
        public string StatusRentalCarName { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RentalCar> RentalCars { get; set; }
    }
}
