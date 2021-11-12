using System.Net.Mime;
using System.Text;

namespace aboutme.Components;

public partial class MarkdownToHtmlComponent
{
    [Parameter] public string? MarkdownContentFileName { get; set; }

    [Parameter] public bool AllowPageDownload { get; set; } = false;

    [Parameter] public string? DownloadPageButtonText { get; set; }

    [Parameter] public string? DownloadPageFileName { get; set; }

    protected string? ContentFileName => !(string.IsNullOrEmpty(DownloadPageFileName) || string.IsNullOrWhiteSpace(DownloadPageFileName))
        ? DownloadPageFileName
        : MarkdownContentFileName == null
            ? null
            : new FileInfo(MarkdownContentFileName)?.Name?.Replace(".md", ".txt") ?? MarkdownContentFileName;

    protected string html = string.Empty;
    protected string errorMessage = string.Empty;

    protected override async Task OnInitializedAsync()
    {
        html = string.Empty;
        RefreshService.RefreshRequested += StateHasChanged;
        try
        {
            html = MarkdownContentFileName == null ? string.Empty : Markdown.Transform(await HttpClient.ReadPageContentFromMd(MarkdownContentFileName));
        }
        catch (Exception ex)
        {
            OnError(ex);
        }
    }

    protected void OnError(Exception ex)
    {
        StringBuilder errorBuilder = new();
        BuildErrorMessage(errorBuilder, ex);
        errorMessage = errorBuilder.ToString();
    }

    protected void BuildErrorMessage(StringBuilder errorBuilder, Exception ex)
    {
        errorBuilder.AppendLine($"{ex.Message}{Environment.NewLine}{ex.StackTrace}");
        if (ex.InnerException != null)
        {
            BuildErrorMessage(errorBuilder, ex.InnerException);
        }
    }

    protected async Task DownloadPage()
    {
        try
        {
            await JsInterop.DownloadFile($"{DownloadPageFileName}.html", MediaTypeNames.Text.Html, Encoding.UTF8.GetBytes(html));
        }
        catch (Exception ex)
        {
            OnError(ex);
        }
    }
}

