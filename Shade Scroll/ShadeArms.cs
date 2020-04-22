
using System;
using Server;
using Server.Items;
//using Server.Engines.XmlSpawner2;

namespace Server.Items
{
    public class ShadeArms : PlateArms
    {
        [Constructable]
        public ShadeArms()
        {
            this.Weight = 2;
            this.Hue = 2675;
            this.Name = "Shade Arms";

		//	XmlAttach.AttachTo(this, new XmlSocketable(4));
         //   XmlAttach.AttachTo(this, new XmlSockets(4));
            this.Attributes.AttackChance = 75;
            this.Attributes.BonusDex = 75;
            this.Attributes.BonusInt = 75;
            this.Attributes.CastRecovery = 75;
            this.Attributes.CastSpeed = 75;
            this.Attributes.DefendChance = 100;
            this.Attributes.LowerManaCost = 75;
            this.Attributes.LowerRegCost = 75;
            this.Attributes.Luck = 100;
            this.Attributes.NightSight = 1;
            this.Attributes.ReflectPhysical = 70;
            this.Attributes.RegenHits = 75;
            this.Attributes.RegenMana = 75;
            this.Attributes.RegenStam = 75;
            this.Attributes.SpellChanneling = 1;
            this.Attributes.WeaponDamage = 75;

            this.ArmorAttributes.DurabilityBonus = 75;
            this.ArmorAttributes.LowerStatReq = 75;
            this.ArmorAttributes.SelfRepair = 1;

            this.ColdBonus = 74;
            this.EnergyBonus = 40;
            this.FireBonus = 20;
            this.PhysicalBonus = 50;
            this.PoisonBonus = 10;
            this.StrBonus = 55;

        }

        public ShadeArms( Serial serial ) : base( serial )
        {
        }

		public override int ArtifactRarity{ get{ return 95; } }
             
        public override void Serialize( GenericWriter writer )
        {
            base.Serialize( writer );
            writer.Write( (int) 0 );
        }
              
        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize( reader );
            int version = reader.ReadInt();
        }
    }
}