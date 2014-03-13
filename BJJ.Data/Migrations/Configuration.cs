namespace BJJ.Data.Migrations
{
    using BJJ.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BJJ.Data.BJJDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BJJ.Data.BJJDbContext context)
        {
            context.Configuration.LazyLoadingEnabled = true;

        //    context.States.AddOrUpdate(s => s.StateName,
        //        new State { StateName = "Alabama", Abbreviation = "AL" },
        //        new State { StateName = "Alaska", Abbreviation = "AK" },
        //        new State { StateName = "Arizona", Abbreviation = "AZ" },
        //        new State { StateName = "Arkansas", Abbreviation = "AR" },
        //        new State { StateName = "California", Abbreviation = "CA" },
        //        new State { StateName = "Colorado", Abbreviation = "CO" },
        //        new State { StateName = "Connecticut", Abbreviation = "CT" },
        //        new State { StateName = "Delaware", Abbreviation = "DE" },
        //        new State { StateName = "District of Columbia", Abbreviation = "DC" },
        //        new State { StateName = "Florida", Abbreviation = "FL" },
        //        new State { StateName = "Georgia", Abbreviation = "GA" },
        //        new State { StateName = "Hawaii", Abbreviation = "HI" },
        //        new State { StateName = "Idaho", Abbreviation = "ID" },
        //        new State { StateName = "Illinois", Abbreviation = "IL" },
        //        new State { StateName = "Indiana", Abbreviation = "IN" },
        //        new State { StateName = "Iowa", Abbreviation = "IA" },
        //        new State { StateName = "Kansas", Abbreviation = "KS" },
        //        new State { StateName = "Kentucky", Abbreviation = "KY" },
        //        new State { StateName = "Louisiana", Abbreviation = "LA" },
        //        new State { StateName = "Maine", Abbreviation = "ME" },
        //        new State { StateName = "Maryland", Abbreviation = "MD" },
        //        new State { StateName = "Massachusetts", Abbreviation = "MA" },
        //        new State { StateName = "Michigan", Abbreviation = "MI" },
        //        new State { StateName = "Minnesota", Abbreviation = "MN" },
        //        new State { StateName = "Mississippi", Abbreviation = "MS" },
        //        new State { StateName = "Missouri", Abbreviation = "MO" },
        //        new State { StateName = "Montana", Abbreviation = "MT" },
        //        new State { StateName = "Nebraska", Abbreviation = "NE" },
        //        new State { StateName = "Nevada", Abbreviation = "NV" },
        //        new State { StateName = "New Hampshire", Abbreviation = "NH" },
        //        new State { StateName = "New Jersey", Abbreviation = "NJ" },
        //        new State { StateName = "New Mexico", Abbreviation = "NM" },
        //        new State { StateName = "New York", Abbreviation = "NY" },
        //        new State { StateName = "North Carolina", Abbreviation = "NC" },
        //        new State { StateName = "North Dakota", Abbreviation = "ND" },
        //        new State { StateName = "Ohio", Abbreviation = "OH" },
        //        new State { StateName = "Oklahoma", Abbreviation = "OK" },
        //        new State { StateName = "Oregon", Abbreviation = "OR" },
        //        new State { StateName = "Pennsylvania", Abbreviation = "PA" },
        //        new State { StateName = "Rhode Island", Abbreviation = "RI" },
        //        new State { StateName = "South Carolina", Abbreviation = "SC" },
        //        new State { StateName = "South Dakota", Abbreviation = "SD" },
        //        new State { StateName = "Tennessee", Abbreviation = "TN" },
        //        new State { StateName = "Texas", Abbreviation = "TX" },
        //        new State { StateName = "Utah", Abbreviation = "UT" },
        //        new State { StateName = "Vermont", Abbreviation = "VT" },
        //        new State { StateName = "Virginia", Abbreviation = "VA" },
        //        new State { StateName = "Washington", Abbreviation = "WA" },
        //        new State { StateName = "West Virginia", Abbreviation = "WV" },
        //        new State { StateName = "Wisconsin", Abbreviation = "WI" },
        //        new State { StateName = "Wyoming", Abbreviation = "WY" }
        //        );

        //    context.SaveChanges();


            //var RoleStore = new RoleStore<IdentityRole>(context);
            //var RoleManager = new RoleManager<IdentityRole>(RoleStore);

            //if(!RoleManager.RoleExists("Administrator"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Administrator";
            //    RoleManager.Create(role);

            //}

            //if (!RoleManager.RoleExists("Moderator"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "Moderator";
            //    RoleManager.Create(role);

            //}

            //if (!RoleManager.RoleExists("User"))
            //{
            //    var role = new IdentityRole();
            //    role.Name = "User";
            //    RoleManager.Create(role);

            //}

            //context.SaveChanges();

            //var UserStore = new UserStore<User>(context);
            //var UserManager = new UserManager<User>(UserStore);

            //if (!context.Users.Any(u => u.UserName == "Bob"))
            //{
            //    var user = new User { UserName = "Bob", FirstName = "Bob", LastName = "Jones", Email = "bob@gmail.com" };
            //    UserManager.Create(user, "ABCD1234");
            //    UserManager.AddToRole(user.Id, "Moderator");
            //}

            //if (!context.Users.Any(u => u.UserName == "Steve"))
            //{
            //    var user = new User { UserName = "Steve", FirstName = "Steve", LastName = "Miller", Email = "steve@gmail.com" };
            //    UserManager.Create(user, "ABCD1234");
            //    UserManager.AddToRole(user.Id, "User");
            //}

            //if (!context.Users.Any(u => u.UserName == "Jill"))
            //{
            //    var user = new User { UserName = "Jill", FirstName = "Jill", LastName = "Smith", Email = "jill@gmail.com" };
            //    UserManager.Create(user, "ABCD1234");
            //    UserManager.AddToRole(user.Id, "User");
            //}

            //if (!context.Users.Any(u => u.UserName == "Jane"))
            //{
            //    var user = new User { UserName = "Jane", FirstName = "Jane", LastName = "Patrick", Email = "jane@gmail.com" };
            //    UserManager.Create(user, "ABCD1234");
            //    UserManager.AddToRole(user.Id, "User");
            //}

            //if (!context.Users.Any(u => u.UserName == "Bill"))
            //{
            //    var user = new User { UserName = "Bill", FirstName = "Bill", LastName = "Austin", Email = "bill@gmail.com" };
            //    UserManager.Create(user, "ABCD1234");
            //    UserManager.AddToRole(user.Id, "User");
            //}

            //if (!context.Users.Any(u => u.UserName == "Aaron"))
            //{
            //    var user = new User { UserName = "Aaron", FirstName = "Aaron", LastName = "Wands", Email = "aaronwands@gmail.com" };
            //    UserManager.Create(user, "Susanc");
            //    UserManager.AddToRole(user.Id, "Administrator");
            //}

            //context.SaveChanges();



            //if (!context.Schools.Any(u => u.SchoolName == "Pearland Jiu-Jitsu"))
            //{
            //    var school = new School { SchoolName = "Pearland Jiu-Jitsu", Address1 = "123 Main Street", Address2 = "Suite 200", City = "Pearland", State = "TX", Zip = "77584", Website = "https://www.WandsJitsu.com" };
            //    var holder = UserManager.FindByName("Jane");
            //    school.UserId = holder.Id;
            //    context.Schools.Add(school);
            //}

            //if (!context.Schools.Any(u => u.SchoolName == "Austin MMA & BJJ"))
            //{
            //    var school = new School { SchoolName = "Austin MMA & BJJ", Address1 = "254 Oneida Avenue", Address2 = "A", City = "Austin", State = "TX", Zip = "78617", Website = "https://www.BJJAustin.com" };                                    
            //    var holder = UserManager.FindByName("Bill");
            //    school.UserId = holder.Id;
            //    context.Schools.Add(school);
            //}
            
            //if (!context.Schools.Any(u => u.SchoolName == "Dallas Kickboxing and BJJ"))
            //{
            //    var school = new School { SchoolName = "Dallas Kickboxing and BJJ", Address1 = "34 State Street", Address2 = "Second Floor", City = "Dallas", State = "TX", Zip = "75019", Website = "https://www.GracieDallas.com" };                                                    
            //    var holder = UserManager.FindByName("Steve");
            //    school.UserId = holder.Id;
            //    context.Schools.Add(school);
            //}

            //if (!context.Schools.Any(u => u.SchoolName == "Alamo Jiu-Jitsu"))
            //{
            //    var school = new School { SchoolName = "Alamo Jiu-Jitsu", Address1 = "300 Any Street", Address2 = "Suite 1100", City = "San Antonio", State = "TX", Zip = "79852", Website = "https://www.SAGracie.com" };                                                                 
            //    var holder = UserManager.FindByName("Bob");
            //    school.UserId = holder.Id;
            //    context.Schools.Add(school);
            //}

            //context.SaveChanges();


            //if (!context.Pictures.Any(u => u.PicURL == "http://www.returnofkings.com/wp-content/uploads/2013/03/bjj2.jpg"))
            //{
            //    var picture = new Picture { PicURL = "http://www.returnofkings.com/wp-content/uploads/2013/03/bjj2.jpg" };
            //    var holder = UserManager.FindByName("Jill");
            //    picture.UserId = holder.Id;
            //    context.Pictures.Add(picture);
            //}

            //if (!context.Pictures.Any(u => u.PicURL == "http://www.bjjpix.com/images/miniatures-2013-2/bishop.jpg"))
            //{
            //    var picture = new Picture { PicURL = "http://www.bjjpix.com/images/miniatures-2013-2/bishop.jpg" };
            //    var holder = UserManager.FindByName("Bob");
            //    picture.UserId = holder.Id;
            //    context.Pictures.Add(picture);
            //}

            //if (!context.Pictures.Any(u => u.PicURL == "http://claudiofrancabjj-watsonville.com/wp-content/uploads/2013/01/Tahoe-Classic-2012-Raul-Quintero-1.jpg"))
            //{
            //    var picture = new Picture { PicURL = "http://claudiofrancabjj-watsonville.com/wp-content/uploads/2013/01/Tahoe-Classic-2012-Raul-Quintero-1.jpg" };
            //    var holder = UserManager.FindByName("Steve");
            //    picture.UserId = holder.Id;
            //    context.Pictures.Add(picture);
            //}

            //if (!context.Pictures.Any(u => u.PicURL == "http://www.bjjpix.com/cache/widgetkit/gallery/234/WIL_3974-2c80541cb3.jpg"))
            //{
            //    var picture = new Picture { PicURL = "http://www.bjjpix.com/cache/widgetkit/gallery/234/WIL_3974-2c80541cb3.jpg" };
            //    var holder = UserManager.FindByName("Jane");
            //    picture.UserId = holder.Id;
            //    context.Pictures.Add(picture);
            //}

            //context.SaveChanges();


            //if (!context.Videos.Any(u => u.VidURL == "http://youtu.be/rBKbAW8IhRE"))
            //{
            //    var video = new Video { VidURL = "http://youtu.be/rBKbAW8IhRE" };
            //    var holder = UserManager.FindByName("Bill");
            //    video.UserId = holder.Id;
            //    context.Videos.Add(video);
            //}

            //if (!context.Videos.Any(u => u.VidURL == "http://youtu.be/D9N1jxstaKA"))
            //{
            //    var video = new Video { VidURL = "http://youtu.be/D9N1jxstaKA" };
            //    var holder = UserManager.FindByName("Jane");
            //    video.UserId = holder.Id;
            //    context.Videos.Add(video);
            //}

            //context.SaveChanges();

            
            //if (!context.Comments.Any(u => u.CommentText == "Great School! Awesome place to Learn Jiu-Jitsu!"))
            //{
            //    var comment = new Comment { CommentText = "Great School! Awesome place to Learn Jiu-Jitsu!", SchoolId = 1 };
            //    var holder = UserManager.FindByName("Steve");
            //    comment.UserId = holder.Id;
            //    context.Comments.Add(comment);
            //}
            
            //if (!context.Comments.Any(u => u.CommentText == "Not bad, I liked my old school better."))
            //{
            //    var comment = new Comment { CommentText = "Not bad, I liked my old school better.", SchoolId = 2 };
            //    var holder = UserManager.FindByName("Jill");
            //    comment.UserId = holder.Id;
            //    context.Comments.Add(comment);
            //}

            //if (!context.Comments.Any(u => u.CommentText == "I'm so glad I signed up!"))
            //{
            //    var comment = new Comment { CommentText = "I'm so glad I signed up!", SchoolId = 3 };
            //    var holder = UserManager.FindByName("Bill");
            //    comment.UserId = holder.Id;
            //    context.Comments.Add(comment);
            //}

            //if (!context.Comments.Any(u => u.CommentText == "Kinda overpriced, and the teachers don't take a lot of time to explain things."))
            //{
            //    var comment = new Comment { CommentText = "Kinda overpriced, and the teachers don't take a lot of time to explain things.", SchoolId = 4 };
            //    var holder = UserManager.FindByName("Bob");
            //    comment.UserId = holder.Id;
            //    context.Comments.Add(comment);
            //}

            //context.SaveChanges();

            //if (!context.Articles.Any(u => u.Heading == "The Life Changing Benefits of Brazilian Jiu Jitsu"))
            //{
            //    var article = new Article { Heading = "The Life Changing Benefits of Brazilian Jiu Jitsu", Url="http://breakingmuscle.com/martial-arts/top-10-brazilian-jiu-jitsu-articles-of-2013", Active=true };
            //    var holder = UserManager.FindByName("Steve");
            //    article.UserId = holder.Id;
            //    context.Articles.Add(article);
            //}

            //if (!context.Articles.Any(u => u.Heading == "The Hidden Benefits of Brazilian Jiu Jitsu"))
            //{
            //    var article = new Article { Heading = "The Hidden Benefits of Brazilian Jiu Jitsu", Url = "http://breakingmuscle.com/martial-arts/the-hidden-benefits-of-brazilian-jiu-jitsu", Active = true };
            //    var holder = UserManager.FindByName("Jane");
            //    article.UserId = holder.Id;
            //    context.Articles.Add(article);
            //}

            //context.SaveChanges();


            //if (!context.Events.Any(u => u.EventName == "NAGA Dallas"))
            //{
            //    var newevent = new Event { EventName = "Naga Dallas", EventDescription = "NAGA returns to Dallas, Texas with its annual NAGA Dallas Grappling Championship, No-Gi & Gi tournament.This event is nationally RANKED!", StartDate = DateTime.Now, Active = true };
            //    var holder = UserManager.FindByName("Steve");
            //    newevent.UserId = holder.Id;
            //    context.Events.Add(newevent);
            //}

            //if (!context.Events.Any(u => u.EventName == "World Championship"))
            //{
            //    var newevent = new Event { EventName = "World Championship", EventDescription = "On Saturday & Sunday, April 26 & 27, 2014 NAGA returns to New Jersey for our 20th annual NAGA World Grappling Championship No-Gi & Gi tournament. ", StartDate = DateTime.Now, Active = true };
            //    var holder = UserManager.FindByName("Jane");
            //    newevent.UserId = holder.Id;
            //    context.Events.Add(newevent);
            //}

            //if (!context.Events.Any(u => u.EventName == "European Open No-Gi Championship"))
            //{
            //    var newevent = new Event { EventName = "European Open No-Gi Championship", EventDescription = "European Open No-Gi Championship", StartDate = DateTime.Now, Active = true };
            //    var holder = UserManager.FindByName("Bill");
            //    newevent.UserId = holder.Id;
            //    context.Events.Add(newevent);
            //}
            
            //context.SaveChanges();

        }
    }
}
