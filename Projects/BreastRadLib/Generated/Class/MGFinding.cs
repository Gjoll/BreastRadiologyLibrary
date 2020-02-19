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
		public AbnormalityCyst_Accessor AbnormalityCyst { get ; protected set; }                                                                  // CSBuildMemberListReference.cs:120
		public AbnormalityDuct_Accessor AbnormalityDuct { get ; protected set; }                                                                  // CSBuildMemberListReference.cs:120
		public AbnormalityForeignObject_Accessor AbnormalityForeignObject { get ; protected set; }                                                // CSBuildMemberListReference.cs:120
		public AbnormalityLymphNode_Accessor AbnormalityLymphNode { get ; protected set; }                                                        // CSBuildMemberListReference.cs:120
		public AbnormalityMass_Accessor AbnormalityMass { get ; protected set; }                                                                  // CSBuildMemberListReference.cs:120
		public AssociatedFeatures_Accessor AssociatedFeatures { get ; protected set; }                                                            // CSBuildMemberListReference.cs:120
		public AbnormalityFibroadenoma_Accessor AbnormalityFibroadenoma { get ; protected set; }                                                  // CSBuildMemberListReference.cs:120
		public MGAbnormalityArchitecturalDistortion_Accessor MGAbnormalityArchitecturalDistortion { get ; protected set; }                        // CSBuildMemberListReference.cs:120
		public MGAbnormalityAsymmetry_Accessor MGAbnormalityAsymmetry { get ; protected set; }                                                    // CSBuildMemberListReference.cs:120
		public MGAbnormalityCalcification_Accessor MGAbnormalityCalcification { get ; protected set; }                                            // CSBuildMemberListReference.cs:120
		public MGAbnormalityDensity_Accessor MGAbnormalityDensity { get ; protected set; }                                                        // CSBuildMemberListReference.cs:120
		public MGAbnormalityFatNecrosis_Accessor MGAbnormalityFatNecrosis { get ; protected set; }                                                // CSBuildMemberListReference.cs:120
		public MGBreastDensity_Accessor MGBreastDensity { get ; protected set; }                                                                  // CSBuildMemberListReference.cs:120
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:136
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // CSDefineBase.cs:197
			this.AbnormalityCyst = new AbnormalityCyst_Accessor(doc);                                                                                // CSBuildMemberListReference.cs:123
			this.AbnormalityDuct = new AbnormalityDuct_Accessor(doc);                                                                                // CSBuildMemberListReference.cs:123
			this.AbnormalityForeignObject = new AbnormalityForeignObject_Accessor(doc);                                                              // CSBuildMemberListReference.cs:123
			this.AbnormalityLymphNode = new AbnormalityLymphNode_Accessor(doc);                                                                      // CSBuildMemberListReference.cs:123
			this.AbnormalityMass = new AbnormalityMass_Accessor(doc);                                                                                // CSBuildMemberListReference.cs:123
			this.AssociatedFeatures = new AssociatedFeatures_Accessor(doc);                                                                          // CSBuildMemberListReference.cs:123
			this.AbnormalityFibroadenoma = new AbnormalityFibroadenoma_Accessor(doc);                                                                // CSBuildMemberListReference.cs:123
			this.MGAbnormalityArchitecturalDistortion = new MGAbnormalityArchitecturalDistortion_Accessor(doc);                                      // CSBuildMemberListReference.cs:123
			this.MGAbnormalityAsymmetry = new MGAbnormalityAsymmetry_Accessor(doc);                                                                  // CSBuildMemberListReference.cs:123
			this.MGAbnormalityCalcification = new MGAbnormalityCalcification_Accessor(doc);                                                          // CSBuildMemberListReference.cs:123
			this.MGAbnormalityDensity = new MGAbnormalityDensity_Accessor(doc);                                                                      // CSBuildMemberListReference.cs:123
			this.MGAbnormalityFatNecrosis = new MGAbnormalityFatNecrosis_Accessor(doc);                                                              // CSBuildMemberListReference.cs:123
			this.MGBreastDensity = new MGBreastDensity_Accessor(doc);                                                                                // CSBuildMemberListReference.cs:123
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearHasMember();                                                                                                                   // CSBuildMemberListReference.cs:87
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.AbnormalityCyst);                                                                                               // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AbnormalityDuct);                                                                                               // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AbnormalityForeignObject);                                                                                      // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AbnormalityLymphNode);                                                                                          // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AbnormalityMass);                                                                                               // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AssociatedFeatures);                                                                                            // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.AbnormalityFibroadenoma);                                                                                       // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                          // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityAsymmetry);                                                                                        // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityCalcification);                                                                                    // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityDensity);                                                                                          // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGAbnormalityFatNecrosis);                                                                                      // CSBuildMemberListReference.cs:126
			this.WriteHasMember(this.MGBreastDensity);                                                                                               // CSBuildMemberListReference.cs:126
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.AbnormalityCyst);                                                                                                // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AbnormalityDuct);                                                                                                // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AbnormalityForeignObject);                                                                                       // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AbnormalityLymphNode);                                                                                           // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AbnormalityMass);                                                                                                // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AssociatedFeatures);                                                                                             // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.AbnormalityFibroadenoma);                                                                                        // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityArchitecturalDistortion);                                                                           // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityAsymmetry);                                                                                         // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityCalcification);                                                                                     // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityDensity);                                                                                           // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGAbnormalityFatNecrosis);                                                                                       // CSBuildMemberListReference.cs:129
			this.ReadHasMember(this.MGBreastDensity);                                                                                                // CSBuildMemberListReference.cs:129
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
