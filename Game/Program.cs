using System;

namespace TowerDefence
{
    class Program
    {
        static void Main(string[] args)
        {

            Map map = new Map(8, 5);

            try
            {
                MapLocation mapLocation = new MapLocation(20,20,map);
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenceExceptions)
            {
                Console.WriteLine("Unhandled TowerDefenceExceptions");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Unhandled Exception");
            }



            Console.Read();
        }
    }
}
