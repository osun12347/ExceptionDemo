using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ExceptionDemo
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int a = 0;
                int b = 2 / a;
        
            }
            catch (Exception ex)
            {

                //Debug.WriteLine("stacktrace:"+ex.Message);
                Debug.WriteLine("msg:" + ex.Message);
                Debug.WriteLine("stacktrace" + ex.StackTrace);
            }

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Demo d = new Demo();
            try
            {
                int value = d.Devide(3, -1);
            }
            catch (Exception ex)
            {

                Debug.WriteLine("message" + ex.Message);
                Debug.WriteLine("stacktrace" + ex.StackTrace);

            }
         
           
        }
       
        }
    public class MinusException : Exception
    {
        public MinusException():base()
        {

        }
        public MinusException(String msg) : base(msg)
        {

        }

    }
    public class Demo
    {
       public int Devide(int a, int b) {
            if (b<0)
                throw new MinusException("/devide by minus");
            return a / b; 
        }
    }

}
