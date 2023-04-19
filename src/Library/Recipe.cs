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

        public void AddStep(Step step)
        {
            this.steps.Add(step);
        }

        public void RemoveStep(Step step)
        {
            this.steps.Remove(step);
        }
        
        public string Text()
        {
            string result="";
            foreach(Step step in this.steps)
            {
                result+= step.Text() +" \n";
            }
            return result;
        }
        /*
        public string Text() se encuentra en esta clase ya que es la que conoce los steps
        que se agregan o eliminan
        */
    }
}