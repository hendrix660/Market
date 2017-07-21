using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SupportFragment = Android.Support.V4.App.Fragment;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;
using Android.Support.Design.Widget;

namespace DesignLibraryTutorial.Fragments
{
    public class Fragment2 : SupportFragment
    {
        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            View view = inflater.Inflate(Resource.Layout.Fragment2, container, false);
            Button btnLogin = view.FindViewById<Button>(Resource.Id.btnLogin);
            TextInputLayout password = view.FindViewById<TextInputLayout>(Resource.Id.txtInputLayoutPassword);
            string txtPassword = password.EditText.Text;

            btnLogin.Click += (o, e) =>
                        {
                            if(txtPassword != "123") { password.Error = "Wrong Password"; }
                        };

            TextInputLayout Username = view.FindViewById<TextInputLayout>(Resource.Id.txtInputLayoutUsername);

            return view;



        }
    }
}