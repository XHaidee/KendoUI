using KendoUI.Models.FromModel;

namespace KendoUI.Models.SubForms{
    public class SubForm{
        public long SN{get; set;}
        public string Name{get; set;}
        public string Symbol_No { get; set;}
        public string Specificatin_No { get; set;}
        public string Akin_no { get; set; }
        public string Quantity { get; set;}
        public string Rate { get; set;}
        public string Remark { get; set;}
        public long FormID{get; set;}
        public Form Form{get; set;}
    }
}