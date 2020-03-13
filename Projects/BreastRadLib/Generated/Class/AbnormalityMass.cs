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
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// TumorSatellite
		/// Access fhir element 'Observation.hasMember:tumorSatellite'
		/// </summary>
		public TumorSatelliteContainer TumorSatellite { get ; protected set; }                                                                    // BuildMemberBase.cs:311
		public TItemElementSingle<BodySiteExtended> BodySite { get; private set; }                                                                // DefineBase.cs:76
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public ObsChangesContainer ObsChanges { get ; protected set; }                                                                            // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public BiRadsAssessmentCategoryContainer BiRadsAssessmentCategory { get ; protected set; }                                                // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// Orientation
		/// Access fhir element 'Observation.component:orientation'
		/// </summary>
		public OrientationContainer Orientation { get ; protected set; }                                                                          // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// Shape
		/// Access fhir element 'Observation.component:shape'
		/// </summary>
		public ShapeContainer Shape { get ; protected set; }                                                                                      // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// Margin
		/// Access fhir element 'Observation.component:margin'
		/// </summary>
		public MarginContainer Margin { get ; protected set; }                                                                                    // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// MgDensity
		/// Access fhir element 'Observation.component:mgDensity'
		/// </summary>
		public MgDensityContainer MgDensity { get ; protected set; }                                                                              // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ObsCount
		/// Access fhir element 'Observation.component:obsCount'
		/// </summary>
		public ObsCountContainer ObsCount { get ; protected set; }                                                                                // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ObsSize
		/// Access fhir element 'Observation.component:obsSize'
		/// </summary>
		public ObsSizeContainer ObsSize { get ; protected set; }                                                                                  // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ObsDistribution
		/// Access fhir element 'Observation.component:obsDistribution'
		/// </summary>
		public ObsDistributionContainer ObsDistribution { get ; protected set; }                                                                  // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ObsDistRegionSize
		/// Access fhir element 'Observation.component:obsDistRegionSize'
		/// </summary>
		public ObsDistRegionSizeContainer ObsDistRegionSize { get ; protected set; }                                                              // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public NotPreviouslySeenContainer NotPreviouslySeen { get ; protected set; }                                                              // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public CorrespondsWithContainer CorrespondsWith { get ; protected set; }                                                                  // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public PreviouslyDemonstratedByContainer PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public AssociatedFeatureContainer AssociatedFeature { get ; protected set; }                                                              // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public ConsistentWithContainer ConsistentWith { get ; protected set; }                                                                    // BuildMemberBase.cs:311
		                                                                                                                                          // BuildMemberBase.cs:306
		/// <summary>
		/// MassType
		/// Access fhir element 'Observation.component:massType'
		/// </summary>
		public MassTypeContainer MassType { get ; protected set; }                                                                                // BuildMemberBase.cs:311
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:159
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");                                            // DefineBase.cs:220
			this.TumorSatellite = new TumorSatelliteContainer(0, 0);                                                                                 // BuildMemberBase.cs:295
			this.BodySite = new TItemElementSingle<BodySiteExtended>("Observation.bodySite", 1, 1);                                                  // DefineBase.cs:79
			this.ObsChanges = new ObsChangesContainer(0, 0);                                                                                         // BuildMemberBase.cs:295
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategoryContainer(0, 0);                                                             // BuildMemberBase.cs:295
			this.Orientation = new OrientationContainer(0, 0);                                                                                       // BuildMemberBase.cs:295
			this.Shape = new ShapeContainer(0, 0);                                                                                                   // BuildMemberBase.cs:295
			this.Margin = new MarginContainer(0, 0);                                                                                                 // BuildMemberBase.cs:295
			this.MgDensity = new MgDensityContainer(0, 0);                                                                                           // BuildMemberBase.cs:295
			this.ObsCount = new ObsCountContainer(0, 0);                                                                                             // BuildMemberBase.cs:295
			this.ObsSize = new ObsSizeContainer(0, 0);                                                                                               // BuildMemberBase.cs:295
			this.ObsDistribution = new ObsDistributionContainer(0, 0);                                                                               // BuildMemberBase.cs:295
			this.ObsDistRegionSize = new ObsDistRegionSizeContainer(0, 0);                                                                           // BuildMemberBase.cs:295
			this.NotPreviouslySeen = new NotPreviouslySeenContainer(0, 0);                                                                           // BuildMemberBase.cs:295
			this.CorrespondsWith = new CorrespondsWithContainer(0, 0);                                                                               // BuildMemberBase.cs:295
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedByContainer(0, 0);                                                             // BuildMemberBase.cs:295
			this.AssociatedFeature = new AssociatedFeatureContainer(0, 0);                                                                           // BuildMemberBase.cs:295
			this.ConsistentWith = new ConsistentWithContainer(0, 0);                                                                                 // BuildMemberBase.cs:295
			this.MassType = new MassTypeContainer(0, 0);                                                                                             // BuildMemberBase.cs:295
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
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:157
			//- !WriteHasMembers
			this.BodySite.Write(this.Doc, this.Resource);                                                                                            // DefineBase.cs:85
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:146
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
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:166
			//- !ReadHasMembers
			this.BodySite.Read(this.Doc, this.Resource);                                                                                             // DefineBase.cs:82
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:155
			//- !ReadComponents
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
		        temp4.CodeElement.Value = "abnormalityMassObservation";                                                                           // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Mass observation";                                                                      // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Mass observation";                                                                            // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			                                                                                                                                         // BuildMemberReferences.cs:121
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:124
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:128
			{                                                                                                                                        // BuildMemberReferences.cs:129
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:130
			    //+ ReadHasMembers
			    this.TumorSatellite.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:80
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:80
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:80
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:132
			                                                                                                                                         // BuildMemberReferences.cs:134
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:138
			{                                                                                                                                        // BuildMemberReferences.cs:139
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:140
			    //+ WriteHasMembers
			    items.AddRange(this.TumorSatellite.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:101
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:101
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:101
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:142
			}                                                                                                                                        // BuildMemberReferences.cs:143
		//- !HasMembers
			                                                                                                                                         // BuildMemberComponents.cs:110
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:113
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:117
			{                                                                                                                                        // BuildMemberComponents.cs:118
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:119
			    //+ ReadComponents
			    this.ObsChanges.Read(this.Doc, items);                                                                                               // BuildMemberComponents.cs:68
			    this.BiRadsAssessmentCategory.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:68
			    this.Orientation.Read(this.Doc, items);                                                                                              // BuildMemberComponents.cs:68
			    this.Shape.Read(this.Doc, items);                                                                                                    // BuildMemberComponents.cs:68
			    this.Margin.Read(this.Doc, items);                                                                                                   // BuildMemberComponents.cs:68
			    this.MgDensity.Read(this.Doc, items);                                                                                                // BuildMemberComponents.cs:68
			    this.ObsCount.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:68
			    this.ObsSize.Read(this.Doc, items);                                                                                                  // BuildMemberComponents.cs:68
			    this.ObsDistribution.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:68
			    this.ObsDistRegionSize.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:68
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:68
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:68
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:68
			    this.MassType.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:68
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:121
			                                                                                                                                         // BuildMemberComponents.cs:123
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:127
			{                                                                                                                                        // BuildMemberComponents.cs:128
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:129
			    //+ WriteComponents
			    items.AddRange(this.ObsChanges.Write(this.Doc));                                                                                     // BuildMemberComponents.cs:90
			    items.AddRange(this.BiRadsAssessmentCategory.Write(this.Doc));                                                                       // BuildMemberComponents.cs:90
			    items.AddRange(this.Orientation.Write(this.Doc));                                                                                    // BuildMemberComponents.cs:90
			    items.AddRange(this.Shape.Write(this.Doc));                                                                                          // BuildMemberComponents.cs:90
			    items.AddRange(this.Margin.Write(this.Doc));                                                                                         // BuildMemberComponents.cs:90
			    items.AddRange(this.MgDensity.Write(this.Doc));                                                                                      // BuildMemberComponents.cs:90
			    items.AddRange(this.ObsCount.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:90
			    items.AddRange(this.ObsSize.Write(this.Doc));                                                                                        // BuildMemberComponents.cs:90
			    items.AddRange(this.ObsDistribution.Write(this.Doc));                                                                                // BuildMemberComponents.cs:90
			    items.AddRange(this.ObsDistRegionSize.Write(this.Doc));                                                                              // BuildMemberComponents.cs:90
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:90
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:90
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:90
			    items.AddRange(this.MassType.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:90
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:131
			}                                                                                                                                        // BuildMemberComponents.cs:132
		//- !Components
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberComponents.cs:110
			                                                                                                                                         // BuildMemberReferences.cs:121
			                                                                                                                                         // BuildMemberReferences.cs:121
		//- Methods
	}
}
