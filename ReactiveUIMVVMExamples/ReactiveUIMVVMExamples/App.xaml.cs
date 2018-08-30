using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Reactive.Concurrency;
using System.Threading.Tasks;
using System.Windows;

namespace ReactiveUIMVVMExamples
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        public App() => RxApp.MainThreadScheduler = new WaitForDispatcherScheduler(
            () => DispatcherScheduler.Current
        );
    }
}
