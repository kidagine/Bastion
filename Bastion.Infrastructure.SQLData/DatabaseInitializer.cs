using Bastion.Core.Entity;

namespace Bastion.Infrastructure.SQLData
{
    public class DatabaseInitializer
    {
        public static void Seed(BastionContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
			for (int i = 0; i < 10; i++)
			{
				Speaker speakerHeadphone1 = context.Speakers.Add(new Speaker() { Name = "Crusher ANC Personalized Noise Canceling Wireless Headphones", Price = 299.99, Image = "https://i.imgur.com/pZaDNSe.jpg", Color = ColorType.Red }).Entity;
				Speaker speakerHeadphone2 = context.Speakers.Add(new Speaker() { Name = "Crusher 360 Ultra-Realistic Audio", Price = 299.99, Image = "https://i.imgur.com/9yeVtwE.jpg", Color = ColorType.Blue }).Entity;
				Speaker speakerHeadphone3 = context.Speakers.Add(new Speaker() { Name = "Venue Noise Canceling Wireless Headphone", Price = 179.99, Image = "https://i.imgur.com/pXcsT5g.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone4 = context.Speakers.Add(new Speaker() { Name = "Crusher Wireless Immersive Bass Headphone", Price = 169.99, Image = "https://i.imgur.com/cYWx42y.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone5 = context.Speakers.Add(new Speaker() { Name = "Hesh 3 Wireless Over-Ear Headphone", Price = 99.99, Image = "https://i.imgur.com/FeUgEWR.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone6 = context.Speakers.Add(new Speaker() { Name = "Icon Wireless On-Ear Headphone", Price = 49.99, Image = "https://i.imgur.com/xhszOxO.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone7 = context.Speakers.Add(new Speaker() { Name = "Riff Wireless On-Ear Headphone", Price = 49.99, Image = "https://i.imgur.com/CijkYIm.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone8 = context.Speakers.Add(new Speaker() { Name = "Cassette Wireless On-Ear Headphones", Price = 39.99, Image = "https://i.imgur.com/UPmzzDY.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone9 = context.Speakers.Add(new Speaker() { Name = "Hesh 2 Over-Ear Wireless Headphone", Price = 99.99, Image = "https://i.imgur.com/a7NkzEJ.jpg", Color = ColorType.Green }).Entity;
				Speaker speakerHeadphone10 = context.Speakers.Add(new Speaker() { Name = "Riff On-Ear Headphone", Price = 29.99, Image = "https://i.imgur.com/gT6hrdg.jpg", Color = ColorType.Green }).Entity;

			}

			context.SaveChanges();
        }
    }
}
