namespace AboutMe.Wasm.Pages;

public partial class Resume
{
    private readonly ResumeModel? resumeModel = new()
    {
        Name = "Michael Bond",
        Email = "michael@bondcodes.com",
        Summary = "Web / Windows / C# / ASP / .NET Developer",
        Skills =
        [
            Skills.DotNetCore,
            Skills.VisualStudio,
            Skills.AspNet,
            Skills.Blazor,
            Skills.MudBlazor,
            Skills.DotNetMaui,
            Skills.MsSqlServer,
            Skills.Sql,
            Skills.Html,
            Skills.Css,
            Skills.JavaScript,
        ],
        Jobs =
        [
            new Job
            {
                Title = "Software Developer",
                Company = "3 Story Software",
                Summary = "",
                SkillsUsed =
                [
                    Skills.DotNetCore,
                    Skills.VisualStudio,
                    Skills.AspNet,
                    Skills.MsSqlServer,
                    Skills.Sql,
                    Skills.Html,
                    Skills.Css,
                    Skills.JavaScript,
                ],
                Duties =
                [
                    new Duty
                    {
                        Description = "Designed and developed workforce management web application, supported across the globe",
                    },
                    new Duty
                    {
                        Description = "Designed high-level solutions as well as in-depth technical requirements for new feature requests and bug fixes",
                    },
                    new Duty
                    {
                        Description = "Reviewed code written by other developers in peer review, pointing out potential bugs, optimizations, and styling fixes",
                    },
                    new Duty
                    {
                        Description = "Full stack developer: worked on back-end .NET Framework / .NET Core / C# and SQL Server, Entity Framework, Azure-hosted app, web and SQL servers, front-end HTML, CSS, JavaScript, jQuery, and Angular / TypeScript",
                    },
                    new Duty
                    {
                        Description = "Developed core logic / framework code, client specific code, app extensions etc.",
                    },
                    new Duty
                    {
                        Description = "Developed and improved tools used to design pages / sections / mappers / forms that form our web application, including designing and coding brand new modules to our tools",
                    },
                    new Duty
                    {
                        Description = "Developed schema update scripts, views, stored procedures, etc.",
                    },
                    new Duty
                    {
                        Description = "Azure: worked with Azure-hosted app, web, and SQL servers",
                    },
                    new Duty
                    {
                        Description = "Designed and coded static HTML templates and CSS styling",
                    },
                    new Duty
                    {
                        Description = "Developed JavaScript front-end functionality that communicates with C# back-end\r\n",
                    },
                    new Duty
                    {
                        Description = "Developed and tested jQuery included in JS for manipulating DOM\r\n",
                    },
                    new Duty
                    {
                        Description = "Designed and developed more modern / updated UI using Angular and TypeScript",
                    },
                    new Duty
                    {
                        Description = "Handled debugging for support cases, diagnosing and fixing bugs, fixing data in SQL Server, deploying patches to production sites",
                    },
                    new Duty
                    {
                        Description = "SQL Server, deploying patches to production sites",
                    },
                ],
                StartDate = new DateTime(year: 2015, month: 02, day: 1),
                EndDate = new DateTime(year: 2021, month: 09, day: 1),
            },
            new Job
            {
                Title = "Programmer Analyst",
                Company = "Fairfax Data Systems",
                Summary = "",
                SkillsUsed = [],
                Duties =
                [
                    new Duty
                    {
                        Description = "Developed custom DLLs, scripts within Microsoft .NET environment (C#, VB.NET, VBScript) to supplement Datacap / FileNet OOTB solutions, worked with custom FileNet objects",
                    },
                    new Duty
                    {
                        Description = "Provided client with custom DLLs developed with C#, and accompanying documentation",
                    },
                    new Duty
                    {
                        Description = "Developed Datacap applications based on specific client requirements",
                    },
                    new Duty
                    {
                        Description = "Configured FileNet and WorkplaceXT for client to search and modify documents",
                    },
                ],
                StartDate = new DateTime(year: 2013, month: 05, day: 1),
                EndDate = new DateTime(year: 2014, month: 10, day: 1),
            },
            new Job
            {
                Title = "Senior Blazor Developer",
                Company = "AmericanEagle.com",
                Summary = "",
                SkillsUsed = [],
                Duties =
                [
                    new Duty
                    {
                        Description = "Develop services backend using AWS Lambda, Amplify, ASP.NET Core",
                    },
                    new Duty
                    {
                        Description = "Develop web frontend using React",
                    },
                    new Duty
                    {
                        Description = "Collaborate using Jira, Azure DevOps, and Git",
                    },
                    new Duty
                    {
                        Description = "Manage code branches, merges, and cherry-picks",
                    },
                    new Duty
                    {
                        Description = "Review code submitted by other developers",
                    },
                ],
                StartDate = new DateTime(year: 2022, month: 04, day: 1),
                EndDate = new DateTime(year: 2022, month: 09, day: 1),
            },
            new Job
            {
                Title = "Full Stack Developer",
                Company = "Fusion Worldwide",
                Summary = "",
                SkillsUsed = [],
                Duties =
                [
                    new Duty
                    {
                        Description = "",
                    },
                ],
                StartDate = new DateTime(year: 2022, month: 09, day: 1),
                PresentlyEmployed = true,
            },
            new Job
            {
                Title = "Senior Software Engineer",
                Company = "LTi Technology Solutions",
                Summary = "",
                SkillsUsed = [],
                Duties =
                [
                    new Duty
                    {
                        Description = "Developed full stack lease management application, including client, web API / services, and database, written with C# / VB.NET, MS SQL Server, and WPF / XAML.",
                    },
                ],
                StartDate = new DateTime(year: 2021, month: 09, day: 1),
                EndDate = new DateTime(year: 2022, month: 04, day: 1),
            },
        ],
    };

    private class ResumeModel
    {
        public string? Name { get; set; }

        public string? Email { get; set; }

        public string? Summary { get; set; }

        public List<Skill>? Skills { get; set; }

        public List<Job>? Jobs { get; set; }
    }

    private class Skill
    {
        public string? Name { get; set; }

        public string? Description { get; set; }
    }

    private class Job
    {
        public string? Email { get; set; }

        public string? Phone { get; set; }

        public string? Address { get; set; }

        public string? Summary { get; set; }

        public string? Title { get; set; }

        public string? Company { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public List<Skill>? SkillsUsed { get; set; }

        public List<Duty>? Duties { get; set; }

        public bool PresentlyEmployed { get; set; }
    }

    private class Duty
    {
        public string? Description { get; set; }
    }

    private static class Skills
    {
        public static Skill DotNetCore = new()
        {
            Name = ".NET Core",
            Description = "",
        };

        public static Skill VisualStudio = new()
        {
            Name = "Visual Studio",
            Description = "",
        };

        public static Skill AspNet = new()
        {
            Name = "ASP.Net",
            Description = "",
        };

        public static Skill Blazor = new()
        {
            Name = "Blazor",
            Description = "",
        };

        public static Skill MudBlazor = new()
        {
            Name = "MudBlazor",
            Description = "",
        };

        public static Skill DotNetMaui = new()
        {
            Name = ".NET MAUI",
            Description = "",
        };

        public static Skill MsSqlServer = new()
        {
            Name = "MS SQL Server",
            Description = "",
        };

        public static Skill Sql = new()
        {
            Name = "SQL",
            Description = "",
        };

        public static Skill Html = new()
        {
            Name = "HTML",
            Description = "",
        };

        public static Skill Css = new()
        {
            Name = "CSS",
            Description = "",
        };

        public static Skill JavaScript = new()
        {
            Name = "JavaScript",
            Description = "",
        };
    }
}
