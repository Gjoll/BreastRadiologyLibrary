using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityDensityLocal;
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
	public class MGAbnormalityDensity : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, IShapeComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSBuildMemberListCodedValue.cs:214
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSBuildMemberListCodedValue.cs:214
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSBuildMemberListCodedValue.cs:214
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSBuildMemberListCodedValue.cs:214
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSBuildMemberListCodedValue.cs:214
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSBuildMemberListCodedValue.cs:214
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSBuildMemberListCodedValue.cs:214
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSBuildMemberListCodedValue.cs:214
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSBuildMemberListCodedValue.cs:214
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSBuildMemberListCodedValue.cs:214
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSBuildMemberListCodedValue.cs:214
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSBuildMemberListCodedValue.cs:214
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSBuildMemberListCodedValue.cs:214
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildMemberListReference.cs:120
		public ConsistentWith_Accessor ConsistentWith { get ; protected set; }                                                                    // CSBuildMemberListReference.cs:120
		public DensityType_Accessor DensityType { get ; protected set; }                                                                          // CSBuildMemberListCodedValue.cs:214
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public MGAbnormalityDensity() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGAbnormalityDensity(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGAbnormalityDensity(BreastRadiologyDocument doc)
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:136
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");                                       // CSDefineBase.cs:197
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSBuildMemberListCodedValue.cs:217
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSBuildMemberListCodedValue.cs:217
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // CSBuildMemberListCodedValue.cs:217
			this.Shape = new Shape_Accessor(doc);                                                                                                    // CSBuildMemberListCodedValue.cs:217
			this.Margin = new Margin_Accessor(doc);                                                                                                  // CSBuildMemberListCodedValue.cs:217
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // CSBuildMemberListCodedValue.cs:217
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // CSBuildMemberListCodedValue.cs:217
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSBuildMemberListCodedValue.cs:217
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // CSBuildMemberListCodedValue.cs:217
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // CSBuildMemberListCodedValue.cs:217
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // CSBuildMemberListCodedValue.cs:217
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSBuildMemberListCodedValue.cs:217
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSBuildMemberListCodedValue.cs:217
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildMemberListReference.cs:123
			this.ConsistentWith = new ConsistentWith_Accessor(doc);                                                                                  // CSBuildMemberListReference.cs:123
			this.DensityType = new DensityType_Accessor(doc);                                                                                        // CSBuildMemberListCodedValue.cs:217
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:176
			//- WriteCodeStart
			//+ WriteCode
			this.WriteComponent(this.ObsChanges);                                                                                                    // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.Orientation);                                                                                                   // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.Shape);                                                                                                         // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.Margin);                                                                                                        // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.MgDensity);                                                                                                     // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.ObsCount);                                                                                                      // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.ObsSize);                                                                                                       // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.ObsDistribution);                                                                                               // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.CorrespondsWith);                                                                                               // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // CSBuildMemberListCodedValue.cs:220
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.ConsistentWith);                                                                                                // CSBuildMemberListReference.cs:126
			this.WriteComponent(this.DensityType);                                                                                                   // CSBuildMemberListCodedValue.cs:220
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.ObsChanges);                                                                                                     // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.Orientation);                                                                                                    // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.Shape);                                                                                                          // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.Margin);                                                                                                         // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.MgDensity);                                                                                                      // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.ObsCount);                                                                                                       // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.ObsSize);                                                                                                        // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.ObsDistribution);                                                                                                // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.CorrespondsWith);                                                                                                // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSBuildMemberListCodedValue.cs:223
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.ConsistentWith);                                                                                                 // CSBuildMemberListReference.cs:129
			this.ReadComponent(this.DensityType);                                                                                                    // CSBuildMemberListCodedValue.cs:223
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
		        temp4.CodeElement.Value = "mgAbnormalityDensityObservation";                                                                      // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "MG Abnormality Density observation";                                                                // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "MG Abnormality Density observation";                                                                      // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
