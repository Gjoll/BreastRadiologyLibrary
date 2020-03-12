using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AssociatedFeatureLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedCountFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class AssociatedFeature.
	/// This class is automatically generated.
	/// </summary>
	public class AssociatedFeature : ObservationBase, IAssociatedFeature
	{
		//+ Properties
		public TItemElementSingle<BodySiteExtended> BodySite { get; private set; }                                                                // DefineBase.cs:76
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access ObsCount
		/// </summary>
		public TItemComponentSingle<Quantity, Range> ObsCount { get ; protected set; }                                                            // BuildElementItemComponent.cs:72
		                                                                                                                                          // BuildElementItemComponent.cs:68
		/// <summary>
		/// Access FeatureType
		/// </summary>
		public TItemComponentSingle<CodeableConcept> FeatureType { get ; protected set; }                                                         // BuildElementItemComponent.cs:72
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public AssociatedFeature() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public AssociatedFeature(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public AssociatedFeature(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature");                                          // DefineBase.cs:220
			this.BodySite = new TItemElementSingle<BodySiteExtended>("Observation.bodySite", 1, 1);                                                  // DefineBase.cs:79
			this.ObsCount = new TItemComponentSingle<Quantity, Range>("Observation.component:obsCount", 0, 1, FixedValue_ObservationComponentObsCountCode());// BuildElementItemComponent.cs:57
			this.FeatureType = new TItemComponentSingle<CodeableConcept>("Observation.component:featureType", 1, 1, FixedValue_ObservationComponentFeatureTypeCode());// BuildElementItemComponent.cs:57
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
			if (this.ObsCount.Validate(sb) == false) retVal = false;                                                                                 // BuildElementItemComponent.cs:81
			if (this.FeatureType.Validate(sb) == false) retVal = false;                                                                              // BuildElementItemComponent.cs:81
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
			this.ClearHasMember();
			this.ClearComponent();
			//- WriteCodeStart
			//+ WriteCode
			this.BodySite.Write(this.Doc, this.Resource);                                                                                            // DefineBase.cs:85
			this.ObsCount.Write(this.Doc, this.Resource);                                                                                            // BuildElementItemComponent.cs:75
			this.FeatureType.Write(this.Doc, this.Resource);                                                                                         // BuildElementItemComponent.cs:75
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
			this.BodySite.Read(this.Doc, this.Resource);                                                                                             // DefineBase.cs:82
			this.ObsCount.Read(this.Doc, this.Resource);                                                                                             // BuildElementItemComponent.cs:78
			this.FeatureType.Read(this.Doc, this.Resource);                                                                                          // BuildElementItemComponent.cs:78
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
		        temp4.CodeElement.Value = "associatedFeaturesObservation";                                                                        // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Associated Features observation";                                                                   // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Associated Features observation";                                                                         // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
			/// <summary>
			/// Method to create fixed value
			/// </summary>
			public CodeableConcept FixedValue_ObservationComponentObsCountCode()                                                                     // FhirConstruct.cs:753
			{                                                                                                                                        // FhirConstruct.cs:754
			    CodeableConcept retVal = new CodeableConcept();                                                                                      // FhirConstruct.cs:755
			    retVal.Coding = new List<Coding>();                                                                                                  // FhirConstruct.cs:761
			    {                                                                                                                                    // FhirConstruct.cs:764
			        var temp4 = new Coding();                                                                                                        // FhirConstruct.cs:765
			        temp4.SystemElement = new FhirUri();                                                                                             // FhirConstruct.cs:768
			        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                 // FhirConstruct.cs:770
			        temp4.CodeElement = new Code();                                                                                                  // FhirConstruct.cs:784
			        temp4.CodeElement.Value = "obsCount";                                                                                            // FhirConstruct.cs:786
			        retVal.Coding.Add(temp4);                                                                                                        // FhirConstruct.cs:813
			    }                                                                                                                                    // FhirConstruct.cs:814
			    return retVal;                                                                                                                       // FhirConstruct.cs:829
			}                                                                                                                                        // FhirConstruct.cs:830
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationComponentFeatureTypeCode()                                                                   // FhirConstruct.cs:753
		{                                                                                                                                         // FhirConstruct.cs:754
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:755
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:761
		    {                                                                                                                                     // FhirConstruct.cs:764
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:765
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:768
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes";                  // FhirConstruct.cs:770
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:784
		        temp4.CodeElement.Value = "featureType";                                                                                          // FhirConstruct.cs:786
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
