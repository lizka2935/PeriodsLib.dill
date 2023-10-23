using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeriodsLib.dill
{
    public class Calculations
    {
        /// <summary>
        /// Разработайте библиотеку (отдельным проектом), которая позволит вернуть список свободных временных интервалов
        /// </summary>
        /// <param name="startTimes">список занятых промежутков времени startTimes - начало</param>
        /// <param name="durations">список занятых промежутков времени durations - длительность</param>
        /// <param name="beginWorkingTime">рабочий день сотрудника начало - beginWorkingTime </param>
        /// <param name="endWorkingTime">рабочий день сотрудника завершение - endWorkingTime </param>
        /// <param name="consultationTime">минимальное необходимое время посетителя</param>
        /// <returns>список подходящих свободных временных промежутков</returns>
        public static string[] AvailablePeriods(TimeSpan[] startTimes, int[] durations, TimeSpan beginWorkingTime, TimeSpan endWorkingTime, int consultationTime)
        {
            consultationTime = 30;
            startTimes = null;
            durations = null;
            beginWorkingTime = new TimeSpan(8, 0, 0);
            endWorkingTime = new TimeSpan(18, 0, 0);
            TimeSpan interval;
            interval = new TimeSpan(0, consultationTime, 0);
            while (beginWorkingTime != endWorkingTime)
            {

                beginWorkingTime = beginWorkingTime + interval;
            }
            
        }
    }
}
