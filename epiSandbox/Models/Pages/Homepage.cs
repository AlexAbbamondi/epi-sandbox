using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;
using EPiServer.DataAnnotations;

namespace epiSandbox.Models.Pages
{
    [ContentType(
        DisplayName = "Home Page")]
    public class Homepage : PageData
    {
        public virtual string Title { get; set; }
    }
}