// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in

using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace Nallenthal.Common.XtensionSuite.DateTimeXtensions
{
     public static partial class DateTimeXtensions
     {
          #region Fields
          private static readonly string WeekDays;
          private static readonly string Holidays;
          private static readonly int AdultAgeLimit;

          private static List<DayOfWeek> _workdaysList;
          private static List<DayOfWeek> _holidaysList;
          #endregion
          
          #region Constructors
          /// <summary>
          /// Static constructor of the class. Used to instantiate the private members of this class.
          /// </summary>
          static DateTimeXtensions()
          {
               WeekDays = ConfigurationManager.AppSettings["WEEK_DAYS"];
               var workdaysStringList = WeekDays.Split(',');
               _workdaysList = new List<DayOfWeek>();
               foreach (var element in workdaysStringList) 
               {
                   _workdaysList.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), element));
               }
               
               Holidays = ConfigurationManager.AppSettings["HOLIDAYS"];
               var holidaysStringList = Holidays.Split(',');
               _holidaysList = new List<DayOfWeek>();
               foreach (var element in holidaysStringList) 
               {
                   _holidaysList.Add((DayOfWeek)Enum.Parse(typeof(DayOfWeek), element));
               }
               
               AdultAgeLimit = Convert.ToInt32(ConfigurationManager.AppSettings["ADULT_AGE_LIMIT"]);
          }
          
          #endregion
     }
}