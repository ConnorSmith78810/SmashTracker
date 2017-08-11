﻿using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SmashTracker.Common
{
	public static class CollectionExtensions
	{
		public static ObservableCollection<T> ToObservableCollection<T>(this IEnumerable<T> source)
		{
			return new ObservableCollection<T>(source);
		}
	}
}
