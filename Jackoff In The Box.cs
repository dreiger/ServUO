using System;
using Server.Engines.CannedEvil;
using Server.Items;
using Server.Spells.Fifth;
using Server.Spells.Seventh;

namespace Server.Mobiles
{
    public class JackoffInTheBox : BaseCreature
    {
        [Constructable]
        public JackoffInTheBox() : base( AIType.AI_Archer, FightMode.Closest, 10, 1, 0.2, 0.4 )
        {
            this.Name = "Jackoff In The Box";
            this.Title = "the assclown";
            this.Body = 1428;
            

            this.SetStr(283, 725);
            this.SetDex(272, 750);
            this.SetInt(505, 750);

            this.SetHits(152000);
            this.SetStam(102, 300);
            this.SetMana(505, 750);

            this.SetDamage(29, 138);

            this.SetDamageType(ResistanceType.Physical, 100);

            this.SetResistance(ResistanceType.Physical, 65, 75);
            this.SetResistance(ResistanceType.Fire, 70, 80);
            this.SetResistance(ResistanceType.Cold, 65, 80);
            this.SetResistance(ResistanceType.Poison, 70, 75);
            this.SetResistance(ResistanceType.Energy, 70, 80);

            this.SetSkill(SkillName.MagicResist, 100.0);
            this.SetSkill(SkillName.Tactics, 118.3, 120.2);
            this.SetSkill(SkillName.Wrestling, 118.4, 122.7);

            this.Fame = 22500;
            this.Karma = -22500;

            this.VirtualArmor = 80;

         //   this.AddItem(new FancyShirt(Utility.RandomGreenHue()));
         //   this.AddItem(new LongPants(Utility.RandomYellowHue()));
         //   this.AddItem(new JesterHat(Utility.RandomPinkHue()));
         //   this.AddItem(new Cloak(Utility.RandomPinkHue()));
         //   this.AddItem(new Sandals());

        //    this.HairItemID = 0x203B; // Short Hair
         //   this.HairHue = 0x94;

            this.m_SpecialSlayerMechanics = true;
        }

        public JackoffInTheBox(Serial serial)
            : base(serial)
        {
        }

    //    public override ChampionSkullType SkullType
    //    {
    //        get
    //        {
    //            return ChampionSkullType.Greed;
    //        }
    //    }
    /*    public override Type[] UniqueList
        {
            get
            {
                return new Type[] { typeof(FangOfRactus) };
            }
        }
        public override Type[] SharedList
        {
            get
            {
                return new Type[]
                {
                    typeof(EmbroideredOakLeafCloak),
                    typeof(DjinnisRing),
                    typeof(DetectiveBoots),
                    typeof(GauntletsOfAnger)
                };
            }
        } */
    //    public override Type[] DecoshitiveList
     //   {
     //       get
    //        {
     //           return new Type[] { typeof(SwampTile), typeof(MonsterStatuette) };
     //       }
     //   }
    /*    public override MonsterStatuetteType[] StatueTypes
        {
            get
            {
                return new MonsterStatuetteType[] { MonsterStatuetteType.Slime };
            }
        } */
        public override bool AlwaysMurderer
        {
            get
            {
                return true;
            }
        }
        public override bool AutoDispel
        {
            get
            {
                return true;
            }
        }
        public override double AutoDispelChance
        {
            get
            {
                return 1.0;
            }
        }
        public override bool BardImmune
        {
            get
            {
                return !Core.SE;
            }
        }
		public override bool AllureImmune
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
                return Core.SE;
            }
        }
        public override bool Uncalmable
        {
            get
            {
                return Core.SE;
            }
        }
        public override Poison PoisonImmune
        {
            get
            {
                return Poison.Deadly;
            }
        }
        public override bool ShowFameTitle
        {
            get
            {
                return false;
            }
        }
        public override bool ClickTitle
        {
            get
            {
                return false;
            }
        }
        public override void GenerateLoot()
        {
            this.AddLoot(LootPack.UltraRich, 3);
        }

        public void Polymorph(Mobile m)
        {
            if (!m.CanBeginAction(typeof(PolymorphSpell)) || !m.CanBeginAction(typeof(IncognitoSpell)) || m.IsBodyMod)
                return;

            IMount mount = m.Mount;

            if (mount != null)
                mount.Rider = null;

			if (m.Flying)
                m.ToggleFlying();

            if (m.Mounted)
                return;

            if (m.BeginAction(typeof(PolymorphSpell)))
            {
                m.BodyMod = 1423;
                m.HueMod = 0;
                if (m == this) { 
                    m_SlayerVulnerabilities.Add("Vermin");
                    m_SlayerVulnerabilities.Add("Repond");
                }
   
                new ExpirePolymorphTimer(m).Start();
            }
        }

    /*    public void SpawnShit(Mobile target)
        {
            Map map = this.Map;

            if (map == null)
                return;

            int shit = 0;

            foreach (Mobile m in this.GetMobilesInRange(10))
            {
                if (m is VorpalBunny || m is AgapiteColossus || m is ValoriteColossus)
                    ++shit;
            }

            if (shit < 16)
            {
                this.PlaySound(0x3D);

                int newshit = Utility.RandomMinMax(3, 6);

                for (int i = 0; i < newshit; ++i)
                {
                    BaseCreature shit;

                    switch ( Utility.Random(5) )
                    {
                        default:
                        case 0:
                        case 1:
                            shit = new VorpalBunny();
                            break;
                        case 2:
                        case 3:
                            shit = new AgapiteColossus();
                            break;
                        case 4:
                            shit = new ValoriteColossus();
                            break;
                    }

                    shit.Team = this.Team;

                    bool validLocation = false;
                    Point3D loc = this.Location;

                    for (int j = 0; !validLocation && j < 10; ++j)
                    {
                        int x = this.X + Utility.Random(3) - 1;
                        int y = this.Y + Utility.Random(3) - 1;
                        int z = map.GetAverageZ(x, y);

                        if (validLocation = map.CanFit(x, y, this.Z, 16, false, false))
                            loc = new Point3D(x, y, this.Z);
                        else if (validLocation = map.CanFit(x, y, z, 16, false, false))
                            loc = new Point3D(x, y, z);
                    }

                    shit.MoveToWorld(loc, map);
                    shit.Combatant = target;
                }
            }
        } */

        public void DoSpecialAbility(Mobile target)
        {
            if (target == null || target.Deleted) //sanity
                return;
            if (0.6 >= Utility.RandomDouble()) // 60% chance to polymorph attacker into a shitman
                this.Polymorph(target);

           // if (0.1 >= Utility.RandomDouble()) // 10% chance to more shitmen
           //     this.Spawnshitmen(target);

            if (0.05 >= Utility.RandomDouble() && !this.IsBodyMod) // 5% chance to polymorph into a shitman
                this.Polymorph(this);
        }

        public override void OnGotMeleeAttack(Mobile attacker)
        {
            base.OnGotMeleeAttack(attacker);

            this.DoSpecialAbility(attacker);
        }

        public override void OnGaveMeleeAttack(Mobile defender)
        {
            base.OnGaveMeleeAttack(defender);

            this.DoSpecialAbility(defender);
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

            m_SlayerVulnerabilities.Clear();
        }

        private class ExpirePolymorphTimer : Timer
        {
            private Mobile m_Owner;
            public ExpirePolymorphTimer(Mobile owner)
                : base(TimeSpan.FromMinutes(3.0)) //3.0
            {
                this.m_Owner = owner;

                this.Priority = TimerPriority.OneSecond;
            }

            protected override void OnTick()
            {
                if (!this.m_Owner.CanBeginAction(typeof(PolymorphSpell)))
                {
                    this.m_Owner.BodyMod = 0;
                    this.m_Owner.HueMod = -1;
                    this.m_Owner.EndAction(typeof(PolymorphSpell));
                    if (this.m_Owner.SlayerVulnerabilities != null)
                    {
                        this.m_Owner.SlayerVulnerabilities.Remove("Vermin");
                        this.m_Owner.SlayerVulnerabilities.Remove("Repond");    
                    }
                }
            }
        }
    }
}