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
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberElement.cs, Line 123
		// BuildMemberBase.cs:396
		/// <summary>
		/// BodySite
		/// Access fhir element 'Observation.bodySite'
		/// </summary>
		public MBodySite BodySite { get ; protected set; }                                                                                        // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:396
		/// <summary>
		/// ObsCount
		/// Access fhir element 'Observation.component:obsCount'
		/// </summary>
		public MObsCount ObsCount { get ; protected set; }                                                                                        // BuildMemberBase.cs:400
		                                                                                                                                          // BuildMemberBase.cs:394
		// Called from BuildMemberComponents.cs, Line 202
		// BuildMemberBase.cs:396
		/// <summary>
		/// FeatureType
		/// Access fhir element 'Observation.component:featureType'
		/// </summary>
		public MFeatureType FeatureType { get ; protected set; }                                                                                  // BuildMemberBase.cs:400
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
			this.Resource.Code = FixedValue_ObservationCode();                                                                                       // DefineBase.cs:177
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeature");                                          // DefineBase.cs:238
			// Called from BuildMemberElement.cs, Line 123
			this.BodySite = new MBodySite(1, 1);                                                                                                     // BuildMemberBase.cs:379
			// Called from BuildMemberComponents.cs, Line 202
			this.ObsCount = new MObsCount(0, 1);                                                                                                     // BuildMemberBase.cs:379
			// Called from BuildMemberComponents.cs, Line 202
			this.FeatureType = new MFeatureType(1, 1);                                                                                               // BuildMemberBase.cs:379
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
			this.Resource.SetValue("bodySite", this.BodySite.Write(this.Doc));                                                                       // BuildMemberElement.cs:86
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:164
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
			this.BodySite.Read(this.Doc, this.Resource.GetValue<CodeableConcept>("bodySite"));                                                       // BuildMemberElement.cs:71
			//+ !ReadComponents
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:173
			//- !ReadComponents
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:155
		/// <summary>
		/// Method to create fixed value
		/// </summary>
		public CodeableConcept FixedValue_ObservationCode()                                                                                       // FhirConstruct.cs:759
		{                                                                                                                                         // FhirConstruct.cs:760
		    CodeableConcept retVal = new CodeableConcept();                                                                                       // FhirConstruct.cs:761
		    retVal.Coding = new List<Coding>();                                                                                                   // FhirConstruct.cs:767
		    {                                                                                                                                     // FhirConstruct.cs:770
		        var temp4 = new Coding();                                                                                                         // FhirConstruct.cs:771
		        temp4.SystemElement = new FhirUri();                                                                                              // FhirConstruct.cs:774
		        temp4.SystemElement.Value = "http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationCodes";                                // FhirConstruct.cs:776
		        temp4.CodeElement = new Code();                                                                                                   // FhirConstruct.cs:790
		        temp4.CodeElement.Value = "associatedFeaturesObservation";                                                                        // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Associated Features observation";                                                                   // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Associated Features observation";                                                                         // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
			                                                                                                                                         // BuildMemberComponents.cs:128
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:131
			// BuildMemberComponents.cs:132
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:135
			{                                                                                                                                        // BuildMemberComponents.cs:136
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:137
			    //+ ReadComponents
			    this.ObsCount.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:90
			    this.FeatureType.Read(this.Doc, items);                                                                                              // BuildMemberComponents.cs:90
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:139
			                                                                                                                                         // BuildMemberComponents.cs:141
			// BuildMemberComponents.cs:142
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:145
			{                                                                                                                                        // BuildMemberComponents.cs:146
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:147
			    //+ WriteComponents
			    items.AddRange(this.ObsCount.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:108
			    items.AddRange(this.FeatureType.Write(this.Doc));                                                                                    // BuildMemberComponents.cs:108
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:149
			}                                                                                                                                        // BuildMemberComponents.cs:150
		//- !Components
		//- Methods
	}
}
