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
		//+ Fields
		//- Fields

		public BodyDistanceFromExtension(Extension resource) : base(resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BodyDistanceFromExtension() : this(new Extension())
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
