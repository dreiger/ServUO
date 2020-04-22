using System;
using Server;

namespace Server.Items
{
   
    public class DonationBunnySlippers: Shoes
    {
        public override CraftResource DefaultResource{ get{ return CraftResource.RegularLeather; } }

        [Constructable]
        public DonationBunnySlippers()
        {
            Name = "Fluffy Bunny Slippers";
            Hue = 1902;

            Attributes.AttackChance = 75;
            Attributes.BonusDex = 225;
            Attributes.BonusHits = 220;
            Attributes.BonusInt = 235;
            Attributes.BonusMana = 235;
            Attributes.BonusStam = 237;
            Attributes.CastRecovery = 10;
            Attributes.CastSpeed = 10;
            Attributes.DefendChance = 154;
            //Attributes.EnhancePotions = 30;
            Attributes.LowerManaCost = 100;
            Attributes.LowerRegCost = 100;
            Attributes.Luck = 420;
            Attributes.NightSight = 1;
            Attributes.ReflectPhysical = 75;
            Attributes.RegenHits = 150;
            Attributes.RegenMana = 153;
            Attributes.RegenStam = 154;
            Attributes.SpellChanneling = 1;
            SkillBonuses.SetValues(0, SkillName.AnimalTaming, 55.0);
            SkillBonuses.SetValues(1, SkillName.Stealth, 50.0);
            SkillBonuses.SetValues(2, SkillName.Swords, 52.0);
            SkillBonuses.SetValues(3, SkillName.Hiding, 55.0);
            SkillBonuses.SetValues(4, SkillName.AnimalLore, 55.0);
        }

       

        public DonationBunnySlippers(Serial serial)
            : base(serial)
        {
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0); // version
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
  
        }
    }
}