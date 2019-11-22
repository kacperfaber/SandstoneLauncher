﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using KacpiiToZiomal.SandstoneLauncher.Commons.Types;
using KacpiiToZiomal.SandstoneLauncher.Languages.Models;
using KacpiiToZiomal.SandstoneLauncher.Languages.Types;

namespace KacpiiToZiomal.SandstoneLauncher
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            LanguageService service = new LanguageService(new JsonDeserializer<Language>(),
                new JsonSerializer<Language>(), new FileReader(), new FileCreator(new FileNameRemover()),
                new ActuallyLanguagePathGenerator(new ApplicationData()));

            Language langugage = service.GetLangugage();
            LanguageLoader.Load(langugage, Resources);

            InitializeComponent();
        }
    }
}