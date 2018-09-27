using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;
using Android.Support.V7.App;
using Android.Text;
using System.Collections.Generic;
using System.Linq;

namespace App10.Droid
{
    [Activity(Label = "DignoseActivity")]
    public class DignoseActivity : Activity
    {
        ListView myList;
        EditText inputSearch;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.second);
            inputSearch = FindViewById<EditText>(Resource.Id.inputSearch);
            myList = FindViewById<ListView>(Resource.Id.try_view);
            inputSearch.TextChanged += InputSearch_TextChanged;

            myList.Adapter = new MyCustomListAdapter(UserData.Users);
            myList.ItemClick += MyList_ItemClick;
            string body = Intent.GetStringExtra("part");
        }

        private void MyList_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var intent = new Intent(this, typeof(TabsActivity));
           StartActivity(intent);
        }

        private void InputSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            //get the text from Edit Text            
            var searchText = inputSearch.Text;

            //Compare the entered text with List  
            List<User> list = (from items in UserData.Users
                               where items.Name.Contains(searchText) ||
                                              items.Department.Contains(searchText) ||
                                              items.Details.Contains(searchText)
                               select items).ToList<User>();

            // bind the result with adapter  
            myList.Adapter = new MyCustomListAdapter(list);
        }
    }
}