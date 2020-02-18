using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGBreastDensityLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class MGBreastDensity : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoDeviceFragment
	{
		//+ Fields
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public MGBreastDensity() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGBreastDensity(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGBreastDensity(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Observation resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		//- WriteCodeStart
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
