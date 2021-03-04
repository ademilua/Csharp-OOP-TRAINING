using System;
using System.Collections.Generic;

namespace OOP_TRAINING
{
    class Program
    {
        static void Main(string[] args)
        {

           
            
            List<Actor> actors = new List<Actor> { 
                new MovieActor("John", "Kennet"),
                new MovieActor("Tom", "Tom"),
                new MusicActor("Tred", "Las") };
            foreach (var actor in actors)
            {

                actor.Act();
                actor.Dance();
            };

            List<Developer> developers = new List<Developer> { 
                new WebDeveloper("Ted", "Dred", "C#"), 
                new WebDeveloper("Ben", "Robot", "Java") };
            foreach (var developer in developers)
            {
                developer.Code();
            };

            List<IDancer> dancers = new List<IDancer> {
                new WebDeveloper("Habort", "Thread", "V#"),
                new MovieActor("John", "Kennet") };
            foreach (var dancer in dancers)
            {
                dancer.Dance();
            };
            List<ITeacher> teachers = new List<ITeacher> { 
                new WebDeveloper("John", "Lies", "Html"), 
                new WebDeveloper("Dred", "Gay", "Php") };
             //ITeacher t = new WebDeveloper("Dred", "Gay", "Php");

            foreach (var teacher in teachers)
            {
                teacher.Teach();
            };
        }
    }
}
