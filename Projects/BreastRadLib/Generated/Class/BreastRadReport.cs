using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastRadReportLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class BreastRadReport : DiagnosticReportBase, IHeaderFragment, ICategoryFragment
	{
		//+ Fields
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public BreastRadReport() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadReport(BreastRadiologyDocument doc, DiagnosticReport resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public BreastRadReport(BreastRadiologyDocument doc)
		{
		this.Create(doc, new DiagnosticReport());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, DiagnosticReport resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		//- WriteCodeStart
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
