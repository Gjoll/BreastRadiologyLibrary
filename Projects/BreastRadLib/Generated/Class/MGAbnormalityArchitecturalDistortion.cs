using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityArchitecturalDistortionLocal;
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
using BreastRadLib.ShapeComponentsFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class MGAbnormalityArchitecturalDistortion.
	/// This class is automatically generated.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion : ObservationBase, IMGAbnormalityArchitecturalDistortion
	{
		//+ Properties
		public BodySiteExtended BodySite { get; private set; }                                                                                    // DefineBase.cs:75
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access ObsChanges
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> ObsChanges { get ; protected set; }                                                        // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access BiRadsAssessmentCategory
		/// </summary>
		public TItemComponentSingle<CodeableConcept> BiRadsAssessmentCategory { get ; protected set; }                                            // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access Orientation
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Orientation { get ; protected set; }                                                         // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access Shape
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Shape { get ; protected set; }                                                               // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access Margin
		/// </summary>
		public TItemComponentSingle<CodeableConcept> Margin { get ; protected set; }                                                              // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access MgDensity
		/// </summary>
		public TItemComponentSingle<CodeableConcept> MgDensity { get ; protected set; }                                                           // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access NotPreviouslySeen
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> NotPreviouslySeen { get ; protected set; }                                                 // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access CorrespondsWith
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> CorrespondsWith { get ; protected set; }                                                   // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemComponent.cs:70
		/// <summary>
		/// Access PreviouslyDemonstratedBy
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> PreviouslyDemonstratedBy { get ; protected set; }                                          // BuildElementItemComponent.cs:74
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		public TItemReferenceSingle<AssociatedFeatures> AssociatedFeatures { get ; protected set; }                                               // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access ConsistentWith
		/// </summary>
		public TItemReferenceMultiple<ConsistentWith> ConsistentWith { get ; protected set; }                                                     // BuildElementItemReference.cs:63
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGAbnormalityArchitecturalDistortion() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc)
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:158
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");                       // DefineBase.cs:219
			this.BodySite = new BodySiteExtended(1, 1);                                                                                              // DefineBase.cs:78
			this.ObsChanges = new TItemComponentMultiple<CodeableConcept>("ObsChanges", 0, -1, FixedValue_ObservationComponentObsChangesCode());     // BuildElementItemComponent.cs:59
			this.BiRadsAssessmentCategory = new TItemComponentSingle<CodeableConcept>("BiRadsAssessmentCategory", 0, 1, FixedValue_ObservationComponentBiRadsAssessmentCategoryCode());// BuildElementItemComponent.cs:59
			this.Orientation = new TItemComponentSingle<CodeableConcept>("Orientation", 0, 1, FixedValue_ObservationComponentOrientationCode());     // BuildElementItemComponent.cs:59
			this.Shape = new TItemComponentSingle<CodeableConcept>("Shape", 0, 1, FixedValue_ObservationComponentShapeCode());                       // BuildElementItemComponent.cs:59
			this.Margin = new TItemComponentSingle<CodeableConcept>("Margin", 0, 1, FixedValue_ObservationComponentMarginCode());                    // BuildElementItemComponent.cs:59
			this.MgDensity = new TItemComponentSingle<CodeableConcept>("MgDensity", 0, 1, FixedValue_ObservationComponentMgDensityCode());           // BuildElementItemComponent.cs:59
			this.NotPreviouslySeen = new TItemComponentMultiple<CodeableConcept>("NotPreviouslySeen", 0, -1, FixedValue_ObservationComponentNotPreviouslySeenCode());// BuildElementItemComponent.cs:59
			this.CorrespondsWith = new TItemComponentMultiple<CodeableConcept>("CorrespondsWith", 0, -1, FixedValue_ObservationComponentCorrespondsWithCode());// BuildElementItemComponent.cs:59
			this.PreviouslyDemonstratedBy = new TItemComponentMultiple<CodeableConcept>("PreviouslyDemonstratedBy", 0, -1, FixedValue_ObservationComponentPreviouslyDemonstratedByCode());// BuildElementItemComponent.cs:59
			this.AssociatedFeatures = new TItemReferenceSingle<AssociatedFeatures>("AssociatedFeatures", 0, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");// BuildElementItemReference.cs:48
			this.ConsistentWith = new TItemReferenceMultiple<ConsistentWith>("ConsistentWith", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");// BuildElementItemReference.cs:48
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
			if (this.ObsChanges.Validate(sb) == false) retVal = false;                                                                               // BuildElementItemComponent.cs:83
			if (this.BiRadsAssessmentCategory.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemComponent.cs:83
			if (this.Orientation.Validate(sb) == false) retVal = false;                                                                              // BuildElementItemComponent.cs:83
			if (this.Shape.Validate(sb) == false) retVal = false;                                                                                    // BuildElementItemComponent.cs:83
			if (this.Margin.Validate(sb) == false) retVal = false;                                                                                   // BuildElementItemComponent.cs:83
			if (this.MgDensity.Validate(sb) == false) retVal = false;                                                                                // BuildElementItemComponent.cs:83
			if (this.NotPreviouslySeen.Validate(sb) == false) retVal = false;                                                                        // BuildElementItemComponent.cs:83
			if (this.CorrespondsWith.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemComponent.cs:83
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemComponent.cs:83
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildElementItemReference.cs:72
			if (this.ConsistentWith.Validate(sb) == false) retVal = false;                                                                           // BuildElementItemReference.cs:72
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
			this.ClearHasMember();                                                                                                                   // BuildElementItemReference.cs:81
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildElementItemComponent.cs:92
			this.ClearHasMember();                                                                                                                   // BuildElementItemReference.cs:81
			this.ClearHasMember();                                                                                                                   // BuildElementItemReference.cs:81
			//- WriteCodeStart
			//+ WriteCode
			this.BodySite.Write();                                                                                                                   // DefineBase.cs:84
			this.WriteComponent(this.ObsChanges);                                                                                                    // BuildElementItemComponent.cs:77
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // BuildElementItemComponent.cs:77
			this.WriteComponent(this.Orientation);                                                                                                   // BuildElementItemComponent.cs:77
			this.WriteComponent(this.Shape);                                                                                                         // BuildElementItemComponent.cs:77
			this.WriteComponent(this.Margin);                                                                                                        // BuildElementItemComponent.cs:77
			this.WriteComponent(this.MgDensity);                                                                                                     // BuildElementItemComponent.cs:77
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // BuildElementItemComponent.cs:77
			this.WriteComponent(this.CorrespondsWith);                                                                                               // BuildElementItemComponent.cs:77
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // BuildElementItemComponent.cs:77
			this.WriteHasMembers(this.AssociatedFeatures);                                                                                           // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.ConsistentWith);                                                                                               // BuildElementItemReference.cs:66
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
			this.BodySite.Read();                                                                                                                    // DefineBase.cs:81
			this.ReadComponent(this.ObsChanges);                                                                                                     // BuildElementItemComponent.cs:80
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // BuildElementItemComponent.cs:80
			this.ReadComponent(this.Orientation);                                                                                                    // BuildElementItemComponent.cs:80
			this.ReadComponent(this.Shape);                                                                                                          // BuildElementItemComponent.cs:80
			this.ReadComponent(this.Margin);                                                                                                         // BuildElementItemComponent.cs:80
			this.ReadComponent(this.MgDensity);                                                                                                      // BuildElementItemComponent.cs:80
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // BuildElementItemComponent.cs:80
			this.ReadComponent(this.CorrespondsWith);                                                                                                // BuildElementItemComponent.cs:80
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // BuildElementItemComponent.cs:80
			this.ReadHasMembers(this.AssociatedFeatures);                                                                                            // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.ConsistentWith);                                                                                                // BuildElementItemReference.cs:69
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
		        temp4.CodeElement.Value = "mgAbnormalityArchitecturalDistortionObservation";                                                      // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Architectural Distortion observation";                                                  // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Architectural Distortion observation";                                                        // FhirConstruct.cs:821
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
		//- Methods
	}
}
