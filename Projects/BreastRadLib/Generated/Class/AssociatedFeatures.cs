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
	/// <summary>
	/// Class AssociatedFeatures.
	/// This class is automatically generated.
	/// </summary>
	public class AssociatedFeatures : ObservationBase, IAssociatedFeatures
	{
		//+ Properties
		/// <summary>
		/// Access HasMembers value MGAbnormalityArchitecturalDistortion
		/// </summary>
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // BuildMemberListBase.cs:69
		/// <summary>
		/// Access HasMembers value MGAbnormalityCalcification
		/// </summary>
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // BuildMemberListBase.cs:69
		/// <summary>
		/// Access HasMembers value ObservedFeature
		/// </summary>
		public ObservedFeature_Accessor ObservedFeature { get ; protected set; }                                                                  // BuildMemberListBase.cs:69
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AssociatedFeatures() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AssociatedFeatures(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:133
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                                         // DefineBase.cs:194
			/// <summary>
			/// Constructor
			/// </summary>
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // BuildMemberListBase.cs:75
			/// <summary>
			/// Constructor
			/// </summary>
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // BuildMemberListBase.cs:75
			/// <summary>
			/// Constructor
			/// </summary>
			this.ObservedFeature = new ObservedFeature_Accessor(doc);                                                                                // BuildMemberListBase.cs:75
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
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // BuildMemberListBase.cs:84
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // BuildMemberListBase.cs:84
			if (this.ObservedFeature.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:84
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
			this.ClearComponents();                                                                                                                  // BuildMemberListCodedValue.cs:155
			this.ClearHasMember();                                                                                                                   // BuildMemberListReference.cs:88
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // BuildMemberListBase.cs:78
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // BuildMemberListBase.cs:78
			this.WriteHasMember(this.ObservedFeature);                                                                                               // BuildMemberListBase.cs:78
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
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // BuildMemberListBase.cs:81
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // BuildMemberListBase.cs:81
			this.ReadHasMember(this.ObservedFeature);                                                                                                // BuildMemberListBase.cs:81
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
