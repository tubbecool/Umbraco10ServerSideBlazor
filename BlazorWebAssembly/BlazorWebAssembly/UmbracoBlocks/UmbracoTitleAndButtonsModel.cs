using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssembly.UmbracoBlocks {
    public class UmbracoTitleAndButtonsModel {
        public UmbracoTitleAndButtonsModel() {
        }
        public string Title { get; set; }
        public string Paragraph { get; set; }
        public string LogButtonText { get; set; }
        public string LogText { get; set; }
        public LinkButton LinkButton { get; set;}
        public bool UseWaitIndication { get; set; }
    }

    public class LinkButton {
        public string ButtonText { get; set; }
        public string Link { get; set; }
    }
}
