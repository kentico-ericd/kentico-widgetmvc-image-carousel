using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using System;

namespace KenticoMarketplace.Models.Widgets.CarouselWidget
{
    public class CarouselWidgetProperties : IWidgetProperties
    {
        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 0, ExplanationText = "If enabled, the carousel will automatically scroll through the items", Label = "Autoplay")]
        public bool DoAutoplay { get; set; } = true;

        [EditingComponent(CheckBoxComponent.IDENTIFIER, Order = 1, ExplanationText = "If enabled, users can navigate the carousel by swiping on mobile devices", Label = "Swiping")]
        public bool Swiping { get; set; } = true;

        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 3, ExplanationText = "The time (in ms) between automatic scrolling of items", Label = "Delay")]
        public int Delay { get; set; } = 5000;

        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 4, ExplanationText = "The number of rows displayed per slide", Label = "Rows")]
        public int Rows { get; set; } = 1;

        [EditingComponent(IntInputComponent.IDENTIFIER, Order = 5, ExplanationText = "The number of carousel items in each slide row", Label = "Items per row")]
        public int ItemsPerRow { get; set; } = 1;

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 6, ExplanationText = "The ID that will be added to the DIV wrapping the entire carousel", Label = "Container ID")]
        public string ContainerID { get; set; } = "carousel-" + Guid.NewGuid().ToString().Replace("-", "").Substring(0, 12);

        public string Path { get; set; }

        public string PageType { get; set; } = "MVC.CarouselItem";
    }
}