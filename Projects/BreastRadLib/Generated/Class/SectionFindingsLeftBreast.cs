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
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// MGFinding
		/// Access fhir element 'Observation.hasMember:mGFinding'
		/// </summary>
		public MGFindingContainer MGFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// MRIFinding
		/// Access fhir element 'Observation.hasMember:mRIFinding'
		/// </summary>
		public MRIFindingContainer MRIFinding { get ; protected set; }                                                                            // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// NMFinding
		/// Access fhir element 'Observation.hasMember:nMFinding'
		/// </summary>
		public NMFindingContainer NMFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// USFinding
		/// Access fhir element 'Observation.hasMember:uSFinding'
		/// </summary>
		public USFindingContainer USFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:332
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:159
			this.Resource.BodySite = FixedValue_ObservationBodySite();                                                                               // DefineBase.cs:159
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // DefineBase.cs:220
			this.MGFinding = new MGFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:316
			this.MRIFinding = new MRIFindingContainer(0, 0);                                                                                         // BuildMemberBase.cs:316
			this.NMFinding = new NMFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:316
			this.USFinding = new USFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:316
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
			//+ !WriteHasMembers
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:144
			//- !WriteHasMembers
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
			//+ !ReadHasMembers
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:153
			//- !ReadHasMembers
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationCode()                                                                                       // FhirConstruct.cs:753
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
		public CodeableConcept FixedValue_ObservationBodySite()                                                                                   // FhirConstruct.cs:753
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
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // DefineBase.cs:184
			{                                                                                                                                        // DefineBase.cs:185
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // DefineBase.cs:187
			}                                                                                                                                        // DefineBase.cs:190
			                                                                                                                                         // BuildMemberReferences.cs:108
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:111
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:115
			{                                                                                                                                        // BuildMemberReferences.cs:116
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:117
			    //+ ReadHasMembers
			    this.MGFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:67
			    this.MRIFinding.Read(this.Doc, items);                                                                                               // BuildMemberReferences.cs:67
			    this.NMFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:67
			    this.USFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:67
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:119
			                                                                                                                                         // BuildMemberReferences.cs:121
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:125
			{                                                                                                                                        // BuildMemberReferences.cs:126
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:127
			    //+ WriteHasMembers
			    items.AddRange(this.MGFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:88
			    items.AddRange(this.MRIFinding.Write(this.Doc));                                                                                     // BuildMemberReferences.cs:88
			    items.AddRange(this.NMFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:88
			    items.AddRange(this.USFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:88
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:129
			}                                                                                                                                        // BuildMemberReferences.cs:130
		//- !HasMembers
		//- Methods
	}
}
