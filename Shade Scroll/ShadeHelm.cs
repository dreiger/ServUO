
using System;
using Server;
using Server.Items;
//using Server.Engines.XmlSpawner2;

namespace Server.Items
{
    public class ShadeHelm : NorseHelm
    {
        [Constructable]
        public ShadeHelm()
        {
            this.Weight = 2;
            this.Hue = 2675;
            this.Name = "Shade Helm";

			//XmlAttach.AttachTo(this, new XmlSocketable(8));
			//XmlAttach.AttachTo(this, new XmlSockets(8));
            this.Attributes.AttackChance = 70;
            this.Attributes.BonusDex = 10;
            this.Attributes.BonusHits = 10;
            this.Attributes.BonusInt = 5;
            this.Attributes.BonusMana = 5;
            this.Attributes.CastRecovery = 100;
            this.Attributes.CastSpeed = 60;
            this.Attributes.DefendChance = 40;
            this.Attributes.LowerManaCost = 66;
            this.Attributes.LowerRegCost = 60;
            this.Attributes.Luck = 100;
            this.Attributes.NightSight = 1;
            this.Attributes.ReflectPhysical = 80;
            this.Attributes.RegenHits = 70;
            this.Attributes.SpellChanneling = 1;
            this.Attributes.WeaponDamage = 60;

            this.ArmorAttributes.DurabilityBonus = 40;
            this.ArmorAttributes.LowerStatReq = 38;
            this.ArmorAttributes.SelfRepair = 1;

            this.ColdBonus = 74;
            this.EnergyBonus = 40;
            this.FireBonus = 20;
            this.PhysicalBonus = 50;
            this.PoisonBonus = 10;
            this.StrBonus = 55;

        }

        public ShadeHelm( Serial serial ) : base( serial )
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