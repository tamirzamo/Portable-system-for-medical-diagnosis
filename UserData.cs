using System.Collections.Generic;
using System.Linq;
using App10.Droid;
public static class UserData
{
    public static List<User> Users { get; private set; }

    static UserData()
    {
        var temp = new List<User>();

        AddUser(temp);
     

        Users = temp.OrderBy(i => i.Name).ToList();
    }

    static  void AddUser(List<User> users)
    {
            users.Add(new User()
            {
                Name = "בצקת ריאות",
                Department = "מידע נוסף ........",

                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });
            users.Add(new User()
            {
                Name = "אסתמה",
                Department = "מידע נוסף ........",

                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });
            users.Add(new User()
            {
                Name ="דלקת ריאות",
                Department = "מידע נוסף ........",

                Details = "Virendra has over 2 years of experience developing mobile applications,"
            });

        users.Add(new User()
        {
            Name = "תסחיף ריאה",
            Department = "מידע נוסף ........",

            Details = "Virendra has over 2 years of experience developing mobile applications,"
        });

    }
    }
       
    
