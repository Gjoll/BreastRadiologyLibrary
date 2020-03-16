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
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 206
		// BuildMemberBase.cs:376
		/// <summary>
		/// ObsCount
		/// Access fhir element 'Observation.component:obsCount'
		/// </summary>
		public ObsCountContainer ObsCount { get ; protected set; }                                                                                // BuildMemberBase.cs:380
		                                                                                                                                          // BuildMemberBase.cs:374
		// Called from BuildMemberComponents.cs, Line 206
		// BuildMemberBase.cs:376
		/// <summary>
		/// FeatureType
		/// Access fhir element 'Observation.component:featureType'
		/// </summary>
		public FeatureTypeContainer FeatureType { get ; protected set; }                                                                          // BuildMemberBase.cs:380
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
			// Called from BuildMemberComponents.cs, Line 206
			this.ObsCount = new ObsCountContainer(0, 0);                                                                                             // BuildMemberBase.cs:359
			// Called from BuildMemberComponents.cs, Line 206
			this.FeatureType = new FeatureTypeContainer(1, 1);                                                                                       // BuildMemberBase.cs:359
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
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:168
			//- !WriteComponents
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
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:177
			//- !ReadComponents
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:137
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
			                                                                                                                                         // BuildMemberComponents.cs:132
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:135
			// BuildMemberComponents.cs:136
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:139
			{                                                                                                                                        // BuildMemberComponents.cs:140
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:141
			    //+ ReadComponents
			    this.ObsCount.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:90
			    this.FeatureType.Read(this.Doc, items);                                                                                              // BuildMemberComponents.cs:90
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:143
			                                                                                                                                         // BuildMemberComponents.cs:145
			// BuildMemberComponents.cs:146
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:149
			{                                                                                                                                        // BuildMemberComponents.cs:150
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:151
			    //+ WriteComponents
			    items.AddRange(this.ObsCount.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:112
			    items.AddRange(this.FeatureType.Write(this.Doc));                                                                                    // BuildMemberComponents.cs:112
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:153
			}                                                                                                                                        // BuildMemberComponents.cs:154
		//- !Components
		//- Methods
	}
}
