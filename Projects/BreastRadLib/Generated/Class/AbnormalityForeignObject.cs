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
		public BodySiteExtended BodySite { get; private set; }                                                                                    // DefineBase.cs:75
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access ObsChanges
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> ObsChanges { get ; protected set; }                                                  // BuildItemComponent.cs:74
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access BiRadsAssessmentCategory
		/// </summary>
		public TItemComponentSingle<CodeableConcept> BiRadsAssessmentCategory { get ; protected set; }                                      // BuildItemComponent.cs:74
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access NotPreviouslySeen
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> NotPreviouslySeen { get ; protected set; }                                           // BuildItemComponent.cs:74
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access CorrespondsWith
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> CorrespondsWith { get ; protected set; }                                             // BuildItemComponent.cs:74
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access PreviouslyDemonstratedBy
		/// </summary>
		public TItemComponentMultiple<CodeableConcept> PreviouslyDemonstratedBy { get ; protected set; }                                    // BuildItemComponent.cs:74
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		public TItemReferenceSingle<AssociatedFeatures> AssociatedFeatures { get ; protected set; }                                         // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access ConsistentWith
		/// </summary>
		public TItemReferenceMultiple<ConsistentWith> ConsistentWith { get ; protected set; }                                               // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemComponent.cs:70
		/// <summary>
		/// Access AbnormalityForeignObjectType
		/// </summary>
		public TItemComponentSingle<CodeableConcept> AbnormalityForeignObjectType { get ; protected set; }                                  // BuildItemComponent.cs:74
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:158
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                                   // DefineBase.cs:219
			this.BodySite = new BodySiteExtended(1, 1);                                                                                              // DefineBase.cs:78
			this.ObsChanges = new TItemComponentMultiple<CodeableConcept>("ObsChanges", 0, -1, FixedValue_ObservationComponentObsChangesCode());// BuildItemComponent.cs:59
			this.BiRadsAssessmentCategory = new TItemComponentSingle<CodeableConcept>("BiRadsAssessmentCategory", 0, 1, FixedValue_ObservationComponentBiRadsAssessmentCategoryCode());// BuildItemComponent.cs:59
			this.NotPreviouslySeen = new TItemComponentMultiple<CodeableConcept>("NotPreviouslySeen", 0, -1, FixedValue_ObservationComponentNotPreviouslySeenCode());// BuildItemComponent.cs:59
			this.CorrespondsWith = new TItemComponentMultiple<CodeableConcept>("CorrespondsWith", 0, -1, FixedValue_ObservationComponentCorrespondsWithCode());// BuildItemComponent.cs:59
			this.PreviouslyDemonstratedBy = new TItemComponentMultiple<CodeableConcept>("PreviouslyDemonstratedBy", 0, -1, FixedValue_ObservationComponentPreviouslyDemonstratedByCode());// BuildItemComponent.cs:59
			this.AssociatedFeatures = new TItemReferenceSingle<AssociatedFeatures>("AssociatedFeatures", 0, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");// BuildItemReference.cs:48
			this.ConsistentWith = new TItemReferenceMultiple<ConsistentWith>("ConsistentWith", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");// BuildItemReference.cs:48
			this.AbnormalityForeignObjectType = new TItemComponentSingle<CodeableConcept>("AbnormalityForeignObjectType", 1, 1, FixedValue_ObservationComponentAbnormalityForeignObjectTypeCode());// BuildItemComponent.cs:59
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
			if (this.ObsChanges.Validate(sb) == false) retVal = false;                                                                               // BuildItemComponent.cs:83
			if (this.BiRadsAssessmentCategory.Validate(sb) == false) retVal = false;                                                                 // BuildItemComponent.cs:83
			if (this.NotPreviouslySeen.Validate(sb) == false) retVal = false;                                                                        // BuildItemComponent.cs:83
			if (this.CorrespondsWith.Validate(sb) == false) retVal = false;                                                                          // BuildItemComponent.cs:83
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildItemComponent.cs:83
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildItemReference.cs:72
			if (this.ConsistentWith.Validate(sb) == false) retVal = false;                                                                           // BuildItemReference.cs:72
			if (this.AbnormalityForeignObjectType.Validate(sb) == false) retVal = false;                                                             // BuildItemComponent.cs:83
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
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearHasMember();                                                                                                                   // BuildItemReference.cs:81
			this.ClearHasMember();                                                                                                                   // BuildItemReference.cs:81
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			//- WriteCodeStart
			//+ WriteCode
			this.BodySite.Write();                                                                                                                   // DefineBase.cs:84
			this.WriteComponent(this.ObsChanges);                                                                                                    // BuildItemComponent.cs:77
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // BuildItemComponent.cs:77
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // BuildItemComponent.cs:77
			this.WriteComponent(this.CorrespondsWith);                                                                                               // BuildItemComponent.cs:77
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // BuildItemComponent.cs:77
			this.WriteHasMembers(this.AssociatedFeatures);                                                                                           // BuildItemReference.cs:66
			this.WriteHasMembers(this.ConsistentWith);                                                                                               // BuildItemReference.cs:66
			this.WriteComponent(this.AbnormalityForeignObjectType);                                                                                  // BuildItemComponent.cs:77
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
			this.ReadComponent(this.ObsChanges);                                                                                                     // BuildItemComponent.cs:80
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // BuildItemComponent.cs:80
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // BuildItemComponent.cs:80
			this.ReadComponent(this.CorrespondsWith);                                                                                                // BuildItemComponent.cs:80
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // BuildItemComponent.cs:80
			this.ReadHasMembers(this.AssociatedFeatures);                                                                                            // BuildItemReference.cs:69
			this.ReadHasMembers(this.ConsistentWith);                                                                                                // BuildItemReference.cs:69
			this.ReadComponent(this.AbnormalityForeignObjectType);                                                                                   // BuildItemComponent.cs:80
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
		public CodeableConcept FixedValue_ObservationComponentAbnormalityForeignObjectTypeCode()                                                  // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                  // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "abnormalityForeignObjectType";                                                                         // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
