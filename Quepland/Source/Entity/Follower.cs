using System.Collections.Generic;

namespace Quepland
{
    public class Follower : IEntity<Follower, int>
    {
        public int Id { get; }
        public string Name { get; }
        public string Description { get; }
        public string AutoCollectMessage { get; }
        public IReadOnlyCollection<(SkillType, int)> RequiredSkillLevels { get; }
        public SkillType AutoCollectSkillType { get; }
        public int AutoCollectLevel { get; }
        public int MaxCarry { get; }
        public int AutoCollectSpeed { get; }
        public int Cost { get; }
        
        public int CostItemID { get; set; }

        public Follower(
            int id, 
            string name, 
            string description, 
            string autoCollectMessage,
            (SkillType, int)[] RequiredLevels,
            int autoCollectLevel,
            int maxCarry,
            int autoCollectSpeed,
            int cost)
        {
            Id = id;
            Name = name;
            Description = description;
            AutoCollectMessage = autoCollectMessage;
            RequiredSkillLevels = RequiredLevels;
            AutoCollectLevel = autoCollectLevel;
            MaxCarry = maxCarry;
            AutoCollectSpeed = autoCollectSpeed;
            Cost = cost;
        }

        public override string ToString() => $"Current Follower:{Name}";
    }
}
