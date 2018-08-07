using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorldApi.Models
{
    public class InsertStuffModel : InsertStuffBaseModel
    {
        public string stuff { set; get; }
        public string moreStuff { set; get; }
    }
}