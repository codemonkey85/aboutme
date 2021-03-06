﻿using aboutme.Shared;
using MarkdownSharp;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.IO;
using System.Net.Http;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace aboutme.Components
{
    public partial class MarkdownToHtmlComponent : ComponentBase
    {
        [Parameter]
        public string MarkdownContentFileName
        {
            get; set;
        }

        [Parameter]
        public bool AllowPageDownload
        {
            get; set;
        } = false;

        [Parameter]
        public string DownloadPageButtonText
        {
            get; set;
        }

        [Parameter]
        public string DownloadPageFileName
        {
            get; set;
        }

        [Inject]
        public HttpClient HttpClient
        {
            get; set;
        }

        [Inject]
        public Markdown Markdown
        {
            get; set;
        }

        [Inject]
        public IJSRuntime JSRuntime
        {
            get; set;
        }

        [Inject]
        private IRefreshService RefreshService
        {
            get; set;
        }

        protected string ContentFileName =>
            !(string.IsNullOrEmpty(DownloadPageFileName) || string.IsNullOrWhiteSpace(DownloadPageFileName))
                ? DownloadPageFileName
                : new FileInfo(MarkdownContentFileName)?.Name?.Replace(".md", ".txt") ?? MarkdownContentFileName;

        protected string html = string.Empty;
        protected string errorMessage = string.Empty;

        protected override async Task OnInitializedAsync()
        {
            html = string.Empty;
            RefreshService.RefreshRequested += StateHasChanged;
            try
            {
                html = Markdown.Transform(await HttpClient.ReadPageContentFromMd(MarkdownContentFileName));
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }

        protected void OnError(Exception ex)
        {
            StringBuilder errorBuilder = new StringBuilder();
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
                await JSRuntime.DownloadFile($"{DownloadPageFileName}.html", MediaTypeNames.Text.Html, Encoding.UTF8.GetBytes(html));
            }
            catch (Exception ex)
            {
                OnError(ex);
            }
        }
    }
}
