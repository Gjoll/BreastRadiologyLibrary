using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityCystLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.TumorSatelliteFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedChangesFragmentLocal;
using BreastRadLib.BiRadFragmentLocal;
using BreastRadLib.CommonComponentsFragmentLocal;
using BreastRadLib.ShapeComponentsFragmentLocal;
using BreastRadLib.ObservedCountFragmentLocal;
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class AbnormalityCyst.
	/// This class is automatically generated.
	/// </summary>
	public class AbnormalityCyst : ObservationBase, IAbnormalityCyst
	{
		//+ Properties
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access TumorSatellite
		/// </summary>
		public TItemReferenceMultiple<TumorSatellite> TumorSatellite { get ; protected set; }                                                     // BuildElementItemReference.cs:62
		public TItemElementSingle<BodySiteExtended> BodySite { get; private set; }                                                                // DefineBase.cs:76
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsChanges
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> ObsChanges { get ; protected set; }                                                        // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access BiRadsAssessmentCategory
		/// </summary>
		public TItemComponentSingle<CodeableConcept> BiRadsAssessmentCategory { get ; protected set; }                                            // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access Orientation
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Orientation { get ; protected set; }                                                         // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access Shape
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Shape { get ; protected set; }                                                               // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access Margin
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Margin { get ; protected set; }                                                              // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access MgDensity
		/// </summary>
		public TItemComponentSingle<CodeableConcept> MgDensity { get ; protected set; }                                                           // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsCount
		/// </summary>
		public TItemComponentSingle<Quantity, Range> ObsCount { get ; protected set; }                                                            // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsDistribution
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> ObsDistribution { get ; protected set; }                                                   // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsDistRegionSize
		/// </summary>
		public TItemComponentMultiple<Quantity, Range> ObsDistRegionSize { get ; protected set; }                                                 // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsSize
		/// </summary>
		public TItemComponentMultiple<Quantity, Range> ObsSize { get ; protected set; }                                                           // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access NotPreviouslySeen
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> NotPreviouslySeen { get ; protected set; }                                                 // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access CorrespondsWith
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> CorrespondsWith { get ; protected set; }                                                   // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access PreviouslyDemonstratedBy
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> PreviouslyDemonstratedBy { get ; protected set; }                                          // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access ConsistentWith
		/// </summary>
		public TItemReferenceMultiple<ConsistentWith> ConsistentWith { get ; protected set; }                                                     // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AssociatedFeature
		/// </summary>
		public TItemReferenceMultiple<AssociatedFeature> AssociatedFeature { get ; protected set; }                                               // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access CystType
		/// </summary>
		public TItemComponentSingle<CodeableConcept> CystType { get ; protected set; }                                                            // BuildElementItemComponent.cs:72
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityCyst() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityCyst(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AbnormalityCyst(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                                            // DefineBase.cs:220
			this.TumorSatellite = new TItemReferenceMultiple<TumorSatellite>("Observation.hasMember:tumorSatellite", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");// BuildElementItemReference.cs:47
			this.BodySite = new TItemElementSingle<BodySiteExtended>("Observation.bodySite", 1, 1);                                                  // DefineBase.cs:79
			this.ObsChanges = new TItemComponentMultiple<CodeableConcept>("Observation.component:obsChanges", 0, -1, FixedValue_ObservationComponentObsChangesCode());// BuildElementItemComponent.cs:57
			this.BiRadsAssessmentCategory = new TItemComponentSingle<CodeableConcept>("Observation.component:biRadsAssessmentCategory", 0, 1, FixedValue_ObservationComponentBiRadsAssessmentCategoryCode());// BuildElementItemComponent.cs:57
			this.Orientation = new TItemComponentSingle<CodeableConcept>("Observation.component:orientation", 0, 1, FixedValue_ObservationComponentOrientationCode());// BuildElementItemComponent.cs:57
			this.Shape = new TItemComponentSingle<CodeableConcept>("Observation.component:shape", 0, 1, FixedValue_ObservationComponentShapeCode()); // BuildElementItemComponent.cs:57
			this.Margin = new TItemComponentSingle<CodeableConcept>("Observation.component:margin", 0, 1, FixedValue_ObservationComponentMarginCode());// BuildElementItemComponent.cs:57
			this.MgDensity = new TItemComponentSingle<CodeableConcept>("Observation.component:mgDensity", 0, 1, FixedValue_ObservationComponentMgDensityCode());// BuildElementItemComponent.cs:57
			this.ObsCount = new TItemComponentSingle<Quantity, Range>("Observation.component:obsCount", 0, 1, FixedValue_ObservationComponentObsCountCode());// BuildElementItemComponent.cs:57
			this.ObsDistribution = new TItemComponentMultiple<CodeableConcept>("Observation.component:obsDistribution", 0, -1, FixedValue_ObservationComponentObsDistributionCode());// BuildElementItemComponent.cs:57
			this.ObsDistRegionSize = new TItemComponentMultiple<Quantity, Range>("Observation.component:obsDistRegionSize", 0, 3, FixedValue_ObservationComponentObsDistRegionSizeCode());// BuildElementItemComponent.cs:57
			this.ObsSize = new TItemComponentMultiple<Quantity, Range>("Observation.component:obsSize", 0, 3, FixedValue_ObservationComponentObsSizeCode());// BuildElementItemComponent.cs:57
			this.NotPreviouslySeen = new TItemComponentMultiple<CodeableConcept>("Observation.component:notPreviouslySeen", 0, -1, FixedValue_ObservationComponentNotPreviouslySeenCode());// BuildElementItemComponent.cs:57
			this.CorrespondsWith = new TItemComponentMultiple<CodeableConcept>("Observation.component:correspondsWith", 0, -1, FixedValue_ObservationComponentCorrespondsWithCode());// BuildElementItemComponent.cs:57
			this.PreviouslyDemonstratedBy = new TItemComponentMultiple<CodeableConcept>("Observation.component:PreviouslyDemonstratedBy", 0, -1, FixedValue_ObservationComponentPreviouslyDemonstratedByCode());// BuildElementItemComponent.cs:57
			this.ConsistentWith = new TItemReferenceMultiple<ConsistentWith>("Observation.hasMember:consistentWith", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");// BuildElementItemReference.cs:47
			this.AssociatedFeature = new TItemReferenceMultiple<AssociatedFeature>("Observation.hasMember:associatedFeature", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature");// BuildElementItemReference.cs:47
			this.CystType = new TItemComponentSingle<CodeableConcept>("Observation.component:cystType", 0, 1, FixedValue_ObservationComponentCystTypeCode());// BuildElementItemComponent.cs:57
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
			if (this.TumorSatellite.Validate(sb) == false) retVal = false;                                                                           // BuildElementItemReference.cs:71
			if (this.ObsChanges.Validate(sb) == false) retVal = false;                                                                               // BuildElementItemComponent.cs:81
			if (this.BiRadsAssessmentCategory.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemComponent.cs:81
			if (this.Orientation.Validate(sb) == false) retVal = false;                                                                              // BuildElementItemComponent.cs:81
			if (this.Shape.Validate(sb) == false) retVal = false;                                                                                    // BuildElementItemComponent.cs:81
			if (this.Margin.Validate(sb) == false) retVal = false;                                                                                   // BuildElementItemComponent.cs:81
			if (this.MgDensity.Validate(sb) == false) retVal = false;                                                                                // BuildElementItemComponent.cs:81
			if (this.ObsCount.Validate(sb) == false) retVal = false;                                                                                 // BuildElementItemComponent.cs:81
			if (this.ObsDistribution.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemComponent.cs:81
			if (this.ObsDistRegionSize.Validate(sb) == false) retVal = false;                                                                        // BuildElementItemComponent.cs:81
			if (this.ObsSize.Validate(sb) == false) retVal = false;                                                                                  // BuildElementItemComponent.cs:81
			if (this.NotPreviouslySeen.Validate(sb) == false) retVal = false;                                                                        // BuildElementItemComponent.cs:81
			if (this.CorrespondsWith.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemComponent.cs:81
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemComponent.cs:81
			if (this.ConsistentWith.Validate(sb) == false) retVal = false;                                                                           // BuildElementItemReference.cs:71
			if (this.AssociatedFeature.Validate(sb) == false) retVal = false;                                                                        // BuildElementItemReference.cs:71
			if (this.CystType.Validate(sb) == false) retVal = false;                                                                                 // BuildElementItemComponent.cs:81
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
			this.ClearHasMember();
			this.ClearComponent();
			//- WriteCodeStart
			//+ WriteCode
			this.TumorSatellite.Write(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:65
			this.BodySite.Write(this.Doc, this.Resource);                                                                                            // DefineBase.cs:85
			this.ObsChanges.Write(this.Doc, this.Resource);                                                                                          // BuildElementItemComponent.cs:75
			this.BiRadsAssessmentCategory.Write(this.Doc, this.Resource);                                                                            // BuildElementItemComponent.cs:75
			this.Orientation.Write(this.Doc, this.Resource);                                                                                         // BuildElementItemComponent.cs:75
			this.Shape.Write(this.Doc, this.Resource);                                                                                               // BuildElementItemComponent.cs:75
			this.Margin.Write(this.Doc, this.Resource);                                                                                              // BuildElementItemComponent.cs:75
			this.MgDensity.Write(this.Doc, this.Resource);                                                                                           // BuildElementItemComponent.cs:75
			this.ObsCount.Write(this.Doc, this.Resource);                                                                                            // BuildElementItemComponent.cs:75
			this.ObsDistribution.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemComponent.cs:75
			this.ObsDistRegionSize.Write(this.Doc, this.Resource);                                                                                   // BuildElementItemComponent.cs:75
			this.ObsSize.Write(this.Doc, this.Resource);                                                                                             // BuildElementItemComponent.cs:75
			this.NotPreviouslySeen.Write(this.Doc, this.Resource);                                                                                   // BuildElementItemComponent.cs:75
			this.CorrespondsWith.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemComponent.cs:75
			this.PreviouslyDemonstratedBy.Write(this.Doc, this.Resource);                                                                            // BuildElementItemComponent.cs:75
			this.ConsistentWith.Write(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:65
			this.AssociatedFeature.Write(this.Doc, this.Resource);                                                                                   // BuildElementItemReference.cs:65
			this.CystType.Write(this.Doc, this.Resource);                                                                                            // BuildElementItemComponent.cs:75
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
			this.TumorSatellite.Read(this.Doc, this.Resource);                                                                                       // BuildElementItemReference.cs:68
			this.BodySite.Read(this.Doc, this.Resource);                                                                                             // DefineBase.cs:82
			this.ObsChanges.Read(this.Doc, this.Resource);                                                                                           // BuildElementItemComponent.cs:78
			this.BiRadsAssessmentCategory.Read(this.Doc, this.Resource);                                                                             // BuildElementItemComponent.cs:78
			this.Orientation.Read(this.Doc, this.Resource);                                                                                          // BuildElementItemComponent.cs:78
			this.Shape.Read(this.Doc, this.Resource);                                                                                                // BuildElementItemComponent.cs:78
			this.Margin.Read(this.Doc, this.Resource);                                                                                               // BuildElementItemComponent.cs:78
			this.MgDensity.Read(this.Doc, this.Resource);                                                                                            // BuildElementItemComponent.cs:78
			this.ObsCount.Read(this.Doc, this.Resource);                                                                                             // BuildElementItemComponent.cs:78
			this.ObsDistribution.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemComponent.cs:78
			this.ObsDistRegionSize.Read(this.Doc, this.Resource);                                                                                    // BuildElementItemComponent.cs:78
			this.ObsSize.Read(this.Doc, this.Resource);                                                                                              // BuildElementItemComponent.cs:78
			this.NotPreviouslySeen.Read(this.Doc, this.Resource);                                                                                    // BuildElementItemComponent.cs:78
			this.CorrespondsWith.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemComponent.cs:78
			this.PreviouslyDemonstratedBy.Read(this.Doc, this.Resource);                                                                             // BuildElementItemComponent.cs:78
			this.ConsistentWith.Read(this.Doc, this.Resource);                                                                                       // BuildElementItemReference.cs:68
			this.AssociatedFeature.Read(this.Doc, this.Resource);                                                                                    // BuildElementItemReference.cs:68
			this.CystType.Read(this.Doc, this.Resource);                                                                                             // BuildElementItemComponent.cs:78
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
		        temp4.CodeElement.Value = "abnormalityCyst";                                                                                      // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Cyst observation";                                                                      // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Cyst observation";                                                                            // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsChangesCode()                                                                   // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsChanges";                                                                                          // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentBiRadsAssessmentCategoryCode()                                                     // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "targetBiRads";                                                                                        // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentOrientationCode()                                                                  // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "orientation";                                                                                         // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentShapeCode()                                                                        // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "shape";                                                                                               // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentMarginCode()                                                                       // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "margin";                                                                                              // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentMgDensityCode()                                                                    // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "mgDensity";                                                                                           // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsCountCode()                                                                     // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsCount";                                                                                            // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsDistributionCode()                                                              // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsDistribution";                                                                                     // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsDistRegionSizeCode()                                                            // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsSize";                                                                                             // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsSizeCode()                                                                      // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsSize";                                                                                             // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentNotPreviouslySeenCode()                                                            // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "notPreviouslySeen";                                                                                   // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentCorrespondsWithCode()                                                              // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "correspondsWith";                                                                                     // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentPreviouslyDemonstratedByCode()                                                     // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "prevDemBy";                                                                                           // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationComponentCystTypeCode()                                                                      // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                  // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "abnormalityCystType";                                                                                  // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
