using MyToDo.Common;
using Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyToDo.ViewModels
{
    public class ToDoViewModel : BindableBase
    {
        public ToDoViewModel()
        {
            ToDoDtos = new ObservableCollection<ToDoDto>();
            CreatToDoList();
        }

        private ObservableCollection<ToDoDto> toDoDtos;

        public ObservableCollection<ToDoDto> ToDoDtos
        {
            get { return toDoDtos; }
            set { toDoDtos = value; RaisePropertyChanged(); }
        }

        private void CreatToDoList()
        {
            for (int i = 0; i < 10; i++)
            {
                toDoDtos.Add(new ToDoDto() { Title = "Todo" + i, Content = "测试数据..." });
            }
        }
    }
}
