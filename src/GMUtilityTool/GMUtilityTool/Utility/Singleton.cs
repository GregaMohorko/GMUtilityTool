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

// FIXME GM.Utility

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMUtilityTool.Utility
{
	/// <summary>
	/// Base class for a thread-safe singleton class.
	/// </summary>
	/// <typeparam name="T">The type of the actual singleton class.</typeparam>
	public abstract class Singleton<T> where T : Singleton<T>
	{
		private static object _lock_instance = new object();
		private static T _instance;
		public static T Instance
		{
			get
			{
				if(_instance == null) {
					lock(_lock_instance) {
						if(_instance == null) {
							// create an instance of T using the public, protected or private parameterless constructor
							_instance = (T)Activator.CreateInstance(typeof(T), true);
						}
					}
				}
				return _instance;
			}
		}
	}
}
