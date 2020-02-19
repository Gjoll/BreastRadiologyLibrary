using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityLymphNodeLocal;
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
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class AbnormalityLymphNode : ObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ Fields
		public TumorSatellite_Accessor TumorSatellite { get ; protected set; }                                                                    // CSBuildCodedReferenceList.cs:126
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSDefineObservation.cs:211
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:211
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSDefineObservation.cs:211
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSDefineObservation.cs:211
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSDefineObservation.cs:211
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSDefineObservation.cs:211
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSDefineObservation.cs:211
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSDefineObservation.cs:211
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSDefineObservation.cs:211
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSDefineObservation.cs:211
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:211
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:211
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:211
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildCodedReferenceList.cs:126
		public LymphNodeType_Accessor LymphNodeType { get ; protected set; }                                                                      // CSDefineObservation.cs:211
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public AbnormalityLymphNode() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AbnormalityLymphNode(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AbnormalityLymphNode(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");                                       // CSDefineBase.cs:217
			this.TumorSatellite = new TumorSatellite_Accessor(doc);                                                                                  // CSBuildCodedReferenceList.cs:129
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSDefineObservation.cs:214
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSDefineObservation.cs:214
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // CSDefineObservation.cs:214
			this.Shape = new Shape_Accessor(doc);                                                                                                    // CSDefineObservation.cs:214
			this.Margin = new Margin_Accessor(doc);                                                                                                  // CSDefineObservation.cs:214
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // CSDefineObservation.cs:214
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSDefineObservation.cs:214
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // CSDefineObservation.cs:214
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // CSDefineObservation.cs:214
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // CSDefineObservation.cs:214
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // CSDefineObservation.cs:214
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSDefineObservation.cs:214
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSDefineObservation.cs:214
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildCodedReferenceList.cs:129
			this.LymphNodeType = new LymphNodeType_Accessor(doc);                                                                                    // CSDefineObservation.cs:214
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSDefineObservation.cs:173
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.TumorSatellite);                                                                                                // CSBuildCodedReferenceList.cs:132
			this.WriteComponent(this.ObsChanges);                                                                                                    // CSDefineObservation.cs:217
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // CSDefineObservation.cs:217
			this.WriteComponent(this.Orientation);                                                                                                   // CSDefineObservation.cs:217
			this.WriteComponent(this.Shape);                                                                                                         // CSDefineObservation.cs:217
			this.WriteComponent(this.Margin);                                                                                                        // CSDefineObservation.cs:217
			this.WriteComponent(this.MgDensity);                                                                                                     // CSDefineObservation.cs:217
			this.WriteComponent(this.ObsCount);                                                                                                      // CSDefineObservation.cs:217
			this.WriteComponent(this.ObsDistribution);                                                                                               // CSDefineObservation.cs:217
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // CSDefineObservation.cs:217
			this.WriteComponent(this.ObsSize);                                                                                                       // CSDefineObservation.cs:217
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // CSDefineObservation.cs:217
			this.WriteComponent(this.CorrespondsWith);                                                                                               // CSDefineObservation.cs:217
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // CSDefineObservation.cs:217
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildCodedReferenceList.cs:132
			this.WriteComponent(this.LymphNodeType);                                                                                                 // CSDefineObservation.cs:217
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.TumorSatellite);                                                                                                 // CSBuildCodedReferenceList.cs:135
			this.ReadComponent(this.ObsChanges);                                                                                                     // CSDefineObservation.cs:220
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:220
			this.ReadComponent(this.Orientation);                                                                                                    // CSDefineObservation.cs:220
			this.ReadComponent(this.Shape);                                                                                                          // CSDefineObservation.cs:220
			this.ReadComponent(this.Margin);                                                                                                         // CSDefineObservation.cs:220
			this.ReadComponent(this.MgDensity);                                                                                                      // CSDefineObservation.cs:220
			this.ReadComponent(this.ObsCount);                                                                                                       // CSDefineObservation.cs:220
			this.ReadComponent(this.ObsDistribution);                                                                                                // CSDefineObservation.cs:220
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // CSDefineObservation.cs:220
			this.ReadComponent(this.ObsSize);                                                                                                        // CSDefineObservation.cs:220
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:220
			this.ReadComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:220
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:220
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildCodedReferenceList.cs:135
			this.ReadComponent(this.LymphNodeType);                                                                                                  // CSDefineObservation.cs:220
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
		        temp4.CodeElement.Value = "abnormalityLymphNodeObservation";                                                                      // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Lymph Node observation";                                                                // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Lymph Node observation";                                                                      // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
