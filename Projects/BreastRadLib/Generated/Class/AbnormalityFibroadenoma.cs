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
	/// <summary>
	/// Class AbnormalityFibroadenoma.
	/// This class is automatically generated.
	/// </summary>
	public class AbnormalityFibroadenoma : ObservationBase, IAbnormalityFibroadenoma
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
		/// Access Component value Orientation
		/// </summary>
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value Shape
		/// </summary>
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value Margin
		/// </summary>
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value MgDensity
		/// </summary>
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value ObsCount
		/// </summary>
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // BuildMemberListBase.cs:70
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
		/// Access Component value ObsSize
		/// </summary>
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value PreviouslyDemonstratedBy
		/// </summary>
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AssociatedFeatures
		/// </summary>
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access Component value FibroAdenomaType
		/// </summary>
		public FibroAdenomaType_Accessor FibroAdenomaType { get ; protected set; }                                                                // BuildMemberListBase.cs:70
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AbnormalityFibroadenoma() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AbnormalityFibroadenoma(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                                    // DefineBase.cs:215
			this.bodySite = new BreastBodyLocation(doc);                                                                                             // DefineBase.cs:78
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // BuildMemberListBase.cs:73
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // BuildMemberListBase.cs:73
			this.Shape = new Shape_Accessor(doc);                                                                                                    // BuildMemberListBase.cs:73
			this.Margin = new Margin_Accessor(doc);                                                                                                  // BuildMemberListBase.cs:73
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // BuildMemberListBase.cs:73
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // BuildMemberListBase.cs:73
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // BuildMemberListBase.cs:73
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // BuildMemberListBase.cs:73
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // BuildMemberListBase.cs:73
			this.FibroAdenomaType = new FibroAdenomaType_Accessor(doc);                                                                              // BuildMemberListBase.cs:73
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
			if (this.Orientation.Validate(sb) == false) retVal = false;                                                                              // BuildMemberListBase.cs:82
			if (this.Shape.Validate(sb) == false) retVal = false;                                                                                    // BuildMemberListBase.cs:82
			if (this.Margin.Validate(sb) == false) retVal = false;                                                                                   // BuildMemberListBase.cs:82
			if (this.MgDensity.Validate(sb) == false) retVal = false;                                                                                // BuildMemberListBase.cs:82
			if (this.ObsCount.Validate(sb) == false) retVal = false;                                                                                 // BuildMemberListBase.cs:82
			if (this.ObsDistribution.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.ObsDistRegionSize.Validate(sb) == false) retVal = false;                                                                        // BuildMemberListBase.cs:82
			if (this.ObsSize.Validate(sb) == false) retVal = false;                                                                                  // BuildMemberListBase.cs:82
			if (this.PreviouslyDemonstratedBy.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:82
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListBase.cs:82
			if (this.FibroAdenomaType.Validate(sb) == false) retVal = false;                                                                         // BuildMemberListBase.cs:82
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
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:88
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:88
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			//- WriteCodeStart
			//+ WriteCode
			this.bodySite.Write();                                                                                                                   // DefineBase.cs:84
			this.WriteComponent(this.ObsChanges);                                                                                                    // BuildMemberListBase.cs:76
			this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                      // BuildMemberListBase.cs:76
			this.WriteComponent(this.Orientation);                                                                                                   // BuildMemberListBase.cs:76
			this.WriteComponent(this.Shape);                                                                                                         // BuildMemberListBase.cs:76
			this.WriteComponent(this.Margin);                                                                                                        // BuildMemberListBase.cs:76
			this.WriteComponent(this.MgDensity);                                                                                                     // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsCount);                                                                                                      // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsDistribution);                                                                                               // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsDistRegionSize);                                                                                             // BuildMemberListBase.cs:76
			this.WriteComponent(this.ObsSize);                                                                                                       // BuildMemberListBase.cs:76
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // BuildMemberListBase.cs:76
			this.WriteComponent(this.FibroAdenomaType);                                                                                              // BuildMemberListBase.cs:76
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
			this.ReadComponent(this.Orientation);                                                                                                    // BuildMemberListBase.cs:79
			this.ReadComponent(this.Shape);                                                                                                          // BuildMemberListBase.cs:79
			this.ReadComponent(this.Margin);                                                                                                         // BuildMemberListBase.cs:79
			this.ReadComponent(this.MgDensity);                                                                                                      // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsCount);                                                                                                       // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsDistribution);                                                                                                // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsDistRegionSize);                                                                                              // BuildMemberListBase.cs:79
			this.ReadComponent(this.ObsSize);                                                                                                        // BuildMemberListBase.cs:79
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // BuildMemberListBase.cs:79
			this.ReadComponent(this.FibroAdenomaType);                                                                                               // BuildMemberListBase.cs:79
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
