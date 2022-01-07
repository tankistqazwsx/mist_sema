﻿using mist_sema.DataClasses;

namespace mist_sema.Model
{
    public class ComponentRepository : IComponentRepository
    {
        static List<ComputerComponent> data = new List<ComputerComponent>
        {
            new GraphicCard()
            {
                Id = 1,
                Consumed_power = 9010,
                ImageLink = "nope.png",
                Manufacturer = "NVidia",
                Name = "RTX 4099",
                Perfomance = 100501,
                MemoryVolume = 128,
                Price = 5000000000
            },

            new GraphicCard()
            {
                Id = 2,
                Consumed_power = 9000,
                ImageLink = "nope.png",
                Manufacturer = "NVidia",
                Name = "RTX 3090",
                Perfomance = 100000,
                MemoryVolume = 32,
                Price = 50000000
            },

            new GraphicCard()
            {
                Id = 3,
                Consumed_power = 1500,
                ImageLink = "nope.png",
                Manufacturer = "AMD",
                Name = "Radeon XR8600 XXL",
                Perfomance = 90000,
                MemoryVolume = 16,
                Price = 50000
            },
            new GraphicCard()
            {
                Id = 4,
                Consumed_power = 50,
                ImageLink = "nope.png",
                Manufacturer = "NVidia",
                Name = "GTX 110M",
                Perfomance = 5,
                MemoryVolume = 0.25,
                Price = 1000
            },
            new PowerSupply()
            {
                Id = 5,
                Consumed_power = 500,
                ImageLink = "nope.png",
                Manufacturer = "no name",
                Name = "basic power supply by noname",
                Efficiency = 0.9,
                Price = 2000
            },
            new PowerSupply()
            {
                Id = 6,
                Consumed_power = 1000,
                ImageLink = "nope.png",
                Manufacturer = "no name",
                Name = "advanced power supply by noname",
                Efficiency = 0.99,
                Price = 4000
            },
            new Processor()
            {
                Id = 7,
                Consumed_power = 100,
                ImageLink = "nope.png",
                Manufacturer = "Intel",
                Name = "Triple Core T800",
                Perfomance = 100500,
                SocketTypeId = 1,
                Price = 50000
            },
            new Processor()
            {
                Id = 8,
                Consumed_power = 150,
                ImageLink = "nope.png",
                Manufacturer = "Intel",
                Name = "Triple Core T805",
                Perfomance = 100501,
                SocketTypeId = 1,
                Price = 100000
            },
            new Processor()
            {
                Id = 9,
                Consumed_power = 300,
                ImageLink = "nope.png",
                Manufacturer = "AMD",
                Name = "Athlant",
                Perfomance = 100000,
                SocketTypeId = 2,
                Price = 5000
            },
            new Ram()
            {
                Id = 10,
                Consumed_power = 5,
                ImageLink = "nope.png",
                Manufacturer = "Corsair",
                Name = "Corsair DDR4 16GB",
                GenerationId = 4,
                Volume = 16,
                Price = 4500
            },
            new Ram()
            {
                Id = 11,
                Consumed_power = 5,
                ImageLink = "nope.png",
                Manufacturer = "Corsair",
                Name = "Corsair DDR4 8GB",
                GenerationId = 4,
                Volume = 8,
                Price = 3000
            },
            new Ram()
            {
                Id = 12,
                Consumed_power = 5,
                ImageLink = "nope.png",
                Manufacturer = "noname",
                Name = "noname DDR3 4GB",
                GenerationId = 3,
                Volume = 4,
                Price = 500
            },
            new StorageDevice()
            {
                Id = 13,
                Consumed_power = 10,
                ImageLink = "nope.png",
                Manufacturer = "WD",
                Name = "WD Green HDD 500GB",
                TypeId = 1,
                Volume = 500,
                Price = 3000
            },
            new StorageDevice()
            {
                Id = 14,
                Consumed_power = 10,
                ImageLink = "nope.png",
                Manufacturer = "WD",
                Name = "WD Green HDD 1TB",
                TypeId = 1,
                Volume = 1000,
                Price = 4000
            },
            new StorageDevice()
            {
                Id = 15,
                Consumed_power = 10,
                ImageLink = "nope.png",
                Manufacturer = "WD",
                Name = "WD Green SSD 250GB",
                TypeId = 2,
                Volume = 250,
                Price = 4000
            },
            new SystemBoard()
            {
                Id = 16,
                Consumed_power = 5,
                ImageLink = "nope.png",
                Manufacturer = "no name",
                Name = "basic systemboard by noname",
                MemorySlotsCount = 2,
                MemoryGenerationId = 4,
                SataPortsCount = 2,
                SocketTypeId = 1,
                Price = 2000
            },
            new SystemBoard()
            {
                Id = 17,
                Consumed_power = 5,
                ImageLink = "nope.png",
                Manufacturer = "no name",
                Name = "basic systemboard by noname",
                MemorySlotsCount = 2,
                MemoryGenerationId = 4,
                SataPortsCount = 2,
                SocketTypeId = 1,
                Price = 2000
            },
        };

        public IEnumerable<T> GetAll<T>() where T : ComputerComponent
        {
            return data.OfType<T>();
        }

        public T? Get<T>(long id) where T : ComputerComponent
        {
            return data.FirstOrDefault((x) => x.Id == id) as T;
        }

        public void Add<T>(T newComponent) where T : ComputerComponent
        {
            data.Add(newComponent);
        }

        public void Delete(long id)
        {
            var component = data.FirstOrDefault((x) => x.Id == id);
            if (component != null)
                data.Remove(component);
        }
    }
}