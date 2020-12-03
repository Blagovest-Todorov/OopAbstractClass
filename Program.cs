using System;

namespace _25.AbstractClass
{
    //class Program
    //{
    //    static void Main(string[] args)
    //    {
    //       // Abstract class  can never be instantiated, no instance made ! 
    //       // and abstract class is marked with keyword abstract ! 
    //      // Abstract Class should have a minimum of one abstrasct method!  
    //      //  abstract class can not have an instance !!!!can not be instantiated !!! 
    //       // Abstract Class  can be inherited, but can not have an instance ! 
    //       // abstract class is much like an base class that is designed to be inherited  by subclasses that
    //      // either implement or override its methods
    //    }
    //}

     public abstract class Tutorial
     {
        public virtual void Set(int pID, string pName)  //virtual--this means that the method can not be changed by the child class;
        {  // basic requrement for any abstract class , the method to be virtual-can not be change by any further child class! 

        }
     }

    public class Guru99Tutorial : Tutorial
    {
        protected int TutorialID;
        protected string TutorialName;

        public void SetTutorial(int pID, string pName ) 
        {
            TutorialID = pID;
            TutorialName = pName;
        }

        public string GetTutorial() 
        {
            return TutorialName;
        }

        static void Main(string[]args) 
        {
            Guru99Tutorial pTutor = new Guru99Tutorial();
            pTutor.Set(1, ".Net");
            Console.WriteLine(pTutor.GetTutorial());
        }
    
    }
    
   
}

