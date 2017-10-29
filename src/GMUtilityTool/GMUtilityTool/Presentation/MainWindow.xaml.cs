/*
Copyright 2017 Grega Mohorko

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.

Project: GMUtilityTool
Created: 2017-10-29
Author: Grega Mohorko
*/

using System;
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

namespace GMUtilityTool.Presentation
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		// TODO searchbox
		// a search box that searches through all the scripts and shows the ones that contain the typed-in filter

		public MainWindow()
		{
			InitializeComponent();

			// TODO window position
			// set the position of the window like it was when it was last used?

			// TODO scan .dlls
			// BackgroundWorker that searches for all .dlls of scripts and shows them
			// then also searches for custom .dlls in the custom directory
			// meanwhile, a progressbar is shown
		}
	}
}
