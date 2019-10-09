using Bastion.Core.Entity.Filtering;

namespace Bastion.Core.Entity
{
    public enum ColorType { Red, Green, Blue, };
	public enum SpeakerType { All, Headphone, Earbud, Speaker };

	public class Speaker
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
		public string Image { get; set; }
		public ColorType Color { get; set; }
		public SpeakerType SpeakerType { get; set; }
	}
}
