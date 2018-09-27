using System;
using Android.App;
using Android.Graphics;
using Android.OS;
using Android.Support.V4.App;
using Android.Views;
using Android.Widget;
using Java.Lang;

namespace App10.Droid
{
    public class PageFragment : Android.Support.V4.App.Fragment
    {
        const string ARG_PAGE = "ARG_PAGE";
        private int mPage;

        public static PageFragment newInstance(int page)
        {
            var args = new Bundle();
            args.PutInt(ARG_PAGE, page);
            var fragment = new PageFragment();
            fragment.Arguments = args;
            return fragment;
        }


        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            mPage = Arguments.GetInt(ARG_PAGE);
        }

       
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            var viewc = inflater.Inflate(Resource.Layout.testlist, container, false);


           // RelativeLayout rl = (RelativeLayout)viewc.FindViewById(Resource.Id.fragment_main_layout);
            //ListView mylist = new ListView(this.Activity);
            // mylist.Adapter = new MyCustomListAdapter(UserData.Users);
            // Button bt = new Button(this.Activity);
            //rl.AddView(bt);
            //rl.AddView(mylist);
            //var textView = (TextView)view;
            //textView.Text = "Fragment #" + mPage;
            Activity newContext = this.Activity;
            ExpandableListView lv = (ExpandableListView)viewc.FindViewById(Resource.Id.myExpandableListview);
            //var listView = FindViewById<ExpandableListView>(Resource.Id.myExpandableListview);
            lv.SetAdapter(new ExpandableDataAdapter(newContext, Data.SampleData(),mPage));

        
  
            return viewc;
        }
    }
}