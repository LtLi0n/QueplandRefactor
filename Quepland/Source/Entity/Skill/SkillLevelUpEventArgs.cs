using System;

namespace Quepland
{
    public class SkillLevelUpEventArgs : EventArgs
    {
        public Skill Skill { get; }
        public SkillType SkillType => Skill.SkillType;

        public SkillLevelUpEventArgs(Skill skill)
        {
            Skill = skill;
        }
    }
}
