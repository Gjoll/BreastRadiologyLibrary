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
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSDefineObservation.cs:255
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSDefineObservation.cs:255
		public ObservedFeature_Accessor ObservedFeature { get ; protected set; }                                                                  // CSDefineObservation.cs:255
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public AssociatedFeatures() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AssociatedFeatures(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AssociatedFeatures(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                                         // CSDefineBase.cs:208
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSDefineObservation.cs:258
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSDefineObservation.cs:258
			this.ObservedFeature = new ObservedFeature_Accessor(doc);                                                                                // CSDefineObservation.cs:258
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearHasMembers();                                                                                                                  // CSDefineObservation.cs:222
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSDefineObservation.cs:261
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSDefineObservation.cs:261
			this.WriteHasMember(this.ObservedFeature);                                                                                               // CSDefineObservation.cs:261
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSDefineObservation.cs:264
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSDefineObservation.cs:264
			this.ReadHasMember(this.ObservedFeature);                                                                                                // CSDefineObservation.cs:264
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
