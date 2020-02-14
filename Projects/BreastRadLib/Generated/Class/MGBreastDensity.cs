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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");                                            // CSDefineBase.cs:112
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
