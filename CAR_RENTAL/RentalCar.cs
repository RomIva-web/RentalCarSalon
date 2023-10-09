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
    
    public partial class RentalCar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public RentalCar()
        {
            this.Fines = new HashSet<Fine>();
            this.ReturnCarHaveDamages = new HashSet<ReturnCarHaveDamage>();
        }
    
        public int RentalCarId { get; set; }
        public int CatalogCarId { get; set; }
        public int ClientId { get; set; }
        public int StatusPaymentRentalCarId { get; set; }
        public int AdditionalServicesOnOrderId { get; set; }
        public int StatusAdditionalPaymentRentalCarId { get; set; }
        public int StatusRentalCarId { get; set; }
        public System.DateTime RentalCarRentalDateCar { get; set; }
        public System.DateTime RentalCarReturnDate { get; set; }
        public int RentalCarFullPriceNow { get; set; }
        public int RentalCarFullPricePay { get; set; }
    
        public virtual AdditionalServicesOnOrder AdditionalServicesOnOrder { get; set; }
        public virtual CatalogCar CatalogCar { get; set; }
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Fine> Fines { get; set; }
        public virtual StatusAdditionalPaymentRentalCar StatusAdditionalPaymentRentalCar { get; set; }
        public virtual StatusPaymentRentalCar StatusPaymentRentalCar { get; set; }
        public virtual StatusRentalCar StatusRentalCar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ReturnCarHaveDamage> ReturnCarHaveDamages { get; set; }
    }
}