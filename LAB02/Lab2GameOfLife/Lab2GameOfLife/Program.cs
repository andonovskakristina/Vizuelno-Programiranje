using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Lab2GameOfLife
{
    class Cell
    {
        public bool IsAlive { get; set; }
        public bool ShouldLive { get; set; }

        public Cell()
        {
            IsAlive = false;
            ShouldLive = false;
        }

        public override string ToString()
        {
            if (IsAlive)
                return " X ";
            else
                return " _ ";
        }
    }

    class Grid
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Cell[][] Cells { get; set; }

        public Grid(int rows, int columns)
        {
            // kod za postavuvanje na svojstvata Rows i Columns
            // ... ovde vasiot kod ...
            Rows = rows;
            Columns = columns;
            // kod za inicijalizacija na matricata
            Cells = new Cell[rows][];
            for (int i = 0; i < Rows; i++)
            {
                Cells[i] = new Cell[Columns];
                for (int j = 0; j < Columns; j++)
                {
                    // ovde kod za instanciranje na objekt od klasata Cell
                    // i postavuvanje na toj objekt na soodvetniot element vo matricata
                    // ... vasiot kod ovde...   
                    Cell TempCell = new Cell();
                    Cells[i][j] = TempCell;
                }
            }
        }

        public void ToggleCell(int x, int y, bool isAlive)
        {
            // vasiot kod ovde
            //Cells[x][y].IsAlive = !isAlive;
            Cells[x][y].IsAlive = !Cells[x][y].IsAlive;
        }

        public void Evolve()
        {
            /*
            Algoritam za implementiranje na pravilata na igrata
            1. Za sekoja kletka vo matricata so kletki treba da se izbrojat brojot na
            zhivi sosedi vo 8-te nasoki (gore levo, gore sredina, gore desno, levo,
            desno, dolu levo, dolu sredina i dolu desno). 
            2. Spored slednite pravila na igrata za evolucija treba da se implementiraat
            slednite uslovi (postavuvanje na svojstvoto ShouldLive):
            - sekoja zhiva kletka so pomalku od dva zhivi sosedi umira od osamenost

            - sekoja zhiva kletka so dva ili tri zhivi sosedi prezhivuva do slednata
            generacija

            - sekoja zhiva kletka so povekje od tri sosedi umira od prenaselenost

            - sekoja mrtva kletka so tochno tri sosedi ozivuva preku reprodukcija

            3. Otkako kje gi evoluirame site kletki, treba da ja promenime nivnata
            sostojba (svojstvoto IsAlive) vo zavisnost od toa dali treba da zhivee
            (svojstvoto ShouldLive). Treba da se izminat povtorno site kletki i
            svojstvoto IsAlive da dobie vrednost na svojstvoto ShouldLive.
            */

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    int numAliveN = 0;

                    if (i > 0 && j > 0 && Cells[i - 1][j - 1].IsAlive)
                        numAliveN++;
                    if (i > 0 && Cells[i - 1][j].IsAlive)
                        numAliveN++;
                    if (i > 0 && j < Columns - 1 && Cells[i - 1][j + 1].IsAlive)
                        numAliveN++;
                    if (j > 0 && Cells[i][j - 1].IsAlive)
                        numAliveN++;
                    if (j < Columns - 1 && Cells[i][j + 1].IsAlive)
                        numAliveN++;
                    if (i < Rows - 1 && j > 0 && Cells[i + 1][j - 1].IsAlive)
                        numAliveN++;
                    if (i < Rows - 1 && Cells[i + 1][j].IsAlive)
                        numAliveN++;
                    if (i < Rows - 1 && j < Columns - 1 && Cells[i + 1][j + 1].IsAlive)
                        numAliveN++;

                    if (Cells[i][j].IsAlive && numAliveN < 2)
                    {
                        Cells[i][j].ShouldLive = false;
                    }
                    else if(Cells[i][j].IsAlive && (numAliveN == 2 || numAliveN == 3))
                    {
                        Cells[i][j].ShouldLive = true;
                    } 
                    else if(Cells[i][j].IsAlive && numAliveN > 3)
                    {
                        Cells[i][j].ShouldLive = false;
                    }
                    else if(!Cells[i][j].IsAlive && numAliveN == 3)
                    {
                        Cells[i][j].ShouldLive = true;
                    }
                    else
                    {
                        Cells[i][j].ShouldLive = false;
                    }
                }
            }

            for(int i = 0; i < Rows; i++)
            {
                for(int j = 0; j < Columns; j++)
                {
                    Cells[i][j].IsAlive = Cells[i][j].ShouldLive;
                }
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Columns; j++)
                {
                    sb.Append(Cells[i][j].ToString());
                }
                sb.AppendLine();
            }

            return sb.ToString();
        }
    }

    abstract class Game
    {
        protected Grid grid;

        public int CurrentGeneration { get; set; }

        public int MaxGenerations { get; set; }

        public Game(int maxGenerations)
        {
            // vasiot kod ovde
            MaxGenerations = maxGenerations;
            CurrentGeneration = 0;
        }

        public void Evolve()
        {
            // vasiot kod ovde
            grid.Evolve();
            CurrentGeneration++;
        }

        virtual public void Show()
        {
            Console.Clear();
            // vasiot kod ovde
            // prikazot od pechatenjeto treba da e sleden:
            // 'Current generation: <CurrentGeneration>'
            // ' _ _ _ X _ _ _

            // ' _ _ _ X _ _ _

            // itn

            Console.WriteLine("Current generation: " + CurrentGeneration);
            Console.WriteLine(grid.ToString());
        }
    }

    /// <summary>
    /// Implementacija na igrata so pochetna sostojba so statichki raspored na zhivi kletki koi ne se menuvaat pri evolucija.
    /// </summary>
    class StillLifeGame : Game
    {
        public enum GameType
        {
            Block,
            Beehive,
            Loaf,
            Boat
        }

        public GameType Type { get; set; }

        public StillLifeGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == GameType.Block)
            {
                grid = new Grid(4, 4);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
            }

            if (Type == GameType.Beehive)
            {
                grid = new Grid(5, 6);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 2, true);
                grid.ToggleCell(3, 3, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Still Game of Life: {0}", Type);
            base.Show();
        }
    }

    /// <summary>
    /// Implementacija na igrata so pochetna sostojba so raspored na zhivi kletki koi osciliraat pri evolucija.
    /// </summary>
    class OscilatorGame : Game
    {
        public enum GameType
        {
            Blinker,
            Toad,
            Beacon,
            Pulsar
        }

        public GameType Type { get; set; }

        public OscilatorGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (gameType == GameType.Blinker)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(2, 3, true);
            }

            if (gameType == GameType.Toad)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(4, 2, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(2, 4, true);
                grid.ToggleCell(3, 4, true);
            }
            if (gameType == GameType.Beacon)
            {
                grid = new Grid(6, 6);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(1, 2, true);
                grid.ToggleCell(2, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(3, 4, true);
                grid.ToggleCell(4, 3, true);
                grid.ToggleCell(4, 4, true);
            }
            if (gameType == GameType.Pulsar)
            {
                grid = new Grid(17, 17);
                for (int i = 0; i < 17; i++)
                {
                    for (int j = 0; j < 17; j++)
                    {
                        if (i == 2 || i == 7 || i == 9 || i == 14)
                        {
                            if (j == 4 || j == 5 || j == 6 || j == 10 || j == 11 || j == 12)
                            {
                                grid.ToggleCell(i, j, true);
                            }
                        }
                        if ((i >= 4 && i <= 6) || (i >= 10 && i <= 12))
                        {
                            if (j == 2 || j == 7 || j == 9 || j == 14)
                            {
                                grid.ToggleCell(i, j, true);
                            }

                        }
                    }
                }
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("Oscilator Game of Life: {0}", Type);
            base.Show();
        }
    }

    class MyGame : Game
    {
        public enum GameType
        {
            Type1,
            Type2,
            Type3
        }

        public GameType Type { get; set; }

        public MyGame(GameType gameType, int maxGenerations) : base(maxGenerations)
        {
            Type = gameType;
            if (Type == GameType.Type1)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(0, 0, true);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(4, 4, true);
            }

            if (Type == GameType.Type2)
            {
                grid = new Grid(4, 2);
                grid.ToggleCell(0, 0, true);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(2, 0, true);
                grid.ToggleCell(3, 1, true);
            }

            if (Type == GameType.Type3)
            {
                grid = new Grid(5, 5);
                grid.ToggleCell(0, 0, true);
                grid.ToggleCell(1, 1, true);
                grid.ToggleCell(2, 2, true);
                grid.ToggleCell(3, 3, true);
                grid.ToggleCell(4, 4, true);
                grid.ToggleCell(0, 4, true);
                grid.ToggleCell(1, 3, true);
                grid.ToggleCell(3, 1, true);
                grid.ToggleCell(4, 0, true);
            }
        }

        override public void Show()
        {
            Console.Title = String.Format("My Game of Life: {0}", Type);
            base.Show();
        }
    }

    class Program
    {
        static readonly int MAX_GENERATIONS = 10;

        static void Main(string[] args)
        {
            // Instanciranje na objekt od igrata
            //Game game = new OscilatorGame(OscilatorGame.GameType.Blinker, MAX_GENERATIONS);
            //Game game = new StillLifeGame(StillLifeGame.GameType.Block, MAX_GENERATIONS);
            Game game = new MyGame(MyGame.GameType.Type3, MAX_GENERATIONS);
            while (game.CurrentGeneration <= game.MaxGenerations)
            {
                game.Show();
                game.Evolve();
                Thread.Sleep(1000);
            }
            Console.WriteLine("Evaluation ended!\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
