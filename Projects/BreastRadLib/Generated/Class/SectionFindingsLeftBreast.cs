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
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:396
		/// <summary>
		/// MGFinding
		/// Access fhir element 'Observation.hasMember:mGFinding'
		/// </summary>
		public MMGFinding MGFinding { get ; protected set; }                                                                                      // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:396
		/// <summary>
		/// MRIFinding
		/// Access fhir element 'Observation.hasMember:mRIFinding'
		/// </summary>
		public MMRIFinding MRIFinding { get ; protected set; }                                                                                    // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:396
		/// <summary>
		/// NMFinding
		/// Access fhir element 'Observation.hasMember:nMFinding'
		/// </summary>
		public MNMFinding NMFinding { get ; protected set; }                                                                                      // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:396
		/// <summary>
		/// USFinding
		/// Access fhir element 'Observation.hasMember:uSFinding'
		/// </summary>
		public MUSFinding USFinding { get ; protected set; }                                                                                      // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:396
		/// <summary>
		/// BodySite
		/// Access fhir element 'Observation.bodySite'
		/// </summary>
		public MBodySite BodySite { get ; protected set; }                                                                                        // BuildMemberBase.cs:400
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:177
			this.Resource.BodySite = FixedValue_ObservationBodySite();                                                                               // DefineBase.cs:177
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // DefineBase.cs:238
			// Called from BuildMemberReferences.cs, Line 191
			this.MGFinding = new MMGFinding(0, 1);                                                                                                   // BuildMemberBase.cs:379
			// Called from BuildMemberReferences.cs, Line 191
			this.MRIFinding = new MMRIFinding(0, 1);                                                                                                 // BuildMemberBase.cs:379
			// Called from BuildMemberReferences.cs, Line 191
			this.NMFinding = new MNMFinding(0, 1);                                                                                                   // BuildMemberBase.cs:379
			// Called from BuildMemberReferences.cs, Line 191
			this.USFinding = new MUSFinding(0, 1);                                                                                                   // BuildMemberBase.cs:379
			// Called from BuildMemberElement.cs, Line 123
			this.BodySite = new MBodySite(1, 1);                                                                                                     // BuildMemberBase.cs:379
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
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:155
			//- !WriteHasMembers
			this.Resource.SetValue("bodySite", this.BodySite.Write(this.Doc));                                                                       // BuildMemberElement.cs:86
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
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:164
			//- !ReadHasMembers
			this.BodySite.Read(this.Doc, this.Resource.GetValue<CodeableConcept>("bodySite"));                                                       // BuildMemberElement.cs:71
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:155
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
		// DefineBase.cs:155
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
			// DefineBase.cs:199
			/// <summary>
			/// Set Observation.value[x] to one of the predefined items
			/// </summary>
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // DefineBase.cs:202
			{                                                                                                                                        // DefineBase.cs:203
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // DefineBase.cs:205
			}                                                                                                                                        // DefineBase.cs:208
			                                                                                                                                         // BuildMemberReferences.cs:119
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:122
			// BuildMemberReferences.cs:123
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:126
			{                                                                                                                                        // BuildMemberReferences.cs:127
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:128
			    //+ ReadHasMembers
			    this.MGFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:81
			    this.MRIFinding.Read(this.Doc, items);                                                                                               // BuildMemberReferences.cs:81
			    this.NMFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:81
			    this.USFinding.Read(this.Doc, items);                                                                                                // BuildMemberReferences.cs:81
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:130
			                                                                                                                                         // BuildMemberReferences.cs:132
			// BuildMemberReferences.cs:133
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:136
			{                                                                                                                                        // BuildMemberReferences.cs:137
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:138
			    //+ WriteHasMembers
			    items.AddRange(this.MGFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:99
			    items.AddRange(this.MRIFinding.Write(this.Doc));                                                                                     // BuildMemberReferences.cs:99
			    items.AddRange(this.NMFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:99
			    items.AddRange(this.USFinding.Write(this.Doc));                                                                                      // BuildMemberReferences.cs:99
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:140
			}                                                                                                                                        // BuildMemberReferences.cs:141
		//- !HasMembers
		//- Methods
	}
}
