using System;

namespace FLAME.WASM.Shared
{
    public class Record
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public int TemperatureC { get; set;}

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public string First { get; set; }

        public string Last { get; set; }

        public string Domain { get; set; }

        public string Title { get; set; }

        public string Phone { get; set; }
    }
}
