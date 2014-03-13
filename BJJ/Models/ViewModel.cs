using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BJJ.Models
{
    public class ViewModel
    {
        public List<School> Schools { get; set; }
        public IPagedList<School> PagedSchools { get; set; }
        public School School { get; set; }
        public int SchoolId { get; set; }
        public string SchoolName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Website { get; set; }


        public List<Picture> Pictures { get; set; }
        public Picture Picture { get; set; }
        public IPagedList<Picture> PagedPictures { get; set; }
        public int PictureId { get; set; }
        public string PicURL { get; set; }


        public List<Video> Videos { get; set; }
        public Video Video { get; set; }
        public IPagedList<Video> PagedVideos { get; set; }
        public int VideoId { get; set; }
        public string VidURL { get; set; }

        
        public List<Article> Articles { get; set; }
        public Article Article { get; set; }
        public IPagedList<Article> PagedArticles { get; set; }
        public int ArticleId { get; set; }
        public string Heading { get; set; }
        public string Url { get; set; }
        public bool Active { get; set; }
        
        public IPagedList<Event> PagedEvents { get; set; }
        public List<Event> Events { get; set; }
        public Event Event { get; set; }
        public int EventId { get; set; }
        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public DateTime StartDate { get; set; }

        public List<Comment> Comments { get; set; }
        public Comment Comment { get; set; }
        public IPagedList<Comment> PagedComments { get; set; }
        public int CommentId { get; set; }
        public string CommentText { get; set; }

    }
}