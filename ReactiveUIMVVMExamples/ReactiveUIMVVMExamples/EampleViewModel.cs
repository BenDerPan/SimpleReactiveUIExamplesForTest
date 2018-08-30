using PropertyChanged;
using ReactiveUI;
using System;
using System.Collections.Generic;

using System.Reactive;
using System.Reactive.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReactiveUIMVVMExamples
{
    [AddINotifyPropertyChangedInterface]
    public class EampleViewModel
    {
        public ReactiveCommand<Unit,Unit> ShowName { get; }
        public string Name { get; set; }

        public EampleViewModel(IService service)
        {
            var shouldShow = this.WhenAnyValue(x => x.Name, (name) => !string.IsNullOrWhiteSpace(name) && name.ToLower() == "大兄弟");
            shouldShow.Throttle(TimeSpan.FromSeconds(1)).Subscribe(x =>
            {
                if (!string.IsNullOrWhiteSpace(Name)) { service.Show("但是不知道你是不是我的大兄弟"); }
            });
            ShowName = ReactiveCommand.Create(() => service.Show(Name), shouldShow);
                
        }
    }
}
