namespace AboutMe.Wasm.Pages;

public partial class Contact
{
    private const string MastodonSvg = """
        <svg xmlns="http://www.w3.org/2000/svg"
             width="24"
             height="24"
             fill="currentColor"
             class="bi bi-mastodon"
             viewBox="0 0 16 16">
          <path d="M11.19 12.195c2.016-.24 3.77-1.475 3.99-2.603.348-1.778.32-4.339.32-4.339 0-3.47-2.286-4.488-2.286-4.488C12.062.238 10.083.017 8.027 0h-.05C5.92.017 3.942.238 2.79.765c0 0-2.285 1.017-2.285 4.488l-.002.662c-.004.64-.007 1.35.011 2.091.083 3.394.626 6.74 3.78 7.57 1.454.383 2.703.463 3.709.408 1.823-.1 2.847-.647 2.847-.647l-.06-1.317s-1.303.41-2.767.36c-1.45-.05-2.98-.156-3.215-1.928a3.614 3.614 0 0 1-.033-.496s1.424.346 3.228.428c1.103.05 2.137-.064 3.188-.189zm1.613-2.47H11.13v-4.08c0-.859-.364-1.295-1.091-1.295-.804 0-1.207.517-1.207 1.541v2.233H7.168V5.89c0-1.024-.403-1.541-1.207-1.541-.727 0-1.091.436-1.091 1.296v4.079H3.197V5.522c0-.859.22-1.541.66-2.046.456-.505 1.052-.764 1.793-.764.856 0 1.504.328 1.933.983L8 4.39l.417-.695c.429-.655 1.077-.983 1.934-.983.74 0 1.336.259 1.791.764.442.505.661 1.187.661 2.046v4.203z" />
        </svg>
        """;

    private const string BlueskySvg = """
        <svg class="w-[40px] h-auto"
                    xmlns="http://www.w3.org/2000/svg"
                    fill="none"
                    viewBox="0 0 568 501">
          <title>Bluesky butterfly logo</title>
          <path fill="currentColor"
                      d="M123.121 33.664C188.241 82.553 258.281 181.68 284 234.873c25.719-53.192 95.759-152.32 160.879-201.21C491.866-1.611 568-28.906 568 57.947c0 17.346-9.945 145.713-15.778 166.555-20.275 72.453-94.155 90.933-159.875 79.748C507.222 323.8 536.444 388.56 473.333 453.32c-119.86 122.992-172.272-30.859-185.702-70.281-2.462-7.227-3.614-10.608-3.631-7.733-.017-2.875-1.169.506-3.631 7.733-13.43 39.422-65.842 193.273-185.702 70.281-63.111-64.76-33.89-129.52 80.986-149.071-65.72 11.185-139.6-7.295-159.875-79.748C9.945 203.659 0 75.291 0 57.946 0-28.906 76.135-1.612 123.121 33.664Z" />
        </svg>
        """;

    private const string SignalSvg = """
        <svg xmlns="http://www.w3.org/2000/svg"
             viewBox="0 0 512 512">
             <!--!Font Awesome Free 6.5.1 by @fontawesome - https://fontawesome.com License - https://fontawesome.com/license/free Copyright 2024 Fonticons, Inc.-->
             <path d="M194.6 7.5l5.8 23.3C177.7 36.3 156 45.3 136 57.4L123.7 36.8c22-13.3 45.9-23.2 70.9-29.3zm122.9 0l-5.8 23.3C334.3 36.3 356 45.3 376 57.4l12.4-20.6c-22-13.3-46-23.2-71-29.3zM36.8 123.7c-13.3 22-23.2 45.9-29.3 70.9l23.3 5.8C36.3 177.7 45.3 156 57.4 136L36.8 123.7zM24 256c0-11.6 .9-23.3 2.6-34.8L2.9 217.6c-3.8 25.4-3.8 51.3 0 76.7l23.7-3.6C24.9 279.3 24 267.6 24 256zM388.3 475.2L376 454.6c-20 12.1-41.6 21-64.2 26.6l5.8 23.3c24.9-6.2 48.8-16 70.8-29.3zM488 256c0 11.6-.9 23.3-2.6 34.8l23.7 3.6c3.8-25.4 3.8-51.3 0-76.7l-23.7 3.6c1.7 11.5 2.6 23.1 2.6 34.8zm16.5 61.4l-23.3-5.8c-5.6 22.7-14.5 44.3-26.6 64.3l20.6 12.4c13.3-22 23.2-46 29.3-71zm-213.8 168c-23 3.5-46.5 3.5-69.5 0l-3.6 23.7c25.4 3.8 51.3 3.8 76.7 0l-3.6-23.7zm152-91.8c-13.8 18.7-30.4 35.3-49.2 49.1l14.2 19.3c20.7-15.2 39-33.4 54.2-54.1l-19.3-14.4zM393.6 69.2c18.8 13.8 35.3 30.4 49.2 49.2L462.1 104C446.9 83.4 428.6 65.1 408 49.9L393.6 69.2zM69.2 118.4c13.8-18.8 30.4-35.3 49.2-49.2L104 49.9C83.4 65.1 65.1 83.4 49.9 104l19.3 14.4zm406 5.3L454.6 136c12.1 20 21 41.6 26.6 64.2l23.3-5.8c-6.2-24.9-16-48.8-29.3-70.8zm-254-97.1c23-3.5 46.5-3.5 69.5 0l3.6-23.7C268.9-1 243.1-1 217.6 2.9l3.6 23.7zM81.6 468.4L32 480l11.6-49.6L20.2 425 8.6 474.5c-.9 4-.8 8.1 .3 12.1s3.2 7.5 6.1 10.4s6.5 5 10.4 6.1s8.1 1.2 12.1 .3L87 492l-5.4-23.6zM25.2 403.6L48.6 409l8-34.4c-11.7-19.6-20.4-40.8-25.8-63L7.5 317.4c5.2 21.2 13.2 41.7 23.6 60.8l-5.9 25.3zm112 52l-34.4 8 5.4 23.4 25.3-5.9c19.2 10.4 39.6 18.4 60.8 23.6l5.8-23.3c-22.1-5.5-43.3-14.3-62.8-26l-.2 .2zM256 48c-37.2 0-73.6 10-105.6 28.9s-58.4 46-76.3 78.6s-26.9 69.3-25.8 106.4s12 73.3 31.8 104.8L60 452l85.3-20c27.3 17.2 58.2 27.8 90.3 31s64.5-1.1 94.6-12.6s57.2-29.8 79-53.6s37.8-52.2 46.8-83.2s10.5-63.6 4.7-95.3s-19-61.6-38.4-87.4s-44.5-46.7-73.4-61S288.3 48 256 48z"/>
             </svg>
        """;

    private const string MicroBlogSvg = """
                                        <svg style="width: 24px; height: 24px;"
                                             xmlns="http://www.w3.org/2000/svg"
                                             viewBox="0 0 482.79 486.16">
                                          <path class="cls-1"
                                                d="M495.79,372.06c32-37.64,51.11-85,51.11-136.5C546.9,113,438.82,13.72,305.5,13.72S64.1,113,64.1,235.56,172.18,457.4,305.5,457.4a259.65,259.65,0,0,0,86.2-14.58,7.78,7.78,0,0,1,8.81,2.77c20.17,27.23,51.67,46.38,86.7,54.17a4.79,4.79,0,0,0,4.74-7.65,94.37,94.37,0,0,1,4-120.11ZM420,209.48l-62.17,47.19,22.56,74.72a7.06,7.06,0,0,1-10.79,7.84L305.5,294.68l-64.09,44.55a7.06,7.06,0,0,1-10.79-7.84l22.56-74.72L191,209.48a7.06,7.06,0,0,1,4.12-12.68l78-1.63,25.67-73.71a7.06,7.06,0,0,1,13.33,0l25.67,73.71,78,1.63A7.06,7.06,0,0,1,420,209.48Z"
                                                transform="translate(-64.1 -13.72)" />
                                        </svg>
                                        """;

    private List<SocialLink> SocialLinksList { get; set; } =
    [
        SocialLink.EmailMe,
        SocialLink.MyGitHub with { Name = "GitHub" },
        new()
        {
            Name = "Mastodon",
            Url = "https://mastodon.social/@codemonkey85",
            Title = "Michael Bond on Mastodon",
            Icon = MastodonSvg,
        },
        new()
        {
            Name = "Bluesky",
            Url = "https://bsky.app/profile/codemonkey85.bsky.social",
            Title = "Michael Bond on BlueSky",
            Icon = BlueskySvg,
        },
        new()
        {
            Name = "Signal",
            Url = "https://signal.me/#eu/2Bhlv1XZ2g4FRDl3UEk5iMQ+NqY/KnM6iV6oJQdBsiAJKz4PJahI1420U+VZ1cHD",
            Title = "Michael Bond on Signal",
            Icon = SignalSvg,
        },
        new()
        {
            Name = "Micro.blog",
            Url = "https://micro.blog/codemonkey85",
            Title = "Michael Bond on Micro.blog",
            Icon = MicroBlogSvg
        }
    ];
}
