using System.Text;

namespace FilesReadWrite
{
    public class Utilities
    {
        public static List<Vehicle> ReadVehicles(string filename)
        {
            List<Vehicle> vehiclesList = new List<Vehicle>();

            string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + filename;

            if (File.Exists(path))
            {
                //string[] lines = File.ReadAllLines(path);
                //for (int i = 0; i < lines.Length; i++)
                //{
                //    string[] words = lines[i].Split(';');
                //    Vehicle v = new Vehicle(Int32.Parse(words[words.Length - 1]), words[0], words[1]);
                //    vehicles.Add(v);
                //}
                string[] vehicles = File.ReadAllLines(path);
                foreach (string v in vehicles)
                {
                    string[] words = v.Split(';');
                    Vehicle vehicle = new Vehicle(Int32.Parse(words[words.Length - 1]), words[0], words[1]);
                    vehiclesList.Add(vehicle);
                }

            }
            return vehiclesList;
        }

        public static void WriteVehicles(List<Vehicle> vehicles, string filename)
        {
            string path = Directory.GetParent(@"../../../").FullName + Path.DirectorySeparatorChar + filename;
            StringBuilder sb = new StringBuilder();

            foreach (Vehicle vehicle in vehicles)
            {
                sb.Append(vehicle.Model + ";");
                sb.Append(vehicle.Color + ";");
                sb.Append(vehicle.CurrentMileage);
                sb.Append(Environment.NewLine);
            }

            File.WriteAllText(path, sb.ToString());
        }

        static void Main(string[] args)
        {
            List<Vehicle> vehiclesList = Utilities.ReadVehicles("vehicles.txt");
            foreach (Vehicle vehicle in vehiclesList)
            {
                Console.WriteLine(vehicle.DisplayVehicleDetails());
            }
            vehiclesList.Clear();

            Vehicle vehicledata = new Vehicle(10, "Ford", "Black");
            vehiclesList.Add(vehicledata);
            vehicledata = null;
            vehicledata = new Vehicle(455, "Toyota", "Red");
            vehiclesList.Add(vehicledata);
            vehicledata = null;
            vehicledata = new Vehicle(1000, "Mercedes", "Green");
            vehiclesList.Add(vehicledata);
            vehicledata = null;

            Utilities.WriteVehicles(vehiclesList, "vehiclewrite.txt");
        }
    }
}
