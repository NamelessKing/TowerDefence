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
                Path path = new Path(
                new MapLocation[] 
                    {
                        new MapLocation(0,2,map),
                        new MapLocation(1,2,map),
                        new MapLocation(2,2,map),
                        new MapLocation(3,2,map),
                        new MapLocation(4,2,map),
                        new MapLocation(5,2,map),
                        new MapLocation(6,2,map),
                        new MapLocation(7,2,map)
                    }
                );


            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenceExceptions)
            {
                Console.WriteLine("Unhandled TowerDefenceExceptions");
            }
            catch (Exception)
            {
                Console.WriteLine("Unhandled Exception");
            }



            Console.Read();
        }
    }
}
