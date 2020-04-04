using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Ngo.Prayas.ViewModels
{
    public class EventGalleryVM
    {
        public int Id { get; set; }

        public string ImageName { get; set; }

        [Required]
        public HttpPostedFileBase[] Files { get; set; }

        [Required]
        public string GalleryName { get; set; }

        [Required]
        public string GalleryDescription { get; set; }
    }

    public class PagedList<T>
    {
        public List<T> Content { get; set; }
        public Int32 CurrentPage { get; set; }
        public Int32 PageSize { get; set; }
        public int TotalRecords { get; set; }

    }

}