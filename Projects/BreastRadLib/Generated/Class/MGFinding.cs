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
	/// <summary>
	/// Class MGFinding.
	/// This class is automatically generated.
	/// </summary>
	public class MGFinding : ObservationBase, IMGFinding
	{
		//+ Properties
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityCyst
		/// </summary>
		public AbnormalityCyst_Accessor AbnormalityCyst { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityDuct
		/// </summary>
		public AbnormalityDuct_Accessor AbnormalityDuct { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityForeignObject
		/// </summary>
		public AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; protected set; }                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityLymphNode
		/// </summary>
		public AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; protected set; }                                                        // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityMass
		/// </summary>
		public AbnormalityMass_Accessor AbnormalityMass { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AssociatedFeatures
		/// </summary>
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value AbnormalityFibroadenoma
		/// </summary>
		public AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; protected set; }                                                  // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGAbnormalityArchitecturalDistortion
		/// </summary>
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGAbnormalityAsymmetry
		/// </summary>
		public MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; protected set; }                                                    // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGAbnormalityCalcification
		/// </summary>
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGAbnormalityDensity
		/// </summary>
		public MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; protected set; }                                                        // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGAbnormalityFatNecrosis
		/// </summary>
		public MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; protected set; }                                                // BuildMemberListBase.cs:70
		                                                                                                                                          // BuildMemberListBase.cs:66
		/// <summary>
		/// Access HasMembers value MGBreastDensity
		/// </summary>
		public MGBreastDensity_Accessor MGBreastDensity { get ; protected set; }                                                                  // BuildMemberListBase.cs:70
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGFinding() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGFinding(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:155
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // DefineBase.cs:216
			this.AbnormalityCyst = new AbnormalityCyst_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.AbnormalityDuct = new AbnormalityDuct_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.AbnormalityForeignObject = new AbnormalityForeignObject_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.AbnormalityLymphNode = new AbnormalityLymphNode_Accessor(doc);                                                                      // BuildMemberListBase.cs:73
			this.AbnormalityMass = new AbnormalityMass_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // BuildMemberListBase.cs:73
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenoma_Accessor(doc);                                                                // BuildMemberListBase.cs:73
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // BuildMemberListBase.cs:73
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetry_Accessor(doc);                                                                  // BuildMemberListBase.cs:73
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // BuildMemberListBase.cs:73
			this.MGAbnormalityDensity = new MGAbnormalityDensity_Accessor(doc);                                                                      // BuildMemberListBase.cs:73
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosis_Accessor(doc);                                                              // BuildMemberListBase.cs:73
			this.MGBreastDensity = new MGBreastDensity_Accessor(doc);                                                                                // BuildMemberListBase.cs:73
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
			if (this.AbnormalityCyst.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.AbnormalityDuct.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.AbnormalityForeignObject.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:82
			if (this.AbnormalityLymphNode.Validate(sb) == false) retVal = false;                                                                     // BuildMemberListBase.cs:82
			if (this.AbnormalityMass.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildMemberListBase.cs:82
			if (this.AbnormalityFibroadenoma.Validate(sb) == false) retVal = false;                                                                  // BuildMemberListBase.cs:82
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // BuildMemberListBase.cs:82
			if (this.MGAbnormalityAsymmetry.Validate(sb) == false) retVal = false;                                                                   // BuildMemberListBase.cs:82
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // BuildMemberListBase.cs:82
			if (this.MGAbnormalityDensity.Validate(sb) == false) retVal = false;                                                                     // BuildMemberListBase.cs:82
			if (this.MGAbnormalityFatNecrosis.Validate(sb) == false) retVal = false;                                                                 // BuildMemberListBase.cs:82
			if (this.MGBreastDensity.Validate(sb) == false) retVal = false;                                                                          // BuildMemberListBase.cs:82
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
			this.WriteHasMember(this.AbnormalityCyst);                                                                                               // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AbnormalityDuct);                                                                                               // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AbnormalityForeignObject);                                                                                      // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AbnormalityLymphNode);                                                                                          // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AbnormalityMass);                                                                                               // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // BuildMemberListBase.cs:76
			this.WriteHasMember(this.AbnormalityFibroadenoma);                                                                                       // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGAbnormalityAsymmetry);                                                                                        // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGAbnormalityDensity);                                                                                          // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGAbnormalityFatNecrosis);                                                                                      // BuildMemberListBase.cs:76
			this.WriteHasMember(this.MGBreastDensity);                                                                                               // BuildMemberListBase.cs:76
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
			this.ReadHasMember(this.AbnormalityCyst);                                                                                                // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AbnormalityDuct);                                                                                                // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AbnormalityForeignObject);                                                                                       // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AbnormalityLymphNode);                                                                                           // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AbnormalityMass);                                                                                                // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // BuildMemberListBase.cs:79
			this.ReadHasMember(this.AbnormalityFibroadenoma);                                                                                        // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGAbnormalityAsymmetry);                                                                                         // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGAbnormalityDensity);                                                                                           // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGAbnormalityFatNecrosis);                                                                                       // BuildMemberListBase.cs:79
			this.ReadHasMember(this.MGBreastDensity);                                                                                                // BuildMemberListBase.cs:79
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
