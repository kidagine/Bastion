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
				Speaker speaker1 = context.Speakers.Add(new Speaker() { Name = "Crusher ANC", Price = 299.99, Color = ColorType.Red }).Entity;
				Speaker speaker2 = context.Speakers.Add(new Speaker() { Name = "Crusher 360 Ultra", Price = 299.99, Color = ColorType.Blue }).Entity;
				Speaker speaker3 = context.Speakers.Add(new Speaker() { Name = "Indy True Wireless Earbuds", Price = 29.99, Color = ColorType.Green }).Entity;
				Speaker speaker4 = context.Speakers.Add(new Speaker() { Name = "Push True Wireless Earbuds with Socks", Price = 129.99, Color = ColorType.Green }).Entity;
			}

			context.SaveChanges();
        }
    }
}
