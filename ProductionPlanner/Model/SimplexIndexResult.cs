using ProductionPlanner.Services;

namespace ProductionPlanner.Model
{
    public class SimplexIndexResult
    {
        //Chứa kết quả sau mỗi bảng, chứa thông tin về chỉ số của các biến vào và ra và kết quả của bước Simplex.
        public Tuple<int, int> index;
        public SimplexResult result;

        public SimplexIndexResult(Tuple<int, int> index, SimplexResult result)
        {
            this.index = index;
            this.result = result;
        }
    }
}
