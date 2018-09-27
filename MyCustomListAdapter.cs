using Android.Views;
using Android.Widget;
using App10.Droid;
using System.Collections.Generic;

    public class MyCustomListAdapter : BaseAdapter<User>
    {
        List<User> users;

        public MyCustomListAdapter(List<User> users)
        {
            this.users = users;
        }

        public override User this[int position]
        {
            get
            {
                return users[position];
            }
        }

        public override int Count
        {
            get
            {
                return users.Count;
            }
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if (view == null)
            {
                view = LayoutInflater.From(parent.Context).Inflate(Resource.Layout.userRow, parent, false);

                //RelativeLayout rl = (RelativeLayout)view.FindViewById(Resource.Id.secondlist);
               // Button bt = new Button(Android.App.Application.Context);
                 //rl.AddView(bt);

            var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var department = view.FindViewById<TextView>(Resource.Id.departmentTextView);

                view.Tag = new ViewHolder() { Name = name, Department = department };
            }

            var holder = (ViewHolder)view.Tag;


            holder.Name.Text = users[position].Name;
            holder.Department.Text = users[position].Department;


            return view;

        }


    }
