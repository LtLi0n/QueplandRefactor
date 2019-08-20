using System.Collections.Generic;

namespace Quepland
{
    public class Room
    {
        public string Name { get; }
        public string Url { get; }
        public string Description { get; }
        public int ConstructionLevelRequired { get; }
        public int MinimumPlankLevel { get; }
        public int PlanksRequired { get; }
        public int MinimumBarLevel { get; }
        public int BarsRequired { get; }

        public int[][] OtherItemCosts { get; set; }
        public int ExperienceGained { get; set; }
        public bool IsComplete { get; set; }
        public int WorkRemaining { get; set; }
        public List<Furniture> Furniture { get; } = new List<Furniture>();

        public Room(
            string name, 
            string url, 
            string description, 
            int constructionLevelRequired, 
            int minimumPlankLevel, 
            int planksRequired, 
            int minimumBarLevel, 
            int barsRequired)
        {
            Name = name;
            Url = url;
            Description = description;
            ConstructionLevelRequired = constructionLevelRequired;
            MinimumPlankLevel = minimumPlankLevel;
            PlanksRequired = planksRequired;
            MinimumBarLevel = minimumBarLevel;
            BarsRequired = barsRequired;
        }
    }
}
