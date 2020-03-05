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
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityCyst
		/// </summary>
		public TItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; protected set; }                                             // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		public TItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; protected set; }                                             // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		public TItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; protected set; }                           // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		public TItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; protected set; }                                   // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		public TItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; protected set; }                                             // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AssociatedFeatures
		/// </summary>
		public TItemReferenceMultiple<AssociatedFeatures> AssociatedFeatures { get ; protected set; }                                       // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		public TItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; protected set; }                             // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; protected set; }   // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; protected set; }                               // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; protected set; }                       // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; protected set; }                                   // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; protected set; }                           // BuildItemReference.cs:63
		                                                                                                                                          // BuildItemReference.cs:59
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		public TItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; protected set; }                                               // BuildItemReference.cs:63
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:158
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // DefineBase.cs:219
			this.AbnormalityCyst = new TItemReferenceMultiple<AbnormalityCyst>("AbnormalityCyst", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");// BuildItemReference.cs:48
			this.AbnormalityDuct = new TItemReferenceMultiple<AbnormalityDuct>("AbnormalityDuct", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");// BuildItemReference.cs:48
			this.AbnormalityForeignObject = new TItemReferenceMultiple<AbnormalityForeignObject>("AbnormalityForeignObject", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");// BuildItemReference.cs:48
			this.AbnormalityLymphNode = new TItemReferenceMultiple<AbnormalityLymphNode>("AbnormalityLymphNode", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");// BuildItemReference.cs:48
			this.AbnormalityMass = new TItemReferenceMultiple<AbnormalityMass>("AbnormalityMass", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");// BuildItemReference.cs:48
			this.AssociatedFeatures = new TItemReferenceMultiple<AssociatedFeatures>("AssociatedFeatures", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");// BuildItemReference.cs:48
			this.AbnormalityFibroadenoma = new TItemReferenceMultiple<AbnormalityFibroadenoma>("AbnormalityFibroadenoma", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");// BuildItemReference.cs:48
			this.MGAbnormalityArchitecturalDistortion = new TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion>("MGAbnormalityArchitecturalDistortion", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");// BuildItemReference.cs:48
			this.MGAbnormalityAsymmetry = new TItemReferenceMultiple<MGAbnormalityAsymmetry>("MGAbnormalityAsymmetry", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");// BuildItemReference.cs:48
			this.MGAbnormalityCalcification = new TItemReferenceMultiple<MGAbnormalityCalcification>("MGAbnormalityCalcification", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");// BuildItemReference.cs:48
			this.MGAbnormalityDensity = new TItemReferenceMultiple<MGAbnormalityDensity>("MGAbnormalityDensity", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");// BuildItemReference.cs:48
			this.MGAbnormalityFatNecrosis = new TItemReferenceMultiple<MGAbnormalityFatNecrosis>("MGAbnormalityFatNecrosis", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");// BuildItemReference.cs:48
			this.MGBreastDensity = new TItemReferenceSingle<MGBreastDensity>("MGBreastDensity", 1, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");// BuildItemReference.cs:48
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
			if (this.AbnormalityCyst.Validate(sb) == false) retVal = false;                                                                          // BuildItemReference.cs:72
			if (this.AbnormalityDuct.Validate(sb) == false) retVal = false;                                                                          // BuildItemReference.cs:72
			if (this.AbnormalityForeignObject.Validate(sb) == false) retVal = false;                                                                 // BuildItemReference.cs:72
			if (this.AbnormalityLymphNode.Validate(sb) == false) retVal = false;                                                                     // BuildItemReference.cs:72
			if (this.AbnormalityMass.Validate(sb) == false) retVal = false;                                                                          // BuildItemReference.cs:72
			if (this.AssociatedFeatures.Validate(sb) == false) retVal = false;                                                                       // BuildItemReference.cs:72
			if (this.AbnormalityFibroadenoma.Validate(sb) == false) retVal = false;                                                                  // BuildItemReference.cs:72
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // BuildItemReference.cs:72
			if (this.MGAbnormalityAsymmetry.Validate(sb) == false) retVal = false;                                                                   // BuildItemReference.cs:72
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // BuildItemReference.cs:72
			if (this.MGAbnormalityDensity.Validate(sb) == false) retVal = false;                                                                     // BuildItemReference.cs:72
			if (this.MGAbnormalityFatNecrosis.Validate(sb) == false) retVal = false;                                                                 // BuildItemReference.cs:72
			if (this.MGBreastDensity.Validate(sb) == false) retVal = false;                                                                          // BuildItemReference.cs:72
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
			this.ClearComponent();                                                                                                                   // BuildItemComponent.cs:92
			this.ClearHasMember();                                                                                                                   // BuildItemReference.cs:81
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMembers(this.AbnormalityCyst);                                                                                              // BuildItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityDuct);                                                                                              // BuildItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityForeignObject);                                                                                     // BuildItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityLymphNode);                                                                                         // BuildItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityMass);                                                                                              // BuildItemReference.cs:66
			this.WriteHasMembers(this.AssociatedFeatures);                                                                                           // BuildItemReference.cs:66
			this.WriteHasMembers(this.AbnormalityFibroadenoma);                                                                                      // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityArchitecturalDistortion);                                                                         // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityAsymmetry);                                                                                       // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityCalcification);                                                                                   // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityDensity);                                                                                         // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGAbnormalityFatNecrosis);                                                                                     // BuildItemReference.cs:66
			this.WriteHasMembers(this.MGBreastDensity);                                                                                              // BuildItemReference.cs:66
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
			this.ReadHasMembers(this.AbnormalityCyst);                                                                                               // BuildItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityDuct);                                                                                               // BuildItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityForeignObject);                                                                                      // BuildItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityLymphNode);                                                                                          // BuildItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityMass);                                                                                               // BuildItemReference.cs:69
			this.ReadHasMembers(this.AssociatedFeatures);                                                                                            // BuildItemReference.cs:69
			this.ReadHasMembers(this.AbnormalityFibroadenoma);                                                                                       // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityArchitecturalDistortion);                                                                          // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityAsymmetry);                                                                                        // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityCalcification);                                                                                    // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityDensity);                                                                                          // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGAbnormalityFatNecrosis);                                                                                      // BuildItemReference.cs:69
			this.ReadHasMembers(this.MGBreastDensity);                                                                                               // BuildItemReference.cs:69
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationCode()                                                                                       // FhirConstruct.cs:753
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
