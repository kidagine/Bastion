namespace Bastion.Core.Entity.Filtering
{
	public enum SpeakerType { Headphone, Earbud, Speaker };


	public class Filter
	{
		public int CurrentPage { get; set; }
		public int ItemsPerPage { get; set; }
		public SpeakerType SortType { get; set; }
	}
}
