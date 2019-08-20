using System;

namespace Quepland
{
    public class Skill
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public int LevelBoosted => Level + LevelBoost;
        private long _experience;
        public bool IsBlocked { get; set; }
        public SkillType SkillType { get; set; }
        public string Description { get; set; }
        public int LevelBoost { get; set; }
        public long Experience
        {
            get => _experience;
            set
            {
                if (value >= 0)
                {
                    _experience = Math.Min(value, long.MaxValue - 20000000);
                }
                else
                {
                    _experience = long.MaxValue - 20000000;
                }
            }
        }

        public event EventHandler<SkillLevelUpEventArgs> LevelUp;

        public int TryIncreaseLevels()
        {
            int levels_added = 0;

            while (Experience > GetRequiredExperience(Level))
            {
                Level++;
                LevelUp?.Invoke(this, new SkillLevelUpEventArgs(this));
                levels_added++;
            }

            return levels_added;
        }

        public static string FromSkillType(SkillType skill_type) =>
            skill_type switch
            {
                SkillType.Unknown => "Unknown",
                SkillType.HP => "HP",
                SkillType.Knifesmanship => "Knifesmanship",
                SkillType.Swordsmanship => "Swordsmanship",
                SkillType.Axemanship => "Axemanship",
                SkillType.Hammermanship => "Hammermanship",
                SkillType.Deftness => "Deftness",
                SkillType.Strength => "Strength",
                SkillType.Archery => "Archery",
                SkillType.Mining => "Mining",
                SkillType.Smithing => "Smithing",
                SkillType.Alchemy => "Alchemy",
                SkillType.Fishing => "Fishing",
                SkillType.Woodcutting => "Woodcutting",
                SkillType.Woodworking => "Woodworking",
                SkillType.Hunting => "Hunting",
                SkillType.Culinary_Arts => "Culinary Arts",
                SkillType.Leatherworking => "Leatherworking",
                SkillType.Construction => "Construction",
                _ => throw new NotImplementedException()
            };

        public static long GetRequiredExperience(int level)
        {
            long exp = 0;
            for (int i = 0; i < level; i++)
            {
                exp += (long)(100.0d * Math.Pow(1.1, i));
            }
            return exp;
        }
    }
}
