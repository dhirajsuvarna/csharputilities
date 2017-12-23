using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

[assembly: log4net.Config.XmlConfigurator(Watch =true)]

namespace utility_workbench
{
    public partial class Log4NetSample : Form
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Log4NetSample()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            log.Debug("this is my first log");

            List<Animal> animalList = new List<Animal>();
            animalList.Add(new Tiger());
            animalList.Add(new Dog());


            foreach (Animal thisAnimal in animalList)
            {
                thisAnimal.Speak();
            }
            

        }
    }

    abstract class Animal
    {
        public string Name { get; set; }

        public abstract string Speak();
    }

    class Dog : Animal
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Dog()
        {
            Name = "i am a dog";
        }
        public override string Speak()
        {
            log.Debug("Dog: Speak()");
            return Name;
        }
    }

    class Tiger : Animal
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public Tiger()
        {
            Name = "i am a tiger";
        }

        public override string Speak()
        {
            ChangeLogFileName();
            log.Debug("Tiger: Speak()");
            return Name;
        }

        private void ChangeLogFileName()
        {
            log4net.Repository.ILoggerRepository repository = log4net.LogManager.GetRepository();
            foreach(var thisAppender in repository.GetAppenders())
            {
                if(thisAppender is log4net.Appender.FileAppender)
                {
                    log4net.Appender.FileAppender fileAppender = thisAppender as log4net.Appender.FileAppender;
                    fileAppender.File = @"C:\Users\dhiraj\Documents\Visual Studio 2015\Projects\utility_workbench\dump\log4net_tiger.log";
                    fileAppender.ActivateOptions();
                }
            }
        }
    }
}
