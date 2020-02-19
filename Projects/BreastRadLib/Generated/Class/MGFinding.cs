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
		public AbnormalityCyst_Accessor AbnormalityCyst { get ; protected set; }                                                                  // CSDefineObservation.cs:320
		public AbnormalityDuct_Accessor AbnormalityDuct { get ; protected set; }                                                                  // CSDefineObservation.cs:320
		public AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; protected set; }                                                // CSDefineObservation.cs:320
		public AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; protected set; }                                                        // CSDefineObservation.cs:320
		public AbnormalityMass_Accessor AbnormalityMass { get ; protected set; }                                                                  // CSDefineObservation.cs:320
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSDefineObservation.cs:320
		public AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; protected set; }                                                  // CSDefineObservation.cs:320
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSDefineObservation.cs:320
		public MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; protected set; }                                                    // CSDefineObservation.cs:320
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSDefineObservation.cs:320
		public MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; protected set; }                                                        // CSDefineObservation.cs:320
		public MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; protected set; }                                                // CSDefineObservation.cs:320
		public MGBreastDensity_Accessor MGBreastDensity { get ; protected set; }                                                                  // CSDefineObservation.cs:320
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // CSDefineBase.cs:218
			this.AbnormalityCyst = new AbnormalityCyst_Accessor(doc);                                                                                // CSDefineObservation.cs:323
			this.AbnormalityDuct = new AbnormalityDuct_Accessor(doc);                                                                                // CSDefineObservation.cs:323
			this.AbnormalityForeignObject = new AbnormalityForeignObject_Accessor(doc);                                                              // CSDefineObservation.cs:323
			this.AbnormalityLymphNode = new AbnormalityLymphNode_Accessor(doc);                                                                      // CSDefineObservation.cs:323
			this.AbnormalityMass = new AbnormalityMass_Accessor(doc);                                                                                // CSDefineObservation.cs:323
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSDefineObservation.cs:323
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenoma_Accessor(doc);                                                                // CSDefineObservation.cs:323
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSDefineObservation.cs:323
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetry_Accessor(doc);                                                                  // CSDefineObservation.cs:323
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSDefineObservation.cs:323
			this.MGAbnormalityDensity = new MGAbnormalityDensity_Accessor(doc);                                                                      // CSDefineObservation.cs:323
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosis_Accessor(doc);                                                              // CSDefineObservation.cs:323
			this.MGBreastDensity = new MGBreastDensity_Accessor(doc);                                                                                // CSDefineObservation.cs:323
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearHasMembers();                                                                                                                  // CSDefineObservation.cs:287
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.AbnormalityCyst);                                                                                               // CSDefineObservation.cs:326
			this.WriteHasMember(this.AbnormalityDuct);                                                                                               // CSDefineObservation.cs:326
			this.WriteHasMember(this.AbnormalityForeignObject);                                                                                      // CSDefineObservation.cs:326
			this.WriteHasMember(this.AbnormalityLymphNode);                                                                                          // CSDefineObservation.cs:326
			this.WriteHasMember(this.AbnormalityMass);                                                                                               // CSDefineObservation.cs:326
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSDefineObservation.cs:326
			this.WriteHasMember(this.AbnormalityFibroadenoma);                                                                                       // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGAbnormalityAsymmetry);                                                                                        // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGAbnormalityDensity);                                                                                          // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGAbnormalityFatNecrosis);                                                                                      // CSDefineObservation.cs:326
			this.WriteHasMember(this.MGBreastDensity);                                                                                               // CSDefineObservation.cs:326
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.AbnormalityCyst);                                                                                                // CSDefineObservation.cs:329
			this.ReadHasMember(this.AbnormalityDuct);                                                                                                // CSDefineObservation.cs:329
			this.ReadHasMember(this.AbnormalityForeignObject);                                                                                       // CSDefineObservation.cs:329
			this.ReadHasMember(this.AbnormalityLymphNode);                                                                                           // CSDefineObservation.cs:329
			this.ReadHasMember(this.AbnormalityMass);                                                                                                // CSDefineObservation.cs:329
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSDefineObservation.cs:329
			this.ReadHasMember(this.AbnormalityFibroadenoma);                                                                                        // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGAbnormalityAsymmetry);                                                                                         // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGAbnormalityDensity);                                                                                           // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGAbnormalityFatNecrosis);                                                                                       // CSDefineObservation.cs:329
			this.ReadHasMember(this.MGBreastDensity);                                                                                                // CSDefineObservation.cs:329
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
