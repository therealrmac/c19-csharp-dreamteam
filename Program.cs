using System;
using System.Collections.Generic;
using System.Linq;

namespace dreamteam
{
    class Program
    {
        static void Main(string[] args)
        {
            Adam adam_clientSide = new Adam();
            Aarti aarti_clientSide= new Aarti();
            Tamela tamela_clientSide = new Tamela();
            Jason jason_serverSide= new Jason();
            Ryan ryan_serverSide = new Ryan();
            Eliza eliza_serverSide = new Eliza();

            Console.WriteLine("CLIENT SIDE:");
            List<ITeamMember> clientSide= new List<ITeamMember>();
            clientSide.Add(adam_clientSide);
            clientSide.Add(aarti_clientSide);
            clientSide.Add(tamela_clientSide);
            foreach(var x in clientSide){
                Console.WriteLine(x.fullName);
                x.work();
            }

            Console.WriteLine("");
            List<ITeamMember> serverSide= new List<ITeamMember>();
            serverSide.Add(jason_serverSide);
            serverSide.Add(ryan_serverSide);
            serverSide.Add(eliza_serverSide);

            Console.WriteLine("SERVER SIDE:");
            foreach(var x in serverSide){
                Console.WriteLine(x.fullName);
                x.work();
            }

        }
        public interface ITeamMember{
            string firstName {get; set;}
            string lastName {get; set;}
            string fullName {get;}
            string speciality {get; set;}
            void work();
        }
           public class Adam : ITeamMember{
           public string firstName {get; set;}= "Adam";
           public string lastName {get; set;}= "Reidelbach";
           public string fullName {
               get{
                   return this.firstName + " " +this.lastName;
                }
           }
           public string speciality {get; set;}="Javascript";
           public void work(){
                Console.WriteLine("Adam likes to joke and lighten the mood in a group to help keep morale up.");
            }
        }
           public class Aarti : ITeamMember{
           public string firstName {get; set;}= "Aarti";
           public string lastName {get; set;}= "Jaisinghani";
           public string fullName {
               get{
                   return this.firstName + " " + this.lastName;
                }
           }
           public string speciality {get; set;}="c#";
           public void work(){
                Console.WriteLine("Aarti is a very persistent developer that doesn't shy away from a challegne.");
            }
        }
           public class Tamela : ITeamMember{
           public string firstName {get; set;}= "Tamela";
           public string lastName {get; set;}= "Lerma";
           public string fullName {
               get{
                   return this.firstName + " " + this.lastName;
                }
           }
           public string speciality {get; set;}="css and Angular";
           public void work(){
                Console.WriteLine("Tamela stops at nothing to get the job done, her determination often yields great results.");
            }
        }
           public class Ryan : ITeamMember{
           public string firstName {get; set;}= "Ryan";
           public string lastName {get; set;}= "McCarty";
           public string fullName {
               get{
                   return this.firstName + " " + this.lastName;
                }
           }
           public string speciality {get; set;}="c#";
           public void work(){
                Console.WriteLine("Ryan is a natural born leader. He sets by example and helps inspire those around him.");
            }
        }

        public class Jason : ITeamMember{
           public string firstName {get; set;}= "Jason";
           public string lastName {get; set;}= "Smith";
           public string fullName {
               get{
                   return this.firstName + " " + this.lastName;
                }
           }
           public string speciality {get; set;}="Angular";
           public void work(){
                Console.WriteLine("Jason is a bit of a lone wolf, he thrives on his own skills and brings a high level of expectation to his team.");
            }
        }
           public class Eliza : ITeamMember{
           public string firstName {get; set;}= "Eliza";
           public string lastName {get; set;}= "Meeks";
           public string fullName {
               get{
                   return this.firstName + " " + this.lastName;
                }
           }
           public string speciality {get; set;}="css and Javascript";
           public void work(){
                Console.WriteLine("Eliza works fast and gets results even faster.  She is very knowledgeable and can explain complicated things to her teammates with ease.");
            }
        }

    }
}
