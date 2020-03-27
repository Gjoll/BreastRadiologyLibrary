using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityMassLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.TumorSatelliteFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedChangesFragmentLocal;
using BreastRadLib.BiRadFragmentLocal;
using BreastRadLib.CommonComponentsFragmentLocal;
using BreastRadLib.ShapeComponentsFragmentLocal;
using BreastRadLib.ObservedCountFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class AbnormalityMass.
	/// This class is automatically generated.
	/// </summary>
	public class AbnormalityMass : ObservationBase, IAbnormalityMass
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:395
		/// <summary>
		/// TumorSatellite
		/// Access fhir element 'Observation.hasMember:tumorSatellite'
		/// </summary>
		public MTumorSatellite TumorSatellite { get ; protected set; }                                                                            // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:395
		/// <summary>
		/// BodySite
		/// Access fhir element 'Observation.bodySite'
		/// </summary>
		public MBodySite BodySite { get ; protected set; }                                                                                        // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public MObsChanges ObsChanges { get ; protected set; }                                                                                    // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public MBiRadsAssessmentCategory BiRadsAssessmentCategory { get ; protected set; }                                                        // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// Orientation
		/// Access fhir element 'Observation.component:orientation'
		/// </summary>
		public MOrientation Orientation { get ; protected set; }                                                                                  // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// Shape
		/// Access fhir element 'Observation.component:shape'
		/// </summary>
		public MShape Shape { get ; protected set; }                                                                                              // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// Margin
		/// Access fhir element 'Observation.component:margin'
		/// </summary>
		public MMargin Margin { get ; protected set; }                                                                                            // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// MgDensity
		/// Access fhir element 'Observation.component:mgDensity'
		/// </summary>
		public MMgDensity MgDensity { get ; protected set; }                                                                                      // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// ObsCount
		/// Access fhir element 'Observation.component:obsCount'
		/// </summary>
		public MObsCount ObsCount { get ; protected set; }                                                                                        // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// ObsSize
		/// Access fhir element 'Observation.component:obsSize'
		/// </summary>
		public MObsSize ObsSize { get ; protected set; }                                                                                          // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// ObsDistribution
		/// Access fhir element 'Observation.component:obsDistribution'
		/// </summary>
		public MObsDistribution ObsDistribution { get ; protected set; }                                                                          // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// ObsDistRegionSize
		/// Access fhir element 'Observation.component:obsDistRegionSize'
		/// </summary>
		public MObsDistRegionSize ObsDistRegionSize { get ; protected set; }                                                                      // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public MNotPreviouslySeen NotPreviouslySeen { get ; protected set; }                                                                      // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public MCorrespondsWith CorrespondsWith { get ; protected set; }                                                                          // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public MPreviouslyDemonstratedBy PreviouslyDemonstratedBy { get ; protected set; }                                                        // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:395
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public MAssociatedFeature AssociatedFeature { get ; protected set; }                                                                      // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberReferences.cs, Line 188
		// BuildMemberBase.cs:395
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public MConsistentWith ConsistentWith { get ; protected set; }                                                                            // BuildMemberBase.cs:399
		                                                                                                                                          // BuildMemberBase.cs:393
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:395
		/// <summary>
		/// MassType
		/// Access fhir element 'Observation.component:massType'
		/// </summary>
		public MMassType MassType { get ; protected set; }                                                                                        // BuildMemberBase.cs:399
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityMass() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityMass(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityMass(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                                            // DefineBase.cs:238
			// Called from BuildMemberReferences.cs, Line 188
			this.TumorSatellite = new MTumorSatellite(0, -1);                                                                                        // BuildMemberBase.cs:378
			// Called from BuildMemberElement.cs, Line 123
			this.BodySite = new MBodySite(1, 1);                                                                                                     // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsChanges = new MObsChanges(0, -1);                                                                                                // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.BiRadsAssessmentCategory = new MBiRadsAssessmentCategory(0, 1);                                                                     // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.Orientation = new MOrientation(0, 1);                                                                                               // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.Shape = new MShape(0, 1);                                                                                                           // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.Margin = new MMargin(0, 1);                                                                                                         // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.MgDensity = new MMgDensity(0, 1);                                                                                                   // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsCount = new MObsCount(0, 1);                                                                                                     // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsSize = new MObsSize(0, 3);                                                                                                       // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsDistribution = new MObsDistribution(0, -1);                                                                                      // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsDistRegionSize = new MObsDistRegionSize(0, 3);                                                                                   // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.NotPreviouslySeen = new MNotPreviouslySeen(0, -1);                                                                                  // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.CorrespondsWith = new MCorrespondsWith(0, -1);                                                                                      // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.PreviouslyDemonstratedBy = new MPreviouslyDemonstratedBy(0, -1);                                                                    // BuildMemberBase.cs:378
			// Called from BuildMemberReferences.cs, Line 188
			this.AssociatedFeature = new MAssociatedFeature(0, -1);                                                                                  // BuildMemberBase.cs:378
			// Called from BuildMemberReferences.cs, Line 188
			this.ConsistentWith = new MConsistentWith(0, -1);                                                                                        // BuildMemberBase.cs:378
			// Called from BuildMemberComponents.cs, Line 202
			this.MassType = new MMassType(0, 1);                                                                                                     // BuildMemberBase.cs:378
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
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:152
			//- !WriteHasMembers
			this.Resource.SetValue("bodySite", this.BodySite.Write(this.Doc));                                                                       // BuildMemberElement.cs:86
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:164
			//- !WriteComponents
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
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:161
			//- !ReadHasMembers
			this.BodySite.Read(this.Doc, this.Resource.GetValue<CodeableConcept>("bodySite"));                                                       // BuildMemberElement.cs:71
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:173
			//- !ReadComponents
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
		        temp4.CodeElement.Value = "abnormalityMassObservation";                                                                           // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Abnormality Mass observation";                                                                      // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Abnormality Mass observation";                                                                            // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
			                                                                                                                                         // BuildMemberReferences.cs:116
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:119
			// BuildMemberReferences.cs:120
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:123
			{                                                                                                                                        // BuildMemberReferences.cs:124
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:125
			    //+ ReadHasMembers
			    this.TumorSatellite.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:78
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:78
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:78
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:127
			                                                                                                                                         // BuildMemberReferences.cs:129
			// BuildMemberReferences.cs:130
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:133
			{                                                                                                                                        // BuildMemberReferences.cs:134
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:135
			    //+ WriteHasMembers
			    items.AddRange(this.TumorSatellite.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:96
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:96
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:96
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:137
			}                                                                                                                                        // BuildMemberReferences.cs:138
		//- !HasMembers
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
			    this.Orientation.Read(this.Doc, items);                                                                                              // BuildMemberComponents.cs:90
			    this.Shape.Read(this.Doc, items);                                                                                                    // BuildMemberComponents.cs:90
			    this.Margin.Read(this.Doc, items);                                                                                                   // BuildMemberComponents.cs:90
			    this.MgDensity.Read(this.Doc, items);                                                                                                // BuildMemberComponents.cs:90
			    this.ObsCount.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:90
			    this.ObsSize.Read(this.Doc, items);                                                                                                  // BuildMemberComponents.cs:90
			    this.ObsDistribution.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:90
			    this.ObsDistRegionSize.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:90
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:90
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:90
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:90
			    this.MassType.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:90
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
			    items.AddRange(this.Orientation.Write(this.Doc));                                                                                    // BuildMemberComponents.cs:108
			    items.AddRange(this.Shape.Write(this.Doc));                                                                                          // BuildMemberComponents.cs:108
			    items.AddRange(this.Margin.Write(this.Doc));                                                                                         // BuildMemberComponents.cs:108
			    items.AddRange(this.MgDensity.Write(this.Doc));                                                                                      // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsCount.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsSize.Write(this.Doc));                                                                                        // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsDistribution.Write(this.Doc));                                                                                // BuildMemberComponents.cs:108
			    items.AddRange(this.ObsDistRegionSize.Write(this.Doc));                                                                              // BuildMemberComponents.cs:108
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:108
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:108
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.MassType.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:108
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
			                                                                                                                                         // BuildMemberComponents.cs:128
			                                                                                                                                         // BuildMemberReferences.cs:116
			                                                                                                                                         // BuildMemberReferences.cs:116
		//- Methods
	}
}
