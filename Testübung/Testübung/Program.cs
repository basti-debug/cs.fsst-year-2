/* Beispielfragen 
 * 
 * Welche 4 Grundkonzepte der OOP haben wir gelernt?
 * - Encapsulation, Polymorthismus, Vererbung, abstraktion
 * 
 * Erkläre was Encapsulation ist
 * - Encapsulation ist wenn man mit den drei keywords public, protected und private variablen,methoden oder klassen die Zugriffsberechtigung bestimmt
 * 
 * -ja
 * 
 * -mit public kann man von überall zugreifen und mit protected nur innerhalb der Stammklasse oder deren erbenden klassen darauf zugreifen 
 * 
 * Nenne 4 Teile einer Klasse auf die wir bisher gelernt haben?
 * -fields(alle variablen innerhalb von klassen etc),properties,constructor(übergabe Parameter),Methods
 * 
 * Für welches der Grundkonzepte können wir Properties in Klassen verwenden?
 * 
 */

namespace Testübung
{
    class programm
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();

            persons.Add(new Male("John"));
            persons.Add(new Female("Olivia"));
            persons.Add(new Male("Chris"));
            persons.Add(new Female("Sahin"));

            


            foreach (Person person in persons)
            {
                Console.WriteLine("Hi {0}", person.Name);
            }


            Console.ReadKey();
        }
    }
    

    
}
