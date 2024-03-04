using KendoUI.Models.SubForms;
using Microsoft.VisualBasic;

namespace KendoUI.Models.FromModel{
public class Form{
    public long FormID{get;set;} 
    public string Mantralaya {get; set;}
    public long OfficeCodeNo { get; set; }
    public string FiscalYear {get; set;}
    public long KharchaNikasasNo {get; set;}
    public long KharchaNikasasGariakoNo {get; set;}
    public string Date { get; set; }
        public ICollection<SubForm> SubForms { get; set; }
    }
}