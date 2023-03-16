using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PROG6221_ICE1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Scripts scripts = new Scripts();
            //scripts.numScripts();
            //scripts.questionCount();
            //scripts.question_Subtotal();
            //scripts.num_Lecturers();

            Console.WriteLine(scripts.numScripts());
            Console.WriteLine(scripts.questionCount());
            Console.WriteLine(scripts.question_Subtotal());
            Console.WriteLine(scripts.num_Lecturers());
        }
    }
}
class Scripts
{
    private int total_Num_Scripts;
    private int num_Questions;
    private int lecture_Count;
    private int time_Per_Tick = 60;

    public int numScripts()
    {
        Console.Write("Enter number of scripts to be marked: ");
        total_Num_Scripts = Convert.ToInt32(Console.ReadLine());

        if (total_Num_Scripts == 0)
        {
            Console.WriteLine("Please enter a value greater than 0.");
        }

        return total_Num_Scripts;
    }
    public int questionCount()
    {

        Console.Write("Enter the number of questions in the scripts: ");
        num_Questions = Convert.ToInt32(Console.ReadLine());

        while (num_Questions < 1)
        {
            Console.WriteLine("Please enter a value greater than 0.");
            num_Questions = Convert.ToInt32(Console.ReadLine());
        }

        return num_Questions;

    }
    public int question_Subtotal()
    {
        int num = 0;
        int tot = 0;
        while (num < num_Questions )
        {
            int subTot = Convert.ToInt32(Console.ReadLine());
            while(subTot < 1)
            {
                Console.WriteLine("...");
                Console.ReadLine();
            }
              tot += subTot;

            num++;
        }
        return tot;
        
    }
    public int num_Lecturers()
    {
        Console.WriteLine("Please enter the number of lecturers marking the scripts: ");
        lecture_Count = Convert.ToInt32(Console.ReadLine());
    }
    public void displayMethod(int total_Num_Scripts, int num_Questions, int subTot, int tot, int lecture_Count, int time_Per_Tick)
    {
        int num_Scripts = total_Num_Scripts / lecture_Count;
        int question_Count = num_Questions * num_Scripts;
        int total_Time = time_Per_Tick * question_Count;
        float time = total_Time / time_Per_Tick;


        Console.WriteLine("Each lecturer will need to mark: " + num_Scripts + " of scripts.");
        Console.WriteLine("Each lecturer will have " + num_Scripts + " of questions to mark.");
        Console.WriteLine("Each lecturer will take " + time + "hours to mark all of the tests.");
    }
}