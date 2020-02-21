using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGFindingLocal;
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
	public class MGFinding : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		public AbnormalityCyst_Accessor AbnormalityCyst { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:33
		public AbnormalityDuct_Accessor AbnormalityDuct { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:33
		public AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; protected set; }                                                // CSBuildMemberListBase.cs:33
		public AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; protected set; }                                                        // CSBuildMemberListBase.cs:33
		public AbnormalityMass_Accessor AbnormalityMass { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:33
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildMemberListBase.cs:33
		public AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; protected set; }                                                  // CSBuildMemberListBase.cs:33
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSBuildMemberListBase.cs:33
		public MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; protected set; }                                                    // CSBuildMemberListBase.cs:33
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSBuildMemberListBase.cs:33
		public MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; protected set; }                                                        // CSBuildMemberListBase.cs:33
		public MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; protected set; }                                                // CSBuildMemberListBase.cs:33
		public MGBreastDensity_Accessor MGBreastDensity { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:33
		//- Fields

		//+ Properties
		//- Properties

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public MGFinding() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGFinding(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public MGFinding(BreastRadiologyDocument doc)
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:130
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // CSDefineBase.cs:191
			this.AbnormalityCyst = new AbnormalityCyst_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:36
			this.AbnormalityDuct = new AbnormalityDuct_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:36
			this.AbnormalityForeignObject = new AbnormalityForeignObject_Accessor(doc);                                                              // CSBuildMemberListBase.cs:36
			this.AbnormalityLymphNode = new AbnormalityLymphNode_Accessor(doc);                                                                      // CSBuildMemberListBase.cs:36
			this.AbnormalityMass = new AbnormalityMass_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:36
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildMemberListBase.cs:36
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenoma_Accessor(doc);                                                                // CSBuildMemberListBase.cs:36
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSBuildMemberListBase.cs:36
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetry_Accessor(doc);                                                                  // CSBuildMemberListBase.cs:36
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSBuildMemberListBase.cs:36
			this.MGAbnormalityDensity = new MGAbnormalityDensity_Accessor(doc);                                                                      // CSBuildMemberListBase.cs:36
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosis_Accessor(doc);                                                              // CSBuildMemberListBase.cs:36
			this.MGBreastDensity = new MGBreastDensity_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:36
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
			if (this.AbnormalityCyst.Validate(sb) == false) retVal = false;                                                                          // CSBuildMemberListBase.cs:45
			if (this.AbnormalityDuct.Validate(sb) == false) retVal = false;                                                                          // CSBuildMemberListBase.cs:45
			if (this.AbnormalityForeignObject.Validate(sb) == false) retVal = false;                                                                 // CSBuildMemberListBase.cs:45
			if (this.AbnormalityLymphNode.Validate(sb) == false) retVal = false;                                                                     // CSBuildMemberListBase.cs:45
			if (this.AbnormalityMass.Validate(sb) == false) retVal = false;                                                                          // CSBuildMemberListBase.cs:45
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // CSBuildMemberListBase.cs:45
			if (this.AbnormalityFibroadenoma.Validate(sb) == false) retVal = false;                                                                  // CSBuildMemberListBase.cs:45
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // CSBuildMemberListBase.cs:45
			if (this.MGAbnormalityAsymmetry.Validate(sb) == false) retVal = false;                                                                   // CSBuildMemberListBase.cs:45
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // CSBuildMemberListBase.cs:45
			if (this.MGAbnormalityDensity.Validate(sb) == false) retVal = false;                                                                     // CSBuildMemberListBase.cs:45
			if (this.MGAbnormalityFatNecrosis.Validate(sb) == false) retVal = false;                                                                 // CSBuildMemberListBase.cs:45
			if (this.MGBreastDensity.Validate(sb) == false) retVal = false;                                                                          // CSBuildMemberListBase.cs:45
			//- ValidateCode
			return retVal;
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:171
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:87
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.AbnormalityCyst);                                                                                               // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AbnormalityDuct);                                                                                               // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AbnormalityForeignObject);                                                                                      // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AbnormalityLymphNode);                                                                                          // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AbnormalityMass);                                                                                               // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.AbnormalityFibroadenoma);                                                                                       // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGAbnormalityAsymmetry);                                                                                        // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGAbnormalityDensity);                                                                                          // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGAbnormalityFatNecrosis);                                                                                      // CSBuildMemberListBase.cs:39
			this.WriteHasMember(this.MGBreastDensity);                                                                                               // CSBuildMemberListBase.cs:39
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.AbnormalityCyst);                                                                                                // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AbnormalityDuct);                                                                                                // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AbnormalityForeignObject);                                                                                       // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AbnormalityLymphNode);                                                                                           // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AbnormalityMass);                                                                                                // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.AbnormalityFibroadenoma);                                                                                        // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGAbnormalityAsymmetry);                                                                                         // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGAbnormalityDensity);                                                                                           // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGAbnormalityFatNecrosis);                                                                                       // CSBuildMemberListBase.cs:42
			this.ReadHasMember(this.MGBreastDensity);                                                                                                // CSBuildMemberListBase.cs:42
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
		        temp4.CodeElement.Value = "mgFindingObservationObservation";                                                                      // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "MG Finding observation";                                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "MG Finding observation";                                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
