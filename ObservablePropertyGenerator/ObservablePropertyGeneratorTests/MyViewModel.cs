﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace TestProject1
{
	public partial class MyViewModel1<T, TT> : IComparable where T : IList<int>
	{
		// test 1
		[GenerateObservableProperty()]
		private string _name;// comment

		// test 2
		[GenerateObservableProperty]
		public
		DateTime
		_dateOfBirth
		=
		DateTime.Now;// comment

		// test 3
		[GenerateObservableProperty] private ObservableCollection<RangeDirection> _rangeDirections;// comment

		// test 4
		[GenerateObservableProperty]

		protected internal ObservableCollection<State> _states = new ObservableCollection<State>();// comment

		// test 5
		[GenerateObservableProperty]
		[Obsolete]
		private ObservableCollection<County> _counties;// comment

		// test 6
		[GenerateObservableProperty, Obsolete]
		private ObservableCollection<Country> _countries;// comment

		// test 7
		[Obsolete, GenerateObservableProperty]
		private bool _isEmployee; // comment

		// test 8
		[GenerateObservableProperty]
		/// <summary>
		/// </summary>
		ObservableCollection<Section> _sections;// comment

		// test 9
		[GenerateObservableProperty]
		// comments ;
		private   ObservableCollection<TownshipDirection>   _townshipDirections;// comment

		// test 10
		[GenerateObservableProperty]
		/*
		block comments
		*/
		private ObservableCollection<PrincipalMeridian> _principalMeridians;// comment

		// test 11
		[GenerateObservableProperty] /* inline */ private Collateral _selectedCollateral; /*comment*/

		// test 12
		[GenerateObservableProperty]
		// /* suck

		// */
		private int _age;

		//test 13
		[Obsolete,
		GenerateObservableProperty]
		private decimal _salary;// comment

		// test 14
		[GenerateObservableProperty("MarriageDate")]
		DateTime _marriedDate=DateTime.FromOADate(23);// comment

		// test 15
		[GenerateObservablePropertyAttribute]
		byte _b = new byte();//comment


		// test 16
		[GenerateObservableProperty]
		T _theT;

		// test 17
		[GenerateObservableProperty]
		Dictionary<int, T> _dict;

		private void RaisePropertyChanged(string property)
		{}

		public int CompareTo(object o)
		{
			return 0;
		}
	}

	public class Section
	{
	}

	public class TownshipDirection
	{
	}

	public class PrincipalMeridian
	{
	}

	public class Collateral{}
	public class Country{}
	public class State{}
	public class County{}

	public class RangeDirection
	{
	}

	public class GenerateObservablePropertyAttribute : Attribute
	{
		public GenerateObservablePropertyAttribute()
		{

		}

		public GenerateObservablePropertyAttribute(string name)
		{

		}
	}
}
