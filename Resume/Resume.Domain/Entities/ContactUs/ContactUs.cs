
namespace Resume.Domain.Entities.ContactUs
{
	public class ContactUs
	{
        public int Id { get; set; }
		public string FullName { get; set; }
		public string Mobile { get; set; }
		public string Massage { get; set; }
		public DateTime CreateDate { get; set; } = DateTime.Now;
        public bool IsSeeenByAdnmin { get; set; }
    }
}
