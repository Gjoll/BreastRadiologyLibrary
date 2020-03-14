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
		public TItemElementSingle<BodySiteExtended> BodySite { get; private set; }                                                                // DefineBase.cs:76
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public ObsChangesContainer ObsChanges { get ; protected set; }                                                                            // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public BiRadsAssessmentCategoryContainer BiRadsAssessmentCategory { get ; protected set; }                                                // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public NotPreviouslySeenContainer NotPreviouslySeen { get ; protected set; }                                                              // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public CorrespondsWithContainer CorrespondsWith { get ; protected set; }                                                                  // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public PreviouslyDemonstratedByContainer PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public AssociatedFeatureContainer AssociatedFeature { get ; protected set; }                                                              // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public ConsistentWithContainer ConsistentWith { get ; protected set; }                                                                    // BuildMemberBase.cs:332
		                                                                                                                                          // BuildMemberBase.cs:327
		/// <summary>
		/// AbnormalityForeignObjectType
		/// Access fhir element 'Observation.component:abnormalityForeignObjectType'
		/// </summary>
		public AbnormalityForeignObjectTypeContainer AbnormalityForeignObjectType { get ; protected set; }                                        // BuildMemberBase.cs:332
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
			this.BodySite = new TItemElementSingle<BodySiteExtended>("Observation.bodySite", 1, 1);                                                  // DefineBase.cs:79
			this.ObsChanges = new ObsChangesContainer(0, 0);                                                                                         // BuildMemberBase.cs:316
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategoryContainer(0, 0);                                                             // BuildMemberBase.cs:316
			this.NotPreviouslySeen = new NotPreviouslySeenContainer(0, 0);                                                                           // BuildMemberBase.cs:316
			this.CorrespondsWith = new CorrespondsWithContainer(0, 0);                                                                               // BuildMemberBase.cs:316
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedByContainer(0, 0);                                                             // BuildMemberBase.cs:316
			this.AssociatedFeature = new AssociatedFeatureContainer(0, 0);                                                                           // BuildMemberBase.cs:316
			this.ConsistentWith = new ConsistentWithContainer(0, 0);                                                                                 // BuildMemberBase.cs:316
			this.AbnormalityForeignObjectType = new AbnormalityForeignObjectTypeContainer(1, 1);                                                     // BuildMemberBase.cs:316
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
			this.BodySite.Write(this.Doc, this.Resource);                                                                                            // DefineBase.cs:85
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:145
			//- !WriteComponents
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
			this.BodySite.Read(this.Doc, this.Resource);                                                                                             // DefineBase.cs:82
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:154
			//- !ReadComponents
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
		        temp4.CodeElement.Value = "abnormalityForeignObjectObservation";                                                                  // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Foreign Object observation";                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Foreign Object observation";                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			                                                                                                                                         // BuildMemberComponents.cs:109
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:112
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:116
			{                                                                                                                                        // BuildMemberComponents.cs:117
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:118
			    //+ ReadComponents
			    this.ObsChanges.Read(this.Doc, items);                                                                                               // BuildMemberComponents.cs:67
			    this.BiRadsAssessmentCategory.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:67
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:67
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:67
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:67
			    this.AbnormalityForeignObjectType.Read(this.Doc, items);                                                                             // BuildMemberComponents.cs:67
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:120
			                                                                                                                                         // BuildMemberComponents.cs:122
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:126
			{                                                                                                                                        // BuildMemberComponents.cs:127
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:128
			    //+ WriteComponents
			    items.AddRange(this.ObsChanges.Write(this.Doc));                                                                                     // BuildMemberComponents.cs:89
			    items.AddRange(this.BiRadsAssessmentCategory.Write(this.Doc));                                                                       // BuildMemberComponents.cs:89
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:89
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:89
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:89
			    items.AddRange(this.AbnormalityForeignObjectType.Write(this.Doc));                                                                   // BuildMemberComponents.cs:89
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:130
			}                                                                                                                                        // BuildMemberComponents.cs:131
		//- !Components
			                                                                                                                                         // BuildMemberComponents.cs:109
			                                                                                                                                         // BuildMemberComponents.cs:109
			                                                                                                                                         // BuildMemberComponents.cs:109
			                                                                                                                                         // BuildMemberComponents.cs:109
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
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:67
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:67
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
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:88
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:88
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:129
			}                                                                                                                                        // BuildMemberReferences.cs:130
		//- !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:108
		//- Methods
	}
}
