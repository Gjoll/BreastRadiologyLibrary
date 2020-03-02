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
		/// <summary>
		/// Access HasMembers value MGFinding
		/// </summary>
		public MGFinding_Accessor MGFinding { get ; protected set; }                                                                              // BuildMemberListBase.cs:69
		/// <summary>
		/// Access HasMembers value MRIFinding
		/// </summary>
		public MRIFinding_Accessor MRIFinding { get ; protected set; }                                                                            // BuildMemberListBase.cs:69
		/// <summary>
		/// Access HasMembers value NMFinding
		/// </summary>
		public NMFinding_Accessor NMFinding { get ; protected set; }                                                                              // BuildMemberListBase.cs:69
		/// <summary>
		/// Access HasMembers value USFinding
		/// </summary>
		public USFinding_Accessor USFinding { get ; protected set; }                                                                              // BuildMemberListBase.cs:69
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:158
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // DefineBase.cs:219
			/// <summary>
			/// Constructor
			/// </summary>
			this.MGFinding = new MGFinding_Accessor(doc);                                                                                            // BuildMemberListBase.cs:75
			/// <summary>
			/// Constructor
			/// </summary>
			this.MRIFinding = new MRIFinding_Accessor(doc);                                                                                          // BuildMemberListBase.cs:75
			/// <summary>
			/// Constructor
			/// </summary>
			this.NMFinding = new NMFinding_Accessor(doc);                                                                                            // BuildMemberListBase.cs:75
			/// <summary>
			/// Constructor
			/// </summary>
			this.USFinding = new USFinding_Accessor(doc);                                                                                            // BuildMemberListBase.cs:75
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
			if (this.MGFinding.Validate(sb) == false) retVal = false;                                                                                // BuildMemberListBase.cs:84
			if (this.MRIFinding.Validate(sb) == false) retVal = false;                                                                               // BuildMemberListBase.cs:84
			if (this.NMFinding.Validate(sb) == false) retVal = false;                                                                                // BuildMemberListBase.cs:84
			if (this.USFinding.Validate(sb) == false) retVal = false;                                                                                // BuildMemberListBase.cs:84
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
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:88
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGFinding);                                                                                                     // BuildMemberListBase.cs:78
			this.WriteHasMember(this.MRIFinding);                                                                                                    // BuildMemberListBase.cs:78
			this.WriteHasMember(this.NMFinding);                                                                                                     // BuildMemberListBase.cs:78
			this.WriteHasMember(this.USFinding);                                                                                                     // BuildMemberListBase.cs:78
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
			this.ReadHasMember(this.MGFinding);                                                                                                      // BuildMemberListBase.cs:81
			this.ReadHasMember(this.MRIFinding);                                                                                                     // BuildMemberListBase.cs:81
			this.ReadHasMember(this.NMFinding);                                                                                                      // BuildMemberListBase.cs:81
			this.ReadHasMember(this.USFinding);                                                                                                      // BuildMemberListBase.cs:81
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create default value for element
		/// Observation.code
		/// </summary>
		public CodeableConcept DefaultValue_1()                                                                                                   // FhirConstruct.cs:753
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
			/// Set Observation.value[x] to one of the predefined items
			/// </summary>
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // DefineBase.cs:183
			{                                                                                                                                        // DefineBase.cs:184
			    //If: D:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\DefineBase.cs 185                                // CodeBlockNested.cs:588
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // DefineBase.cs:186
			}                                                                                                                                        // DefineBase.cs:189
		//- Methods
	}
}
