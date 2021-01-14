using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace epiSandbox.Models.Pages
{
    [ContentType(DisplayName = "StandardPage", GUID = "d1daa5c5-5ef5-4f72-8a6e-8d3071301ae7", Description = "")]
    public class StandardPage : PageData
    {
        [CultureSpecific]
        [Display]
        public virtual string Heading { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
        public virtual string Footer { get; set; }
    }
}