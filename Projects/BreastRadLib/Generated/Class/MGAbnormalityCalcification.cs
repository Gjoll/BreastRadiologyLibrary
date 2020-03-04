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
		public BreastBodyLocation bodySite { get; protected set; }                                                                                // DefineBase.cs:75
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsChanges
		/// </summary>
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value BiRadsAssessmentCategory
		/// </summary>
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value NotPreviouslySeen
		/// </summary>
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsCount
		/// </summary>
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsSize
		/// </summary>
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsDistribution
		/// </summary>
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsDistRegionSize
		/// </summary>
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value CorrespondsWith
		/// </summary>
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value PreviouslyDemonstratedBy
		/// </summary>
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListReference.cs:59
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		public ElementItemReferenceSingle<AssociatedFeatures> AssociatedFeatures { get ; protected set; }                                         // BuildMemberListReference.cs:63
		                                                                                                                                          // BuildMemberListReference.cs:59
		/// <summary>
		/// Access ConsistentWith
		/// </summary>
		public ElementItemReferenceMultiple<ConsistentWith> ConsistentWith { get ; protected set; }                                               // BuildMemberListReference.cs:63
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value CalcificationType
		/// </summary>
		public CalcificationType_Accessor CalcificationType { get ; protected set; }                                                              // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value CalcificationDistribution
		/// </summary>
		public CalcificationDistribution_Accessor CalcificationDistribution { get ; protected set; }                                              // BuildMemberListBase.cs:70
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                                 // DefineBase.cs:215
			this.bodySite = new BreastBodyLocation(doc);                                                                                             // DefineBase.cs:78
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // BuildMemberListBase.cs:73
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // BuildMemberListBase.cs:73
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // BuildMemberListBase.cs:73
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // BuildMemberListBase.cs:73
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // BuildMemberListBase.cs:73
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.AssociatedFeatures = new ElementItemReferenceSingle<AssociatedFeatures>("AssociatedFeatures", 0, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");// BuildMemberListReference.cs:48
			this.ConsistentWith = new ElementItemReferenceMultiple<ConsistentWith>("ConsistentWith", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");// BuildMemberListReference.cs:48
			this.CalcificationType = new CalcificationType_Accessor(doc);                                                                            // BuildMemberListBase.cs:73
			this.CalcificationDistribution = new CalcificationDistribution_Accessor(doc);                                                            // BuildMemberListBase.cs:73
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
			if (this.ObsChanges.Validate(sb) == false) retVal = false;                                                                               // BuildMemberListBase.cs:82
			if (this.BiRadsAssessmentCategory.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:82
			if (this.NotPreviouslySeen.Validate(sb) == false) retVal = false;                                                                        // BuildMemberListBase.cs:82
			if (this.ObsCount.Validate(sb) == false) retVal = false;                                                                                 // BuildMemberListBase.cs:82
			if (this.ObsSize.Validate(sb) == false) retVal = false;                                                                                  // BuildMemberListBase.cs:82
			if (this.ObsDistribution.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.ObsDistRegionSize.Validate(sb) == false) retVal = false;                                                                        // BuildMemberListBase.cs:82
			if (this.CorrespondsWith.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:82
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListReference.cs:72
			if (this.ConsistentWith.Validate(sb) == false) retVal = false;                                                                           // BuildMemberListReference.cs:72
			if (this.CalcificationType.Validate(sb) == false) retVal = false;                                                                        // BuildMemberListBase.cs:82
			if (this.CalcificationDistribution.Validate(sb) == false) retVal = false;                                                                // BuildMemberListBase.cs:82
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
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:81
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:81
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:81
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			//- WriteCodeStart
			//+ WriteCode
			this.bodySite.Write();                                                                                                                   // DefineBase.cs:84
			this.WriteComponent(this.ObsChanges);                                                                                                    // BuildMemberListBase.cs:76
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // BuildMemberListBase.cs:76
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsCount);                                                                                                      // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsSize);                                                                                                       // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsDistribution);                                                                                               // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // BuildMemberListBase.cs:76
			this.WriteComponent(this.CorrespondsWith);                                                                                               // BuildMemberListBase.cs:76
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // BuildMemberListBase.cs:76
			this.WriteHasMembers(this.AssociatedFeatures);                                                                                           // BuildMemberListReference.cs:66
			this.WriteHasMembers(this.ConsistentWith);                                                                                               // BuildMemberListReference.cs:66
			this.WriteComponent(this.CalcificationType);                                                                                             // BuildMemberListBase.cs:76
			this.WriteComponent(this.CalcificationDistribution);                                                                                     // BuildMemberListBase.cs:76
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
			this.bodySite.Read();                                                                                                                    // DefineBase.cs:81
			this.ReadComponent(this.ObsChanges);                                                                                                     // BuildMemberListBase.cs:79
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // BuildMemberListBase.cs:79
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsCount);                                                                                                       // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsSize);                                                                                                        // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsDistribution);                                                                                                // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // BuildMemberListBase.cs:79
			this.ReadComponent(this.CorrespondsWith);                                                                                                // BuildMemberListBase.cs:79
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // BuildMemberListBase.cs:79
			this.ReadHasMembers(this.AssociatedFeatures);                                                                                            // BuildMemberListReference.cs:69
			this.ReadHasMembers(this.ConsistentWith);                                                                                                // BuildMemberListReference.cs:69
			this.ReadComponent(this.CalcificationType);                                                                                              // BuildMemberListBase.cs:79
			this.ReadComponent(this.CalcificationDistribution);                                                                                      // BuildMemberListBase.cs:79
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create default value for element
		/// Observation.code
		/// </summary>
		public CodeableConcept DefaultValue_1()                                                                                                   // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes";                                // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "mgAbnormalityCalcificationObservation";                                                                // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Calcification observation";                                                             // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Calcification observation";                                                                   // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
