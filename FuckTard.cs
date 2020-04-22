//Created with Script Creator By Marak & Rockstar
//Oh, and Kevin Evans was here :P
using System;
using Server.Network;
using Server.Items;

namespace Server.Mobiles
{
[CorpseName("Corpse of a Fuck Tard")]
public class FuckTard:Dragon
{

[Constructable]
public FuckTard() : base()
{

Name = "Fuck Tard";
Hue = 1289;
SetStr (22500, 55975) ;
SetDex (22500, 55975) ;
SetInt (22500, 55975) ;

SetDamage (75, 225) ;

SetDamageType( ResistanceType.Physical,75) ;
SetDamageType( ResistanceType.Cold,75) ;
SetDamageType( ResistanceType.Fire,75) ;
SetDamageType( ResistanceType.Poison,75) ;


SetResistance( ResistanceType.Physical,75) ;
SetResistance( ResistanceType.Cold,75) ;
SetResistance( ResistanceType.Fire,75) ;
SetResistance( ResistanceType.Poison,75) ;

Fame = 22500;

Karma = 22500;

VirtualArmor = 75;

ControlSlots = 4;



}

          public override bool HasBreath{ get{ return true; } }
          public override bool Unprovokable{ get{ return true; } }
          public override bool AutoDispel{ get{ return true; } }
          public override bool Uncalmable{ get{ return true; } }
          public override bool BleedImmune{ get{ return true; } }
          public override bool CanRummageCorpses{ get{ return true; } }
          public override bool ReacquireOnMovement{ get{ return true; } }


		public FuckTard( Serial serial ) : base( serial )
		{
		}

	public override bool HandlesOnSpeech(Mobile from)
        {
            if (!from.Alive && from.InRange(this.Location, 12))//I put the commands like this so it doesn't spam players.
            {
                this.Say("Double click me");
                this.Say("out of war mode");
                this.Say("to be resurrected!");
            }
            return base.HandlesOnSpeech(from);
        }

        public override void OnDoubleClickDead(Mobile from)//Edit what you want the steed to say when resurrecting below:
        {
            this.Say("There you go, Enjoy life!");
            if (!from.Alive)
            {
                from.Resurrect();
            }
        }

        public override void OnSpeech(SpeechEventArgs e)
        {
            if (!e.Handled && e.Mobile == ControlMaster && e.Mobile.InRange(this.Location, 5))//Edit/add what ever color you want below:
            {
                if (e.Speech == "change random")
                {
                    this.Say("As you wish!");
                    this.Hue = Utility.Random(2, 1200);//Edit which colors you want him to cycle through here.
                }
                if (e.Speech == "change red")
                {
                    this.Say("As you wish!");
                    this.Hue = 33;
                }
                if (e.Speech == "change black")
                {
                    this.Say("As you wish!");
                    this.Hue = 1;
                }
                if (e.Speech == "change blue")
                {
                    this.Say("As you wish!");
                    this.Hue = 2;
                }
                if (e.Speech == "change pink")
                {
                    this.Say("As you wish!");
                    this.Hue = 26;
                }
                if (e.Speech == "change orange")
                {
                    this.Say("As you wish!");
                    this.Hue = 45;
                }
                if (e.Speech == "change yellow")
                {
                    this.Say("As you wish!");
                    this.Hue = 55;
                }
                if (e.Speech == "change purple")
                {
                    this.Say("As you wish!");
                    this.Hue = 117;
                }
                if (e.Speech == "change green")
                {
                    this.Say("As you wish!");
                    this.Hue = 66;
                }
                if (e.Speech == "change brown")
                {
                    this.Say("As you wish!");
                    this.Hue = 1044;
                }
                if (e.Speech == "change gray")
                {
                    this.Say("As you wish!");
                    this.Hue = 941;
                }
                if (e.Speech == "change normal")
                {
                    this.Say("As you wish!");
                    this.Hue = 1289;
                }
                base.OnSpeech(e);
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
