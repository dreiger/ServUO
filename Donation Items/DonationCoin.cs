using System;
using Server.Mobiles;
using Server.Network;
using Server.Items;

namespace Server.Items
{
    public class DonationCoin : Item
    {
        [Constructable]
        public DonationCoin()
            : this(1)
        {
        }

        [Constructable]
        public DonationCoin(int amount)
            : base(3699)
        {
            this.Weight = 0.00001;
            this.Stackable = true;
            this.Amount = amount;
            this.Name = "Donation Coin";
            this.Hue = 2487;
        }

        public DonationCoin(Serial serial)
            : base(serial)
        {
        }

     

        public override void Serialize(GenericWriter writer)
        {
            base.Serialize(writer);

            writer.Write((int)0);
        }

        public override void Deserialize(GenericReader reader)
        {
            base.Deserialize(reader);

            int version = reader.ReadInt();
        }

        

       

        
    }
}