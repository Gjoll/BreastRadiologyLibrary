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
	/// <summary>
	/// Class BreastRadReport.
	/// This class is automatically generated.
	/// </summary>
	public class BreastRadReport : DiagnosticReportBase, IBreastRadReport
	{
		//+ Properties
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public BreastRadReport() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public BreastRadReport(BreastRadiologyDocument doc, DiagnosticReport resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
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
			this.Resource.Code = FixedValue_DiagnosticReportCode();                                                                                  // DefineBase.cs:177
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadReport");                                            // DefineBase.cs:238
			//- Constructor
		}

		/// <summary>
		/// Validate object. Will return false if an error is detected. sb will contains text of error found.
		/// User must not call Init().
		/// </summary>
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

		/// <summary>
		/// Write to fhir resource
		/// </summary>
		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			//- WriteCode
		}

		/// <summary>
		/// Read from fhir resource
		/// </summary>
		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:155
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_DiagnosticReportCode()                                                                                  // FhirConstruct.cs:759
		{                                                                                                                                         // FhirConstruct.cs:760
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:761
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:767
		    {                                                                                                                                     // FhirConstruct.cs:770
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:771
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:774
		        temp4.SystemElement.Value = "http://loinc.org";                                                                                   // FhirConstruct.cs:776
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:790
		        temp4.CodeElement.Value = "10193-1";                                                                                              // FhirConstruct.cs:792
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
		// DefineBase.cs:199
		/// <summary>
		/// Set DiagnosticReport.conclusionCode to one of the predefined items
		/// </summary>
		public void SetConclusionCode(BiRadsAssessmentCategoriesVS.TCoding code)                                                                  // DefineBase.cs:202
		{                                                                                                                                         // DefineBase.cs:203
		    this.Resource.ConclusionCode.Add((CodeableConcept) code);                                                                             // DefineBase.cs:206
		}                                                                                                                                         // DefineBase.cs:208
		//- Methods
	}
}
