using EdAcademy.Model;
using EdAcademy.Model.Bd;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Diagnostics;

namespace EdAcademy
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var service = new ServiceCollection()
               .AddDbContext<EdDbContexts>()
               .BuildServiceProvider();

            var dbContext = service.GetRequiredService<EdDbContexts>();

            Application.Run(new Form1());
           


    }
    }
}