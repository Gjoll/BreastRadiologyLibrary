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
		public MGFinding_Accessor MGFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:255
		public MRIFinding_Accessor MRIFinding { get ; protected set; }                                                                            // CSDefineObservation.cs:255
		public NMFinding_Accessor NMFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:255
		public USFinding_Accessor USFinding { get ; protected set; }                                                                              // CSDefineObservation.cs:255
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public SectionFindingsLeftBreast() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public SectionFindingsLeftBreast(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Observation resource = null)
		{
			if (resource == null)
				resource = new Observation();
			base.Create(doc, resource);
			//+ Constructor
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:154
			this.Resource.BodySite = DefaultValue_2();                                                                                               // CSDefineBase.cs:154
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/SectionFindingsLeftBreast");                                  // CSDefineBase.cs:208
			this.MGFinding = new MGFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:258
			this.MRIFinding = new MRIFinding_Accessor(doc);                                                                                          // CSDefineObservation.cs:258
			this.NMFinding = new NMFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:258
			this.USFinding = new USFinding_Accessor(doc);                                                                                            // CSDefineObservation.cs:258
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			//- WriteCodeStart
			//+ WriteCode
			this.WriteHasMember(this.MGFinding);                                                                                                     // CSDefineObservation.cs:261
			this.WriteHasMember(this.MRIFinding);                                                                                                    // CSDefineObservation.cs:261
			this.WriteHasMember(this.NMFinding);                                                                                                     // CSDefineObservation.cs:261
			this.WriteHasMember(this.USFinding);                                                                                                     // CSDefineObservation.cs:261
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadHasMember(this.MGFinding);                                                                                                      // CSDefineObservation.cs:264
			this.ReadHasMember(this.MRIFinding);                                                                                                     // CSDefineObservation.cs:264
			this.ReadHasMember(this.NMFinding);                                                                                                      // CSDefineObservation.cs:264
			this.ReadHasMember(this.USFinding);                                                                                                      // CSDefineObservation.cs:264
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
		/// Method to create default value for element
		/// Observation.bodySite
		/// </summary>
		public CodeableConcept DefaultValue_2()                                                                                                   // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://snomed.info/sct";                                                                             // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "80248007";                                                                                             // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Left breast structure (body structure)";                                                            // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Left breast structure (body structure)";                                                                  // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
