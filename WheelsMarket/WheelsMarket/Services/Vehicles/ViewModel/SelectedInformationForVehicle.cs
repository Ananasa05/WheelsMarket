﻿namespace WheelsMarket.Services.Vehicles.ViewModel
{
    public class SelectedInformationForVehicle
    {
        public Guid Id { get; set; }
        public int Distance { get; set; }
        public string Fuel { get; set; }
        public string ImageURL { get; set; }
        public int Price { get; set; }
        public int Volume { get; set; }
        public int Year { get; set; }
        public string EditionName { get; set; }
        public string BrandName { get; set; }
    }
}
