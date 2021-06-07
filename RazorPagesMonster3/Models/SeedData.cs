using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RazorPagesMonster3.Data;
using System;
using System.Linq;

namespace RazorPagesMonster3.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RazorPagesMonster3Context(
                serviceProvider.GetRequiredService<
                    DbContextOptions<RazorPagesMonster3Context>>()))
            {
                // Look for any monsters.
                if (context.Monster.Any())
                {
                    return;   // DB has been seeded
                }

                context.Monster.AddRange(
                    new Monster
                    {
                        MonsterName = "Flip Wilson",
                        ReleaseDate = DateTime.Parse("1970-3-1"),
                        Genre = "Dinosaurs",
                        Price = 434M
                    },

                    new Monster
                    {
                        MonsterName = "Terminator",
                        ReleaseDate = DateTime.Parse("1999-12-12"),
                        Genre = "Dragons",
                        Price = 523M
                    },

                    new Monster
                    {
                        MonsterName = "Dobby Puff",
                        ReleaseDate = DateTime.Parse("1943-1-11"),
                        Genre = "Dragsons",
                        Price = 210M
                    },

                    new Monster
                    {
                        MonsterName = "Bubba Gouché",
                        ReleaseDate = DateTime.Parse("2003-10-3"),
                        Genre = "Animated Food",
                        Price = 300M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
