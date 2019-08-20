using System.Collections.Generic;

namespace Quepland
{
    public class Pet : IEntity<Pet, string>
    {
        public string Id { get; }
        public string Name { get; }
        public string Description { get; }
        public int Cost { get; }
        public int MinLevel { get; }
        public SkillType AffinitySkillType { get; }
        public bool CanBuy { get; }

        public string Nickname { get; set; }
        public List<Skill> Skills { get; }

        public Pet(
            string id, 
            string name, 
            string description, 
            int cost, 
            int minLevel, 
            SkillType affinity,
            bool canBuy)
        {
            Id = id;
            Name = name;
            Description = description;
            Cost = cost;
            MinLevel = minLevel;
            AffinitySkillType = affinity;
            CanBuy = canBuy;
            Nickname = string.Empty;
            Skills = new List<Skill>();
        }

        public static Pet Chicken { get; } = new Pet(
            id: "chicken",
            name: "Chicken",
            description: 
            "The Chicken is a loyal companion, or she would be if her brain weren't the size of a pea." +
            " She'll follow you around and help you grow in your skills a little bit more quickly." +
            " She has a natural affinity for Culinary Arts, on account of tasting so good.",
            cost: 15000,
            minLevel: 1,
            affinity: SkillType.Culinary_Arts,
            canBuy: false);

        public static class Buyable
        {
            public static Pet Scarab { get; } = new Pet(
                id: "scarab",
                name: "Scarab",
                description:
                "The scarab is a shiny companion." +
                " His hard outer shell makes it hard to be friends with him, but he'll help you grow in your skills a little more quickly." +
                " He has a natural affinity for Woodworking, as it's his favorite food.",
                cost: 10,
                minLevel: 1,
                affinity: SkillType.Woodworking,
                canBuy: true);
        }
    }
}
