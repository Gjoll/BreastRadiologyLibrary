using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class BreastRadReport : DiagnosticReportBase, IHeaderFragment, ICategoryFragment
	{
		//+ Fields
		//- Fields

		public BreastRadReport(DiagnosticReport resource) : base(resource)
		{
			//+ Constructor
			//- Constructor
		}

		public BreastRadReport() : this(new DiagnosticReport())
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
