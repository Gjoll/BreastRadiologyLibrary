using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class NMFinding : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		//- Fields

		public NMFinding(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			//- Constructor
		}

		public NMFinding(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");                                                   // CSDefineBase.cs:112
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
