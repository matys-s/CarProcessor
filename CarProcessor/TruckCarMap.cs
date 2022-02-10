using CsvHelper.Configuration;

namespace CarProcessor
{
    public sealed class TruckCarMap : ClassMap<TruckCar>
    {
        public TruckCarMap()
        {
            Map(m => m.CarType).Name("Typ");
            Map(m => m.Brand).Name("Marka");
            Map(m => m.Model).Name("Model");
            Map(m => m.TruckCapacity).Name("Ładowność(T)");
            Map(m => m.NumberOfAxles).Name("Ilość osi");
            Map(m => m.TruckAxlePress).Name("Nacisk na oś(T)");
        }
    }
}
