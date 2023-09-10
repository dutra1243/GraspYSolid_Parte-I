//-------------------------------------------------------------------------
// <copyright file="Recipe.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------

using System;
using System.Collections;

namespace Full_GRASP_And_SOLID.Library
{
    public class Recipe
    {
        private ArrayList steps = new ArrayList();

        public Product FinalProduct { get; set; }

        /*
        Recipe es la clase que tiene accesso a todas la etapas de una determinada receta
        por lo tanto se le asigna la responsabilidad de conocer el costo total de la receta
        */
        public double TotalCost
        {
            get
            {
                return TotalCost;
            }
            set
            {
                foreach (Step step in this.steps)
                {
                    TotalCost = step.StepCost;
                }
            }
        }

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }

        public void PrintRecipe()
        {
            Console.WriteLine($"Receta de {this.FinalProduct.Description}:");
            foreach (Step step in this.steps)
            {
                Console.WriteLine($"{step.Quantity} de '{step.Input.Description}' " +
                    $"usando '{step.Equipment.Description}' durante {step.Time}" +
                    $"y todo eso cuesta {step.StepCost} ");
            }
            Console.WriteLine($"El costo total de la receta es: {TotalCost}");
        }
    }
}