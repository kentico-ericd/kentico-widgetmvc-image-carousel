using CMS.DocumentEngine;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace KenticoMarketplace.Models.Widgets.CarouselWidget
{
    public class CarouselWidgetViewModel
    {
        public List<SelectListItem> AvailableTypes { get; set; }

        public List<TreeNode> CarouselItems { get; set; }

        public string ContainerID { get; set; }

        public int Delay { get; set; }

        public bool Swiping { get; set; }

        public int Rows { get; set; }

        public int ItemsPerRow { get; set; }

        public bool DoAutoplay { get; set; }

        public string PageType { get; set; }

        public string Path { get; set; }
    }
}