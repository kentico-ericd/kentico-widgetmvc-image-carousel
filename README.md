# Image carousel MVC widget

This custom MVC page builder widget can be used to add a carousel to your pages which displays images, text, and optionally a button to redirect to a new page.

![Live site](https://github.com/kentico-ericd/kentico-widgetmvc-image-carousel/blob/master/carousel-livesite.gif)

## Installation

You can use Visual Studio's Package Manager to install the widget from [NuGet](https://www.nuget.org/packages/EricD.Kentico.MvcWidget.ImageCarousel/12.0.0).

## Usage

This widget requires jQuery to be loaded on the live site, in the page's &lt;head&gt;.

To begin using the widget, you must create at least one content-only page type which will represent the carousel items. The page type must contain the following fields:

* __Title__ (Text) - The title of a slide
* __Text__ (Text) - The text of a slide
* __Image__ (Text) - The URL of a media file used as the slide's image

Optionally, the page type can contain two other fields which are used to display a call-to-action button on each slide:

* __CtaText__ (Text) - The text of the CTA button
* __CtaUrl__ (Text) - Where the user will be redirected to

All of these fields can use the Text Box form control, though for the Image field you can use Media Selector.

Once you have one or more of these page types, you can add the widget to a page, and use the Page Type inline editor to select your page type, and the Path inline editor to tell the widget from where to load the slides.