using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnplashTest_78_Hung
{
    public class Quadratic_78_Hung
    {
        private double a_78_Hung, b_78_Hung, c_78_Hung; 
        public double A_78_Hung { get => a_78_Hung; set => a_78_Hung = value; }
        public double B_78_Hung { get => b_78_Hung; set => b_78_Hung = value; }
        public double C_78_Hung { get => c_78_Hung; set => c_78_Hung = value; }
        public Quadratic_78_Hung (double a, double b, double c)
        { 
            this.a_78_Hung = a;
            this.b_78_Hung = b;
            this.c_78_Hung = c;
        } 
        // Phương thức giải phương trình
        public string Solve_78_Hung()
        {
            double delta_78_Hung = this.Delta_78_Hung(); // Tính delta
            double x1_78_Hung, x2_78_Hung;

            if (a_78_Hung == 0)
            {
                if (b_78_Hung == 0)
                {
                    if (c_78_Hung == 0)
                    {
                        return "Phuong trinh vo so nghiem";
                    } 
                    return "Phuong trinh vo nghiem";
                }
                else
                {
                    return $"Phuong trinh co mot nghiem x = {-c_78_Hung / b_78_Hung}";
                }
            } 

            if (delta_78_Hung > 0) // Hai nghiệm phân biệt
            {
                x1_78_Hung = (-b_78_Hung + Math.Sqrt(delta_78_Hung)) / (2 * a_78_Hung);
                x2_78_Hung = (-b_78_Hung - Math.Sqrt(delta_78_Hung)) / (2 * a_78_Hung);
                return ($"Phuong trinh co hai nghiem phan biet x1 = {x1_78_Hung} x2 = {x2_78_Hung}");
            }
            else if (delta_78_Hung == 0) // Nghiệm kép
            {
                x1_78_Hung = -b_78_Hung / (2 * a_78_Hung);
                return ($"Phuong trinh co nghiem kep x = {x1_78_Hung}");
            }
            else // Không có nghiệm thực
            {
                return ("Phuong trinh vo nghiem");
            }
        } 
        // Tính Delta
        private double Delta_78_Hung()
        {
            return b_78_Hung * b_78_Hung - 4 * a_78_Hung * c_78_Hung;
        }
    }
}
