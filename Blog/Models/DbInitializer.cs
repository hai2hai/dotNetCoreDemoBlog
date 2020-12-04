using Blog.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models {
    public class DbInitializer {
        public static void Initialize(ApplicationDbContext context) {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Blogs.Any()) {
                return;   // DB has been seeded
            }

            var blogs = new Blogs[]
            {
            new Blogs{ Url = "This is a Blog link"},
            new Blogs{ Url = "This is a Blog link 2"},
            };
            foreach (Blogs s in blogs) {
                context.Blogs.Add(s);
            }
            context.SaveChanges();

            var posts = new Posts[]
            {
            new Posts{BlogId = 1, Content = "Demo blog content", Title = "Post Title 1" },
            new Posts{BlogId = 2, Content = "Demo blog content", Title = "Post Title 2" },
            };
            foreach (Posts c in posts) {
                context.Posts.Add(c);
            }
            context.SaveChanges();
        }
    }
}
