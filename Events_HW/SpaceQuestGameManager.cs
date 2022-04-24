using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events_HW
{
    internal class SpaceQuestGameManager
    {
        private int _goodSpaceShipHitPoints;
        private int _shipXLocation;
        private int _shipYLocation;
        private int _numberOfBadShips;

        private int currentLevel_;
        public event EventHandler<PointEventArgs> GoodSpaceShipHpChanged;
        public event EventHandler<LocationEventAregs> GoodSpaceShipLocationChanged;
        public event EventHandler<LocationEventAregs> GoodSpaceShipDestroyed;
        public event EventHandler<BadShipsExplodedEventArgs> BadShipsExploded;
        public event EventHandler<LevelEventArgs> LevelUpReached;

        public SpaceQuestGameManager(int goodSpaceShipHitPoints, int shipXLocation, int shipYLocation, int numberOfBadShips)
        {
            _goodSpaceShipHitPoints = goodSpaceShipHitPoints;
            _shipXLocation = shipXLocation;
            _shipYLocation = shipYLocation;
            _numberOfBadShips = numberOfBadShips;
        }

        public void MoveSpaceShip (int newX, int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodSpaceShipLocationChanged(newX, newY);


        }
        public void GoodSpaceShipGotDamaged(int newX, int newY)
        {
            _shipXLocation = newX;
            _shipYLocation = newY;
            OnGoodSpaceShipDestroyed(newX, newY);
        }
        public void GoodSpaceShipGotExtraHp(int extra)
        {
            _goodSpaceShipHitPoints += extra;
            OnGoodSpaceShipHpChanged(_goodSpaceShipHitPoints);
        }

        public void EnemyShipsDestroyed(int numberOfBadShipsDestroyed)
        {
            _numberOfBadShips = numberOfBadShipsDestroyed;
            OnBadSpaceShipExploded(_numberOfBadShips);
        }
        private void OnGoodSpaceShipHpChanged(int points)
        {
            GoodSpaceShipHpChanged.Invoke(this, new PointEventArgs(points));
        }
        private void OnGoodSpaceShipLocationChanged(int newX, int newY)
        {
            GoodSpaceShipLocationChanged.Invoke(this, new LocationEventAregs(newX, newY));
        }
        private void OnGoodSpaceShipDestroyed(int newX, int newY)
        {
            GoodSpaceShipDestroyed.Invoke(this, new LocationEventAregs(newX, newY));

        }

        private void OnBadSpaceShipExploded(int numberOfExplodedShips)
        {
            BadShipsExploded.Invoke(this, new BadShipsExplodedEventArgs(numberOfExplodedShips));
        }
        private void OnLevelUpReached()
        {
            LevelUpReached.Invoke(this, new LevelEventArgs());
        }
    }
}
