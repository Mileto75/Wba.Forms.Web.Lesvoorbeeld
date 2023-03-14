using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace Wba.Forms.Web.Models
{
    public class CheckBoxModel
    {
        [HiddenInput]
        public string Name{ get; set; }
        [HiddenInput]
        public string Value { get; set; }
        public bool IsSelected { get; set; }
    }
}
