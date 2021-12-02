using System;
namespace question_2
{
    public class marks
    {
                public float Subject_1;
        public float Subject_2;
        public float Subject_3;
        public void Sum(){
            float sum = Subject_1+Subject_2+Subject_3;
            Console.WriteLine("Sum of Subjects is = " + sum);
        }
        public void Average(){
            float avg = (Subject_1+Subject_2+Subject_3)/3;
            Console.WriteLine("Average of Subjects is = " + avg);

        }
    }
}