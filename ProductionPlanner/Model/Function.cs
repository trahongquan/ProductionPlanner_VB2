namespace ProductionPlanner.Model
{
    public class Function
        //Lớp này thể hiện hàm mục tiêu
    {
        public double[] variables;
        public double c;
        public bool isExtrMax;  //true là tìm MAX

        public Function(double[] variables, double c, bool isExtrMax)
        {
            this.variables = variables;
            this.c = c;
            this.isExtrMax = isExtrMax;
        }
    }
}
