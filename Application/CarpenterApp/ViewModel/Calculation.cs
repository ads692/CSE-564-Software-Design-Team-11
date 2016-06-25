using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpenterApp.ViewModel
{
    class Calculation
    {
        public double cube1_side_length(double length)
        {
            double sidelength = length / 12;
            return sidelength;
        }

        public double cubevolume(double length)
        {
            double sidelength = length / 12;
            double sidesquared = Math.Pow(sidelength, 2);
            double area = 6 * sidesquared;
            double volume = Math.Pow(area, 3);
            return volume;
        }

        public double[] cube2_side_length(double length, double a, double b)
        {

            double sidelength1 = (length + 8 * a + 8 * b) / 12;  //4 pieces of this length

            double sidelength2 = (length - (16 * b) + 8 * a) / 12;   //4 pieces of this length

            double sidelength3 = (length + 8 * b - (16 * a)) / 12;   //4 pieces of this length

            double[] sidelengths = { sidelength1, sidelength2, sidelength3 };

            return sidelengths;
        }


        public double[] cube3_side_length(double length, double a, double b)
        {

            double sidelength1 = (length + 8 * b + 8 * a) / 12;  //4 pieces of this length

            double sidelength2 = (length - (16 * a) + 8 * b) / 12;   //4 pieces of this length

            double sidelength3 = (length + 8 * a - (16 * b)) / 12;   //4 pieces of this length

            double[] sidelengths = { sidelength1, sidelength2, sidelength3 };

            return sidelengths;
        }

        public double triangle_pyramid_sidelength(double length)
        {
            double sidelength = length / 6;
            return sidelength;
        }

        public double triangular_pyramidvolume_(double length)
        {
            double sidelength = length / 6;
            double basearea = (Math.Sqrt(3) / 4) * sidelength * sidelength;
            double height = (Math.Sqrt(6) / 3) * sidelength;
            double volume = (basearea * height) / 3;
            return volume;
        }

        public double square_pyramid_sidelength(double length)
        {
            double sidelength = length / 8;
            return sidelength;
        }

        public double rectangular_pyramidvolume_(double length)
        {
            double sidelength = length / 8;
            double sidesquared = Math.Pow(sidelength, 2);
            double diagonal = Math.Sqrt(sidesquared + sidesquared);
            double height = Math.Sqrt(sidesquared - Math.Pow(diagonal / 2, 2));
            double volume = (sidesquared * height) / 3;
            return volume;
        }
    }
}
