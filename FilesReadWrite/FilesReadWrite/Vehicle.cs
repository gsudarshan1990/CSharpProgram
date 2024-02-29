namespace FilesReadWrite
{
    public class Vehicle
    {
        private int currentMileage;
        private string model = string.Empty;
        private string color = string.Empty;

        public int CurrentMileage
        {
            get { return currentMileage; }
            set { currentMileage = value; }
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }


        public Vehicle(int currentMileage, string model, string color)
        {
            CurrentMileage = currentMileage;
            Model = model;
            Color = color;

        }

        public string DisplayVehicleDetails()
        {
            return $"Model: {Model} - Color : {Color} - Current Mileage :{CurrentMileage}";
        }
    }
}

