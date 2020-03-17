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
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:376
		/// <summary>
		/// MGFinding
		/// Access fhir element 'Observation.hasMember:mGFinding'
		/// </summary>
		public MGFindingContainer MGFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:376
		/// <summary>
		/// MRIFinding
		/// Access fhir element 'Observation.hasMember:mRIFinding'
		/// </summary>
		public MRIFindingContainer MRIFinding { get ; protected set; }                                                                            // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:376
		/// <summary>
		/// NMFinding
		/// Access fhir element 'Observation.hasMember:nMFinding'
		/// </summary>
		public NMFindingContainer NMFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:376
		/// <summary>
		/// USFinding
		/// Access fhir element 'Observation.hasMember:uSFinding'
		/// </summary>
		public USFindingContainer USFinding { get ; protected set; }                                                                              // BuildMemberBase.cs:380
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
			// Called from BuildMemberReferences.cs, Line 199
			this.MGFinding = new MGFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:359
			// Called from BuildMemberReferences.cs, Line 199
			this.MRIFinding = new MRIFindingContainer(0, 0);                                                                                         // BuildMemberBase.cs:359
			// Called from BuildMemberReferences.cs, Line 199
			this.NMFinding = new NMFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:359
			// Called from BuildMemberReferences.cs, Line 199
			this.USFinding = new USFindingContainer(0, 0);                                                                                           // BuildMemberBase.cs:359
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
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:163
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
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:172
			//- !ReadHasMembers
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:137
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationCode()                                                                                       // FhirConstruct.cs:759
		{                                                                                                                                         // FhirConstruct.cs:760
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:761
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:767
		    {                                                                                                                                     // FhirConstruct.cs:770
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:771
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:774
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes";                                // FhirConstruct.cs:776
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:790
		        temp4.CodeElement.Value = "findingsLeftBreastObservation";                                                                        // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Findings Left Breast observation";                                                                  // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Findings Left Breast observation";                                                                        // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
		// DefineBase.cs:137
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationBodySite()                                                                                   // FhirConstruct.cs:759
		{                                                                                                                                         // FhirConstruct.cs:760
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:761
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:767
		    {                                                                                                                                     // FhirConstruct.cs:770
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:771
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:774
		        temp4.SystemElement.Value = "http://snomed.info/sct";                                                                             // FhirConstruct.cs:776
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:790
		        temp4.CodeElement.Value = "80248007";                                                                                             // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Left breast structure (body structure)";                                                            // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Left breast structure (body structure)";                                                                  // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
			// DefineBase.cs:181
			/// <summary>
			/// Set Observation.value[x] to one of the predefined items
			/// </summary>
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // DefineBase.cs:184
			{                                                                                                                                        // DefineBase.cs:185
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // DefineBase.cs:187
			}                                                                                                                                        // DefineBase.cs:190
			                                                                                                                                         // BuildMemberReferences.cs:127
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:130
			// BuildMemberReferences.cs:131
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:134
			{                                                                                                                                        // BuildMemberReferences.cs:135
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:136
			    //+ ReadHasMembers
			    this.MGFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:89
			    this.MRIFinding.Read(this.Doc, items);                                                                                               // BuildMemberReferences.cs:89
			    this.NMFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:89
			    this.USFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:89
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:138
			                                                                                                                                         // BuildMemberReferences.cs:140
			// BuildMemberReferences.cs:141
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:144
			{                                                                                                                                        // BuildMemberReferences.cs:145
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:146
			    //+ WriteHasMembers
			    items.AddRange(this.MGFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:107
			    items.AddRange(this.MRIFinding.Write(this.Doc));                                                                                     // BuildMemberReferences.cs:107
			    items.AddRange(this.NMFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:107
			    items.AddRange(this.USFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:107
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:148
			}                                                                                                                                        // BuildMemberReferences.cs:149
		//- !HasMembers
		//- Methods
	}
}
