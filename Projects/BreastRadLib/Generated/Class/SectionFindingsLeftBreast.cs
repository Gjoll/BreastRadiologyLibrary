using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.SectionFindingsLeftBreastLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.FindingBreastFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class SectionFindingsLeftBreast.
	/// This class is automatically generated.
	/// </summary>
	public class SectionFindingsLeftBreast : ObservationBase, ISectionFindingsLeftBreast
	{
		//+ Properties
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGFinding
		/// </summary>
		public ElementItemReferenceMultiple<MGFinding> MGFinding { get ; protected set; }                                                         // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MRIFinding
		/// </summary>
		public ElementItemReferenceMultiple<MRIFinding> MRIFinding { get ; protected set; }                                                       // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access NMFinding
		/// </summary>
		public ElementItemReferenceMultiple<NMFinding> NMFinding { get ; protected set; }                                                         // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access USFinding
		/// </summary>
		public ElementItemReferenceMultiple<USFinding> USFinding { get ; protected set; }                                                         // BuildElementItemReference.cs:63
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public SectionFindingsLeftBreast() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc)
		{
			this.Init(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Observation resource = (Observation) baseResource;
			if (resource == null)
				resource = new Observation();
			base.Init(doc, resource);
			//+ Constructor
			this.Resource.Code = FixedValue_1();                                                                                                     // DefineBase.cs:158
			this.Resource.BodySite = FixedValue_2();                                                                                                 // DefineBase.cs:158
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // DefineBase.cs:219
			this.MGFinding = new ElementItemReferenceMultiple<MGFinding>("MGFinding", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");// BuildElementItemReference.cs:48
			this.MRIFinding = new ElementItemReferenceMultiple<MRIFinding>("MRIFinding", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding");// BuildElementItemReference.cs:48
			this.NMFinding = new ElementItemReferenceMultiple<NMFinding>("NMFinding", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");// BuildElementItemReference.cs:48
			this.USFinding = new ElementItemReferenceMultiple<USFinding>("USFinding", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");// BuildElementItemReference.cs:48
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
			if (this.MGFinding.Validate(sb) == false) retVal = false;                                                                                // BuildElementItemReference.cs:72
			if (this.MRIFinding.Validate(sb) == false) retVal = false;                                                                               // BuildElementItemReference.cs:72
			if (this.NMFinding.Validate(sb) == false) retVal = false;                                                                                // BuildElementItemReference.cs:72
			if (this.USFinding.Validate(sb) == false) retVal = false;                                                                                // BuildElementItemReference.cs:72
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
			this.ClearHasMember();                                                                                                                   // BuildElementItemReference.cs:81
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMembers(this.MGFinding);                                                                                                    // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MRIFinding);                                                                                                   // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.NMFinding);                                                                                                    // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.USFinding);                                                                                                    // BuildElementItemReference.cs:66
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
			this.ReadHasMembers(this.MGFinding);                                                                                                     // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MRIFinding);                                                                                                    // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.NMFinding);                                                                                                     // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.USFinding);                                                                                                     // BuildElementItemReference.cs:69
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_1()                                                                                                     // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes";                                // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "findingsLeftBreastObservation";                                                                        // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Findings Left Breast observation";                                                                  // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Findings Left Breast observation";                                                                        // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_2()                                                                                                     // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://snomed.info/sct";                                                                             // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "80248007";                                                                                             // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Left breast structure (body structure)";                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Left breast structure (body structure)";                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			/// <summary>
			/// Set Observation.value[x] to one of the predefined items
			/// </summary>
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // DefineBase.cs:183
			{                                                                                                                                        // DefineBase.cs:184
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // DefineBase.cs:186
			}                                                                                                                                        // DefineBase.cs:189
		//- Methods
	}
}
