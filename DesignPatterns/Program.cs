﻿using DesignPatterns.AbstractFactory;
using DesignPatterns.Builder;
using DesignPatterns.Composite;
using DesignPatterns.Dinosaur;
using DesignPatterns.FactoryMethod;
using System;
using System.Collections.Generic;

namespace DesignPatterns
{
    class Program
    {
        static void Main(string[] args)
        {
            CompositeExample();
        }

        public static void AbstractFactoryExamples(string dinosaurType)
        {
            IDinosaurNoiseProducer af1 = new AbstractFactory.DinosaurNoiseProducer(new DinosaurFactory(dinosaurType));
            af1.MakeADinosaurNoise();
        }

        public static void FactoryMethodExamples()
        {
            IDinosaurNoiseProducer fm1 = new TRexNoiseProducer();
            fm1.MakeADinosaurNoise();

            IDinosaurNoiseProducer fm2 = new StegosaurusNoiseProducer();
            fm2.MakeADinosaurNoise();
        }

        static void CreateAMealExample()
        {
            var meal = new Meal();

            meal.Starter = "a few green leaves";
            meal.MainCourse = "a huge plate of ferns";
            meal.SetDessert("fruit and berries");

            meal.ServeMeal();
        }

        public static void BuilderExample()
        {
            MealBuilder builder = new StegosaurusMealBuilder();
            Meal meal = builder.BuildMeal();

            meal.ServeMeal();
        }

        public static void CompositeExample()
        {
            var plants = new List<IPlant>();

            var branch = new Branch(2);
            var anotherBranch = new Branch(4);

            plants.Add(new Tree(
                new List<Branch>()
                    { branch, anotherBranch }
            ));

            plants.Add(new Leaf());
            plants.Add(new Branch(5));
            plants.Add(new Leaf());

            foreach (IPlant plant in plants)
            {
                plant.Eat();
            }
            
        }
    }
}
