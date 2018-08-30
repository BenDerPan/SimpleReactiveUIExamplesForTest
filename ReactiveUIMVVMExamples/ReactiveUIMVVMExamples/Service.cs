using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace ReactiveUIMVVMExamples
{
    public class Service : IService
    {
        public void Show(string name)
        {
            var msg = $"终于等到你了啊，{name}";
            MessageBox.Show(msg);
        }
    }
}
