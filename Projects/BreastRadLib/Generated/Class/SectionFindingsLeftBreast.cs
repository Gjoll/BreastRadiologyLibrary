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
		public MGFinding_Accessor MGFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:322
		public MRIFinding_Accessor MRIFinding { get ; protected set; }                                                                            // CSDefineObservation.cs:322
		public NMFinding_Accessor NMFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:322
		public USFinding_Accessor USFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:322
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // CSDefineBase.cs:235
			this.MGFinding = new MGFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:325
			this.MRIFinding = new MRIFinding_Accessor(doc);                                                                                          // CSDefineObservation.cs:325
			this.NMFinding = new NMFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:325
			this.USFinding = new USFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:325
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGFinding);                                                                                                     // CSDefineObservation.cs:328
			this.WriteHasMember(this.MRIFinding);                                                                                                    // CSDefineObservation.cs:328
			this.WriteHasMember(this.NMFinding);                                                                                                     // CSDefineObservation.cs:328
			this.WriteHasMember(this.USFinding);                                                                                                     // CSDefineObservation.cs:328
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.MGFinding);                                                                                                      // CSDefineObservation.cs:331
			this.ReadHasMember(this.MRIFinding);                                                                                                     // CSDefineObservation.cs:331
			this.ReadHasMember(this.NMFinding);                                                                                                      // CSDefineObservation.cs:331
			this.ReadHasMember(this.USFinding);                                                                                                      // CSDefineObservation.cs:331
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
			public void SetValueX(BiRadsAssessmentCategoriesVS.TCoding code)                                                                         // CSDefineBase.cs:199
			{                                                                                                                                        // CSDefineBase.cs:200
			    //If: C:\Development\HL7\BreastRadiologyLibrary\Projects\FireFragger\FireFragger\CS\CSDefineBase.cs 201                              // CodeBlockNested.cs:588
			    this.Resource.Value = (CodeableConcept) code;                                                                                        // CSDefineBase.cs:202
			}                                                                                                                                        // CSDefineBase.cs:205
		//- Methods
	}
}
