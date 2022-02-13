using MyToDo.ViewModels;
using MyToDo.Views;
using Prism.DryIoc;
using Prism.Ioc;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace MyToDo
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        // prism框架改造
        protected override Window CreateShell()
        {
            return Container.Resolve<MainView>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegister)
        {
            containerRegister.RegisterForNavigation<AboutView>();
            containerRegister.RegisterForNavigation<SkinView, SkinViewModel>();
            containerRegister.RegisterForNavigation<IndexView, IndexViewModel>();
            containerRegister.RegisterForNavigation<MemoView, MemoViewModel>();
            containerRegister.RegisterForNavigation<SettingsView, SettingsViewModel>();
            containerRegister.RegisterForNavigation<ToDoView, ToDoViewModel>();
        }

    }
}
