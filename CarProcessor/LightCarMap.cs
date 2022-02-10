using CsvHelper.Configuration;

namespace CarProcessor
{
    public sealed class LightCarMap : ClassMap<LightCar>
    {
        public LightCarMap()
        {
            Map(m => m.CarType).Name("Typ");
            Map(m => m.Brand).Name("Marka");
            Map(m => m.Model).Name("Model");
            Map(m => m.EngineCapacity).Name("Pojemność silnika");
            Map(m => m.DoorsNumber).Name("Ilość drzwi");
            Map(m => m.PassengersQuantity).Name("Ilość pasażerów");

        }
    }
}
