using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MRIFinding : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		//- Fields

		public MRIFinding(Observation resource) : base(resource)
		{
			//+ Constructor
			//- Constructor
		}

		public MRIFinding() : this(new Observation())
		{
		}

		public void Write()
		{
		//+ WriteCode
		//- WriteCode
		}

		public void Read(ResourceBag resourceBag)
		{
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
