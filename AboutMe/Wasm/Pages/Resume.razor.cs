namespace AboutMe.Wasm.Pages;

// ReSharper disable once UnusedType.Global
public partial class Resume
{
    private readonly ResumeModel resumeModel = new()
    {
        Name = "Michael Bond",
        Email = "michael@bondcodes.com",
        Summary = "Web / Windows / C# / ASP / .NET Developer",
        ResumeSkills = [],
        Jobs =
        [
            new()
            {
                Title = "Senior Software Developer I",
                Company = "SETWorks",
                CompanyUrl = "https://set-works.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
                SkillsUsed =
                [
                    Skills.DotNetCore,
                    Skills.VisualStudio,
                    Skills.AspNet,
                    Skills.Blazor,
                    Skills.MsSqlServer,
                    Skills.Sql,
                    Skills.Html,
                    Skills.Css,
                    Skills.Git,
                    Skills.TelerikBlazor,
                    Skills.DotNetFramework
                ],
                Duties =
                [
                    new()
                    {
                        Description =
                            "Build out Blazor server-side application with clean architecture and modular monolith structures"
                    },
                    new()
                    {
                        Description =
                            "Leverage code generation and XML templates to build modules"
                    },
                    new()
                    {
                        Description =
                            "Create relational databases in SQL Server using XML templates and custom code"
                    },
                    new()
                    {
                        Description =
                            "Build on and use custom CRM"
                    }
                ],
                StartDate = new(2025, 05, 12),
                EndDate = new(2025, 07, 11),
                PresentlyEmployed = false
            }, // SETWorks
            new()
            {
                Title = "Full Stack Developer",
                Company = "Fusion Worldwide",
                CompanyUrl = "https://www.fusionww.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
                SkillsUsed =
                [
                    Skills.AzureDevOps,
                    Skills.DotNetCore,
                    Skills.VisualStudio,
                    Skills.MsSqlServer,
                    Skills.Sql,
                    Skills.Html,
                    Skills.Css,
                    Skills.JavaScript,
                    Skills.Git,
                    Skills.Blazor,
                    Skills.MudBlazor,
                    Skills.TelerikBlazor,
                    Skills.DotNetFramework,
                    Skills.WindowsForms,
                    Skills.TailwindCss
                ],
                Duties =
                [
                    new()
                    {
                        Description =
                            "Read and convert .NET Framework code from WinForms app and translate logic to apply to ASP.NET Core web app using Blazor"
                    },
                    new()
                    {
                        Description =
                            "Reviewed code written by other developers in peer review, pointing out potential bugs, optimizations, and styling fixes"
                    },
                    new()
                    {
                        Description = "Azure: worked with Azure-hosted app, web, and SQL servers"
                    },
                    new()
                    {
                        Description =
                            "Work in an agile development environment, managing feature branches and feature flags"
                    },
                    new()
                    {
                        Description =
                            "Created new APIs, extensions, and source generators to streamline code and simplify tasks"
                    },
                    new()
                    {
                        Description =
                            "Use MudBlazor and Tailwind CSS to design a pleasant and responsive user experience"
                    }
                ],
                StartDate = new(2022, 09, 1),
                EndDate = null,
                PresentlyEmployed = true
            }, // Fusion Worldwide
            new()
            {
                Title = "Software Developer",
                Company = "3 Story Software",
                CompanyUrl = "https://www.3storysoftware.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
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
                    Skills.Git
                ],
                Duties =
                [
                    new()
                    {
                        Description =
                            "Full stack developer: worked on back-end .NET Framework / .NET Core / C# and SQL Server, Entity Framework, Azure-hosted app, web and SQL servers, front-end HTML, CSS, JavaScript, jQuery, and Angular / TypeScript"
                    },
                    new()
                    {
                        Description =
                            "Designed and developed workforce management web application, supported across the globe"
                    },
                    new()
                    {
                        Description =
                            "Designed high-level solutions as well as in-depth technical requirements for new feature requests and bug fixes"
                    },
                    new()
                    {
                        Description =
                            "Reviewed code written by other developers in peer review, pointing out potential bugs, optimizations, and styling fixes"
                    },
                    new()
                    {
                        Description =
                            "Developed core logic / framework code, client specific code, app extensions etc."
                    },
                    new()
                    {
                        Description =
                            "Developed and improved tools used to design pages / sections / mappers / forms that form our web application, including designing and coding brand new modules to our tools"
                    },
                    new()
                    {
                        Description = "Developed schema update scripts, views, stored procedures, etc."
                    },
                    new()
                    {
                        Description = "Azure: worked with Azure-hosted app, web, and SQL servers"
                    },
                    new()
                    {
                        Description = "Designed and coded static HTML templates and CSS styling"
                    },
                    new()
                    {
                        Description =
                            "Developed JavaScript front-end functionality that communicates with C# back-end"
                    },
                    new()
                    {
                        Description = "Developed and tested jQuery included in JS for manipulating DOM"
                    },
                    new()
                    {
                        Description = "Designed and developed more modern / updated UI using Angular and TypeScript"
                    },
                    new()
                    {
                        Description =
                            "Handled debugging for support cases, diagnosing and fixing bugs, fixing data in SQL Server, deploying patches to production sites"
                    },
                    new()
                    {
                        Description = "SQL Server, deploying patches to production sites"
                    }
                ],
                StartDate = new(2015, 02, 1),
                EndDate = new DateTime(2021, 09, 1),
                PresentlyEmployed = false
            }, // 3 Story Software
            new()
            {
                Title = "Senior Blazor Developer",
                Company = "AmericanEagle.com",
                CompanyUrl = "https://www.americaneagle.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
                SkillsUsed =
                [
                    Skills.AspNet,
                    Skills.DotNetCore,
                    Skills.VisualStudio,
                    Skills.Html,
                    Skills.Css,
                    Skills.JavaScript,
                    Skills.Git,
                    Skills.AzureDevOps
                ],
                Duties =
                [
                    new()
                    {
                        Description = "Develop services backend using AWS Lambda, Amplify, ASP.NET Core"
                    },
                    new()
                    {
                        Description = "Develop web frontend using React"
                    },
                    new()
                    {
                        Description = "Collaborate using Jira, Azure DevOps, and Git"
                    },
                    new()
                    {
                        Description = "Manage code branches, merges, and cherry-picks"
                    },
                    new()
                    {
                        Description = "Review code submitted by other developers"
                    }
                ],
                StartDate = new(2022, 04, 1),
                EndDate = new DateTime(2022, 09, 1),
                PresentlyEmployed = false
            }, // AmericanEagle.com
            new()
            {
                Title = "Senior Software Engineer",
                Company = "LTi Technology Solutions",
                CompanyUrl = "https://www.ltisolutions.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
                SkillsUsed =
                [
                    Skills.Git,
                    Skills.DotNetCore,
                    Skills.VisualStudio,
                    Skills.Sql,
                    Skills.MsSqlServer,
                    Skills.AzureDevOps
                ],
                Duties =
                [
                    new()
                    {
                        Description =
                            "Developed full stack lease management application, including client, web API / services, and database, written with C# / VB.NET, MS SQL Server, and WPF / XAML."
                    }
                ],
                StartDate = new(2021, 09, 1),
                EndDate = new DateTime(2022, 04, 1),
                PresentlyEmployed = false
            }, // LTi Technology Solutions
            new()
            {
                Title = "Programmer Analyst",
                Company = "Fairfax Data Systems",
                CompanyUrl = "https://www.fairfaxdatasystems.com/",
                Summary = string.Empty,
                Email = null,
                Phone = null,
                Address = null,
                SkillsUsed =
                [
                    Skills.VisualStudio,
                    Skills.DotNetFramework
                ],
                Duties =
                [
                    new()
                    {
                        Description =
                            "Developed custom DLLs, scripts within Microsoft .NET environment (C#, VB.NET, VBScript) to supplement Datacap / FileNet OOTB solutions, worked with custom FileNet objects"
                    },
                    new()
                    {
                        Description =
                            "Provided client with custom DLLs developed with C#, and accompanying documentation"
                    },
                    new()
                    {
                        Description = "Developed Datacap applications based on specific client requirements"
                    },
                    new()
                    {
                        Description = "Configured FileNet and WorkplaceXT for client to search and modify documents"
                    }
                ],
                StartDate = new(2013, 05, 1),
                EndDate = new DateTime(2014, 10, 1),
                PresentlyEmployed = false
            } // Fairfax Data Systems
        ]
    };

    private List<Skill> SelectedSkills { get; } = [];

    protected override void OnInitialized()
    {
        base.OnInitialized();

        List<Skill> skillList =
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
            Skills.Git,
            Skills.AzureDevOps,
            Skills.TelerikBlazor,
            Skills.DotNetFramework,
            Skills.WindowsForms,
            Skills.TailwindCss
        ];

        foreach (var skill in skillList)
        {
            resumeModel.ResumeSkills.Add(skill with
            {
                TimeUsed = resumeModel.Jobs
                    .Where(j => j.SkillsUsed.Contains(skill))
                    .Aggregate(TimeSpan.Zero, (total, job) => total + (job.EndDate is null && job.PresentlyEmployed
                        ? DateTime.Now - job.StartDate
                        : (job.EndDate ?? DateTime.Now) - job.StartDate))
            });
        }
    }

    private void OnSelectSkill(Skill skill)
    {
        if (!SelectedSkills.Remove(skill))
        {
            SelectedSkills.Add(skill);
        }
    }

    private Color GetSkillColor(Skill skill) =>
        SelectedSkills.Contains(skill)
            ? Color.Primary
            : Color.Default;

    private void ClearSelectedSkills() => SelectedSkills.Clear();

    private readonly record struct ResumeModel
    {
        public required string Name { get; init; }

        public required string Email { get; init; }

        public required string Summary { get; init; }

        public required List<Skill> ResumeSkills { get; init; }

        public required List<Job> Jobs { get; init; }
    }

    private readonly struct Skill : IEquatable<Skill>
    {
        public required string Name { get; init; }

        // ReSharper disable once UnusedAutoPropertyAccessor.Local
        public string? Description { get; init; }

        public TimeSpan TimeUsed { get; init; }

        public string TimeUsedString =>
            TimeUsed.Humanize(2, maxUnit: TimeUnit.Year, minUnit: TimeUnit.Year);

        public string Title =>
            $"{(string.IsNullOrEmpty(Description) ? Name : Description)} {TimeUsedString}";

        public bool Equals(Skill other) =>
            string.Equals(Name, other.Name, StringComparison.Ordinal) &&
            string.Equals(Description, other.Description, StringComparison.Ordinal);

        public override bool Equals(object? obj) =>
            obj is Skill other && Equals(other);

        public override int GetHashCode() => HashCode.Combine(
            Name,
            Description
        );

        public static bool operator ==(Skill left, Skill right) => left.Equals(right);

        public static bool operator !=(Skill left, Skill right) => !left.Equals(right);
    }

    [SuppressMessage("ReSharper", "UnusedAutoPropertyAccessor.Local")]
    private readonly record struct Job
    {
        public string? Email { get; init; }

        public string? Phone { get; init; }

        public string? Address { get; init; }

        public required string Summary { get; init; }

        public required string Title { get; init; }

        public required string Company { get; init; }

        public string? CompanyUrl { get; init; }

        public required DateTime StartDate { get; init; }

        public DateTime? EndDate { get; init; }

        public List<Skill> SkillsUsed { get; init; }

        public required List<Duty> Duties { get; init; }

        public bool PresentlyEmployed { get; init; }

        private DateTime EffectiveEndDate => PresentlyEmployed || EndDate is null
            ? DateTime.Now
            : EndDate.Value;

        private TimeSpan TimeAtJob => EffectiveEndDate - StartDate;

        public string TimeAtJobString =>
            TimeAtJob.Humanize(2, maxUnit: TimeUnit.Year, minUnit: TimeUnit.Month);

        public string DatesString =>
            $"{StartDate:MMM yyyy} - {(EndDate is null ? "Present" : $"{EndDate:MMM yyyy}")} ({TimeAtJobString})";
    }

    private readonly record struct Duty
    {
        public required string Description { get; init; }
    }

    private static class Skills
    {
        public static readonly Skill DotNetCore = new()
        {
            Name = ".NET Core",
            Description = null
        };

        public static readonly Skill VisualStudio = new()
        {
            Name = "Visual Studio",
            Description = null
        };

        public static readonly Skill AspNet = new()
        {
            Name = "ASP.Net",
            Description = null
        };

        public static readonly Skill Blazor = new()
        {
            Name = "Blazor",
            Description = null
        };

        public static readonly Skill MudBlazor = new()
        {
            Name = "MudBlazor",
            Description = null
        };

        public static readonly Skill DotNetMaui = new()
        {
            Name = ".NET MAUI",
            Description = null
        };

        public static readonly Skill MsSqlServer = new()
        {
            Name = "MS SQL Server",
            Description = null
        };

        public static readonly Skill Sql = new()
        {
            Name = "SQL",
            Description = null
        };

        public static readonly Skill Html = new()
        {
            Name = "HTML",
            Description = null
        };

        public static readonly Skill Css = new()
        {
            Name = "CSS",
            Description = null
        };

        public static readonly Skill JavaScript = new()
        {
            Name = "JavaScript",
            Description = null
        };

        public static readonly Skill Git = new()
        {
            Name = "Git",
            Description = null
        };

        public static readonly Skill AzureDevOps = new()
        {
            Name = "Azure DevOps",
            Description = null
        };

        public static readonly Skill TelerikBlazor = new()
        {
            Name = "Telerik Blazor",
            Description = null
        };

        public static readonly Skill DotNetFramework = new()
        {
            Name = ".NET Framework",
            Description = null
        };

        public static readonly Skill WindowsForms = new()
        {
            Name = "Windows Forms",
            Description = null
        };

        public static readonly Skill TailwindCss = new()
        {
            Name = "Tailwind CSS",
            Description = null
        };
    }
}
