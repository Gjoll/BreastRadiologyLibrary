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
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityCyst
		/// Access fhir element 'Observation.hasMember:abnormalityCyst'
		/// </summary>
		public AbnormalityCystContainer AbnormalityCyst { get ; protected set; }                                                                  // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityDuct
		/// Access fhir element 'Observation.hasMember:abnormalityDuct'
		/// </summary>
		public AbnormalityDuctContainer AbnormalityDuct { get ; protected set; }                                                                  // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityForeignObject
		/// Access fhir element 'Observation.hasMember:abnormalityForeignObject'
		/// </summary>
		public AbnormalityForeignObjectContainer AbnormalityForeignObject { get ; protected set; }                                                // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityLymphNode
		/// Access fhir element 'Observation.hasMember:abnormalityLymphNode'
		/// </summary>
		public AbnormalityLymphNodeContainer AbnormalityLymphNode { get ; protected set; }                                                        // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityMass
		/// Access fhir element 'Observation.hasMember:abnormalityMass'
		/// </summary>
		public AbnormalityMassContainer AbnormalityMass { get ; protected set; }                                                                  // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public AssociatedFeatureContainer AssociatedFeature { get ; protected set; }                                                              // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// AbnormalityFibroadenoma
		/// Access fhir element 'Observation.hasMember:abnormalityFibroadenoma'
		/// </summary>
		public AbnormalityFibroadenomaContainer AbnormalityFibroadenoma { get ; protected set; }                                                  // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGAbnormalityArchitecturalDistortion
		/// Access fhir element 'Observation.hasMember:mGAbnormalityArchitecturalDistortion'
		/// </summary>
		public MGAbnormalityArchitecturalDistortionContainer MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGAbnormalityAsymmetry
		/// Access fhir element 'Observation.hasMember:mGAbnormalityAsymmetry'
		/// </summary>
		public MGAbnormalityAsymmetryContainer MGAbnormalityAsymmetry { get ; protected set; }                                                    // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGAbnormalityCalcification
		/// Access fhir element 'Observation.hasMember:mGAbnormalityCalcification'
		/// </summary>
		public MGAbnormalityCalcificationContainer MGAbnormalityCalcification { get ; protected set; }                                            // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGAbnormalityDensity
		/// Access fhir element 'Observation.hasMember:mGAbnormalityDensity'
		/// </summary>
		public MGAbnormalityDensityContainer MGAbnormalityDensity { get ; protected set; }                                                        // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGAbnormalityFatNecrosis
		/// Access fhir element 'Observation.hasMember:mGAbnormalityFatNecrosis'
		/// </summary>
		public MGAbnormalityFatNecrosisContainer MGAbnormalityFatNecrosis { get ; protected set; }                                                // BuildMemberBase.cs:335
		                                                                                                                                          // BuildMemberBase.cs:330
		/// <summary>
		/// MGBreastDensity
		/// Access fhir element 'Observation.hasMember:mGBreastDensity'
		/// </summary>
		public MGBreastDensityContainer MGBreastDensity { get ; protected set; }                                                                  // BuildMemberBase.cs:335
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
			this.AbnormalityCyst = new AbnormalityCystContainer(0, 0);                                                                               // BuildMemberBase.cs:316
			this.AbnormalityDuct = new AbnormalityDuctContainer(0, 0);                                                                               // BuildMemberBase.cs:316
			this.AbnormalityForeignObject = new AbnormalityForeignObjectContainer(0, 0);                                                             // BuildMemberBase.cs:316
			this.AbnormalityLymphNode = new AbnormalityLymphNodeContainer(0, 0);                                                                     // BuildMemberBase.cs:316
			this.AbnormalityMass = new AbnormalityMassContainer(0, 0);                                                                               // BuildMemberBase.cs:316
			this.AssociatedFeature = new AssociatedFeatureContainer(0, 0);                                                                           // BuildMemberBase.cs:316
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenomaContainer(0, 0);                                                               // BuildMemberBase.cs:316
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortionContainer(0, 0);                                     // BuildMemberBase.cs:316
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetryContainer(0, 0);                                                                 // BuildMemberBase.cs:316
			this.MGAbnormalityCalcification = new MGAbnormalityCalcificationContainer(0, 0);                                                         // BuildMemberBase.cs:316
			this.MGAbnormalityDensity = new MGAbnormalityDensityContainer(0, 0);                                                                     // BuildMemberBase.cs:316
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosisContainer(0, 0);                                                             // BuildMemberBase.cs:316
			this.MGBreastDensity = new MGBreastDensityContainer(1, 1);                                                                               // BuildMemberBase.cs:316
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
			//- WriteCodeStart
			//+ WriteCode
			//+ !WriteHasMembers
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:140
			//- !WriteHasMembers
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
			//+ !ReadHasMembers
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:149
			//- !ReadHasMembers
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
		                                                                                                                                          // BuildMemberReferences.cs:104
		//+ !HasMembers
		                                                                                                                                          // BuildMemberReferences.cs:107
		/// <summary>
		/// Read all values from resource into this instance
		/// </summary>
		private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                  // BuildMemberReferences.cs:111
		{                                                                                                                                         // BuildMemberReferences.cs:112
		    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                      // BuildMemberReferences.cs:113
		    //+ ReadHasMembers
		    this.AbnormalityCyst.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:63
		    this.AbnormalityDuct.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:63
		    this.AbnormalityForeignObject.Read(this.Doc, items);                                                                                  // BuildMemberReferences.cs:63
		    this.AbnormalityLymphNode.Read(this.Doc, items);                                                                                      // BuildMemberReferences.cs:63
		    this.AbnormalityMass.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:63
		    this.AssociatedFeature.Read(this.Doc, items);                                                                                         // BuildMemberReferences.cs:63
		    this.AbnormalityFibroadenoma.Read(this.Doc, items);                                                                                   // BuildMemberReferences.cs:63
		    this.MGAbnormalityArchitecturalDistortion.Read(this.Doc, items);                                                                      // BuildMemberReferences.cs:63
		    this.MGAbnormalityAsymmetry.Read(this.Doc, items);                                                                                    // BuildMemberReferences.cs:63
		    this.MGAbnormalityCalcification.Read(this.Doc, items);                                                                                // BuildMemberReferences.cs:63
		    this.MGAbnormalityDensity.Read(this.Doc, items);                                                                                      // BuildMemberReferences.cs:63
		    this.MGAbnormalityFatNecrosis.Read(this.Doc, items);                                                                                  // BuildMemberReferences.cs:63
		    this.MGBreastDensity.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:63
		    //- ReadHasMembers
		}                                                                                                                                         // BuildMemberReferences.cs:115
		                                                                                                                                          // BuildMemberReferences.cs:117
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:121
		{                                                                                                                                         // BuildMemberReferences.cs:122
		    List<ResourceReference> items = new List<ResourceReference>();                                                                        // BuildMemberReferences.cs:123
		    //+ WriteHasMembers
		    items.AddRange(this.AbnormalityCyst.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:84
		    items.AddRange(this.AbnormalityDuct.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:84
		    items.AddRange(this.AbnormalityForeignObject.Write(this.Doc));                                                                        // BuildMemberReferences.cs:84
		    items.AddRange(this.AbnormalityLymphNode.Write(this.Doc));                                                                            // BuildMemberReferences.cs:84
		    items.AddRange(this.AbnormalityMass.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:84
		    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                               // BuildMemberReferences.cs:84
		    items.AddRange(this.AbnormalityFibroadenoma.Write(this.Doc));                                                                         // BuildMemberReferences.cs:84
		    items.AddRange(this.MGAbnormalityArchitecturalDistortion.Write(this.Doc));                                                            // BuildMemberReferences.cs:84
		    items.AddRange(this.MGAbnormalityAsymmetry.Write(this.Doc));                                                                          // BuildMemberReferences.cs:84
		    items.AddRange(this.MGAbnormalityCalcification.Write(this.Doc));                                                                      // BuildMemberReferences.cs:84
		    items.AddRange(this.MGAbnormalityDensity.Write(this.Doc));                                                                            // BuildMemberReferences.cs:84
		    items.AddRange(this.MGAbnormalityFatNecrosis.Write(this.Doc));                                                                        // BuildMemberReferences.cs:84
		    items.AddRange(this.MGBreastDensity.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:84
		    //- WriteHasMembers
		    this.Resource.SetValue("hasMember", items);                                                                                           // BuildMemberReferences.cs:125
		}                                                                                                                                         // BuildMemberReferences.cs:126
		//- !HasMembers
		//- Methods
	}
}
