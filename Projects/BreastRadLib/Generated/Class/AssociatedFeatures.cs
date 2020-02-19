using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AssociatedFeaturesLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.ObservationSectionFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class AssociatedFeatures : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSBuildMemberListReference.cs:120
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSBuildMemberListReference.cs:120
		public ObservedFeature_Accessor ObservedFeature { get ; protected set; }                                                                  // CSBuildMemberListReference.cs:120
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public AssociatedFeatures() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AssociatedFeatures(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public AssociatedFeatures(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                                         // CSDefineBase.cs:182
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSBuildMemberListReference.cs:123
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSBuildMemberListReference.cs:123
			this.ObservedFeature = new ObservedFeature_Accessor(doc);                                                                                // CSBuildMemberListReference.cs:123
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:87
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.ObservedFeature);                                                                                               // CSBuildMemberListReference.cs:126
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.ObservedFeature);                                                                                                // CSBuildMemberListReference.cs:129
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
		        temp4.CodeElement.Value = "associatedFeaturesObservation";                                                                        // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Associated Features observation";                                                                   // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Associated Features observation";                                                                         // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
