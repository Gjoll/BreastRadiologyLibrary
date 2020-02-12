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

		public BreastBodyLocationExtension(Extension resource) : base(resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BreastBodyLocationExtension() : this(new Extension())
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
