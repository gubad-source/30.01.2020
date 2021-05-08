using System;
using System.Collections.Generic;
using System.Text;

namespace OutRef
{
    public class Animal
    {
        public virtual string Sound()
        {
            return "Makes Sound";
        }
        //    public readonly int _age;

        //    public Animal(int age)
        //    {
        //        _age = age;
        //    }
        //#region Field
        //private string _class;

        //#endregion

        //#region Property
        //public string Class {
        //    get {
        //        return _class;
        //    }
        //    set {
        //        if (value == "Human" || value=="Whale")
        //        {
        //            throw new Exception("It cannot be human or whale");
        //        }
        //        else
        //        {
        //            _class = value;
        //        }
        //    }
        //}
        //public int Age { get; set; }
        //#endregion

        //#region Methods
        //public void Mymethod()
        //{
        //    Console.WriteLine("It's an animal which can be kept in zoo");
        //}
        //#endregion

        //public Animal(int age)
        //{
        //    this.Age = age;
        //}
    }
}
