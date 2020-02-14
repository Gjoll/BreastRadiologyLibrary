using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class USFinding : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		//- Fields

		public USFinding(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");                                                  // CSDefineBase.cs:112
			//- Constructor
		}

		public USFinding(BreastRadiologyDocument doc) : this(doc, new Observation())
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
