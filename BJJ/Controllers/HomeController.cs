using BJJ.Adapters.DataAdapters;
using BJJ.Adapters.Interfaces;
using BJJ.Data;
using BJJ.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace BJJ.Controllers
{
    public class HomeController : Controller
    {                       
        public ActionResult Index(int? page)
        {            
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();                
            
            return View(model);
        }

        [Authorize(Roles = "Administrator")]
        public ActionResult Admin(int? spage, int? epage, int? apage)
        {
            var SchoolPage = spage ?? 1;
            var EventPage = epage ?? 1;
            var ArticlePage = apage ?? 1;
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedSchools = db.Schools.OrderBy(a => a.SchoolName).ToPagedList(SchoolPage, 10);
            model.PagedEvents = db.Events.Where(e => e.Active == true).OrderBy(e => e.StartDate).ToPagedList(EventPage, 5);
            model.PagedArticles = db.Articles.Where(e => e.Active == true).OrderBy(e => e.Heading).ToPagedList(ArticlePage, 5);

            return View(model);
        }
        
        public ActionResult Search(string query)
        {
            BJJDbContext db = new BJJDbContext();
            ViewModel model = new ViewModel();

            model.Schools = db.Schools.Where(s => s.City.Contains(query) || s.State.Contains(query)).ToList();

            return View(model);
        }

        public ActionResult Schools(int? spage)
        {
            var SchoolPage = spage ?? 1;
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedSchools = db.Schools.OrderBy(a => a.SchoolName).ToPagedList(SchoolPage, 10);

            return View(model);
        }

        public ActionResult SchoolPage(int schoolId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.School = db.Schools.Find(schoolId);

            return View(model);
        }

        public ActionResult CreateSchool()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            
            School addschool = db.Schools.Create();

            db.Schools.Add(addschool);

            return View();
        }

        [HttpPost]
        public ActionResult CreateSchool(ViewModel newschool)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            School addschool = db.Schools.Create();

            addschool.SchoolName = newschool.SchoolName;
            addschool.Address1 = newschool.Address1;
            addschool.Address2 = newschool.Address2;
            addschool.City = newschool.City;
            addschool.State = newschool.State;
            addschool.Zip = newschool.Zip;
            addschool.Website = newschool.Website;

            db.Schools.Add(addschool);
            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult EditSchool(int schoolId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.School = db.Schools.Where(s => s.SchoolId == schoolId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditSchool(ViewModel school)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editschool = db.Schools.Where(s => s.SchoolId == school.SchoolId).First();

            editschool.SchoolName = school.SchoolName;
            editschool.Address1 = school.Address1;
            editschool.Address2 = school.Address2;
            editschool.City = school.City;
            editschool.State = school.State;
            editschool.Zip = school.Zip;
            editschool.Website = school.Website;

            db.SaveChanges();

            return RedirectToAction("Admin");
        }             

        public ActionResult DeleteSchool(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deleteschool = db.Schools.Where(s => s.SchoolId == deleteId).First();

            db.Schools.Remove(deleteschool);

            db.SaveChanges();

            return RedirectToAction("Admin");
        }
                
        public ActionResult UserPage()
        {

            BJJDbContext db = new BJJDbContext();

            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            var currentUser = manager.FindById(User.Identity.GetUserId());

            return View(currentUser);
        }

        public ActionResult Events(int? epage)
        {
            var EventPage = epage ?? 1;

            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedEvents = db.Events.Where(e => e.Active == true).OrderBy(e => e.StartDate).ToPagedList(EventPage, 5);

            return View(model);
        }

        public ActionResult CreateEvent()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            Event addevent = db.Events.Create();

            db.Events.Add(addevent);

            return View();
        }

        [HttpPost]
        public ActionResult CreateEvent(ViewModel newevent)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            Event addevent = db.Events.Create();
            addevent.EventName = newevent.EventName;
            addevent.EventDescription = newevent.EventDescription;
            addevent.StartDate = newevent.StartDate;
            addevent.Active = true;

            var currentUser = manager.FindById(User.Identity.GetUserId());
            addevent.UserId = currentUser.Id;

            db.Events.Add(addevent);
            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult EditEvent(int eventId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.Event = db.Events.Where(s => s.EventId == eventId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditEvent(ViewModel newevent)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editevent = db.Events.Where(s => s.EventId == newevent.EventId).First();

            Event addevent = db.Events.Create();

            editevent.EventName = newevent.EventName;
            editevent.EventDescription = newevent.EventDescription;
            editevent.StartDate = newevent.StartDate;
            editevent.Active = true;

            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult DeleteEvent(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deleteevent = db.Events.Where(s => s.EventId == deleteId).First();

            db.Events.Remove(deleteevent);

            db.SaveChanges();

            return RedirectToAction("Admin");
        }


        public ActionResult Comments(int? epage)
        {
            var CommentPage = epage ?? 1;

            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedComments = db.Comments.OrderBy(e => e.CommentId).ToPagedList(CommentPage, 10);

            return View(model);
        }

        public ActionResult CreateComment()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            Comment addcomment = db.Comments.Create();

            db.Comments.Add(addcomment);

            return View();
        }

        public ActionResult CreateComment(ViewModel comment)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            Comment addcomment = db.Comments.Create();
            addcomment.CommentText = addcomment.CommentText;
            
            var currentUser = manager.FindById(User.Identity.GetUserId());
            addcomment.UserId = currentUser.Id;

            db.Comments.Add(addcomment);

            return RedirectToAction("Comments");
        }

        public ActionResult EditComment(int commentId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.Comment = db.Comments.Where(s => s.CommentId == commentId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditComment(ViewModel comment)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editcomment = db.Comments.Where(s => s.CommentId ==  comment.CommentId).First();

            Comment addcomment = db.Comments.Create();

            editcomment.CommentText = comment.CommentText;
            db.SaveChanges();

            return RedirectToAction("Events");
        }

        public ActionResult DeleteComment(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deletecomment = db.Comments.Where(s => s.CommentId == deleteId).First();

            db.Comments.Remove(deletecomment);

            db.SaveChanges();

            return RedirectToAction("Comments");
        }
        

        public ActionResult Articles(int? epage)
        {
            var ArticlePage = epage ?? 1;

            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedArticles = db.Articles.Where(a=>a.Active == true).OrderBy(e => e.Heading).ToPagedList(ArticlePage, 5);

            return View(model);
        }

        public ActionResult CreateArticle()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();


            return View();
        }

        [HttpPost]
        public ActionResult CreateArticle(ViewModel article)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            Article addarticle = db.Articles.Create();
            addarticle.Heading = article.Heading;
            addarticle.Url = article.Url;
            addarticle.Active = true;

            var currentUser = manager.FindById(User.Identity.GetUserId());
            addarticle.UserId = currentUser.Id;
            

            db.Articles.Add(addarticle);
            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult EditArticle(int articleId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.Article = db.Articles.Where(s => s.ArticleId == articleId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditArticle(ViewModel article)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editarticle = db.Articles.Where(s => s.ArticleId == article.ArticleId).First();

            Article addarticle = db.Articles.Create();

            editarticle.Heading = article.Heading;
            editarticle.Url = article.Url;
            db.SaveChanges();

            return RedirectToAction("Admin");
        }

        public ActionResult DeleteArticle(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deletearticle = db.Articles.Where(s => s.ArticleId == deleteId).First();

            db.Articles.Remove(deletearticle);

            db.SaveChanges();

            return RedirectToAction("Admin");
        }



          public ActionResult Pictures(int? epage)
        {
            var PicturePage = epage ?? 1;

            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedPictures = db.Pictures.OrderBy(e => e.PictureId).ToPagedList(PicturePage, 10);

            return View(model);
        }

        public ActionResult CreatePicture()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            Picture addpicture = db.Pictures.Create();

            db.Pictures.Add(addpicture);

            return View();
        }

        public ActionResult CreatePicture(ViewModel picture)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            Picture addpicture = db.Pictures.Create();
            addpicture.PicURL = addpicture.PicURL;

            var currentUser = manager.FindById(User.Identity.GetUserId());
            addpicture.UserId = currentUser.Id;

            db.Pictures.Add(addpicture);

            return RedirectToAction("Pictures");
        }

        public ActionResult EditPicture(int pictureId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.Picture = db.Pictures.Where(s => s.PictureId == pictureId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditPicture(ViewModel picture)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editpicture = db.Pictures.Where(s => s.PictureId == picture.PictureId).First();

            Picture addpicture = db.Pictures.Create();

            editpicture.PicURL = picture.PicURL;
            db.SaveChanges();

            return RedirectToAction("Pictures");
        }

        public ActionResult DeletePicture(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deletepicture = db.Pictures.Where(s => s.PictureId == deleteId).First();

            db.Pictures.Remove(deletepicture);

            db.SaveChanges();

            return RedirectToAction("Pictures");
        }

        
          public ActionResult Videos(int? epage)
        {
            var VideoPage = epage ?? 1;

            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.PagedVideos = db.Videos.OrderBy(e => e.VideoId).ToPagedList(VideoPage, 10);

            return View(model);
        }

        public ActionResult CreateVideo()
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            Video addvideo = db.Videos.Create();

            db.Videos.Add(addvideo);

            return View();
        }

        public ActionResult CreateVideo(ViewModel video)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();
            UserManager<User> manager = new UserManager<User>(new UserStore<User>(db));

            Video addvideo = db.Videos.Create();
            addvideo.VidURL = addvideo.VidURL;

            var currentUser = manager.FindById(User.Identity.GetUserId());
            addvideo.UserId = currentUser.Id;

            db.Videos.Add(addvideo);

            return RedirectToAction("Videos");
        }

        public ActionResult EditVideo(int videoId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            model.Video = db.Videos.Where(s => s.VideoId == videoId).First();

            return View(model);
        }

        [HttpPost]
        public ActionResult EditVideo(ViewModel video)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var editvideo = db.Videos.Where(s => s.VideoId == video.VideoId).First();

            Video addvideo = db.Videos.Create();

            editvideo.VidURL = video.VidURL;
            db.SaveChanges();

            return RedirectToAction("Videos");
        }

        public ActionResult DeleteVideo(int deleteId)
        {
            ViewModel model = new ViewModel();
            BJJDbContext db = new BJJDbContext();

            var deletevideo = db.Videos.Where(s => s.VideoId == deleteId).First();

            db.Videos.Remove(deletevideo);

            db.SaveChanges();

            return RedirectToAction("Videos");
        }
    }
}