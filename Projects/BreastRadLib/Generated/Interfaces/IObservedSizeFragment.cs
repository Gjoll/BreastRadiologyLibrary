using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedSizeFragmentLocal;

namespace BreastRadLib
{
	/// <summary>
	/// Interface ObservedSizeFragment.
	/// This interface is automatically generated.
	/// </summary>
	public interface IObservedSizeFragment 
	{
		//+ Properties
		/// <summary>
		/// Access ObsSize
		/// </summary>
		TElementItemComponentMultiple<Quantity, Range> ObsSize { get ; }                                                                           // BuildElementItemComponent.cs:66
		//- Properties

		//+ Methods
		//- Methods
	}
}
