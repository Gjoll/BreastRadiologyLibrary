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

		public BreastRadReport(BreastRadiologyDocument doc, DiagnosticReport resource) : base(doc, resource)
		{
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");                                            // CSDefineBase.cs:112
			//- Constructor
		}

		public BreastRadReport(BreastRadiologyDocument doc) : this(doc, new DiagnosticReport())
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
