﻿using ProductionPlanner.Services;

namespace ProductionPlanner.Model
{
    public class SimplexIndexResult
    {
        public Tuple<int, int> index;
        public SimplexResult result;

        public SimplexIndexResult(Tuple<int, int> index, SimplexResult result)
        {
            this.index = index;
            this.result = result;
        }
    }
}
