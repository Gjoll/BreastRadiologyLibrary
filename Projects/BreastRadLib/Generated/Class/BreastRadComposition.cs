using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.BreastRadCompositionLocal;
//+Usings
using BreastRadLib.HeaderFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class BreastRadComposition.
	/// This class is automatically generated.
	/// </summary>
	public class BreastRadComposition : CompositionBase, IBreastRadComposition
	{
		//+ Properties
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access Report
		/// </summary>
		public TItemSectionSingle<BreastRadReport> Report { get ; protected set; }                                                          // BuildItemSection.cs:75
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access Impressions
		/// </summary>
		public TItemSectionMultiple<ClinicalImpressionBase> Impressions { get ; protected set; }                                            // BuildItemSection.cs:75
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access FindingsRightBreast
		/// </summary>
		public TItemSectionSingle<SectionFindingsRightBreast> FindingsRightBreast { get ; protected set; }                                  // BuildItemSection.cs:75
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access FindingsLeftBreast
		/// </summary>
		public TItemSectionSingle<SectionFindingsLeftBreast> FindingsLeftBreast { get ; protected set; }                                    // BuildItemSection.cs:75
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access RelatedResources
		/// </summary>
		public TItemSectionMultiple<ResourceBase> RelatedResources { get ; protected set; }                                                 // BuildItemSection.cs:75
		                                                                                                                                          // BuildItemSection.cs:71
		/// <summary>
		/// Access Recommendations
		/// </summary>
		public TItemSectionMultiple<MedicationRequestBase, ServiceRequestBase, ServiceRecommendation> Recommendations { get ; protected set; }// BuildItemSection.cs:75
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public BreastRadComposition() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public BreastRadComposition(BreastRadiologyDocument doc, Composition resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public BreastRadComposition(BreastRadiologyDocument doc)
		{
			this.Init(doc, new Composition());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public override void Init(BreastRadiologyDocument doc, Base baseResource = null)
		{
			Composition resource = (Composition) baseResource;
			if (resource == null)
				resource = new Composition();
			base.Init(doc, resource);
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/BreastRadComposition");                                       // DefineBase.cs:219
			this.Report = new TItemSectionSingle<BreastRadReport>("Report", 1, 1, "Breast Radiology Report", FixedValue_CompositionSectionReportCode());// BuildItemSection.cs:60
			this.Impressions = new TItemSectionMultiple<ClinicalImpressionBase>("Impressions", 0, -1, "Clinical Impressions", FixedValue_CompositionSectionImpressionsCode());// BuildItemSection.cs:60
			this.FindingsRightBreast = new TItemSectionSingle<SectionFindingsRightBreast>("FindingsRightBreast", 0, 1, "Findings Right Breast", FixedValue_CompositionSectionFindingsRightBreastCode());// BuildItemSection.cs:60
			this.FindingsLeftBreast = new TItemSectionSingle<SectionFindingsLeftBreast>("FindingsLeftBreast", 0, 1, "Findings Left Breast", FixedValue_CompositionSectionFindingsLeftBreastCode());// BuildItemSection.cs:60
			this.RelatedResources = new TItemSectionMultiple<ResourceBase>("RelatedResources", 0, -1, "Related Resources", FixedValue_CompositionSectionRelatedResourcesCode());// BuildItemSection.cs:60
			this.Recommendations = new TItemSectionMultiple<MedicationRequestBase, ServiceRequestBase, ServiceRecommendation>("Recommendations", 0, -1, "Recommendations", FixedValue_CompositionSectionRecommendationsCode());// BuildItemSection.cs:60
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
			if (this.Report.Validate(sb) == false) retVal = false;                                                                                   // BuildItemSection.cs:84
			if (this.Impressions.Validate(sb) == false) retVal = false;                                                                              // BuildItemSection.cs:84
			if (this.FindingsRightBreast.Validate(sb) == false) retVal = false;                                                                      // BuildItemSection.cs:84
			if (this.FindingsLeftBreast.Validate(sb) == false) retVal = false;                                                                       // BuildItemSection.cs:84
			if (this.RelatedResources.Validate(sb) == false) retVal = false;                                                                         // BuildItemSection.cs:84
			if (this.Recommendations.Validate(sb) == false) retVal = false;                                                                          // BuildItemSection.cs:84
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
			this.ClearSection();                                                                                                                     // BuildItemSection.cs:93
			//- WriteCodeStart
			//+ WriteCode
			this.WriteSection(this.Report);                                                                                                          // BuildItemSection.cs:78
			this.WriteSection(this.Impressions);                                                                                                     // BuildItemSection.cs:78
			this.WriteSection(this.FindingsRightBreast);                                                                                             // BuildItemSection.cs:78
			this.WriteSection(this.FindingsLeftBreast);                                                                                              // BuildItemSection.cs:78
			this.WriteSection(this.RelatedResources);                                                                                                // BuildItemSection.cs:78
			this.WriteSection(this.Recommendations);                                                                                                 // BuildItemSection.cs:78
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
			this.ReadSection(this.Report);                                                                                                           // BuildItemSection.cs:81
			this.ReadSection(this.Impressions);                                                                                                      // BuildItemSection.cs:81
			this.ReadSection(this.FindingsRightBreast);                                                                                              // BuildItemSection.cs:81
			this.ReadSection(this.FindingsLeftBreast);                                                                                               // BuildItemSection.cs:81
			this.ReadSection(this.RelatedResources);                                                                                                 // BuildItemSection.cs:81
			this.ReadSection(this.Recommendations);                                                                                                  // BuildItemSection.cs:81
			//- ReadCode
		}

		//+ Methods
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionReportCode()                                                                          // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionReport";                                                                                        // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionImpressionsCode()                                                                     // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionImpressions";                                                                                   // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionFindingsRightBreastCode()                                                             // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionCodeFindingsRightBreast";                                                                       // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionFindingsLeftBreastCode()                                                              // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionCodeFindingsLeftBreast";                                                                        // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionRelatedResourcesCode()                                                                // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionRelatedResources";                                                                              // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_CompositionSectionRecommendationsCode()                                                                 // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/CompositionSectionSliceCodes";                    // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "sectionCodeRecommendations";                                                                           // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
