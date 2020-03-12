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
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityCyst
		/// </summary>
		public TItemReferenceMultiple<AbnormalityCyst> AbnormalityCyst { get ; protected set; }                                                   // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityDuct
		/// </summary>
		public TItemReferenceMultiple<AbnormalityDuct> AbnormalityDuct { get ; protected set; }                                                   // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityForeignObject
		/// </summary>
		public TItemReferenceMultiple<AbnormalityForeignObject> AbnormalityForeignObject { get ; protected set; }                                 // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityLymphNode
		/// </summary>
		public TItemReferenceMultiple<AbnormalityLymphNode> AbnormalityLymphNode { get ; protected set; }                                         // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityMass
		/// </summary>
		public TItemReferenceMultiple<AbnormalityMass> AbnormalityMass { get ; protected set; }                                                   // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AssociatedFeature
		/// </summary>
		public TItemReferenceMultiple<AssociatedFeature> AssociatedFeature { get ; protected set; }                                               // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access AbnormalityFibroadenoma
		/// </summary>
		public TItemReferenceMultiple<AbnormalityFibroadenoma> AbnormalityFibroadenoma { get ; protected set; }                                   // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGAbnormalityArchitecturalDistortion
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion { get ; protected set; }         // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGAbnormalityAsymmetry
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityAsymmetry> MGAbnormalityAsymmetry { get ; protected set; }                                     // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGAbnormalityCalcification
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityCalcification> MGAbnormalityCalcification { get ; protected set; }                             // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGAbnormalityDensity
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityDensity> MGAbnormalityDensity { get ; protected set; }                                         // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGAbnormalityFatNecrosis
		/// </summary>
		public TItemReferenceMultiple<MGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis { get ; protected set; }                                 // BuildElementItemReference.cs:62
		                                                                                                                                          // BuildElementItemReference.cs:58
		/// <summary>
		/// Access MGBreastDensity
		/// </summary>
		public TItemReferenceSingle<MGBreastDensity> MGBreastDensity { get ; protected set; }                                                     // BuildElementItemReference.cs:62
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:159
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // DefineBase.cs:220
			this.AbnormalityCyst = new TItemReferenceMultiple<AbnormalityCyst>("Observation.hasMember:abnormalityCyst", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");// BuildElementItemReference.cs:47
			this.AbnormalityDuct = new TItemReferenceMultiple<AbnormalityDuct>("Observation.hasMember:abnormalityDuct", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityDuct");// BuildElementItemReference.cs:47
			this.AbnormalityForeignObject = new TItemReferenceMultiple<AbnormalityForeignObject>("Observation.hasMember:abnormalityForeignObject", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityForeignObject");// BuildElementItemReference.cs:47
			this.AbnormalityLymphNode = new TItemReferenceMultiple<AbnormalityLymphNode>("Observation.hasMember:abnormalityLymphNode", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityLymphNode");// BuildElementItemReference.cs:47
			this.AbnormalityMass = new TItemReferenceMultiple<AbnormalityMass>("Observation.hasMember:abnormalityMass", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityMass");// BuildElementItemReference.cs:47
			this.AssociatedFeature = new TItemReferenceMultiple<AssociatedFeature>("Observation.hasMember:associatedFeature", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature");// BuildElementItemReference.cs:47
			this.AbnormalityFibroadenoma = new TItemReferenceMultiple<AbnormalityFibroadenoma>("Observation.hasMember:abnormalityFibroadenoma", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");// BuildElementItemReference.cs:47
			this.MGAbnormalityArchitecturalDistortion = new TItemReferenceMultiple<MGAbnormalityArchitecturalDistortion>("Observation.hasMember:mGAbnormalityArchitecturalDistortion", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");// BuildElementItemReference.cs:47
			this.MGAbnormalityAsymmetry = new TItemReferenceMultiple<MGAbnormalityAsymmetry>("Observation.hasMember:mGAbnormalityAsymmetry", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");// BuildElementItemReference.cs:47
			this.MGAbnormalityCalcification = new TItemReferenceMultiple<MGAbnormalityCalcification>("Observation.hasMember:mGAbnormalityCalcification", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityCalcification");// BuildElementItemReference.cs:47
			this.MGAbnormalityDensity = new TItemReferenceMultiple<MGAbnormalityDensity>("Observation.hasMember:mGAbnormalityDensity", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityDensity");// BuildElementItemReference.cs:47
			this.MGAbnormalityFatNecrosis = new TItemReferenceMultiple<MGAbnormalityFatNecrosis>("Observation.hasMember:mGAbnormalityFatNecrosis", 0, -1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityFatNecrosis");// BuildElementItemReference.cs:47
			this.MGBreastDensity = new TItemReferenceSingle<MGBreastDensity>("Observation.hasMember:mGBreastDensity", 1, 1, doc, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGBreastDensity");// BuildElementItemReference.cs:47
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
			if (this.AbnormalityCyst.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:71
			if (this.AbnormalityDuct.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:71
			if (this.AbnormalityForeignObject.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemReference.cs:71
			if (this.AbnormalityLymphNode.Validate(sb) == false) retVal = false;                                                                     // BuildElementItemReference.cs:71
			if (this.AbnormalityMass.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:71
			if (this.AssociatedFeature.Validate(sb) == false) retVal = false;                                                                        // BuildElementItemReference.cs:71
			if (this.AbnormalityFibroadenoma.Validate(sb) == false) retVal = false;                                                                  // BuildElementItemReference.cs:71
			if (this.MGAbnormalityArchitecturalDistortion.Validate(sb) == false) retVal = false;                                                     // BuildElementItemReference.cs:71
			if (this.MGAbnormalityAsymmetry.Validate(sb) == false) retVal = false;                                                                   // BuildElementItemReference.cs:71
			if (this.MGAbnormalityCalcification.Validate(sb) == false) retVal = false;                                                               // BuildElementItemReference.cs:71
			if (this.MGAbnormalityDensity.Validate(sb) == false) retVal = false;                                                                     // BuildElementItemReference.cs:71
			if (this.MGAbnormalityFatNecrosis.Validate(sb) == false) retVal = false;                                                                 // BuildElementItemReference.cs:71
			if (this.MGBreastDensity.Validate(sb) == false) retVal = false;                                                                          // BuildElementItemReference.cs:71
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
			this.ClearComponent();
			this.ClearHasMember();
			//- WriteCodeStart
			//+ WriteCode
			this.AbnormalityCyst.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemReference.cs:65
			this.AbnormalityDuct.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemReference.cs:65
			this.AbnormalityForeignObject.Write(this.Doc, this.Resource);                                                                            // BuildElementItemReference.cs:65
			this.AbnormalityLymphNode.Write(this.Doc, this.Resource);                                                                                // BuildElementItemReference.cs:65
			this.AbnormalityMass.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemReference.cs:65
			this.AssociatedFeature.Write(this.Doc, this.Resource);                                                                                   // BuildElementItemReference.cs:65
			this.AbnormalityFibroadenoma.Write(this.Doc, this.Resource);                                                                             // BuildElementItemReference.cs:65
			this.MGAbnormalityArchitecturalDistortion.Write(this.Doc, this.Resource);                                                                // BuildElementItemReference.cs:65
			this.MGAbnormalityAsymmetry.Write(this.Doc, this.Resource);                                                                              // BuildElementItemReference.cs:65
			this.MGAbnormalityCalcification.Write(this.Doc, this.Resource);                                                                          // BuildElementItemReference.cs:65
			this.MGAbnormalityDensity.Write(this.Doc, this.Resource);                                                                                // BuildElementItemReference.cs:65
			this.MGAbnormalityFatNecrosis.Write(this.Doc, this.Resource);                                                                            // BuildElementItemReference.cs:65
			this.MGBreastDensity.Write(this.Doc, this.Resource);                                                                                     // BuildElementItemReference.cs:65
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
			this.AbnormalityCyst.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:68
			this.AbnormalityDuct.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:68
			this.AbnormalityForeignObject.Read(this.Doc, this.Resource);                                                                             // BuildElementItemReference.cs:68
			this.AbnormalityLymphNode.Read(this.Doc, this.Resource);                                                                                 // BuildElementItemReference.cs:68
			this.AbnormalityMass.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:68
			this.AssociatedFeature.Read(this.Doc, this.Resource);                                                                                    // BuildElementItemReference.cs:68
			this.AbnormalityFibroadenoma.Read(this.Doc, this.Resource);                                                                              // BuildElementItemReference.cs:68
			this.MGAbnormalityArchitecturalDistortion.Read(this.Doc, this.Resource);                                                                 // BuildElementItemReference.cs:68
			this.MGAbnormalityAsymmetry.Read(this.Doc, this.Resource);                                                                               // BuildElementItemReference.cs:68
			this.MGAbnormalityCalcification.Read(this.Doc, this.Resource);                                                                           // BuildElementItemReference.cs:68
			this.MGAbnormalityDensity.Read(this.Doc, this.Resource);                                                                                 // BuildElementItemReference.cs:68
			this.MGAbnormalityFatNecrosis.Read(this.Doc, this.Resource);                                                                             // BuildElementItemReference.cs:68
			this.MGBreastDensity.Read(this.Doc, this.Resource);                                                                                      // BuildElementItemReference.cs:68
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
