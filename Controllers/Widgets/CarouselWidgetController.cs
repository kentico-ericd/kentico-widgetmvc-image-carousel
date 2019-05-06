using KenticoMarketplace.Models.Widgets.CarouselWidget;
using Kentico.PageBuilder.Web.Mvc;
using System.Web.Mvc;
using System.Collections.Generic;
using CMS.DocumentEngine;
using System.Linq;
using CMS.DataEngine;
using CMS.FormEngine;

[assembly: RegisterWidget("CarouselWidget", typeof(KenticoMarketplace.Controllers.Widgets.CarouselWidgetController), "Image carousel", IconClass = "icon-w-content-slider")]
namespace KenticoMarketplace.Controllers.Widgets
{
    public class CarouselWidgetController : WidgetController<CarouselWidgetProperties>
    {
        public ActionResult Index()
        {
            var properties = GetProperties();

            List<TreeNode> pages = new List<TreeNode>();
            if (DocumentTypeHelper.GetDocumentTypeClasses().WhereEquals("ClassName", properties.PageType).TypedResult.Count() >= 1)
            {
                pages = DocumentHelper.GetDocuments()
                                .Type(properties.PageType)
                                .Path(properties.Path, PathTypeEnum.Children)
                                .OnCurrentSite()
                                .TypedResult
                                .ToList();
            }

            var types = DocumentTypeHelper.GetDocumentTypeClasses()
                    .WhereEquals("ClassIsContentOnly", true)
                    .TypedResult
                    .ToList();
            var filtered = types.Where(t => ClassHasRequiredFields(t));
            var pagetypes = new List<SelectListItem>();
            foreach (var type in filtered)
            {
                pagetypes.Add(new SelectListItem()
                {
                    Text = type.ClassDisplayName,
                    Value = type.ClassName,
                    Selected = (type.ClassName == properties.PageType)
                });
            }

            return PartialView("Widgets/_CarouselWidget", new CarouselWidgetViewModel
            {
                AvailableTypes = pagetypes,
                CarouselItems = pages,
                Path = properties.Path,
                Delay = properties.Delay,
                Swiping = properties.Swiping,
                Rows = properties.Rows,
                ContainerID = properties.ContainerID,
                ItemsPerRow = properties.ItemsPerRow,
                DoAutoplay = properties.DoAutoplay,
                PageType = properties.PageType
            });
        }

        private bool ClassHasRequiredFields(DataClassInfo dci)
        {
            var form = new FormInfo(dci.ClassFormDefinition);
            return form.FieldExists("Title")
                && form.FieldExists("Text")
                && form.FieldExists("Image");
        }
    }
}