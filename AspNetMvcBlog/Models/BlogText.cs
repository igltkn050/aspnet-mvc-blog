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
        public string[]? Comments { get; set; }
        public string? Tag { get; set; }
        public string? imageUrl { get; set; }

        //public Catagory _Catagory { get; set; }
    }
}
