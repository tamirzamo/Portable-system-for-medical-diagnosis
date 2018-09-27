using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android;
using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App10.Droid
{
    public class ExpandableDataAdapter : BaseExpandableListAdapter
    {
        
        List<string> titles = new List<string>();

        readonly Activity Context;
        public ExpandableDataAdapter(Activity newContext, List<Data> newList,int page) : base()
        {
            Context = newContext;
            DataList = newList;
            mpage = page;
            switch(mpage)
                {
                case 1:
                    titles.Add("מבנה");
                    titles.Add("מיקום קנה נשימה");
                    titles.Add("נפיחות בצוואר קדמי");
                    break;
                case 3:
                    titles.Add("מיקום לימפה");
                    break;
                case 4:
                    titles.Add("אוושה קרוטידית");
                    break;
            }
        }
        protected int mpage { get; set; }
        protected List<Data> DataList { get; set; }
        /// <summary>
        /// adding group/header
        /// </summary>
        /// <param name="groupPosition"></param>
        /// <param name="isExpanded"></param>
        /// <param name="convertView"></param>
        /// <param name="parent"></param>
        /// <returns></returns>
        public override View GetGroupView(int groupPosition, bool isExpanded, View convertView, ViewGroup parent)
        {
           
            View header = convertView;
            if (header == null)
            {
                header = Context.LayoutInflater.Inflate(Resource.Layout.ListGroup, null);
            }
            
            header.FindViewById<TextView>(Resource.Id.DataHeader).Text = titles[groupPosition];
           
            return header;
        }
        //creating child 
        public override View GetChildView(int groupPosition, int childPosition, bool isLastChild, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = Context.LayoutInflater.Inflate(Resource.Layout.DataListItem, null);
            }
            string newId = "";
            GetChildViewHelper(groupPosition, childPosition, out newId); //and add him to parent
            row.FindViewById<TextView>(Resource.Id.DataId).Text = newId;
            


            row.FindViewById<TextView>(Resource.Id.DataId).Click += delegate
            {
                row.FindViewById<TextView>(Resource.Id.DataId).SetBackgroundColor(Color.ParseColor("#e7eecc"));
            };



            //row.FindViewById<TextView>(Resource.Id.DataId).
            return row;
            //throw new NotImplementedException ();
        }
        //count how much dad need to expand
        public override int GetChildrenCount(int groupPosition)
        {
            char letter = (char)(65 + groupPosition);
            List<Data> results = DataList.FindAll((Data obj) => obj.cat == groupPosition + 1);
            return results.Count;
        }
        //numbers of groups
        public override int GroupCount
        {
            get
            {
                return titles.Count;
            }
        }
        //adding child to parent
        private void GetChildViewHelper(int groupPosition, int childPosition, out string Id)
        {
            char letter = (char)(65 + groupPosition);
            List<Data> results = DataList.FindAll((Data obj) => obj.cat==groupPosition+1);
            Id = results[childPosition].Id;
            
        }

        #region implemented abstract members of BaseExpandableListAdapter

        public override Java.Lang.Object GetChild(int groupPosition, int childPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetChildId(int groupPosition, int childPosition)
        {
            return childPosition;
        }

        public override Java.Lang.Object GetGroup(int groupPosition)
        {
            throw new NotImplementedException();
        }

        public override long GetGroupId(int groupPosition)
        {
            return groupPosition;
        }

        public override bool IsChildSelectable(int groupPosition, int childPosition)
        {
            return true;
            //throw new NotImplementedException();
        }

        public override bool HasStableIds
        {
            get
            {
                return true;
            }
        }

        #endregion
    }
}