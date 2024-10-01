using System;
using System.Text;

namespace Corso_05.Models
{

    public class Car
    {
        #region constants

        private const int GEAR_MAX = 5;

        #endregion

        #region private variables

        private string name;

        #endregion

        #region public properties

        #region color

        private ConsoleColor color;

        public ConsoleColor Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        #endregion 

        #region power

        private float power;

        public float Power
        {
            get
            {
                return power;
            }
            set
            {
                power = value;
            }
        }

        #endregion

        #region model

        private string model;

        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }

        #endregion

        #region speed

        private int speed;

        public int Speed
        {
            get
            {
                return speed;
            }
            set
            {
                speed = value;
            }
        }

        #endregion

        #region gear

        private int gear;

        public int Gear
        {
            get
            {
                return gear;
            }
            set
            {
                gear = value;
            }
        }

        #endregion

        #region started

        private bool started;

        public bool Started
        {
            get
            {
                return started;
            }
            set
            {
                started = value;
            }
        }

        #endregion

        #endregion

        #region public methods

        /// <summary>
        /// Start engine of instance car
        /// </summary>
        public void Start()
        {
            started = true;

            Console.WriteLine($"{name.ToUpper()}: started");
        }

        /// <summary>
        /// Stop engine of instance car
        /// </summary>
        public void Stop()
        {

            if ((speed == 0) && (gear == 0))
            {
                started = false;
                Console.WriteLine($"{name.ToUpper()}: stopped");
            }

        }

        /// <summary>
        /// Increase a speed of car
        /// </summary>
        /// <param name="pValueToAdded">Increment units of speed</param>
        public void IncreaseSpeed(int pValueToAdded)
        {

            speed += (pValueToAdded * gear);

            Console.WriteLine($"{name.ToUpper()}: actual speed is {speed}");

        }

        /// <summary>
        /// Decrease a speed of car
        /// </summary>
        /// <param name="pValueToRemove">Decrement units of speed</param>
        public void ReduceSpeed(int pValueToRemove)
        {

            speed -= (pValueToRemove * gear);

            Console.WriteLine($"{name.ToUpper()}: actual speed is {speed}");

        }

        /// <summary>
        /// Increase a gear
        /// </summary>
        public void GearUp()
        {

            if (gear < GEAR_MAX)
                gear++;

            //Console.WriteLine($"{name.ToUpper()}: actual gear is {gear}");
            OnGearChanged(new GearChangeEventArgs()
            {
                GearChange = GearChanges.Up,
                Message = $"{name.ToUpper()}: actual speed is {speed}"
            });
        }

        /// <summary>
        /// Decrease a gear
        /// </summary>
        public void GearDown()
        {

            if (gear > 0)
                gear--;

            //Console.WriteLine($"{name.ToUpper()}: actual gear is {gear}");

            var args = new GearChangeEventArgs();
            args.Message = "";
            args.GearChange = GearChanges.Up;
            GearChanged?.Invoke(args);

            OnGearChanged(new GearChangeEventArgs()
            {
                GearChange = GearChanges.Down,
                Message = $"{name.ToUpper()}: actual speed is {speed}"
            });


        }

        /// <summary>
        /// Return info card of instance car
        /// </summary>
        public void GetInfo()
        {

            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {name}");
            sb.AppendLine($"Color: {color}");
            sb.AppendLine($"Power: {power}");

            Console.Write(sb.ToString());
        }

        #endregion

        #region private methods

        private void init()
        {
            gear = 0;
            speed = 0;
            started = false;
        }

        #endregion    

        #region costructors

        public Car(string pName)
        {
            init();
            name = pName;
        }

        public Car(string pName, ConsoleColor pColor, int pPower)
        {
            init();
            name = pName;
            color = pColor;
            power = pPower;
        }

        #endregion

        #region events

        #region gear event

        //public event EventHandler<GearChangeEventArgs> GearChanged;
        public delegate void GearChangedEventHandler(GearChangeEventArgs e);
        public event GearChangedEventHandler GearChanged;

        protected virtual void OnGearChanged(GearChangeEventArgs e)
        {
            /*
            EventHandler<GearChangeEventArgs> handler = GearChanged;
            if (handler != null)
                handler(this, e);
            */

            //Versione contratta
            //GearChanged?.Invoke(this, e);


            #region versione delegate

            /*
            GearChangedEventHandler handler = GearChanged;
            if (handler != null)
                handler(e);
            */
            //versione contratta
            GearChanged?.Invoke(e);

            #endregion 
        }

        #endregion

        #endregion
    }
}
