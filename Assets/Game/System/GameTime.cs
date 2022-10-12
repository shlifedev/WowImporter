using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Game.System
{ 
    public class GameTime
    {
        private const int DefaultYear = 700;
        private const int DefaultMonth = 1;
        private const int DefaultDay = 1;
        private const int DefaultHour = 8;  
        public DateTime Time { get; set; } 
        public delegate void TimeEventDelegate(DateTime prev); 
        public TimeEventDelegate OnHour;
        public TimeEventDelegate OnMinute;
        public TimeEventDelegate OnDay;
        public TimeEventDelegate OnMonth;
        public TimeEventDelegate OnYear; 
        public void Awake()
        {
            Time = new DateTime(DefaultYear, DefaultMonth, DefaultDay, DefaultHour, 0, 0); 
        }
        public void FixedUpdate()
        {
            var currentTime = Time;
            var nextTime = Time.AddMilliseconds(UnityEngine.Time.fixedDeltaTime);
            if (nextTime.Day > currentTime.Day)
            {
                
            }


        }
    }
}
