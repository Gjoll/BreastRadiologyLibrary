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

		//+ Properties
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public BreastRadReport() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BreastRadReport(BreastRadiologyDocument doc, DiagnosticReport resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public BreastRadReport(BreastRadiologyDocument doc)
		{
		this.Init(doc, new DiagnosticReport());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			DiagnosticReport resource = (DiagnosticReport) baseResource;
			if (resource == null)
				resource = new DiagnosticReport();
			base.Init(doc, resource);
			//+ Constructor
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:130
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");                                            // CSDefineBase.cs:191
			//- Constructor
		}

		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create default value for element
		/// DiagnosticReport.code
		/// </summary>
		public Extension DefaultValue_1()                                                                                                         // FhirConstruct.cs:3044
		{                                                                                                                                         // FhirConstruct.cs:3045
		    Extension retVal = new Extension();                                                                                                   // FhirConstruct.cs:3046
		    retVal.Url = "http://www.fragment.com/DefaultValue";                                                                                  // FhirConstruct.cs:3051
		    return retVal;                                                                                                                        // FhirConstruct.cs:3056
		}                                                                                                                                         // FhirConstruct.cs:3057
		/// <summary>
		/// Set DiagnosticReport.conclusionCode to one of the predefined items
		/// </summary>
		public void SetConclusionCode(BiRadsAssessmentCategoriesVS.TCoding code)                                                                  // CSDefineBase.cs:155
		{                                                                                                                                         // CSDefineBase.cs:156
		    //Else: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineBase.cs 157                             // CodeBlockNested.cs:594
		    this.Resource.ConclusionCode.Add((CodeableConcept) code);                                                                             // CSDefineBase.cs:159
		}                                                                                                                                         // CSDefineBase.cs:161
		//- Methods
	}
}
