using OnlineEdu.DataAccess.Abstract;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.Business.Concrete
{
    public class BlogManager : GenericManager<Blog>, IBlogService
    {
        private readonly IBlogRepository _blogRepository;
        public BlogManager(IRepository<Blog> _repository, IBlogRepository blogRepository) : base(_repository)
        {
            _blogRepository=blogRepository;
        }

        public List<Blog> TGetBlogWithCategories()
        {
            return _blogRepository.GetBlogWithCategories();   
        }

        public List<Blog> TGetBlogWithCategoriesByWriterId(int id)
        {
            return _blogRepository.GetBlogWithCategoriesByWriterId(id);
        }

        public List<Blog> TGetLast4BlogsWithCategories()
        {
            return _blogRepository.GetLast4BlogsWithCategories();
        }
    }
}
