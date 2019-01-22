using System;
using System.Collections.Generic;
using System.Linq;

namespace Lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Домашнее задание
            // Создать базу данных на основе своей предметной области с помощью Code First.
            // Реализовать запись, чтение, изменение и удаление данных.

            using (var context = new MyDbContext())
            {
                var group = new Group()
                {
                    Name = "Rammstain",
                    Year = 1994
                };
                var group2 = new Group()
                {
                    Name = "Linkin Park"
                };

                context.Groups.Add(group);
                context.Groups.Add(group2);
                context.SaveChanges();


                var songs = new List<Song>()
                {
                    new Song() { Name = "In the end", GroupId = group2.Id },
                    new Song() { Name = "Numb", GroupId = group2.Id},
                    new Song() {Name = "Mutter", GroupId = group.Id}
                };
                context.Songs.AddRange(songs);
                context.SaveChanges();

                var s = context.Groups.Single(x => x.Id == group.Id);
                s.Name = "jjklasf";
                context.SaveChanges();

                foreach (var song in songs)
                {
                    Console.WriteLine($"Song name: {song.Name}, Group name: {song.Group.Name}");
                }
                Console.ReadLine();
            }
        }
    }
}
