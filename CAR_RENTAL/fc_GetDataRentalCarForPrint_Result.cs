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
    
    public partial class fc_GetDataRentalCarForPrint_Result
    {
        public int RentalCarId { get; set; }
        public string ClientFullName { get; set; }
        public System.DateTime RentalCarRentalDateCar { get; set; }
        public System.DateTime RentalCarReturnDate { get; set; }
        public int CatalogCarId { get; set; }
        public string CarName { get; set; }
        public int CatalogCarPricePerDay { get; set; }
        public int DriverId { get; set; }
        public string DriverFullName { get; set; }
        public decimal DriverDriverLicenseNumber { get; set; }
        public int DriverPricePerDay { get; set; }
        public int RentalCarFullPriceNow { get; set; }
        public int RentalCarFullPricePay { get; set; }
    }
}
