using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityFibroadenomaLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
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
using BreastRadLib.ShapeComponentsFragmentLocal;
using BreastRadLib.ObservedCountFragmentLocal;
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class AbnormalityFibroadenoma : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSDefineObservation.cs:145
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:145
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSDefineObservation.cs:145
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSDefineObservation.cs:145
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSDefineObservation.cs:145
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSDefineObservation.cs:145
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSDefineObservation.cs:145
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSDefineObservation.cs:145
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSDefineObservation.cs:145
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSDefineObservation.cs:145
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:145
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSDefineObservation.cs:256
		public FibroAdenomaType_Accessor FibroAdenomaType { get ; protected set; }                                                                // CSDefineObservation.cs:145
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public AbnormalityFibroadenoma() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityFibroadenoma(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityFibroadenoma(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Observation resource = null)
		{
			if (resource == null)
				resource = new Observation();
			base.Create(doc, resource);
			//+ Constructor
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                                    // CSDefineBase.cs:208
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSDefineObservation.cs:148
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSDefineObservation.cs:148
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // CSDefineObservation.cs:148
			this.Shape = new Shape_Accessor(doc);                                                                                                    // CSDefineObservation.cs:148
			this.Margin = new Margin_Accessor(doc);                                                                                                  // CSDefineObservation.cs:148
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // CSDefineObservation.cs:148
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSDefineObservation.cs:148
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // CSDefineObservation.cs:148
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // CSDefineObservation.cs:148
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // CSDefineObservation.cs:148
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSDefineObservation.cs:148
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSDefineObservation.cs:259
			this.FibroAdenomaType = new FibroAdenomaType_Accessor(doc);                                                                              // CSDefineObservation.cs:148
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSDefineObservation.cs:95
			//- WriteCodeStart
			//+ WriteCode
			this.WriteComponent(this.ObsChanges);                                                                                                    // CSDefineObservation.cs:151
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // CSDefineObservation.cs:151
			this.WriteComponent(this.Orientation);                                                                                                   // CSDefineObservation.cs:151
			this.WriteComponent(this.Shape);                                                                                                         // CSDefineObservation.cs:151
			this.WriteComponent(this.Margin);                                                                                                        // CSDefineObservation.cs:151
			this.WriteComponent(this.MgDensity);                                                                                                     // CSDefineObservation.cs:151
			this.WriteComponent(this.ObsCount);                                                                                                      // CSDefineObservation.cs:151
			this.WriteComponent(this.ObsDistribution);                                                                                               // CSDefineObservation.cs:151
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // CSDefineObservation.cs:151
			this.WriteComponent(this.ObsSize);                                                                                                       // CSDefineObservation.cs:151
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // CSDefineObservation.cs:151
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSDefineObservation.cs:262
			this.WriteComponent(this.FibroAdenomaType);                                                                                              // CSDefineObservation.cs:151
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.ObsChanges);                                                                                                     // CSDefineObservation.cs:154
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:154
			this.ReadComponent(this.Orientation);                                                                                                    // CSDefineObservation.cs:154
			this.ReadComponent(this.Shape);                                                                                                          // CSDefineObservation.cs:154
			this.ReadComponent(this.Margin);                                                                                                         // CSDefineObservation.cs:154
			this.ReadComponent(this.MgDensity);                                                                                                      // CSDefineObservation.cs:154
			this.ReadComponent(this.ObsCount);                                                                                                       // CSDefineObservation.cs:154
			this.ReadComponent(this.ObsDistribution);                                                                                                // CSDefineObservation.cs:154
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // CSDefineObservation.cs:154
			this.ReadComponent(this.ObsSize);                                                                                                        // CSDefineObservation.cs:154
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:154
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSDefineObservation.cs:265
			this.ReadComponent(this.FibroAdenomaType);                                                                                               // CSDefineObservation.cs:154
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
		        temp4.CodeElement.Value = "abnormalityFibroadenomaObservation";                                                                   // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Fibroadenoma observation";                                                              // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Fibroadenoma observation";                                                                    // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
