namespace aboutme.library.Pages;

public partial class Resume
{
    private readonly ResumeModel? resumeModel = new()
    {
        Name = "Michael Bond",
        Email = "michael@bondcodes.com",
        Summary = "Web / Windows / C# / ASP / .NET Developer",
        Skills = new List<Skill>
        {
            new Skill
            {
                Name = ".NET Core",
                Description = "",
            },
            new Skill
            {
                Name = "Visual Studio",
                Description = "",
            },
            new Skill
            {
                Name = "ASP.Net",
                Description = "",
            },
            new Skill
            {
                Name = "Blazor",
                Description = "",
            },
            new Skill
            {
                Name = "MudBlazor",
                Description = "",
            },
            new Skill
            {
                Name = ".NET MAUI",
                Description = "",
            },
            new Skill
            {
                Name = "MS SQL Server",
                Description = "",
            },
            new Skill
            {
                Name = "SQL",
                Description = "",
            },
            new Skill
            {
                Name = "HTML",
                Description = "",
            },
            new Skill
            {
                Name = "CSS",
                Description = "",
            },
            new Skill
            {
                Name = "JavaScript",
                Description = "",
            },
        },
        Jobs = new List<Job>
        {
            new Job
            {
                Title = "Software Developer",
                Company = "3 Story Software",
                Summary = "",
                Duties = new List<Duty>
                {
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
                },
                StartDate = new DateTime(year: 2015, month: 02, day: 1),
                EndDate = new DateTime(year: 2021, month: 09, day: 1),
            },
            new Job
            {
                Title = "Programmer Analyst",
                Company = "Fairfax Data Systems",
                Summary = "",
                Duties = new List<Duty>
                {
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
                },
                StartDate = new DateTime(year: 2013, month: 05, day: 1),
                EndDate = new DateTime(year: 2014, month: 10, day: 1),
            },
            new Job
            {
                Title = "Senior Blazor Developer",
                Company = "AmericanEagle.com",
                Summary = "",
                Duties = new List<Duty>
                {
                    new Duty
                    {
                        Description = "",
                    },
                },
                StartDate = new DateTime(year: 2022, month: 04, day: 1),
                EndDate = new DateTime(year: 2022, month: 09, day: 1),
            },
            new Job
            {
                Title = "Full Stack Developer",
                Company = "Fusion Worldwide",
                Summary = "",
                Duties = new List<Duty>
                {
                    new Duty
                    {
                        Description = "",
                    },
                },
                StartDate = new DateTime(year: 2022, month: 09, day: 1),
                PresentlyEmployed = true,
            },
        },
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
        public List<Duty>? Duties { get; set; }
        public bool PresentlyEmployed { get; set; }
    }

    private class Duty
    {
        public string? Description { get; set; }
    }
}
