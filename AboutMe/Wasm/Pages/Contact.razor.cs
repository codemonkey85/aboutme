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

    private const string MicroBlogSvg = """
       <svg style="width: 24px; height: 24px;"
            xmlns="http://www.w3.org/2000/svg"
            viewBox="0 0 482.79 486.16">
         <path class="cls-1"
               d="M495.79,372.06c32-37.64,51.11-85,51.11-136.5C546.9,113,438.82,13.72,305.5,13.72S64.1,113,64.1,235.56,172.18,457.4,305.5,457.4a259.65,259.65,0,0,0,86.2-14.58,7.78,7.78,0,0,1,8.81,2.77c20.17,27.23,51.67,46.38,86.7,54.17a4.79,4.79,0,0,0,4.74-7.65,94.37,94.37,0,0,1,4-120.11ZM420,209.48l-62.17,47.19,22.56,74.72a7.06,7.06,0,0,1-10.79,7.84L305.5,294.68l-64.09,44.55a7.06,7.06,0,0,1-10.79-7.84l22.56-74.72L191,209.48a7.06,7.06,0,0,1,4.12-12.68l78-1.63,25.67-73.71a7.06,7.06,0,0,1,13.33,0l25.67,73.71,78,1.63A7.06,7.06,0,0,1,420,209.48Z"
               transform="translate(-64.1 -13.72)" />
       </svg>
       """;

    private const string PixelfedSvg = """
        <svg viewBox="-10 -5 1034 1034" 
             xmlns="http://www.w3.org/2000/svg"
             xmlns:xlink="http://www.w3.org/1999/xlink"
             version="1.1" fill="#FFFFFF">
             <g id="SVGRepo_bgCarrier" stroke-width="0">
             </g>
             <g id="SVGRepo_tracerCarrier" stroke-linecap="round" stroke-linejoin="round">
             </g>
             <g id="SVGRepo_iconCarrier">
                <path fill="#FFFFFF" d="M500 176q-115 0 -215 58q-96 57 -152 153q-58 99 -58 214.5t58 214.5q56 96 152 152q100 58 215 58t215 -58q96 -56 152 -152q58 -99 58 -214.5t-58 -214.5q-56 -96 -152 -153q-100 -58 -215 -58zM432 435h112q36 0 66.5 17.5t48.5 47t18 65t-18 65t-48.5 47t-66.5 17.5 h-78l-111 106v-290q0 -31 22.5 -53t54.5 -22z">
             </path>
             </g>
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
            Name = "Pixelfed",
            Url = "https://pixelfed.social/codemonkey85",
            Title = "Michael Bond on Pixelfed",
            Icon = PixelfedSvg
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
