using System.Security.Policy;

namespace AspNetMvcBlog.Models
{
    public class BlogText
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Content { get; set; }
        public string? Author { get; set; }
        public int CatagoryId { get; set; }
        public List<Comments> _CommentsList { get; set; }
		public string? Tag { get; set; }
        public string? imageUrl { get; set; }
        public DateTime? CreatedDate { get; set;}
        public string? Proverb { get; set; }
        public string? shortTitle { get; set; }
        public string? shortContent { get; set; }

        //public Catagory _Catagory { get; set; }
    }
}
