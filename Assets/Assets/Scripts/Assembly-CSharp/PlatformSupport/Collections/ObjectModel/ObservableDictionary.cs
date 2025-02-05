using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using PlatformSupport.Collections.Specialized;

namespace PlatformSupport.Collections.ObjectModel
{
	public class ObservableDictionary
	{
		private const string CountString = "Count";

		private const string IndexerName = "Item[]";

		private const string KeysName = "Keys";

		private const string ValuesName = "Values";

		public int Count => 0;

		public bool IsReadOnly => false;



		public ObservableDictionary()
		{
		}

		public ObservableDictionary(IDictionary<string, string> dictionary)
		{
		}

		public ObservableDictionary(IEqualityComparer<string> comparer)
		{
		}

		public ObservableDictionary(int capacity)
		{
		}

		public ObservableDictionary(IDictionary<string, string> dictionary, IEqualityComparer<string> comparer)
		{
		}

		public ObservableDictionary(int capacity, IEqualityComparer<string> comparer)
		{
		}

		public void Add(string key, string value)
		{
		}

		public bool ContainsKey(string key)
		{
			return false;
		}

		public bool Remove(string key)
		{
			return false;
		}
		

		private void OnPropertyChanged()
		{
		}

		protected virtual void OnPropertyChanged(string propertyName)
		{
		}

		private void OnCollectionChanged()
		{
		}

	
		private void OnCollectionChanged(NotifyCollectionChangedAction action, IList newItems)
		{
		}
	}
}
