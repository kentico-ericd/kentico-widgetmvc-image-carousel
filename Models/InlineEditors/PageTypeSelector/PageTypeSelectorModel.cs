using System.Collections.Generic;
using System.Web.Mvc;

namespace KenticoMarketplace.Models.InlineEditors.PageTypeSelector
{
    public class PageTypeSelectorModel
    {
        public string PropertyName { get; set; }
        public string Value { get; set; }
        public List<SelectListItem> Types { get; set; }
    }
}