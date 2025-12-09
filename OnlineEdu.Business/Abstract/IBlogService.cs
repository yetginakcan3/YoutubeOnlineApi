using OnlineEdu.Business.Abstract;
using OnlineEdu.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineEdu.DataAccess.Abstract
{
    public interface IBlogService:IGenericService<Blog>
    {
       List<Blog> TGetBlogWithCategories();
       List<Blog> TGetLast4BlogsWithCategories();

        List<Blog> TGetBlogWithCategoriesByWriterId(int id);

    }
}
