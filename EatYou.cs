// fuck off
using System;
using Server.Network;
using Server.Items;

namespace Server.Mobiles
{
[CorpseName("Corpse of Ima Eat You")]
public class EatYou:ShadowWyrm
{

[Constructable]
public EatYou() : base()
{

Name = "Ima Eat You";
Hue = 2650;
SetStr (55000) ;
SetDex (1525) ;
SetInt (3563) ;

SetDamage (2500) ;

SetDamageType( ResistanceType.Physical,75) ;
SetDamageType( ResistanceType.Cold,75) ;
SetDamageType( ResistanceType.Fire,75) ;
SetDamageType( ResistanceType.Energy,7) ;
SetDamageType( ResistanceType.Poison,75) ;


SetResistance( ResistanceType.Physical,125) ;
SetResistance( ResistanceType.Cold,125) ;
SetResistance( ResistanceType.Fire,125) ;
SetResistance( ResistanceType.Energy,5) ;
SetResistance( ResistanceType.Poison,125) ;

Fame = 9000;

Karma = 9000;

VirtualArmor = 95;

ControlSlots = 5;



}

          public override bool HasBreath{ get{ return true; } }
          public override bool Unprovokable{ get{ return true; } }
          public override bool AlwaysMurderer{ get{ return true; } }
          public override bool AutoDispel{ get{ return true; } }
          public override bool BleedImmune{ get{ return true; } }
          public override bool CanRummageCorpses{ get{ return true; } }
          public override bool ReacquireOnMovement{ get{ return true; } }
          public override bool SubdueBeforeTame{ get{ return true; } }


		public EatYou( Serial serial ) : base( serial )
		{
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
