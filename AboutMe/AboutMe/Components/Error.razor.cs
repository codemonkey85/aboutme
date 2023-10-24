namespace AboutMe.Components;

public partial class Error
{
    [CascadingParameter] public HttpContext? HttpContext { get; set; }

    public string? RequestId { get; set; }
    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);

    protected override void OnInitialized() =>
        RequestId = Activity.Current?.Id ?? HttpContext?.TraceIdentifier;
}
