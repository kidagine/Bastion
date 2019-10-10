using Bastion.Core.Entity;

namespace Bastion.Infrastructure.SQLData
{
    public class DatabaseInitializer
    {
        public static void Seed(BastionContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

			Speaker speakerHeadphone1 = context.Speakers.Add(new Speaker() { Name = "Crusher ANC Personalized Noise Canceling Wireless Headphones", Price = 299.99, Image = "https://i.imgur.com/pZaDNSe.jpg", Background = "https://i.imgur.com/q8ynDC1.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Red }).Entity;
			Speaker speakerHeadphone2 = context.Speakers.Add(new Speaker() { Name = "Crusher 360 Ultra-Realistic Audio", Price = 299.99, Image = "https://i.imgur.com/9yeVtwE.jpg", Background = "https://i.imgur.com/hVKzg4N.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Blue }).Entity;
			Speaker speakerHeadphone3 = context.Speakers.Add(new Speaker() { Name = "Venue Noise Canceling Wireless Headphone", Price = 179.99, Image = "https://i.imgur.com/pXcsT5g.jpg", Background = "https://i.imgur.com/axo4ofJ.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone4 = context.Speakers.Add(new Speaker() { Name = "Crusher Wireless Immersive Bass Headphone", Price = 169.99, Image = "https://i.imgur.com/cYWx42y.jpg", Background = "https://i.imgur.com/GTv1qYV.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone5 = context.Speakers.Add(new Speaker() { Name = "Hesh 3 Wireless Over-Ear Headphone", Price = 99.99, Image = "https://i.imgur.com/FeUgEWR.jpg", Background = "https://i.imgur.com/i6gHhCo.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone6 = context.Speakers.Add(new Speaker() { Name = "Icon Wireless On-Ear Headphone", Price = 49.99, Image = "https://i.imgur.com/xhszOxO.jpg", Background = "https://i.imgur.com/c5RxIFY.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone7 = context.Speakers.Add(new Speaker() { Name = "Riff Wireless On-Ear Headphone", Price = 49.99, Image = "https://i.imgur.com/CijkYIm.jpg", Background = "https://i.imgur.com/dgJ8GY5.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone8 = context.Speakers.Add(new Speaker() { Name = "Cassette Wireless On-Ear Headphones", Price = 39.99, Image = "https://i.imgur.com/UPmzzDY.jpg", Background = "https://i.imgur.com/zxO10Vv.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone9 = context.Speakers.Add(new Speaker() { Name = "Hesh 2 Over-Ear Wireless Headphone", Price = 99.99, Image = "https://i.imgur.com/a7NkzEJ.jpg", Background = "https://i.imgur.com/s7iS1Gh.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;
			Speaker speakerHeadphone10 = context.Speakers.Add(new Speaker() { Name = "Riff On-Ear Headphone", Price = 29.99, Image = "https://i.imgur.com/gT6hrdg.jpg", Background = "https://i.imgur.com/ig7WEOc.jpg", SpeakerType = SpeakerType.Headphone, Color = ColorType.Green }).Entity;

			Speaker speakerEarbuds1 = context.Speakers.Add(new Speaker() { Name = "Indy True Wireless Earbuds", Price = 79.99, Image = "https://i.imgur.com/I9N2yPs.jpg", Background = "https://i.imgur.com/8YwPDig.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Red }).Entity;
			Speaker speakerEarbuds2 = context.Speakers.Add(new Speaker() { Name = "Push True Wireless Earbuds with Socks", Price = 129.99, Image = "https://i.imgur.com/J3wHkey.jpg", Background = "https://i.imgur.com/8YwPDig.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Blue }).Entity;
			Speaker speakerEarbuds3 = context.Speakers.Add(new Speaker() { Name = "Sesh True Wireless Earbuds", Price = 59.99, Image = "https://i.imgur.com/vJb1aHV.jpg", Background = "https://i.imgur.com/tSTB9cK.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds4 = context.Speakers.Add(new Speaker() { Name = "Push True Wireless Earbuds", Price = 129.99, Image = "https://i.imgur.com/i2uRNc7.jpg", Background = "https://i.imgur.com/OtuMO19.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds5 = context.Speakers.Add(new Speaker() { Name = "Ink'd+™ Active", Price = 59.99, Image = "https://i.imgur.com/SO5ndPp.jpg", Background = "https://i.imgur.com/KttevBU.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds6 = context.Speakers.Add(new Speaker() { Name = "Ink’d+ Wireless Earbuds", Price = 49.99, Image = "https://i.imgur.com/HSBwC33.jpg", Background = "https://i.imgur.com/FtUCSik.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds7 = context.Speakers.Add(new Speaker() { Name = "Jib+ Active Wireless Earbuds", Price = 44.99, Image = "https://i.imgur.com/D7qcPuA.jpg", Background = "https://i.imgur.com/mFq689O.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds8 = context.Speakers.Add(new Speaker() { Name = "Jib+ Wireless Earbuds", Price = 34.99, Image = "https://i.imgur.com/tVhTFjJ.jpg", Background = "https://i.imgur.com/zp9a3Od.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds9 = context.Speakers.Add(new Speaker() { Name = "Method BT Sport Earbud", Price = 59.99, Image = "https://i.imgur.com/UGBMOkC.jpg", Background = "https://i.imgur.com/FXerLif.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;
			Speaker speakerEarbuds10 = context.Speakers.Add(new Speaker() { Name = "Method® Active Wireless Sport Earbuds", Price = 69.99, Image = "https://i.imgur.com/NqpmTuS.jpg", Background = "https://i.imgur.com/WMaeIR2.jpg", SpeakerType = SpeakerType.Earbud, Color = ColorType.Green }).Entity;

			Speaker speakerSpeaker1 = context.Speakers.Add(new Speaker() { Name = "Barricade XL Wireless Speaker", Price = 119.99, Image = "https://i.imgur.com/eLEemCQ.jpg", Background = "https://i.imgur.com/BsewBBv.jpg", SpeakerType = SpeakerType.Speaker, Color = ColorType.Red }).Entity;
			Speaker speakerSpeaker2 = context.Speakers.Add(new Speaker() { Name = "Barricade Mini Wireless Speaker", Price = 39.99, Image = "https://i.imgur.com/9cwZ8j3.jpg", Background = "https://i.imgur.com/r5iw2bG.jpg", SpeakerType = SpeakerType.Speaker, Color = ColorType.Blue }).Entity;

			context.SaveChanges();
        }
    }
}
