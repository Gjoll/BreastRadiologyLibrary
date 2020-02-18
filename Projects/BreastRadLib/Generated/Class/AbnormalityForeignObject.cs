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
	public class AbnormalityForeignObject : ObservationBase, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IBiRadFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSDefineObservation.cs:145
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:145
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:145
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:145
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:145
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSDefineObservation.cs:255
		public ConsistentWith_Accessor ConsistentWith { get ; protected set; }                                                                    // CSDefineObservation.cs:255
		public AbnormalityForeignObjectType_Accessor AbnormalityForeignObjectType { get ; protected set; }                                        // CSDefineObservation.cs:145
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public AbnormalityForeignObject() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityForeignObject(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityForeignObject(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");                                   // CSDefineBase.cs:208
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSDefineObservation.cs:148
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSDefineObservation.cs:148
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // CSDefineObservation.cs:148
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSDefineObservation.cs:148
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSDefineObservation.cs:148
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSDefineObservation.cs:258
			this.ConsistentWith = new ConsistentWith_Accessor(doc);                                                                                  // CSDefineObservation.cs:258
			this.AbnormalityForeignObjectType = new AbnormalityForeignObjectType_Accessor(doc);                                                      // CSDefineObservation.cs:148
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
			this.WriteComponent(this.NotPreviouslySeen);                                                                                             // CSDefineObservation.cs:151
			this.WriteComponent(this.CorrespondsWith);                                                                                               // CSDefineObservation.cs:151
			this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                      // CSDefineObservation.cs:151
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSDefineObservation.cs:261
			this.WriteHasMember(this.ConsistentWith);                                                                                                // CSDefineObservation.cs:261
			this.WriteComponent(this.AbnormalityForeignObjectType);                                                                                  // CSDefineObservation.cs:151
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.ObsChanges);                                                                                                     // CSDefineObservation.cs:154
			this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:154
			this.ReadComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:154
			this.ReadComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:154
			this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:154
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSDefineObservation.cs:264
			this.ReadHasMember(this.ConsistentWith);                                                                                                 // CSDefineObservation.cs:264
			this.ReadComponent(this.AbnormalityForeignObjectType);                                                                                   // CSDefineObservation.cs:154
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
		        temp4.CodeElement.Value = "abnormalityForeignObjectObservation";                                                                  // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Abnormality Foreign Object observation";                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Abnormality Foreign Object observation";                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
