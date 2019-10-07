using Bastion.Core.Entity;

namespace Bastion.Infrastructure.SQLData
{
    public class DatabaseInitializer
    {
        public static void Seed(BastionContext context)
        {
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();
            Speaker speaker1 = context.Speakers.Add(new Speaker() { Name = "Crusher ANC", Price = 299.99, Color = ColorType.Red}).Entity;
            Speaker speaker2 = context.Speakers.Add(new Speaker() { Name = "Crusher 360 Ultra", Price = 299.99, Color = ColorType.Blue }).Entity;
            Speaker speaker3 = context.Speakers.Add(new Speaker() { Name = "Indy True Wireless Earbuds", Price = 29.99, Color = ColorType.Green }).Entity;

            context.SaveChanges();
        }
    }
}
