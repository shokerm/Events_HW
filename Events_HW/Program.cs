using System;
using System.Timers;

namespace Events_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpaceQuestGameManager spaceQuestGameManager = new SpaceQuestGameManager(5, 20, 30,5) ;
            GameViewer gameViewer = new GameViewer();
            

            spaceQuestGameManager.GoodSpaceShipLocationChanged += gameViewer.GoodSpaceShipLocationChangedEventHandler;
            spaceQuestGameManager.BadShipsExploded += gameViewer.BadSpaceShipExplodedEventHandler;
            spaceQuestGameManager.GoodSpaceShipDestroyed += gameViewer.GoodSpaceShipDestroyedEventHandler;
            spaceQuestGameManager.GoodSpaceShipHpChanged += gameViewer.GoodSpaceShipHpChangedEventHandler;
            spaceQuestGameManager.LevelUpReached += gameViewer.LevelUpReachedEventHandler;

            while (true)
            {
                Random r = new Random();
                int randomNumber = r.Next(1, 5);
                switch (randomNumber)
                {
                    case 1:
                        spaceQuestGameManager.MoveSpaceShip(250, 300);
                        Thread.Sleep(1000);
                        break;

                    case 2:
                        Thread.Sleep(1000);
                        spaceQuestGameManager.EnemyShipsDestroyed(3);
                        break;
                    case 3:
                        Thread.Sleep(1000);
                        spaceQuestGameManager.GoodSpaceShipGotDamaged(250, 300);
                        break;
                    case 4:
                        Thread.Sleep(1000);
                        spaceQuestGameManager.GoodSpaceShipGotExtraHp(100);
                        break;


                }
            }
            
            
           
            
            
            

            

        }

       
    }
}
