using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityForeignObjectLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedChangesFragmentLocal;
using BreastRadLib.BiRadFragmentLocal;
using BreastRadLib.CommonComponentsFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class AbnormalityForeignObject.
	/// This class is automatically generated.
	/// </summary>
	public class AbnormalityForeignObject : ObservationBase, IAbnormalityForeignObject
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public ObsChangesContainer ObsChanges { get ; protected set; }                                                                            // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public BiRadsAssessmentCategoryContainer BiRadsAssessmentCategory { get ; protected set; }                                                // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public NotPreviouslySeenContainer NotPreviouslySeen { get ; protected set; }                                                              // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public CorrespondsWithContainer CorrespondsWith { get ; protected set; }                                                                  // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public PreviouslyDemonstratedByContainer PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:376
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public AssociatedFeatureContainer AssociatedFeature { get ; protected set; }                                                              // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberReferences.cs, Line 197
		// BuildMemberBase.cs:376
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public ConsistentWithContainer ConsistentWith { get ; protected set; }                                                                    // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 204
		// BuildMemberBase.cs:376
		/// <summary>
		/// AbnormalityForeignObjectType
		/// Access fhir element 'Observation.component:abnormalityForeignObjectType'
		/// </summary>
		public AbnormalityForeignObjectTypeContainer AbnormalityForeignObjectType { get ; protected set; }                                        // BuildMemberBase.cs:380
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityForeignObject() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityForeignObject(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityForeignObject(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                                   // DefineBase.cs:220
			// Called from BuildMemberComponents.cs, Line 204
			this.ObsChanges = new ObsChangesContainer(0, 0);                                                                                         // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 204
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategoryContainer(0, 0);                                                             // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 204
			this.NotPreviouslySeen = new NotPreviouslySeenContainer(0, 0);                                                                           // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 204
			this.CorrespondsWith = new CorrespondsWithContainer(0, 0);                                                                               // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 204
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedByContainer(0, 0);                                                             // BuildMemberBase.cs:359
			// Called from BuildMemberReferences.cs, Line 197
			this.AssociatedFeature = new AssociatedFeatureContainer(0, 0);                                                                           // BuildMemberBase.cs:359
			// Called from BuildMemberReferences.cs, Line 197
			this.ConsistentWith = new ConsistentWithContainer(0, 0);                                                                                 // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 204
			this.AbnormalityForeignObjectType = new AbnormalityForeignObjectTypeContainer(1, 1);                                                     // BuildMemberBase.cs:359
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
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:166
			//- !WriteComponents
			//+ !WriteHasMembers
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:161
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
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:175
			//- !ReadComponents
			//+ !ReadHasMembers
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:170
			//- !ReadHasMembers
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:137
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
		        temp4.CodeElement.Value = "abnormalityForeignObjectObservation";                                                                  // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Foreign Object observation";                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Foreign Object observation";                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			                                                                                                                                         // BuildMemberComponents.cs:130
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:133
			// BuildMemberComponents.cs:134
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:137
			{                                                                                                                                        // BuildMemberComponents.cs:138
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:139
			    //+ ReadComponents
			    this.ObsChanges.Read(this.Doc, items);                                                                                               // BuildMemberComponents.cs:88
			    this.BiRadsAssessmentCategory.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:88
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:88
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:88
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:88
			    this.AbnormalityForeignObjectType.Read(this.Doc, items);                                                                             // BuildMemberComponents.cs:88
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:141
			                                                                                                                                         // BuildMemberComponents.cs:143
			// BuildMemberComponents.cs:144
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:147
			{                                                                                                                                        // BuildMemberComponents.cs:148
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:149
			    //+ WriteComponents
			    items.AddRange(this.ObsChanges.Write(this.Doc));                                                                                     // BuildMemberComponents.cs:110
			    items.AddRange(this.BiRadsAssessmentCategory.Write(this.Doc));                                                                       // BuildMemberComponents.cs:110
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:110
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:110
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:110
			    items.AddRange(this.AbnormalityForeignObjectType.Write(this.Doc));                                                                   // BuildMemberComponents.cs:110
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:151
			}                                                                                                                                        // BuildMemberComponents.cs:152
		//- !Components
			                                                                                                                                         // BuildMemberComponents.cs:130
			                                                                                                                                         // BuildMemberComponents.cs:130
			                                                                                                                                         // BuildMemberComponents.cs:130
			                                                                                                                                         // BuildMemberComponents.cs:130
			                                                                                                                                         // BuildMemberReferences.cs:125
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:128
			// BuildMemberReferences.cs:129
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:132
			{                                                                                                                                        // BuildMemberReferences.cs:133
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:134
			    //+ ReadHasMembers
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:86
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:86
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:136
			                                                                                                                                         // BuildMemberReferences.cs:138
			// BuildMemberReferences.cs:139
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:142
			{                                                                                                                                        // BuildMemberReferences.cs:143
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:144
			    //+ WriteHasMembers
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:105
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:105
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:146
			}                                                                                                                                        // BuildMemberReferences.cs:147
		//- !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:125
		//- Methods
	}
}
