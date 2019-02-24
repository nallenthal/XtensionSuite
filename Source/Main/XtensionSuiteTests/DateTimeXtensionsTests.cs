// Author: Ganesh Periasamy
// Website : http://www.nallenthal.in
// Website : http://lazypro.nallenthal.in
using System;
using System.Diagnostics;
using System.Runtime.InteropServices;

using Nallenthal.Common;
using Nallenthal.Common.XtensionSuite.DateTimeXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions;
using NUnit.Framework;
using Nallenthal.Common.XtensionSuite.BDDExtensions.BoolBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.StringBDDXtensions;
using Nallenthal.Common.XtensionSuite.BDDExtensions.NumericBDDXtensions;

namespace Nallenthal.Common.XtensionSuiteTests
{
     [TestFixture]
     public class DateTimeXtensionsTests
     {
          [Test]
          public void Test_methods_based_on_days()
          {
               var currentDate = DateTime.Now;
               
               for (int i = 0; i < 7; i++) 
               {
                   CheckDay(currentDate.DayOfWeek,currentDate);
                   currentDate = currentDate.AddDays(1);
               }
          }
          
          [Test]
          public void Test_method_for_workingdays_and_holidays()
          {
              var currentDate = new DateTime(2012,1,1); //1-Jan-2012 is a Sunday
              
              currentDate.IsASunday().ShouldBeTrue();
              currentDate.IsAWorkingDay().ShouldBeFalse(); //as we configured Sunday is a holiday
              currentDate.IsAHoliday().ShouldBeTrue();
              
              currentDate = new DateTime(2012,1,2); //2-Jan-2012 is a Monday
              
              currentDate.IsAMonday().ShouldBeTrue();
              currentDate.IsAWorkingDay().ShouldBeTrue();
              currentDate.IsAHoliday().ShouldBeFalse();
          }
          
          [Test]
          public void Test_method_for_yesterday_today_and_tomorrow()
          {
              var currentDate = DateTime.Now;
              currentDate.IsToday().ShouldBeTrue();
              
              var yesterday = currentDate.SubtractDays(1);
              yesterday.IsYesterday().ShouldBeTrue();
              
              var tomorrow = currentDate.AddDays(1);
              tomorrow.IsTomorrow().ShouldBeTrue();
          }
          
          [Test]
          public void Test_methods_for_months()
          {
              var date = new DateTime(2012,1,1); //let's start from January
              
              date.IsInJanuary().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInFebruary().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInMarch().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInApril().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInMay().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInJune().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInJuly().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInAugust().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInSeptember().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInOctober().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInNovember().ShouldBeTrue();
              
              date = date.AddMonths(1);
              date.IsInDecember().ShouldBeTrue();
              
          }
          
          [Test]
          public void Test_method_for_common_string_representations()
          {
              var date = DateTime.Now;
              date.GetDayString().ShouldBeEqualTo(date.DayOfWeek.ToString());
              
              date.GetMonthString().ShouldBeEqualTo(date.ToString("MMMM"));
          }
          
          [Test]
          public void Test_for_common_methods_based_on_age()
          {
              var age = new DateTime(1980,6,23);
              age.IsAdult().ShouldBeTrue();
              
              age.IsAtLeastOfAge(32).ShouldBeTrue();
              
          }
          
          [Test]
          public void Tests_for_methods_older_than_xxx()
          {
              var date = DateTime.MinValue;
              date.IsOlderThanASecond().ShouldBeTrue();
              date.IsOlderThanAMinute().ShouldBeTrue();
              date.IsOlderThanAnHour().ShouldBeTrue();
              date.IsOlderThanADay().ShouldBeTrue();
              date.IsOlderThanAWeek().ShouldBeTrue();
              date.IsOlderThanAFortnight().ShouldBeTrue();
              date.IsOlderThanAMonth().ShouldBeTrue();
              date.IsOlderThanHalfYear().ShouldBeTrue();
              date.IsOlderThanAYear().ShouldBeTrue();
              date.IsOlderThanADecade().ShouldBeTrue();
              date.IsOlderThanACentury().ShouldBeTrue();
          }
          
          [Test]
          public void Tests_for_methods_younger_than_xxx()
          {
              var date = DateTime.MaxValue;
              date.IsYoungerThanASecond().ShouldBeTrue();
              date.IsYoungerThanAMinute().ShouldBeTrue();
              date.IsYoungerThanAnHour().ShouldBeTrue();
              date.IsYoungerThanADay().ShouldBeTrue();
              date.IsYoungerThanAWeek().ShouldBeTrue();
              date.IsYoungerThanAFortnight().ShouldBeTrue();
              date.IsYoungerThanAMonth().ShouldBeTrue();
              date.IsYoungerThanHalfYear().ShouldBeTrue();
              date.IsYoungerThanAYear().ShouldBeTrue();
              date.IsYoungerThanADecade().ShouldBeTrue();
              date.IsYoungerThanACentury().ShouldBeTrue();
          }
          
          [Test]
          public void Tests_for_Add_a_xxx()
          {
              var date = DateTime.Now;
              
              date.AddASecond().AddASecond().IsYoungerThanASecond().ShouldBeTrue();
              date.AddAMinute().AddASecond().IsYoungerThanAMinute().ShouldBeTrue();
              date.AddHalfAnHour().AddASecond().IsYoungerThan(date.AddMinutes(29)).ShouldBeTrue();
              date.AddAnHour().AddASecond().IsYoungerThanAnHour().ShouldBeTrue();
              date.AddADay().AddASecond().IsYoungerThanADay().ShouldBeTrue();
              date.AddAWeek().AddADay().IsYoungerThanAWeek().ShouldBeTrue(); //a second is added to ensure correct results
              date.AddAFortnight().AddASecond().IsYoungerThanAFortnight().ShouldBeTrue();
              date.AddAMonth().AddASecond().IsYoungerThanAMonth().ShouldBeTrue();
              date.AddAYear().AddASecond().IsYoungerThanAYear().ShouldBeTrue();
              date.AddADecade().AddASecond().IsYoungerThanADecade().ShouldBeTrue();
              date.AddACentury().AddASecond().IsYoungerThanACentury().ShouldBeTrue();
          }
          
          [Test]
          public void Tests_for_Subtract_a_xxx()
          {
              var date = DateTime.Now;
              
              date.SubtractASecond().IsOlderThanASecond().ShouldBeTrue();
              date.SubtractAMinute().IsOlderThanAMinute().ShouldBeTrue();
              date.SubtractHalfAnHour().IsOlderThan(date.SubtractMinutes(29)).ShouldBeTrue();
              date.SubtractAnHour().IsOlderThanAnHour().ShouldBeTrue();
              date.SubtractADay().IsOlderThanADay().ShouldBeTrue();
              date.SubtractAWeek().IsOlderThanAWeek().ShouldBeTrue(); 
              date.SubtractAFortnight().IsOlderThanAFortnight().ShouldBeTrue();
              date.SubtractAMonth().SubtractASecond().IsOlderThanAMonth().ShouldBeTrue();
              date.SubtractAYear().SubtractASecond().IsOlderThanAYear().ShouldBeTrue();
              date.SubtractADecade().SubtractASecond().IsOlderThanADecade().ShouldBeTrue();
              date.SubtractACentury().SubtractASecond().IsOlderThanACentury().ShouldBeTrue();
          }
          
          [Test]
          public void Tests_for_subtract_methods()
          {
              var date = DateTime.Now;
              
              date.SubtractTicks(1).IsOlderThan(date).ShouldBeTrue();
              date.SubtractMilliSeconds(1).IsOlderThan(date).ShouldBeTrue();
              //other methods are covered in the above test
          }
          
          [Test]
          public void Tests_for_Get_xxx_since()
          {
              var date = DateTime.Now;
              date.SubtractTicks(1).GetTicksSince().ShouldBeGreaterThan(0);
              date.SubtractMilliSeconds(1).GetMilliSecondsSince().ShouldBeGreaterThan(0);
              date.SubtractASecond().GetSecondsSince().ShouldBeGreaterThan(0);
              date.SubtractAMinute().GetMinutesSince().ShouldBeGreaterThan(0);
              date.SubtractAnHour().GetHoursSince().ShouldBeGreaterThan(0);
              date.SubtractADay().GetDaysSince().ShouldBeGreaterThan(0);
              date.SubtractAWeek().GetWeeksSince().ShouldBeGreaterThan(0);
              date.SubtractAFortnight().GetFortnightsSince().ShouldBeGreaterThan(0);
              date.SubtractAMonth().SubtractASecond().GetMonthsSince().ShouldBeGreaterThan(0);
              date.AddAMonth().AddASecond().GetMonthsSince().ShouldBeGreaterThan(0);
              date.SubtractAYear().GetYearsSince().ShouldBeGreaterThan(0);
              date.AddAYear().AddASecond().GetYearsSince().ShouldBeGreaterThan(0);
              date.SubtractADecade().GetDecadesSince().ShouldBeGreaterThan(0);
              date.SubtractACentury().GetCenturiesSince().ShouldBeGreaterThan(0);
          }
          
          [Test]public void Tests_for_methods_ToxxyyzzSep()
          {
              var date = DateTime.Now;
              
              date.ToDdMmYyDot().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "." + date.Month.ToString().PadLeft(2,'0') + "." + date.Year.ToString().Substring(2));
              date.ToDdMmYyHyphen().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "-" + date.Month.ToString().PadLeft(2,'0') + "-" + date.Year.ToString().Substring(2));
              date.ToDdMmYySlash().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "/" + date.Month.ToString().PadLeft(2,'0') + "/" + date.Year.ToString().Substring(2));
              date.ToDdMmYyWithSep("^").ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "^" + date.Month.ToString().PadLeft(2,'0') + "^" + date.Year.ToString().Substring(2));
              
              date.ToDdMmYyyyDot().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "." + date.Month.ToString().PadLeft(2,'0') + "." + date.Year.ToString());
              date.ToDdMmYyyyHyphen().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "-" + date.Month.ToString().PadLeft(2,'0') + "-" + date.Year.ToString());
              date.ToDdMmYyyySlash().ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "/" + date.Month.ToString().PadLeft(2,'0') + "/" + date.Year.ToString());
              date.ToDdMmYyyyWithSep("^").ShouldBeEqualTo(date.Day.ToString().PadLeft(2,'0') + "^" + date.Month.ToString().PadLeft(2,'0') + "^" + date.Year.ToString());
              
              date.ToMmDdYyDot().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "." + date.Day.ToString().PadLeft(2,'0')+ "." + date.Year.ToString().Substring(2));
              date.ToMmDdYyHyphen().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "-" + date.Day.ToString().PadLeft(2,'0')+ "-" + date.Year.ToString().Substring(2));
              date.ToMmDdYySlash().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "/" + date.Day.ToString().PadLeft(2,'0')+ "/" + date.Year.ToString().Substring(2));
              date.ToMmDdYyWithSep("^").ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "^" + date.Day.ToString().PadLeft(2,'0')+ "^" + date.Year.ToString().Substring(2));
              
              date.ToMmDdYyyyDot().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "." + date.Day.ToString().PadLeft(2,'0')+ "." + date.Year.ToString());
              date.ToMmDdYyyyHyphen().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "-" + date.Day.ToString().PadLeft(2,'0')+ "-" + date.Year.ToString());
              date.ToMmDdYyyySlash().ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "/" + date.Day.ToString().PadLeft(2,'0')+ "/" + date.Year.ToString());
              date.ToMmDdYyyyWithSep("^").ShouldBeEqualTo(date.Month.ToString().PadLeft(2,'0')  + "^" + date.Day.ToString().PadLeft(2,'0')+ "^" + date.Year.ToString());              
              
              date.ToYyMmDdDot().ShouldBeEqualTo(date.Year.ToString().Substring(2) + "." + date.Month.ToString().PadLeft(2,'0') + "." + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyMmDdHyphen().ShouldBeEqualTo(date.Year.ToString().Substring(2) + "-" + date.Month.ToString().PadLeft(2,'0') + "-" + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyMmDdSlash().ShouldBeEqualTo(date.Year.ToString().Substring(2) + "/" + date.Month.ToString().PadLeft(2,'0') + "/" + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyMmDdWithSep("^").ShouldBeEqualTo(date.Year.ToString().Substring(2) + "^" + date.Month.ToString().PadLeft(2,'0') + "^" + date.Day.ToString().PadLeft(2,'0'));
              
              date.ToYyyyMmDdDot().ShouldBeEqualTo(date.Year.ToString() + "." + date.Month.ToString().PadLeft(2,'0') + "." + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyyyMmDdHyphen().ShouldBeEqualTo(date.Year.ToString() + "-" + date.Month.ToString().PadLeft(2,'0') + "-" + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyyyMmDdSlash().ShouldBeEqualTo(date.Year.ToString() + "/" + date.Month.ToString().PadLeft(2,'0') + "/" + date.Day.ToString().PadLeft(2,'0'));
              date.ToYyyyMmDdWithSep("^").ShouldBeEqualTo(date.Year.ToString() + "^" + date.Month.ToString().PadLeft(2,'0') + "^" + date.Day.ToString().PadLeft(2,'0'));
              
          }
          
          [Test]
          public void Test_methods_for_get_next_xxx()
          {
                var date = DateTime.Now;
                var nextDate = date.GetNextMonday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Monday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextTuesday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Tuesday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextWednesday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Wednesday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextThursday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Thursday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextFriday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Friday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextSaturday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Saturday);

                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                nextDate = date.GetNextSunday();
                Debug.Assert(nextDate.DayOfWeek == DayOfWeek.Sunday);
                nextDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within next 6 days
                
                
                var aSaturday = DateTime.Now.GetNextSaturday();
                var aWorkingDay = aSaturday.GetNextWorkingDay();
                Debug.Assert(aWorkingDay.DayOfWeek == DayOfWeek.Monday);
                aWorkingDay.Subtract(aSaturday).Days.ShouldNOTBeGreaterThan(7);
                
                var aMonday = DateTime.Now.GetNextMonday();
                var aHoliday = aMonday.GetNextHoliday();
                Debug.Assert(aHoliday.DayOfWeek == DayOfWeek.Saturday);
                aHoliday.Subtract(aMonday).Days.ShouldNOTBeGreaterThan(7);
          }
          
          [Test]
          public void Test_methods_for_get_previous_xxx()
          {
                var date = DateTime.Now;
                var prevDate = date.GetPreviousMonday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Monday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousTuesday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Tuesday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousWednesday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Wednesday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousThursday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Thursday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousFriday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Friday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousSaturday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Saturday);

                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                prevDate = date.GetPreviousSunday();
                Debug.Assert(prevDate.DayOfWeek == DayOfWeek.Sunday);
                prevDate.Subtract(date).Days.ShouldNOTBeGreaterThan(7); // it should find a date within prev 6 days
                
                
                var aSunday = DateTime.Now.GetPreviousSunday();
                var aWorkingDay = aSunday.GetPreviousWorkingDay();
                Debug.Assert(aWorkingDay.DayOfWeek == DayOfWeek.Friday);
                aWorkingDay.Subtract(aSunday).Days.ShouldNOTBeGreaterThan(7);
                
                var aFriday = DateTime.Now.GetPreviousFriday();
                var aHoliday = aFriday.GetPreviousHoliday();
                Debug.Assert(aHoliday.DayOfWeek == DayOfWeek.Sunday);
                aHoliday.Subtract(aFriday).Days.ShouldNOTBeGreaterThan(7);
          }

          [Test]
          public void Tests_for_GetFirstxxxOfTheMonth()
          {
              CheckFirstDayOccurrence(DayOfWeek.Monday);
              CheckFirstDayOccurrence(DayOfWeek.Tuesday);
              CheckFirstDayOccurrence(DayOfWeek.Wednesday);
              CheckFirstDayOccurrence(DayOfWeek.Thursday);
              CheckFirstDayOccurrence(DayOfWeek.Friday);
              CheckFirstDayOccurrence(DayOfWeek.Saturday);
              CheckFirstDayOccurrence(DayOfWeek.Sunday);
              
              var date = DateTime.Now;
              var firstHoliday = date.GetFirstHolidayOfTheMonth();
              
              firstHoliday.Month.ShouldBeEqualTo(date.Month);
              firstHoliday.Year.ShouldBeEqualTo(date.Year);
              Assert.IsTrue(firstHoliday.DayOfWeek == DayOfWeek.Sunday || firstHoliday.DayOfWeek == DayOfWeek.Saturday);
              
              var firstWorkingDay = date.GetFirstWorkingDayOfTheMonth();
              
              firstWorkingDay.Month.ShouldBeEqualTo(date.Month);
              firstWorkingDay.Year.ShouldBeEqualTo(date.Year);
              firstWorkingDay.Day.ShouldNOTBeGreaterThan(date.Day);
              Assert.IsTrue(firstWorkingDay.DayOfWeek != DayOfWeek.Sunday && firstWorkingDay.DayOfWeek != DayOfWeek.Saturday);
              
              var firstDay = date.GetFirstDayOfTheMonth();
              firstDay.Day.ShouldBeEqualTo(1);
              firstDay.Month.ShouldBeEqualTo(date.Month);
              firstDay.Year.ShouldBeEqualTo(date.Year);
          }
          
          [Test]
          public void Tests_for_GetLastxxxOfTheMonth()
          {
              CheckLastDayOccurrence(DayOfWeek.Monday);
              CheckLastDayOccurrence(DayOfWeek.Tuesday);
              CheckLastDayOccurrence(DayOfWeek.Wednesday);
              CheckLastDayOccurrence(DayOfWeek.Thursday);
              CheckLastDayOccurrence(DayOfWeek.Friday);
              CheckLastDayOccurrence(DayOfWeek.Saturday);
              CheckLastDayOccurrence(DayOfWeek.Sunday);
              
              var date = DateTime.Now;
              var lastHoliday = date.GetLastHolidayOfTheMonth();
              
              lastHoliday.Month.ShouldBeEqualTo(date.Month);
              lastHoliday.Year.ShouldBeEqualTo(date.Year);
              lastHoliday.Day.ShouldNOTBeLessThan(1);
              Assert.IsTrue(lastHoliday.DayOfWeek == DayOfWeek.Sunday || lastHoliday.DayOfWeek == DayOfWeek.Saturday);
              
              var lastWorkingDay = date.GetLastWorkingDayOfTheMonth();
              
              lastWorkingDay.Month.ShouldBeEqualTo(date.Month);
              lastWorkingDay.Year.ShouldBeEqualTo(date.Year);
              lastWorkingDay.Day.ShouldNOTBeLessThan(1);
              Assert.IsTrue(lastWorkingDay.DayOfWeek != DayOfWeek.Sunday && lastWorkingDay.DayOfWeek != DayOfWeek.Saturday);
              
              var lastDay = date.GetLastDayOfTheMonth();
              lastDay.Day.ShouldBeEqualTo(date.AddAMonth().GetFirstDayOfTheMonth().SubtractADay().Day);
              lastDay.Month.ShouldBeEqualTo(date.Month);
              lastDay.Year.ShouldBeEqualTo(date.Year);
          }
          
          [Test]
          public void Tests_for_GetFirstxxxOfTheYear()
          {
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Monday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Tuesday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Wednesday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Thursday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Friday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Saturday);
              CheckFirstDayOccurrenceOfTheYear(DayOfWeek.Sunday);
              
              var date = DateTime.Now;
              var firstHoliday = date.GetFirstHolidayOfTheYear();
              
              firstHoliday.Year.ShouldBeEqualTo(date.Year);
              firstHoliday.Day.ShouldNOTBeGreaterThan(date.Day);
              Assert.IsTrue(firstHoliday.DayOfWeek == DayOfWeek.Sunday || firstHoliday.DayOfWeek == DayOfWeek.Saturday);
              
              var firstWorkingDay = date.GetFirstWorkingDayOfTheYear();
              
              firstWorkingDay.Year.ShouldBeEqualTo(date.Year);
              firstWorkingDay.Day.ShouldNOTBeGreaterThan(date.Day);
              Assert.IsTrue(firstWorkingDay.DayOfWeek != DayOfWeek.Sunday && firstWorkingDay.DayOfWeek != DayOfWeek.Saturday);
              
              var firstDay = date.GetFirstDayOfTheYear();
              firstDay.Day.ShouldBeEqualTo(1);
              firstDay.Month.ShouldBeEqualTo(1);
              firstDay.Year.ShouldBeEqualTo(date.Year);
          }
          
          [Test]
          public void Tests_for_GetLastxxxOfTheYear()
          {
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Monday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Tuesday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Wednesday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Thursday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Friday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Saturday);
              CheckLastDayOccurrenceOfTheYear(DayOfWeek.Sunday);
              
              var date = DateTime.Now;
              var lastHoliday = date.GetLastHolidayOfTheYear();
              
              lastHoliday.Year.ShouldBeEqualTo(date.Year);
              lastHoliday.Month.ShouldNOTBeLessThan(date.Month);
              Assert.IsTrue(lastHoliday.DayOfWeek == DayOfWeek.Sunday || lastHoliday.DayOfWeek == DayOfWeek.Saturday);
              
              var lastWorkingDay = date.GetLastWorkingDayOfTheYear();
              
              lastWorkingDay.Year.ShouldBeEqualTo(date.Year);
              lastWorkingDay.Day.ShouldNOTBeLessThan(date.Day);
              Assert.IsTrue(lastWorkingDay.DayOfWeek != DayOfWeek.Sunday && lastWorkingDay.DayOfWeek != DayOfWeek.Saturday);
              
              var lastDay = date.GetLastDayOfTheYear();
              lastDay.Day.ShouldBeEqualTo(31);
              lastDay.Month.ShouldBeEqualTo(12);
              lastDay.Year.ShouldBeEqualTo(date.Year);
          }
          
          #region Private Methods
          private void CheckDay(DayOfWeek currentDayOfWeek,DateTime currentDate)
          {
               switch (currentDayOfWeek) 
               {
                    case DayOfWeek.Sunday:
                         {
                              currentDate.IsASunday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Monday:
                         {
                              currentDate.IsAMonday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Tuesday:
                         {
                              currentDate.IsATuesday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Wednesday:
                         {
                              currentDate.IsAWednesday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Thursday:
                         {
                              currentDate.IsAThursday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Friday:
                         {
                              currentDate.IsAFriday().ShouldBeTrue();
                              break;
                         }
                    case DayOfWeek.Saturday:
                         {
                              currentDate.IsASaturday().ShouldBeTrue();
                              break;
                         }
               }
          }
          
          private void CheckLastDayOccurrence(DayOfWeek day)
          {
              var currentDate = DateTime.Now;
              var date = new DateTime(currentDate.Year,currentDate.Month,20); //some arbitrary date
              var lastDayOfTheMonth = date.GetLastDayOccurrenceOfTheMonth(day);
              
              lastDayOfTheMonth.Year.ShouldBeEqualTo(currentDate.Year);
              lastDayOfTheMonth.Month.ShouldBeEqualTo(currentDate.Month);
              lastDayOfTheMonth.Day.ShouldNOTBeLessThan(date.Day);
              
              ((int)lastDayOfTheMonth.DayOfWeek).ShouldBeEqualTo((int)day);
              for (int i = 1; i < lastDayOfTheMonth.Day; i++) 
              {
                 Assert.AreNotSame(new DateTime(lastDayOfTheMonth.Year,lastDayOfTheMonth.Month,i).DayOfWeek , day);
              }
              switch (day)
              {
                  case DayOfWeek.Sunday:
                      {
                          date.GetLastSundayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                      
                  case DayOfWeek.Monday:
                      {
                          date.GetLastMondayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Tuesday:
                      {
                          date.GetLastTuesdayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Wednesday:
                      {
                          date.GetLastWednesdayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Thursday:
                      {
                          date.GetLastThursdayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Friday:
                      {
                          date.GetLastFridayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Saturday:
                      {
                          date.GetLastSaturdayOfTheMonth().Date.ShouldBeEqualTo(lastDayOfTheMonth.Date);
                          break;    
                      }
              }              
          }

          private void CheckFirstDayOccurrence(DayOfWeek day)
          {
              var currentDate = DateTime.Now;
              var date = new DateTime(currentDate.Year,currentDate.Month,20); //some arbitrary date
              var firstDayOfTheMonth = date.GetFirstDayOccurrenceOfTheMonth(day);
              
              firstDayOfTheMonth.Year.ShouldBeEqualTo(currentDate.Year);
              firstDayOfTheMonth.Month.ShouldBeEqualTo(currentDate.Month);
              firstDayOfTheMonth.Day.ShouldNOTBeGreaterThan(date.Day);
              
              ((int)firstDayOfTheMonth.DayOfWeek).ShouldBeEqualTo((int)day);
              for (int i = 1; i < firstDayOfTheMonth.Day; i++) 
              {
                 Assert.AreNotSame(new DateTime(firstDayOfTheMonth.Year,firstDayOfTheMonth.Month,i).DayOfWeek , day);
              }
              
              switch (day)
              {
                  case DayOfWeek.Sunday:
                      {
                          date.GetFirstSundayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                      
                  case DayOfWeek.Monday:
                      {
                          date.GetFirstMondayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Tuesday:
                      {
                          date.GetFirstTuesdayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Wednesday:
                      {
                          date.GetFirstWednesdayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Thursday:
                      {
                          date.GetFirstThursdayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Friday:
                      {
                          date.GetFirstFridayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
                  case DayOfWeek.Saturday:
                      {
                          date.GetFirstSaturdayOfTheMonth().Date.ShouldBeEqualTo(firstDayOfTheMonth.Date);
                          break;    
                      }
              }
          }
          
          private void CheckFirstDayOccurrenceOfTheYear(DayOfWeek day)
          {
              var currentDate = DateTime.Now;
              var date = new DateTime(currentDate.Year,1,31); //some arbitrary date
              var firstDayOfTheYear = date.GetFirstDayOccurrenceOfTheYear(day);
              
              firstDayOfTheYear.Year.ShouldBeEqualTo(currentDate.Year);
              firstDayOfTheYear.IsOlderThan(currentDate).ShouldBeTrue();
              ((int)firstDayOfTheYear.DayOfWeek).ShouldBeEqualTo((int)day);
              for (int i = 1; i < firstDayOfTheYear.Day; i++) 
              {
                 Assert.AreNotSame(new DateTime(firstDayOfTheYear.Year,firstDayOfTheYear.Month,i).DayOfWeek , day);
              }
              
              switch (day)
              {
                  case DayOfWeek.Sunday:
                      {
                          date.GetFirstSundayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                      
                  case DayOfWeek.Monday:
                      {
                          date.GetFirstMondayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Tuesday:
                      {
                          date.GetFirstTuesdayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Wednesday:
                      {
                          date.GetFirstWednesdayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Thursday:
                      {
                          date.GetFirstThursdayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Friday:
                      {
                          date.GetFirstFridayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Saturday:
                      {
                          date.GetFirstSaturdayOfTheYear().Date.ShouldBeEqualTo(firstDayOfTheYear.Date);
                          break;    
                      }
              }              
          }
 
          private void CheckLastDayOccurrenceOfTheYear(DayOfWeek day)
          {
              var currentDate = DateTime.Now;
              var date = new DateTime(currentDate.Year,12,1); //some arbitrary date
              var lastDayOfTheYear = date.GetLastDayOccurrenceOfTheYear(day);
              
              lastDayOfTheYear.Year.ShouldBeEqualTo(currentDate.Year);
              lastDayOfTheYear.IsYoungerThan(currentDate).ShouldBeTrue();
              
              ((int)lastDayOfTheYear.DayOfWeek).ShouldBeEqualTo((int)day);
              for (int i = 1; i < lastDayOfTheYear.Day; i++) 
              {
                 Assert.AreNotSame(new DateTime(lastDayOfTheYear.Year,lastDayOfTheYear.Month,i).DayOfWeek , day);
              }
              switch (day)
              {
                  case DayOfWeek.Sunday:
                      {
                          date.GetLastSundayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                      
                  case DayOfWeek.Monday:
                      {
                          date.GetLastMondayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Tuesday:
                      {
                          date.GetLastTuesdayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Wednesday:
                      {
                          date.GetLastWednesdayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Thursday:
                      {
                          date.GetLastThursdayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Friday:
                      {
                          date.GetLastFridayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
                  case DayOfWeek.Saturday:
                      {
                          date.GetLastSaturdayOfTheYear().Date.ShouldBeEqualTo(lastDayOfTheYear.Date);
                          break;    
                      }
              }              
          }
 
          #endregion

         // Commented to avoid compilation errors with VS Community 2017  
          //[TestFixtureSetUp]
          //public void Init()
          //{
          //}
          
          //[TestFixtureTearDown]
          //public void Dispose()
          //{
          //}
     }
}
