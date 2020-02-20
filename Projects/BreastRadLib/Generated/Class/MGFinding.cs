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
		public AbnormalityCyst_Accessor AbnormalityCyst { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		public AbnormalityDuct_Accessor AbnormalityDuct { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		public AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; protected set; }                                                // CSBuildMemberListBase.cs:40
		public AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; protected set; }                                                        // CSBuildMemberListBase.cs:40
		public AbnormalityMass_Accessor AbnormalityMass { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildMemberListBase.cs:40
		public AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; protected set; }                                                  // CSBuildMemberListBase.cs:40
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSBuildMemberListBase.cs:40
		public MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; protected set; }                                                    // CSBuildMemberListBase.cs:40
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSBuildMemberListBase.cs:40
		public MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; protected set; }                                                        // CSBuildMemberListBase.cs:40
		public MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; protected set; }                                                // CSBuildMemberListBase.cs:40
		public MGBreastDensity_Accessor MGBreastDensity { get ; protected set; }                                                                  // CSBuildMemberListBase.cs:40
		//- Fields

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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:121
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // CSDefineBase.cs:182
			this.AbnormalityCyst = new AbnormalityCyst_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			this.AbnormalityDuct = new AbnormalityDuct_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			this.AbnormalityForeignObject = new AbnormalityForeignObject_Accessor(doc);                                                              // CSBuildMemberListBase.cs:43
			this.AbnormalityLymphNode = new AbnormalityLymphNode_Accessor(doc);                                                                      // CSBuildMemberListBase.cs:43
			this.AbnormalityMass = new AbnormalityMass_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildMemberListBase.cs:43
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenoma_Accessor(doc);                                                                // CSBuildMemberListBase.cs:43
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSBuildMemberListBase.cs:43
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetry_Accessor(doc);                                                                  // CSBuildMemberListBase.cs:43
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSBuildMemberListBase.cs:43
			this.MGAbnormalityDensity = new MGAbnormalityDensity_Accessor(doc);                                                                      // CSBuildMemberListBase.cs:43
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosis_Accessor(doc);                                                              // CSBuildMemberListBase.cs:43
			this.MGBreastDensity = new MGBreastDensity_Accessor(doc);                                                                                // CSBuildMemberListBase.cs:43
			//- Constructor
		}

		public override void Validate()
		{
			base.Validate();
			//+ ValidateCodeStart
			//- ValidateCodeStart
			//+ ValidateCode
			//- ValidateCode
		}

		public override void Write()
		{
			base.Write();
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:172
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:83
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.AbnormalityCyst);                                                                                               // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AbnormalityDuct);                                                                                               // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AbnormalityForeignObject);                                                                                      // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AbnormalityLymphNode);                                                                                          // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AbnormalityMass);                                                                                               // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.AbnormalityFibroadenoma);                                                                                       // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGAbnormalityAsymmetry);                                                                                        // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGAbnormalityDensity);                                                                                          // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGAbnormalityFatNecrosis);                                                                                      // CSBuildMemberListBase.cs:46
			this.WriteHasMember(this.MGBreastDensity);                                                                                               // CSBuildMemberListBase.cs:46
			//- WriteCode
		}

		public override void Read()
		{
			base.Read();
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.AbnormalityCyst);                                                                                                // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AbnormalityDuct);                                                                                                // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AbnormalityForeignObject);                                                                                       // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AbnormalityLymphNode);                                                                                           // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AbnormalityMass);                                                                                                // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.AbnormalityFibroadenoma);                                                                                        // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGAbnormalityAsymmetry);                                                                                         // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGAbnormalityDensity);                                                                                           // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGAbnormalityFatNecrosis);                                                                                       // CSBuildMemberListBase.cs:49
			this.ReadHasMember(this.MGBreastDensity);                                                                                                // CSBuildMemberListBase.cs:49
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
