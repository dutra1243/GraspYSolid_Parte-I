//-------------------------------------------------------------------------------
// <copyright file="Step.cs" company="Universidad Católica del Uruguay">
// Copyright (c) Programación II. Derechos reservados.
// </copyright>
//-------------------------------------------------------------------------------

namespace Full_GRASP_And_SOLID.Library
{
    public class Step
    {
        public Step(Product input, double quantity, Equipment equipment, int time)
        {
            this.Quantity = quantity;
            this.Input = input;
            this.Time = time;
            this.Equipment = equipment;
        }

        public Product Input { get; set; }

        public double Quantity { get; set; }

        public int Time { get; set; }

        public Equipment Equipment { get; set; }

        /*
        Step es la clase que posue todas las informaciones necesárias para
        calcular el costo de un insumo y el costo de equipamento utilizado.
        Por lo tanto, por medio de Expert se le asigna la responsabilidad de
        saber el costo de las etapas de una receta.
        */
        public double StepCost
        {
            get
            {
                return StepCost;
            }
            set
            {
                StepCost = this.Quantity * Input.UnitCost + Equipment.HourlyCost*(this.Time / 60);
            }
        }

    }
}