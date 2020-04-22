//Created with Script Creator By Marak & Rockstar
//Oh, and Kevin Evans was here :P
using System;
using Server.Network;
using Server.Items;

namespace Server.Mobiles
{
[CorpseName("Corpse of a Fuckwad")]
public class Fuckwad:VorpalBunny
{

[Constructable]
public Fuckwad() : base()
{

Name = "a Fuckwad";
Hue = 2828;
SetStr (9000) ;
SetDex (225) ;
SetInt (115) ;

SetDamage (125) ;

SetDamageType( ResistanceType.Physical,70) ;
SetDamageType( ResistanceType.Cold,60) ;
SetDamageType( ResistanceType.Fire,5) ;
SetDamageType( ResistanceType.Energy,65) ;
SetDamageType( ResistanceType.Poison,85) ;


SetResistance( ResistanceType.Physical,70) ;
SetResistance( ResistanceType.Cold,66) ;
SetResistance( ResistanceType.Fire,5) ;
SetResistance( ResistanceType.Energy,76) ;
SetResistance( ResistanceType.Poison,90) ;

			this.SetSkill(SkillName.Anatomy, 178.5);
            this.SetSkill(SkillName.MagicResist, 182.5);
            this.SetSkill(SkillName.Tactics, 165.3);
            this.SetSkill(SkillName.Magery, 250.0, 400.0);
            this.SetSkill(SkillName.Healing, 128.0, 225.0);

            this.AddItem(new Bow());
            this.AddItem(new Arrow(25));
            this.PackItem(new Spam());
            this.PackItem(new Apple(5));
            this.PackItem(new Bandage(25));

Fame = 5000;

Karma = 2500;

VirtualArmor = 65;




}

          public override bool Unprovokable{ get{ return true; } }
          public override bool AlwaysMurderer{ get{ return true; } }
          public override bool Uncalmable{ get{ return true; } }
          public override bool BleedImmune{ get{ return true; } }
          public override bool CanRummageCorpses{ get{ return true; } }
          public override bool ReacquireOnMovement{ get{ return true; } }


		public Fuckwad( Serial serial ) : base( serial )
		{
		}
		
		public override void OnDeath(Container c)
        {

            base.OnDeath(c);

            switch (Utility.Random(10)) //
            {
                case 0: AddItem( new LawnGnomeArms() ); break;
                case 1: AddItem( new LawnGnomeChest() ); break;
                case 2: AddItem( new LawnGnomeGloves() ); break;
                case 3: AddItem( new LawnGnomeHelm() ); break;
                case 4: AddItem( new LawnGnomeLegs() ); break;
                case 5: AddItem( new LawnGnomePoker() ); break;
                case 6: AddItem( new LawnGnomeSmasher() ); break;
                case 7: AddItem( new LawnGnomeSticker() ); break;
                case 8: AddItem( new LawnGnomeSwatter() ); break;
                case 9: AddItem( new BodyBag() ); break;

            }

            
        }

		public override void Serialize( GenericWriter writer )
		{
			base.Serialize( writer );
			writer.Write( (int) 0 ); // version
		}

		public override void Deserialize( GenericReader reader )
		{
			base.Deserialize( reader );

			int version = reader.ReadInt();
		}
	}
}
