using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class SectionFindingsRightBreast : ObservationBase, IFindingBreastFragment
	{
		//+ Fields
		
        public MemberList<IMGFinding> MGFinding {get;}
        public MemberList<IMRIFinding> MRIFinding {get;}
        public MemberList<INMFinding> NMFinding {get;}
        public MemberList<IUSFinding> USFinding {get;}
		//- Fields

		public SectionFindingsRightBreast(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			this.Resource.Code = DefaultValue_1();
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsRightBreast");                                 // CSDefineBase.cs:145
		
            this.MGFinding = CreateHasMemberList<IMGFinding>(0, -1);
            this.MRIFinding = CreateHasMemberList<IMRIFinding>(0, -1);
            this.NMFinding = CreateHasMemberList<INMFinding>(0, -1);
            this.USFinding = CreateHasMemberList<IUSFinding>(0, -1);
			//- Constructor
		}

		public SectionFindingsRightBreast(BreastRadiologyDocument doc) : this(doc, new Observation())
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
		        temp4.CodeElement.Value = "findingsRightBreastObservation";                                                                       // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Findings Right Breast observation";                                                                 // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Findings Right Breast observation";                                                                       // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
