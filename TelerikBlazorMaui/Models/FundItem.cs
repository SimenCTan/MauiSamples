using Telerik.SvgIcons;

namespace TelerikBlazorMaui.Models;

public class FundItem
{
    public int Id { get; set; }
    public string Text { get; set; }
    public int? ParentIdValue { get; set; }
    public bool HasChildren { get; set; }
    public ISvgIcon Icon { get; set; }
    public bool Expanded { get; set; }
}
