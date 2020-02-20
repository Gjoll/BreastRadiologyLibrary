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
	public class MGAbnormalityCalcification : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSBuildMemberListBase.cs:40
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSBuildMemberListBase.cs:40
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSBuildMemberListBase.cs:40
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSBuildMemberListBase.cs:40
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSBuildMemberListBase.cs:40
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSBuildMemberListBase.cs:40
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSBuildMemberListBase.cs:40
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildMemberListBase.cs:40
		public ConsistentWith_Accessor ConsistentWith { get ; protected set; }                                                                    // CSBuildMemberListBase.cs:40
		public CalcificationType_Accessor CalcificationType { get ; protected set; }                                                              // CSBuildMemberListBase.cs:40
		public CalcificationDistribution_Accessor CalcificationDistribution { get ; protected set; }                                              // CSBuildMemberListBase.cs:40
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public MGAbnormalityCalcification() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGAbnormalityCalcification(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:121
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");                                 // CSDefineBase.cs:182
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSBuildMemberListBase.cs:43
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSBuildMemberListBase.cs:43
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // CSBuildMemberListBase.cs:43
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSBuildMemberListBase.cs:43
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // CSBuildMemberListBase.cs:43
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // CSBuildMemberListBase.cs:43
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSBuildMemberListBase.cs:43
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildMemberListBase.cs:43
			this.ConsistentWith = new ConsistentWith_Accessor(doc);                                                                                  // CSBuildMemberListBase.cs:43
			this.CalcificationType = new CalcificationType_Accessor(doc);                                                                            // CSBuildMemberListBase.cs:43
			this.CalcificationDistribution = new CalcificationDistribution_Accessor(doc);                                                            // CSBuildMemberListBase.cs:43
			//- Constructor
		}

		public override void Validate()
		{
			base.Validate();
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:83
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:83
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:83
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			//- WriteCodeStart
			//+ WriteCode
			this.WriteComponent(this.ObsChanges);                                                                                                    // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.ObsCount);                                                                                                      // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.ObsSize);                                                                                                       // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.ObsDistribution);                                                                                               // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.CorrespondsWith);                                                                                               // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.ConsistentWith);                                                                                                // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.CalcificationType);                                                                                             // CSBuildMemberListBase.cs:46
			this.WriteComponent(this.CalcificationDistribution);                                                                                     // CSBuildMemberListBase.cs:46
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.ObsChanges);                                                                                                     // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.ObsCount);                                                                                                       // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.ObsSize);                                                                                                        // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.ObsDistribution);                                                                                                // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.CorrespondsWith);                                                                                                // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.ConsistentWith);                                                                                                 // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.CalcificationType);                                                                                              // CSBuildMemberListBase.cs:49
			this.ReadComponent(this.CalcificationDistribution);                                                                                      // CSBuildMemberListBase.cs:49
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
