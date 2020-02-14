using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGFinding : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		
        public MemberList<IAbnormalityCyst> AbnormalityCyst {get;}
        public MemberList<IAbnormalityDuct> AbnormalityDuct {get;}
        public MemberList<IAbnormalityForeignObject> AbnormalityForeignObject {get;}
        public MemberList<IAbnormalityLymphNode> AbnormalityLymphNode {get;}
        public MemberList<IAbnormalityMass> AbnormalityMass {get;}
        public MemberList<IAssociatedFeatures> AssociatedFeatures {get;}
        public MemberList<IAbnormalityFibroadenoma> AbnormalityFibroadenoma {get;}
        public MemberList<IMGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion {get;}
        public MemberList<IMGAbnormalityAsymmetry> MGAbnormalityAsymmetry {get;}
        public MemberList<IMGAbnormalityCalcification> MGAbnormalityCalcification {get;}
        public MemberList<IMGAbnormalityDensity> MGAbnormalityDensity {get;}
        public MemberList<IMGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis {get;}
        public MemberList<IMGBreastDensity> MGBreastDensity {get;}
		//- Fields

		public MGFinding(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:129
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                                  // CSDefineBase.cs:181
		
            this.AbnormalityCyst = CreateHasMemberList<IAbnormalityCyst>(0, -1);
            this.AbnormalityDuct = CreateHasMemberList<IAbnormalityDuct>(0, -1);
            this.AbnormalityForeignObject = CreateHasMemberList<IAbnormalityForeignObject>(0, -1);
            this.AbnormalityLymphNode = CreateHasMemberList<IAbnormalityLymphNode>(0, -1);
            this.AbnormalityMass = CreateHasMemberList<IAbnormalityMass>(0, -1);
            this.AssociatedFeatures = CreateHasMemberList<IAssociatedFeatures>(0, -1);
            this.AbnormalityFibroadenoma = CreateHasMemberList<IAbnormalityFibroadenoma>(0, -1);
            this.MGAbnormalityArchitecturalDistortion = CreateHasMemberList<IMGAbnormalityArchitecturalDistortion>(0, -1);
            this.MGAbnormalityAsymmetry = CreateHasMemberList<IMGAbnormalityAsymmetry>(0, -1);
            this.MGAbnormalityCalcification = CreateHasMemberList<IMGAbnormalityCalcification>(0, -1);
            this.MGAbnormalityDensity = CreateHasMemberList<IMGAbnormalityDensity>(0, -1);
            this.MGAbnormalityFatNecrosis = CreateHasMemberList<IMGAbnormalityFatNecrosis>(0, -1);
            this.MGBreastDensity = CreateHasMemberList<IMGBreastDensity>(1, 1);
			//- Constructor
		}

		public MGFinding(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
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
