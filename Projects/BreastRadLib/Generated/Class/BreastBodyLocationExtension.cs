using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastBodyLocationExtension : ExtensionBase, IHeaderFragment
	{
		//+ Fields
		//- Fields

		public BreastBodyLocationExtension(BreastRadiologyDocument doc, Extension resource) : base(doc, resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BreastBodyLocationExtension(BreastRadiologyDocument doc) : this(doc, new Extension())
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
