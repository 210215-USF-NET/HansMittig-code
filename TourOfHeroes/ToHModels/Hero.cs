﻿using System;
/*
Class members:
in java:
    fields, constructors, methods, getters & setters
in C#:
    fields, properties, methods, constructors
    fields - characteristics of your object
    methods - behavior of your object
    constructors - special method that gets called when you create an instance of an object
    - if there exists no constructor, there's a default one that gets created for you
    properties - "smart fields"
        - in Java you need to have a field for a getter and setter to exist
        - wrapper for a field, works as a getter and setter for a private backing field,
POCO - plain C# object
    - class that holds data
*/

namespace ToHModels
{
    /// <summary>
    /// Dara structure used for modeling a hero.
    /// </summary>
    public class Hero
    {
        private String heroName; 

        public String HeroName
        {
        get{return heroName;}
        set 
        {
            if(value == null || value.Equals("") ) 
            {throw new ArgumentNullException("Hero name can't be empty or null.");
            } // TODO:
            heroName = value;

        }
    }

    public int HP {get; set;}

    public Element ElementType {get; set;}

    public SuperPower SuperPower {get; set;}

    public override string ToString() => $"Hero Details: \n\t name: {this.HeroName} \n\t hp: {this.HP} \n\t element: {this.ElementType} \n\t superpower: {this.SuperPower.ToString()}";

    }
}
