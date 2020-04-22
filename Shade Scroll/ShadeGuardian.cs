using System;
using Server.Items;

namespace Server.Mobiles
{
    [CorpseName("a dead Shade Guardian")]
    public class ShadeGuardian : BaseCreature
    {
        private DateTime m_Delay;
        [Constructable]
        public ShadeGuardian() : base( AIType.AI_Mage, FightMode.Closest, 10, 1, 0.05, 0.05 )
        {
            this.Name = "an ancient evil";
            this.Body = 1071;
            this.BaseSoundID = 362;
			Hue = Utility.RandomList( 44, 1102, 1109, 1111, 1141, 1148, 1153, 2213, 88 ); //several random hues when it spawns

            this.SetStr(302);
            this.SetDex(250);
            this.SetInt(180);

            this.SetHits(100000);
            this.SetStam(431);
            this.SetMana(180);

            this.SetDamage(33, 55);

            this.SetDamageType(ResistanceType.Physical, 25);
            this.SetDamageType(ResistanceType.Fire, 50);
            this.SetDamageType(ResistanceType.Energy, 25);

            this.SetResistance(ResistanceType.Physical, 85, 89);
            this.SetResistance(ResistanceType.Fire, 85, 89);
            this.SetResistance(ResistanceType.Cold, 65, 69);
            this.SetResistance(ResistanceType.Poison, 80, 81);
            this.SetResistance(ResistanceType.Energy, 85, 87);

            this.SetSkill(SkillName.Anatomy, 100.0);
            this.SetSkill(SkillName.MagicResist, 150.0, 155.0);
            this.SetSkill(SkillName.Tactics, 120.7, 125.0);
            this.SetSkill(SkillName.Wrestling, 115.0, 117.7);

            this.Fame = 15000;
            this.Karma = -15000;

            this.VirtualArmor = 75;
 

            this.Tamable = false;
			PackItem( Loot.RandomArmor() );
                        if ( 0.02 > Utility.RandomDouble() )
													PackItem( new ShadeArms() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.01 > Utility.RandomDouble() )
													PackItem( new ShadeChest() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.03 > Utility.RandomDouble() )
													PackItem( new ShadeGloves() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.04 > Utility.RandomDouble() )
													PackItem( new ShadeGorget() );

                        PackItem( Loot.RandomArmor() );
                        if ( 0.05 > Utility.RandomDouble() )
													PackItem( new ShadeHelm() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.06 > Utility.RandomDouble() )
													PackItem( new ShadeLegs() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.07 > Utility.RandomDouble() )
													PackItem( new DonationCoin(5) );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.08 > Utility.RandomDouble() )
													PackItem( new ParagonPetDeed() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.09 > Utility.RandomDouble() )
													PackItem( new SwiftBoots() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.010 > Utility.RandomDouble() )
													PackItem( new AutoResStone() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.011 > Utility.RandomDouble() )
													PackItem( new TravelAtlas() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.012 > Utility.RandomDouble() )
													PackItem( new DonationShroud() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.013 > Utility.RandomDouble() )
													PackItem( new CrafterRing() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.014 > Utility.RandomDouble() )
													PackItem( new DontaionFollowerScroll5() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.015 > Utility.RandomDouble() )
													PackItem( new Spam() );
				
												PackItem( Loot.RandomArmor() );
                        if ( 0.016> Utility.RandomDouble() )
													PackItem( new MasterScroll() );  //this is the all 130 scroll
        }

        public ShadeGuardian(Serial serial)
            : base(serial)
        {
        }

        public override bool AlwaysMurderer
        {
            get
            {
                return true;
            }
        }
        
        public override bool Unprovokable
        {
            get
            {
                return false;
            }
        }
        public override bool BardImmune
        {
            get
            {
                return false;
            }
        }
        
        public override bool HasBreath
        {
            get
            {
                return true;
            }
        }// fire breath enabled
        public override bool AutoDispel
        {
            get
            {
                return !this.Controlled;
            }
        }
        public override int Meat
        {
            get
            {
                return 25;
            }
        }
        public override int Hides
        {
            get
            {
                return 45;
            }
        }
        public override HideType HideType
        {
            get
            {
                return HideType.Barbed;
            }
        }
        public override int Scales
        {
            get
            {
                return 7;
            }
        }
        
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.Gems, 1);
        }

        public override WeaponAbility GetWeaponAbility()
        {
            if (50.0 >= Utility.RandomDouble())
                return WeaponAbility.Bladeweave;
            else
                return WeaponAbility.TalonStrike;
        }

        public override void OnActionCombat()
        {
            if (DateTime.UtcNow > this.m_Delay)
            {
                switch (Utility.Random(2))
                {
                    case 0:
                        Ability.FlameCross(this);
                        this.m_Delay = DateTime.UtcNow + TimeSpan.FromSeconds(Utility.RandomMinMax(25, 35));
                        break;
                    case 1:
                        Ability.CrimsonMeteor(this, 35);
                        this.m_Delay = DateTime.UtcNow + TimeSpan.FromSeconds(Utility.RandomMinMax(20, 45));
                        break;
                }
            }

            base.OnActionCombat();
        }

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);
            writer.Write((int)1);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);
            int version = reader.ReadInt();
        }
    }
}