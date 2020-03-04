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
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityCyst
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; protected set; }                                             // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; protected set; }                                             // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; protected set; }                           // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; protected set; }                                   // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; protected set; }                                             // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		public ElementItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; protected set; }                                       // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		public ElementItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; protected set; }                             // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		public ElementItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; protected set; }   // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		public ElementItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; protected set; }                               // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		public ElementItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; protected set; }                       // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		public ElementItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; protected set; }                                   // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		public ElementItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; protected set; }                           // BuildElementItemReference.cs:63
		                                                                                                                                          // BuildElementItemReference.cs:59
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		public ElementItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; protected set; }                                               // BuildElementItemReference.cs:63
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // DefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // DefineBase.cs:215
			this.AbnormalityCyst = new ElementItemReferenceMultiple<AbnormalityCyst>("AbnormalityCyst", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");// BuildElementItemReference.cs:48
			this.AbnormalityDuct = new ElementItemReferenceMultiple<AbnormalityDuct>("AbnormalityDuct", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");// BuildElementItemReference.cs:48
			this.AbnormalityForeignObject = new ElementItemReferenceMultiple<AbnormalityForeignObject>("AbnormalityForeignObject", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");// BuildElementItemReference.cs:48
			this.AbnormalityLymphNode = new ElementItemReferenceMultiple<AbnormalityLymphNode>("AbnormalityLymphNode", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");// BuildElementItemReference.cs:48
			this.AbnormalityMass = new ElementItemReferenceMultiple<AbnormalityMass>("AbnormalityMass", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");// BuildElementItemReference.cs:48
			this.AssociatedFeatures = new ElementItemReferenceMultiple<AssociatedFeatures>("AssociatedFeatures", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");// BuildElementItemReference.cs:48
			this.AbnormalityFibroadenoma = new ElementItemReferenceMultiple<AbnormalityFibroadenoma>("AbnormalityFibroadenoma", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");// BuildElementItemReference.cs:48
			this.MGAbnormalityArchitecturalDistortion = new ElementItemReferenceMultiple<MGAbnormalityArchitecturalDistortion>("MGAbnormalityArchitecturalDistortion", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");// BuildElementItemReference.cs:48
			this.MGAbnormalityAsymmetry = new ElementItemReferenceMultiple<MGAbnormalityAsymmetry>("MGAbnormalityAsymmetry", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");// BuildElementItemReference.cs:48
			this.MGAbnormalityCalcification = new ElementItemReferenceMultiple<MGAbnormalityCalcification>("MGAbnormalityCalcification", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");// BuildElementItemReference.cs:48
			this.MGAbnormalityDensity = new ElementItemReferenceMultiple<MGAbnormalityDensity>("MGAbnormalityDensity", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");// BuildElementItemReference.cs:48
			this.MGAbnormalityFatNecrosis = new ElementItemReferenceMultiple<MGAbnormalityFatNecrosis>("MGAbnormalityFatNecrosis", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");// BuildElementItemReference.cs:48
			this.MGBreastDensity = new ElementItemReferenceSingle<MGBreastDensity>("MGBreastDensity", 1, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");// BuildElementItemReference.cs:48
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
			if (this.AbnormalityCyst.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:72
			if (this.AbnormalityDuct.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:72
			if (this.AbnormalityForeignObject.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemReference.cs:72
			if (this.AbnormalityLymphNode.Validate(sb) == false) retVal = false;                                                                     // BuildElementItemReference.cs:72
			if (this.AbnormalityMass.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:72
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildElementItemReference.cs:72
			if (this.AbnormalityFibroadenoma.Validate(sb) == false) retVal = false;                                                                  // BuildElementItemReference.cs:72
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // BuildElementItemReference.cs:72
			if (this.MGAbnormalityAsymmetry.Validate(sb) == false) retVal = false;                                                                   // BuildElementItemReference.cs:72
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // BuildElementItemReference.cs:72
			if (this.MGAbnormalityDensity.Validate(sb) == false) retVal = false;                                                                     // BuildElementItemReference.cs:72
			if (this.MGAbnormalityFatNecrosis.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemReference.cs:72
			if (this.MGBreastDensity.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:72
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
			this.ClearHasMember();                                                                                                                   // BuildElementItemReference.cs:81
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMembers(this.AbnormalityCyst);                                                                                              // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityDuct);                                                                                              // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityForeignObject);                                                                                     // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityLymphNode);                                                                                         // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityMass);                                                                                              // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AssociatedFeatures);                                                                                           // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityFibroadenoma);                                                                                      // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityArchitecturalDistortion);                                                                         // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityAsymmetry);                                                                                       // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityCalcification);                                                                                   // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityDensity);                                                                                         // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityFatNecrosis);                                                                                     // BuildElementItemReference.cs:66
			this.WriteHasMembers(this.MGBreastDensity);                                                                                              // BuildElementItemReference.cs:66
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
			this.ReadHasMembers(this.AbnormalityCyst);                                                                                               // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityDuct);                                                                                               // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityForeignObject);                                                                                      // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityLymphNode);                                                                                          // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityMass);                                                                                               // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AssociatedFeatures);                                                                                            // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityFibroadenoma);                                                                                       // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityArchitecturalDistortion);                                                                          // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityAsymmetry);                                                                                        // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityCalcification);                                                                                    // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityDensity);                                                                                          // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityFatNecrosis);                                                                                      // BuildElementItemReference.cs:69
			this.ReadHasMembers(this.MGBreastDensity);                                                                                               // BuildElementItemReference.cs:69
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
