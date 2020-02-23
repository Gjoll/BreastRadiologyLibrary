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
	public class AbnormalityFibroadenoma : ObservationBase, IAbnormalityFibroadenoma
	{
		//+ Properties
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // BuildMemberListBase.cs:33
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // BuildMemberListBase.cs:33
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // BuildMemberListBase.cs:33
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // BuildMemberListBase.cs:33
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // BuildMemberListBase.cs:33
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // BuildMemberListBase.cs:33
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // BuildMemberListBase.cs:33
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // BuildMemberListBase.cs:33
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // BuildMemberListBase.cs:33
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // BuildMemberListBase.cs:33
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberListBase.cs:33
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // BuildMemberListBase.cs:33
		public FibroAdenomaType_Accessor FibroAdenomaType { get ; protected set; }                                                                // BuildMemberListBase.cs:33
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public AbnormalityFibroadenoma() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AbnormalityFibroadenoma(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AbnormalityFibroadenoma(BreastRadiologyDocument doc)
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:128
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                                    // DefineBase.cs:189
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // BuildMemberListBase.cs:36
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // BuildMemberListBase.cs:36
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // BuildMemberListBase.cs:36
			this.Shape = new Shape_Accessor(doc);                                                                                                    // BuildMemberListBase.cs:36
			this.Margin = new Margin_Accessor(doc);                                                                                                  // BuildMemberListBase.cs:36
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // BuildMemberListBase.cs:36
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // BuildMemberListBase.cs:36
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // BuildMemberListBase.cs:36
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // BuildMemberListBase.cs:36
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // BuildMemberListBase.cs:36
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // BuildMemberListBase.cs:36
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // BuildMemberListBase.cs:36
			this.FibroAdenomaType = new FibroAdenomaType_Accessor(doc);                                                                              // BuildMemberListBase.cs:36
			//- Constructor
		}

		public override bool Validate(StringBuilder sb)
		{
			bool retVal = true;
			if (base.Validate(sb) == false)
				retVal = false;
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			if (this.ObsChanges.Validate(sb) == false) retVal = false;                                                                               // BuildMemberListBase.cs:45
			if (this.BiRadsAssessmentCategory.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:45
			if (this.Orientation.Validate(sb) == false) retVal = false;                                                                              // BuildMemberListBase.cs:45
			if (this.Shape.Validate(sb) == false) retVal = false;                                                                                    // BuildMemberListBase.cs:45
			if (this.Margin.Validate(sb) == false) retVal = false;                                                                                   // BuildMemberListBase.cs:45
			if (this.MgDensity.Validate(sb) == false) retVal = false;                                                                                // BuildMemberListBase.cs:45
			if (this.ObsCount.Validate(sb) == false) retVal = false;                                                                                 // BuildMemberListBase.cs:45
			if (this.ObsDistribution.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:45
			if (this.ObsDistRegionSize.Validate(sb) == false) retVal = false;                                                                        // BuildMemberListBase.cs:45
			if (this.ObsSize.Validate(sb) == false) retVal = false;                                                                                  // BuildMemberListBase.cs:45
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:45
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListBase.cs:45
			if (this.FibroAdenomaType.Validate(sb) == false) retVal = false;                                                                         // BuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:87
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:87
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:171
			//- WriteCodeStart
			//+ WriteCode
			this.WriteComponent(this.ObsChanges);                                                                                                    // BuildMemberListBase.cs:39
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // BuildMemberListBase.cs:39
			this.WriteComponent(this.Orientation);                                                                                                   // BuildMemberListBase.cs:39
			this.WriteComponent(this.Shape);                                                                                                         // BuildMemberListBase.cs:39
			this.WriteComponent(this.Margin);                                                                                                        // BuildMemberListBase.cs:39
			this.WriteComponent(this.MgDensity);                                                                                                     // BuildMemberListBase.cs:39
			this.WriteComponent(this.ObsCount);                                                                                                      // BuildMemberListBase.cs:39
			this.WriteComponent(this.ObsDistribution);                                                                                               // BuildMemberListBase.cs:39
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // BuildMemberListBase.cs:39
			this.WriteComponent(this.ObsSize);                                                                                                       // BuildMemberListBase.cs:39
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // BuildMemberListBase.cs:39
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // BuildMemberListBase.cs:39
			this.WriteComponent(this.FibroAdenomaType);                                                                                              // BuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.ObsChanges);                                                                                                     // BuildMemberListBase.cs:42
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // BuildMemberListBase.cs:42
			this.ReadComponent(this.Orientation);                                                                                                    // BuildMemberListBase.cs:42
			this.ReadComponent(this.Shape);                                                                                                          // BuildMemberListBase.cs:42
			this.ReadComponent(this.Margin);                                                                                                         // BuildMemberListBase.cs:42
			this.ReadComponent(this.MgDensity);                                                                                                      // BuildMemberListBase.cs:42
			this.ReadComponent(this.ObsCount);                                                                                                       // BuildMemberListBase.cs:42
			this.ReadComponent(this.ObsDistribution);                                                                                                // BuildMemberListBase.cs:42
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // BuildMemberListBase.cs:42
			this.ReadComponent(this.ObsSize);                                                                                                        // BuildMemberListBase.cs:42
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // BuildMemberListBase.cs:42
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // BuildMemberListBase.cs:42
			this.ReadComponent(this.FibroAdenomaType);                                                                                               // BuildMemberListBase.cs:42
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
