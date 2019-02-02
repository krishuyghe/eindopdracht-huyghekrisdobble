﻿using Dobble.Domain;
using Dobble.hulpclasse;
using Dobble.Pages;
using FreshMvvm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Dobble.ViewModels
{
    public class TwoViewModel : FreshBasePageModel, INotifyPropertyChanged
    {
        public TwoViewModel()
        {
       
            MessagingCenter.Subscribe<TwoPage, string>(this, "muziek" , (sender, arg) => {
                var music = new Music();
                if (Globals.Sound == true)
                {
                    if (bool.Parse(arg) == true)
                    { music.play("Correct.mp3"); }
                    else { music.play("Wrong.mp3"); };
                }
            });


           
        }



    }
}


