using System;
using System.Collections.Generic;
using System.Text;
using RideHailingApp.DataModel;

namespace RideHailingApp.VIewModels
{
    class WynkPassPageModel
    {
        List<WynkPass> myList = new List<WynkPass>
            {
                new WynkPass{PassName = "Wynk Purple", Validity="Valid for 7 days" },
                new WynkPass{PassName = "Wynk Maverick", Validity="Valid for 30 days" },
                new WynkPass{PassName = "Wynk Gold", Validity="Valid for 90 days" }
            };
    }
}
