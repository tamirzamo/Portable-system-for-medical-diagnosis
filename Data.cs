using System;
using System.Collections.Generic;

/// <summary>
/// Publicly Available Webservices : 
/// Weather
/// source: http://graphical.weather.gov/xml/rest.php
/// Bureau of Labor and Statistics 
/// source: http://www.bls.gov/developers/
/// 
/// Earthquake data: 
/// sources: http://comcat.cr.usgs.gov/fdsnws/event/1/
/// </summary>

namespace App10.Droid
{
    public class Data
    {

        public Data()
        {
        }

        public static List<Data> SampleData()
        {
            var newDataList = new List<Data>();
            newDataList.Add(new Data("תקין",1));
            newDataList.Add(new Data("קצר",1));
            newDataList.Add(new Data("ארוך", 1));
            newDataList.Add(new Data("תפוס", 1));
            newDataList.Add(new Data("קיפוטי", 1));
            /*---------------------------------------*/
            newDataList.Add(new Data("סוטה לימין",2));
            newDataList.Add(new Data("סוטה לשמאל",2));
            newDataList.Add(new Data("לא סוטה", 2));
            newDataList.Add(new Data("אין",3));
            newDataList.Add(new Data("תת לסטי שליש עליון", 3));
            newDataList.Add(new Data("תת ליסטי שליש אמצעי", 3));
            newDataList.Add(new Data("תת לסטי שליש תחתון", 3));
            /*---------------------------------------------*/
            newDataList.Add(new Data("תקין", 3));
            newDataList.Add(new Data("מוחלש", 3));
            newDataList.Add(new Data("נהדר", 3));
            /*-------------------------------------*/
            newDataList.Add(new Data("תקינה",4));

            newDataList.Add(new Data("מוגדלת לא רגישה", 4));
            newDataList.Add(new Data("רגישה - קשה", 4));
            newDataList.Add(new Data("רכה -ניידת ", 4));
            newDataList.Add(new Data("דבוקה", 4));
            /*-----------------------------------*/
            newDataList.Add(new Data("לא נשמע", 5));

            newDataList.Add(new Data("סיסטולית", 5));
            newDataList.Add(new Data("נהמה מתמשכת", 5));
      
            return newDataList;
        }

        public Data(string newId = "Temporary Id" ,int op=0)
        {
            Id = newId;
            cat = op;
        }

        public string Id { get; set; }
        public int cat { get; set; }
    }
}
