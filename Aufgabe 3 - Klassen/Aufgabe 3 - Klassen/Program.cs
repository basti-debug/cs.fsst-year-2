using System;
using Aufgabe_3___Klassen.mainclasses;

namespace Aufgabe_3___Klassen
{
 
    internal class Program
    {

        static void Main(string[] args)
        {
            // configs
            int teachers = 1;
            int students = 10;

            #region registerNames

            Professor richart = new Professor();
            richart.firstName = "Richart";
            richart.lastName = "Lugner";
            richart.sex = "men";

            Student NM = new Student();
            NM.firstName = "Nico";
            NM.lastName = "Maltera";

            Student JR = new Student();
            JR.firstName = "Joel";
            JR.lastName = "Richardini";

            Student SS = new Student();
            SS.firstName = "Stefan";
            SS.lastName = "Subaru";

            Student SR = new Student();
            SR.firstName = "Stefan";
            SR.lastName = "Raab";

            Student GS = new Student();
            GS.firstName = "Gzstav";
            GS.lastName = "Slakowic";

            Student AS = new Student();
            AS.firstName = "Arda";
            AS.lastName = "Subawu";

            Student HE = new Student();
            HE.firstName = "Hubert";
            HE.lastName = "Eberhatl";

            Student RG = new Student();
            RG.firstName = "Robert";
            RG.lastName = "Gunter";

            Student WE = new Student();
            WE.firstName = "Walter";
            WE.lastName = "Ebenda";

            Student SD = new Student();
            SD.firstName = "Subarta";
            SD.lastName = "Daniala";

            #endregion

            #region arrayfill 

            string[] classlist = new string[(teachers + students)];

            classlist[0] = richart.nicefullName();

            classlist[1] = NM.fullName();
            classlist[2] = JR.fullName();
            classlist[3] = SS.fullName();
            classlist[4] = SR.fullName();
            classlist[5] = GS.fullName();
            classlist[6] = AS.fullName();
            classlist[7] = HE.fullName();
            classlist[8] = RG.fullName();
            classlist[9] = WE.fullName();
            classlist[10] = SD.fullName();


            #endregion

            #region outputs

            Console.WriteLine("Klasse :");
            Console.WriteLine("-----------");
            Console.WriteLine("Lehrpersonen: " + classlist[0]);
            Console.WriteLine(" ");
            Console.WriteLine("Schülerinnen: ");

            for (int i = 1; i < classlist.Length-1; i++)
            {
                Console.WriteLine(classlist[i]);
            }

            #endregion


            Console.ReadKey();
        }
    }
}
