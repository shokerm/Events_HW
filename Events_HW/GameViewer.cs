using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    public class GameViewer
    {
        public void GoodSpaceShipHpChangedEventHandler(object? sender, PointEventArgs pointEventArgs)
        {
            Console.WriteLine($"Your Hit Points is {pointEventArgs._goodSpaceShipHitPoints}");
        }

        public void GoodSpaceShipLocationChangedEventHandler(object? sender, LocationEventAregs locationEventAregs)
        {
            Console.WriteLine($"Your new locations: x = {locationEventAregs.x} y = {locationEventAregs.y}");
        }
        public void GoodSpaceShipDestroyedEventHandler(object? sender, LocationEventAregs locationEventAregs )
        {
            Console.WriteLine($"Your damage is at location: x = {locationEventAregs.x}. y = {locationEventAregs.y}");
        }
        public void BadSpaceShipExplodedEventHandler(object? sender, BadShipsExplodedEventArgs badShipsExplodedEventArgs)
        {
            Console.WriteLine($"{badShipsExplodedEventArgs._numberOfBadShips} ships has been exploded.");
        }
        public void LevelUpReachedEventHandler(object? sender, LevelEventArgs levelEventArgs)
        {
            Console.WriteLine($"You ended level {levelEventArgs.Level}");
        }
    }
}
