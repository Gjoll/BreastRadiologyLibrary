using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityCalcificationLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedChangesFragmentLocal;
using BreastRadLib.BiRadFragmentLocal;
using BreastRadLib.CommonComponentsFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.ObservedCountFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class MGAbnormalityCalcification.
	/// This class is automatically generated.
	/// </summary>
	public class MGAbnormalityCalcification : ObservationBase, IMGAbnormalityCalcification
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:392
		/// <summary>
		/// BodySite
		/// Access fhir element 'Observation.bodySite'
		/// </summary>
		public MBodySite BodySite { get ; protected set; }                                                                                        // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public MObsChanges ObsChanges { get ; protected set; }                                                                                    // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public MBiRadsAssessmentCategory BiRadsAssessmentCategory { get ; protected set; }                                                        // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public MNotPreviouslySeen NotPreviouslySeen { get ; protected set; }                                                                      // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// ObsCount
		/// Access fhir element 'Observation.component:obsCount'
		/// </summary>
		public MObsCount ObsCount { get ; protected set; }                                                                                        // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// ObsSize
		/// Access fhir element 'Observation.component:obsSize'
		/// </summary>
		public MObsSize ObsSize { get ; protected set; }                                                                                          // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// ObsDistribution
		/// Access fhir element 'Observation.component:obsDistribution'
		/// </summary>
		public MObsDistribution ObsDistribution { get ; protected set; }                                                                          // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// ObsDistRegionSize
		/// Access fhir element 'Observation.component:obsDistRegionSize'
		/// </summary>
		public MObsDistRegionSize ObsDistRegionSize { get ; protected set; }                                                                      // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public MCorrespondsWith CorrespondsWith { get ; protected set; }                                                                          // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public MPreviouslyDemonstratedBy PreviouslyDemonstratedBy { get ; protected set; }                                                        // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:392
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public MAssociatedFeature AssociatedFeature { get ; protected set; }                                                                      // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberReferences.cs, Line 191
		// BuildMemberBase.cs:392
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public MConsistentWith ConsistentWith { get ; protected set; }                                                                            // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// CalcificationType
		/// Access fhir element 'Observation.component:calcificationType'
		/// </summary>
		public MCalcificationType CalcificationType { get ; protected set; }                                                                      // BuildMemberBase.cs:396
		                                                                                                                                          // BuildMemberBase.cs:390
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:392
		/// <summary>
		/// CalcificationDistribution
		/// Access fhir element 'Observation.component:calcificationDistribution'
		/// </summary>
		public MCalcificationDistribution CalcificationDistribution { get ; protected set; }                                                      // BuildMemberBase.cs:396
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGAbnormalityCalcification() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGAbnormalityCalcification(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public MGAbnormalityCalcification(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                                 // DefineBase.cs:238
			// Called from BuildMemberElement.cs, Line 123
			this.BodySite = new MBodySite(1, 1);                                                                                                     // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsChanges = new MObsChanges(0, -1);                                                                                                // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.BiRadsAssessmentCategory = new MBiRadsAssessmentCategory(0, 1);                                                                     // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.NotPreviouslySeen = new MNotPreviouslySeen(0, -1);                                                                                  // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsCount = new MObsCount(0, 1);                                                                                                     // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsSize = new MObsSize(0, 3);                                                                                                       // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsDistribution = new MObsDistribution(0, -1);                                                                                      // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsDistRegionSize = new MObsDistRegionSize(0, 3);                                                                                   // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.CorrespondsWith = new MCorrespondsWith(0, -1);                                                                                      // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.PreviouslyDemonstratedBy = new MPreviouslyDemonstratedBy(0, -1);                                                                    // BuildMemberBase.cs:375
			// Called from BuildMemberReferences.cs, Line 191
			this.AssociatedFeature = new MAssociatedFeature(0, -1);                                                                                  // BuildMemberBase.cs:375
			// Called from BuildMemberReferences.cs, Line 191
			this.ConsistentWith = new MConsistentWith(0, -1);                                                                                        // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.CalcificationType = new MCalcificationType(0, 1);                                                                                   // BuildMemberBase.cs:375
			// Called from BuildMemberComponents.cs, Line 202
			this.CalcificationDistribution = new MCalcificationDistribution(0, 1);                                                                   // BuildMemberBase.cs:375
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
			this.Resource.SetValue("bodySite", this.BodySite.Write(this.Doc));                                                                       // BuildMemberElement.cs:86
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:164
			//- !WriteComponents
			//+ !WriteHasMembers
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:155
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
			this.BodySite.Read(this.Doc, this.Resource.GetValue<CodeableConcept>("bodySite"));                                                       // BuildMemberElement.cs:71
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:173
			//- !ReadComponents
			//+ !ReadHasMembers
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:164
			//- !ReadHasMembers
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
		        temp4.CodeElement.Value = "mgAbnormalityCalcificationObservation";                                                                // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Abnormality Calcification observation";                                                             // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Abnormality Calcification observation";                                                                   // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
			                                                                                                                                         // BuildMemberComponents.cs:128
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:131
			// BuildMemberComponents.cs:132
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:135
			{                                                                                                                                        // BuildMemberComponents.cs:136
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:137
			    //+ ReadComponents
			    this.ObsChanges.Read(this.Doc, items);                                                                                               // BuildMemberComponents.cs:90
			    this.BiRadsAssessmentCategory.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:90
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:90
			    this.ObsCount.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:90
			    this.ObsSize.Read(this.Doc, items);                                                                                                  // BuildMemberComponents.cs:90
			    this.ObsDistribution.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:90
			    this.ObsDistRegionSize.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:90
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:90
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:90
			    this.CalcificationType.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:90
			    this.CalcificationDistribution.Read(this.Doc, items);                                                                                // BuildMemberComponents.cs:90
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:139
			                                                                                                                                         // BuildMemberComponents.cs:141
			// BuildMemberComponents.cs:142
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:145
			{                                                                                                                                        // BuildMemberComponents.cs:146
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:147
			    //+ WriteComponents
			    items.AddRange(this.ObsChanges.Write(this.Doc));                                                                                     // BuildMemberComponents.cs:108
			    items.AddRange(this.BiRadsAssessmentCategory.Write(this.Doc));                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsCount.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsSize.Write(this.Doc));                                                                                        // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsDistribution.Write(this.Doc));                                                                                // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsDistRegionSize.Write(this.Doc));                                                                              // BuildMemberComponents.cs:108
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:108
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.CalcificationType.Write(this.Doc));                                                                              // BuildMemberComponents.cs:108
			    items.AddRange(this.CalcificationDistribution.Write(this.Doc));                                                                      // BuildMemberComponents.cs:108
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:149
			}                                                                                                                                        // BuildMemberComponents.cs:150
		//- !Components
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberComponents.cs:128
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
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:81
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:81
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
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:99
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:99
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:140
			}                                                                                                                                        // BuildMemberReferences.cs:141
		//- !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:119
		//- Methods
	}
}
