using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGBreastDensity : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoDeviceFragment
	{
		//+ Fields
		//- Fields

		public MGBreastDensity(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			//- Constructor
		}

		public MGBreastDensity(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
