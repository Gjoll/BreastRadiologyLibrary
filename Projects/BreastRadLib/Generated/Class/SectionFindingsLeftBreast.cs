using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.SectionFindingsLeftBreastLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.FindingBreastFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class SectionFindingsLeftBreast : ObservationBase, IFindingBreastFragment
	{
		//+ Fields
		public MGFinding_Accessor MGFinding { get ; protected set; }                                                                              // CSBuildCodedReferenceList.cs:120
		public MRIFinding_Accessor MRIFinding { get ; protected set; }                                                                            // CSBuildCodedReferenceList.cs:120
		public NMFinding_Accessor NMFinding { get ; protected set; }                                                                              // CSBuildCodedReferenceList.cs:120
		public USFinding_Accessor USFinding { get ; protected set; }                                                                              // CSBuildCodedReferenceList.cs:120
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public SectionFindingsLeftBreast() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // CSDefineBase.cs:217
			this.MGFinding = new MGFinding_Accessor(doc);                                                                                            // CSBuildCodedReferenceList.cs:123
			this.MRIFinding = new MRIFinding_Accessor(doc);                                                                                          // CSBuildCodedReferenceList.cs:123
			this.NMFinding = new NMFinding_Accessor(doc);                                                                                            // CSBuildCodedReferenceList.cs:123
			this.USFinding = new USFinding_Accessor(doc);                                                                                            // CSBuildCodedReferenceList.cs:123
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGFinding);                                                                                                     // CSBuildCodedReferenceList.cs:126
			this.WriteHasMember(this.MRIFinding);                                                                                                    // CSBuildCodedReferenceList.cs:126
			this.WriteHasMember(this.NMFinding);                                                                                                     // CSBuildCodedReferenceList.cs:126
			this.WriteHasMember(this.USFinding);                                                                                                     // CSBuildCodedReferenceList.cs:126
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.MGFinding);                                                                                                      // CSBuildCodedReferenceList.cs:129
			this.ReadHasMember(this.MRIFinding);                                                                                                     // CSBuildCodedReferenceList.cs:129
			this.ReadHasMember(this.NMFinding);                                                                                                      // CSBuildCodedReferenceList.cs:129
			this.ReadHasMember(this.USFinding);                                                                                                      // CSBuildCodedReferenceList.cs:129
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
		        temp4.CodeElement.Value = "findingsLeftBreastObservation";                                                                        // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Findings Left Breast observation";                                                                  // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Findings Left Breast observation";                                                                        // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			/// <summary>
			/// Set Observation.value[x] to one of the predefined items
			/// </summary>
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // CSDefineBase.cs:181
			{                                                                                                                                        // CSDefineBase.cs:182
			    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineBase.cs 183                              // CodeBlockNested.cs:588
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // CSDefineBase.cs:184
			}                                                                                                                                        // CSDefineBase.cs:187
		//- Methods
	}
}
