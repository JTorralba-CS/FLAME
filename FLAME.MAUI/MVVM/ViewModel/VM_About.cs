﻿using System.Windows.Input;

namespace FLAME.MAUI.MVVM.ViewModel
{
    public partial class VM_About : VM_
    {
        public VM_About()
        {
            HeaderText = "FLAME";
            FooterPrev = false;
            FooterNext = false;
        }

        //public override ICommand OnClickCommand => new Command<string>((X) =>
        //{
        //});
    }
}