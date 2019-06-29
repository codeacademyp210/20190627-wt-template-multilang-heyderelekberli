namespace WeekendTaskLanguage.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WeekendTaskLanguage.DAL.TempContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeekendTaskLanguage.DAL.TempContext context)
        {
            context.Abilities.AddOrUpdate(a => a.ID,
                new Models.Ability { ID = 1, Number = "01.", Title = "Our Values", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
                new Models.Ability { ID = 2, Number = "01.", Title = "Our Mission", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
                new Models.Ability { ID = 3, Number = "01.", Title = "Our Philosophy", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." }
                );
            context.AboutSpecs.AddOrUpdate(a => a.ID,
              new Models.AboutSpec { ID = 1, Icon = "phonelink", Title = "Web & Mobile Specialties", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis consect." },
              new Models.AboutSpec { ID = 2, Icon = "extension", Title = "Intuitive Thinkers", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis." }
              );
            context.SecondBlogs.AddOrUpdate(a => a.ID,
              new Models.SecondBlog { ID = 1, Image = "img_6.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
              new Models.SecondBlog { ID = 2, Image = "img_2.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
              new Models.SecondBlog { ID = 3, Image = "img_3.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
              new Models.SecondBlog { ID = 4, Image = "img_2.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
              new Models.SecondBlog { ID = 5, Image = "img_5.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." },
              new Models.SecondBlog { ID = 6, Image = "img_1.jpg", Title = "Warehousing Your Packages", Name = "Theresa Winston ", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius." }
              );
            context.Blogs.AddOrUpdate(a => a.ID,
            new Models.Blog { ID = 1, Image = "img_1.jpg", Title1 = "Create Beautiful Website In Less ", Title2 = "Than An Hour", Name = "Ham Brook", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius.", Reading = "Continue Reading..." },
            new Models.Blog { ID = 2, Image = "img_2.jpg", Title1 = "Create Beautiful Website In Less ", Title2 = "Than An Hour", Name = "James Phelps", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius.", Reading = "Continue Reading..." },
            new Models.Blog { ID = 3, Image = "img_1.jpg", Title1 = "Create Beautiful Website In Less ", Title2 = "Than An Hour", Name = "James Phelps", DataTime = "Jan 18, 2019", News = "News", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Natus eligendi nobis ea maiores sapiente veritatis reprehenderit suscipit quaerat rerum voluptatibus a eius.", Reading = "Continue Reading..." }
              );
            context.Comments.AddOrUpdate(a => a.ID,
            new Models.Comment { ID = 1, Title = "Lorem ipsum dolor sit amet" },
            new Models.Comment { ID = 2, Title = "Quaerat rerum voluptatibus veritatis" },
            new Models.Comment { ID = 3, Title = "Maiores sapiente veritatis reprehenderit" },
            new Models.Comment { ID = 4, Title = "Natus eligendi nobis" }
             );
            context.HomeImages.AddOrUpdate(a => a.ID,
            new Models.HomeImage { ID = 1, Image = "img_1.jpg", Title = "Project Name 1", Text = "Web Application" },
            new Models.HomeImage { ID = 2, Image = "img_2.jpg", Title = "Project Name 2", Text = "Branding" },
            new Models.HomeImage { ID = 3, Image = "img_3.jpg", Title = "Project Name 3", Text = "Website" }
            );
            context.Portfolios.AddOrUpdate(a => a.ID,
            new Models.Portfolio { ID = 1, Image = "img_1.jpg", Title = "Project Name 1", Text = "Web Application" },
            new Models.Portfolio { ID = 2, Image = "img_2.jpg", Title = "Project Name 2", Text = "Branding" },
            new Models.Portfolio { ID = 3, Image = "img_3.jpg", Title = "Project Name 3", Text = "Website" },
            new Models.Portfolio { ID = 4, Image = "img_4.jpg", Title = "Project Name 4", Text = "Web Application" },
            new Models.Portfolio { ID = 5, Image = "img_5.jpg", Title = "Project Name 5", Text = "Branding" },
            new Models.Portfolio { ID = 6, Image = "img_6.jpg", Title = "Project Name 6", Text = "Website" },
            new Models.Portfolio { ID = 7, Image = "img_1.jpg", Title = "Project Name 1", Text = "Web Application" },
            new Models.Portfolio { ID = 8, Image = "img_2.jpg", Title = "Project Name 2", Text = "Branding" },
            new Models.Portfolio { ID = 9, Image = "img_3.jpg", Title = "Project Name 3", Text = "Website" },
            new Models.Portfolio { ID = 10, Image = "img_4.jpg", Title = "Project Name 4", Text = "Web Application" },
            new Models.Portfolio { ID = 11, Image = "img_5.jpg", Title = "Project Name 5", Text = "Branding" },
            new Models.Portfolio { ID = 12, Image = "img_6.jpg", Title = "Project Name 6", Text = "Website" }
            );
            context.Positions.AddOrUpdate(a => a.ID,
            new Models.Position { ID = 1, Number ="01.", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
            new Models.Position { ID = 2, Number ="02.", Title = "Web Apps", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
            new Models.Position { ID = 3, Number ="03.", Title = "WordPress", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
            new Models.Position { ID = 4, Number ="04.", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
            new Models.Position { ID = 5, Number ="05.", Title = "Web Apps", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." },
            new Models.Position { ID = 6, Number ="06.", Title = "WordPress", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Et praesentium eos nulla qui commodi consectetur beatae fugiat. Veniam iste rerum perferendis." }
            );
            context.Posts.AddOrUpdate(a => a.ID,
            new Models.Post { ID = 1, Title = "Lorem ipsum dolor sit amet" },
            new Models.Post { ID = 2, Title = "Quaerat rerum voluptatibus veritatis" },
            new Models.Post { ID = 3, Title = "Maiores sapiente veritatis reprehenderit" },
            new Models.Post { ID = 4, Title = "Natus eligendi nobis" }
            );
            context.Services.AddOrUpdate(a => a.ID,
            new Models.Service { ID = 1, Icon = "laptop2", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." },
            new Models.Service { ID = 2, Icon = "shopping_cart", Title = "eCommerce", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." },
            new Models.Service { ID = 3, Icon = "question_answer", Title = "Web Applications", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." },
            new Models.Service { ID = 4, Icon = "format_paint", Title = "Branding", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." },
            new Models.Service { ID = 5, Icon = "extension", Title = "Copy Writing", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." },
            new Models.Service { ID = 6, Icon = "phonelink", Title = "Mobile Applications", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Perferendis quis molestiae vitae eligendi at." }
            );
            context.Specialities.AddOrUpdate(a => a.ID,
            new Models.Speciality { ID = 1, Icon = "phonelink", Title = "Web Design", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt."},
            new Models.Speciality { ID = 2, Icon = "extension", Title = "Branding &amp; Identity", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt."},
            new Models.Speciality { ID = 3, Icon = "format_paint", Title = "Art Direction", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt."},
            new Models.Speciality { ID = 4, Icon = "question_answer", Title = "Copywriting", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Cumque ab nihil quam nesciunt."}
            );
            context.Teams.AddOrUpdate(a => a.ID,
            new Models.Team { ID = 1, Image = "person_2.jpg", Name = "Christine Rooster", Position = "CO-FOUNDER, PRESIDENT", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." },
            new Models.Team { ID = 2, Image = "person_3.jpg", Name = "Brandon Sharp", Position = "CO-FOUNDER, COO", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." },
            new Models.Team { ID = 3, Image = "person_4.jpg", Name = "Connor Hodson", Position = "MARKETING", Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Nisi at consequatur unde molestiae quidem provident voluptatum deleniti quo iste error eos est praesentium distinctio cupiditate tempore suscipit inventore deserunt tenetur." }
            );
            context.Testimonials.AddOrUpdate(a => a.ID,
            new Models.Testimonial { ID = 1, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.", Image = "person_3.jpg", Name = "John Smith" },
            new Models.Testimonial { ID = 2, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.", Image = "person_2.jpg", Name = "Christine Aguilar" },
            new Models.Testimonial { ID = 3, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.", Image = "person_4.jpg", Name = "Robert Spears" },
            new Models.Testimonial { ID = 4, Text = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Consectetur unde reprehenderit aperiam quaerat fugiat repudiandae explicabo animi minima fuga beatae illum eligendi incidunt consequatur. Amet dolores excepturi earum unde iusto.", Image = "person_5.jpg", Name = "Bruce Rogers" }
            );

            context.Settings.AddOrUpdate(a => a.ID,
            new Models.Setting
            {
                ID = 1,
                Phone = "+1 292 3293 4238",
                Email = "info@yourdomain.com",
                Feature = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolores, itaque neque, delectus odio iure explicabo.",
                Hire = "Let's Get Started",
                AbautUsText = "Lorem ipsum dolor sit amet consectetur adipisicing elit. Neque facere laudantium magnam voluptatum autem. Amet aliquid nesciunt veritatis aliquam.",
                AboutUs = "About Us",
                Services = "Services",
                Testimonials = "Testimonials",
                ContactUS = "Contact US",
                FacebookIcon = "facebook",
                TwitterIcon = "twitter",
                InstagramIcon = "instagram",
                LinkedinIcon = "linkedin",
                ContactAddress = "203 Fake St. Mountain View, San Francisco, California, USA",
                ContactPhone = "+1 232 3235 324",
                ContactEmail = "youremail@domain.com",
                Info = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Ipsa ad iure porro mollitia architecto hic consequuntur. Distinctio nisi perferendis dolore, ipsa consectetur? Fugiat quaerat eos qui, libero neque sed nulla."
            }
                );
        }
    }
}
