﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Dobble.Extentions
{
    [ContentProperty("Source")]
    public class ImageResourceExtention : IMarkupExtension
    {
        public string Source { get; set; }
        public Object ProvideValue(IServiceProvider serviceProvider)
        {
            if (Source == null)
            {
                return null;
            }
            var imageSource = ImageSource.FromResource(Source);
            return imageSource;
        }
    }
}
