using System;
using System.Collections.Generic;
using FigureAreaCalculator.Figures;

namespace FigureAreaCalculator
{
    public class FigureCreator
    {
        public static Figure Create(Dictionary<string, double> param)
        {
            if (param.ContainsKey(Parameters.Radius))
            {
                return new Circle(param[Parameters.Radius]);
            }

            if (param.ContainsKey(Parameters.EdgeA))
            {
                if (param.ContainsKey(Parameters.EdgeB)) 
                {
                    if (param.ContainsKey(Parameters.EdgeC)) 
                        return new Triangle(param[Parameters.EdgeA], param[Parameters.EdgeB], param[Parameters.EdgeC]);

                    return new Rectangle(param[Parameters.EdgeA], param[Parameters.EdgeB]);
                }

                return new Square(param[Parameters.EdgeA]);
            }
            
            throw new Exception("Undefined figure");
        }
    }
}
