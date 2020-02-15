using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BodyDistanceFromExtension : ExtensionBase, IHeaderFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		//- Fields

		public BodyDistanceFromExtension(BreastRadiologyDocument doc, Extension resource) : base(doc, resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BodyDistanceFromExtension(BreastRadiologyDocument doc) : this(doc, new Extension())
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
