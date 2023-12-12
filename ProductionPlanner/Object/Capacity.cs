using ProductionPlanner.Model;

namespace ProductionPlanner.Object
{
    internal class Capacity
    {
        // Properties
        private int id;
        private string date;
        private string name;
        private double budget;
        private double total_work_hours;

        public Capacity(int id, string name, string date, double budget, double total_work_hours)
        {
            this.id = id;
            this.date = date;
            this.name = name;
            this.budget = budget;
            this.total_work_hours = total_work_hours;
        }

        public Capacity(int id, string name, string date, double budget, double total_work_hours, bool b)
        {
            Cryption cryption = new Cryption();
            this.id = id;
            this.date = cryption.getDecrypt(date);
            this.name = cryption.getDecrypt(name);
            this.budget = budget;
            this.total_work_hours = total_work_hours;
        }

        //Methods


        public string Decrip { get => name; }
        public double Budget { get => budget; }
        public double Total_work_hours { get => total_work_hours;  }
        public int Id { get => id; }
        public string Date { get => date; }
    }
}
