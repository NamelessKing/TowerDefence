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


                Invader[] invaders =
                {
                    new Invader(path),
                    new Invader(path),
                    new Invader(path),
                    new Invader(path)
                };

                Tower[] towers =
                {
                    new Tower(new MapLocation(1,3,map)),
                    new Tower(new MapLocation(3,3,map)),
                    new Tower(new MapLocation(5,3,map)),
                };


                Level level1 = new Level(invaders)
                {
                    Towers = towers
                };

                bool playerWon = level1.Play();

                Console.WriteLine($"Player {(playerWon ? "won" : "lost" )}");

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
