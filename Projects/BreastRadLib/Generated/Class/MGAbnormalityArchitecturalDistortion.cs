using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityArchitecturalDistortionLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;
using BreastRadLib.ObservedChangesFragmentLocal;
using BreastRadLib.BiRadFragmentLocal;
using BreastRadLib.CommonComponentsFragmentLocal;
using BreastRadLib.ShapeComponentsFragmentLocal;
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class MGAbnormalityArchitecturalDistortion.
	/// This class is automatically generated.
	/// </summary>
	public class MGAbnormalityArchitecturalDistortion : ObservationBase, IMGAbnormalityArchitecturalDistortion
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// ObsChanges
		/// Access fhir element 'Observation.component:obsChanges'
		/// </summary>
		public MObsChanges ObsChanges { get ; protected set; }                                                                                    // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// BiRadsAssessmentCategory
		/// Access fhir element 'Observation.component:biRadsAssessmentCategory'
		/// </summary>
		public MBiRadsAssessmentCategory BiRadsAssessmentCategory { get ; protected set; }                                                        // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// Orientation
		/// Access fhir element 'Observation.component:orientation'
		/// </summary>
		public MOrientation Orientation { get ; protected set; }                                                                                  // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// Shape
		/// Access fhir element 'Observation.component:shape'
		/// </summary>
		public MShape Shape { get ; protected set; }                                                                                              // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// Margin
		/// Access fhir element 'Observation.component:margin'
		/// </summary>
		public MMargin Margin { get ; protected set; }                                                                                            // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// MgDensity
		/// Access fhir element 'Observation.component:mgDensity'
		/// </summary>
		public MMgDensity MgDensity { get ; protected set; }                                                                                      // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// NotPreviouslySeen
		/// Access fhir element 'Observation.component:notPreviouslySeen'
		/// </summary>
		public MNotPreviouslySeen NotPreviouslySeen { get ; protected set; }                                                                      // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// CorrespondsWith
		/// Access fhir element 'Observation.component:correspondsWith'
		/// </summary>
		public MCorrespondsWith CorrespondsWith { get ; protected set; }                                                                          // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// PreviouslyDemonstratedBy
		/// Access fhir element 'Observation.component:PreviouslyDemonstratedBy'
		/// </summary>
		public MPreviouslyDemonstratedBy PreviouslyDemonstratedBy { get ; protected set; }                                                        // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:377
		/// <summary>
		/// AssociatedFeature
		/// Access fhir element 'Observation.hasMember:associatedFeature'
		/// </summary>
		public MAssociatedFeature AssociatedFeature { get ; protected set; }                                                                      // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberReferences.cs, Line 199
		// BuildMemberBase.cs:377
		/// <summary>
		/// ConsistentWith
		/// Access fhir element 'Observation.hasMember:consistentWith'
		/// </summary>
		public MConsistentWith ConsistentWith { get ; protected set; }                                                                            // BuildMemberBase.cs:381
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public MGAbnormalityArchitecturalDistortion() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityArchitecturalDistortion");                       // DefineBase.cs:220
			// Called from BuildMemberComponents.cs, Line 208
			this.ObsChanges = new MObsChanges(0, -1);                                                                                                // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.BiRadsAssessmentCategory = new MBiRadsAssessmentCategory(0, 1);                                                                     // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.Orientation = new MOrientation(0, 1);                                                                                               // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.Shape = new MShape(0, 1);                                                                                                           // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.Margin = new MMargin(0, 1);                                                                                                         // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.MgDensity = new MMgDensity(0, 1);                                                                                                   // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.NotPreviouslySeen = new MNotPreviouslySeen(0, -1);                                                                                  // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.CorrespondsWith = new MCorrespondsWith(0, -1);                                                                                      // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.PreviouslyDemonstratedBy = new MPreviouslyDemonstratedBy(0, -1);                                                                    // BuildMemberBase.cs:360
			// Called from BuildMemberReferences.cs, Line 199
			this.AssociatedFeature = new MAssociatedFeature(0, -1);                                                                                  // BuildMemberBase.cs:360
			// Called from BuildMemberReferences.cs, Line 199
			this.ConsistentWith = new MConsistentWith(0, -1);                                                                                        // BuildMemberBase.cs:360
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
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:170
			//- !WriteComponents
			//+ !WriteHasMembers
			this.WriteHasMembers(this.Doc);                                                                                                          // BuildMemberReferences.cs:163
			//- !WriteHasMembers
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
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:179
			//- !ReadComponents
			//+ !ReadHasMembers
			this.ReadHasMembers(this.Doc);                                                                                                           // BuildMemberReferences.cs:172
			//- !ReadHasMembers
			//- ReadCode
		}

		//+ Methods
		// DefineBase.cs:137
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
		        temp4.CodeElement.Value = "mgAbnormalityArchitecturalDistortionObservation";                                                      // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Abnormality Architectural Distortion observation";                                                  // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Abnormality Architectural Distortion observation";                                                        // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
			                                                                                                                                         // BuildMemberComponents.cs:134
		//+ !Components
			                                                                                                                                         // BuildMemberComponents.cs:137
			// BuildMemberComponents.cs:138
			/// <summary>
			/// Read all component values from resource into this instance
			/// </summary>
			private void ReadComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:141
			{                                                                                                                                        // BuildMemberComponents.cs:142
			    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();           // BuildMemberComponents.cs:143
			    //+ ReadComponents
			    this.ObsChanges.Read(this.Doc, items);                                                                                               // BuildMemberComponents.cs:96
			    this.BiRadsAssessmentCategory.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:96
			    this.Orientation.Read(this.Doc, items);                                                                                              // BuildMemberComponents.cs:96
			    this.Shape.Read(this.Doc, items);                                                                                                    // BuildMemberComponents.cs:96
			    this.Margin.Read(this.Doc, items);                                                                                                   // BuildMemberComponents.cs:96
			    this.MgDensity.Read(this.Doc, items);                                                                                                // BuildMemberComponents.cs:96
			    this.NotPreviouslySeen.Read(this.Doc, items);                                                                                        // BuildMemberComponents.cs:96
			    this.CorrespondsWith.Read(this.Doc, items);                                                                                          // BuildMemberComponents.cs:96
			    this.PreviouslyDemonstratedBy.Read(this.Doc, items);                                                                                 // BuildMemberComponents.cs:96
			    //- ReadComponents
			}                                                                                                                                        // BuildMemberComponents.cs:145
			                                                                                                                                         // BuildMemberComponents.cs:147
			// BuildMemberComponents.cs:148
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteComponents(BreastRadiologyDocument doc)                                                                                // BuildMemberComponents.cs:151
			{                                                                                                                                        // BuildMemberComponents.cs:152
			    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                             // BuildMemberComponents.cs:153
			    //+ WriteComponents
			    items.AddRange(this.ObsChanges.Write(this.Doc));                                                                                     // BuildMemberComponents.cs:114
			    items.AddRange(this.BiRadsAssessmentCategory.Write(this.Doc));                                                                       // BuildMemberComponents.cs:114
			    items.AddRange(this.Orientation.Write(this.Doc));                                                                                    // BuildMemberComponents.cs:114
			    items.AddRange(this.Shape.Write(this.Doc));                                                                                          // BuildMemberComponents.cs:114
			    items.AddRange(this.Margin.Write(this.Doc));                                                                                         // BuildMemberComponents.cs:114
			    items.AddRange(this.MgDensity.Write(this.Doc));                                                                                      // BuildMemberComponents.cs:114
			    items.AddRange(this.NotPreviouslySeen.Write(this.Doc));                                                                              // BuildMemberComponents.cs:114
			    items.AddRange(this.CorrespondsWith.Write(this.Doc));                                                                                // BuildMemberComponents.cs:114
			    items.AddRange(this.PreviouslyDemonstratedBy.Write(this.Doc));                                                                       // BuildMemberComponents.cs:114
			    //- WriteComponents
			    this.Resource.SetValue("component", items);                                                                                          // BuildMemberComponents.cs:155
			}                                                                                                                                        // BuildMemberComponents.cs:156
		//- !Components
			                                                                                                                                         // BuildMemberComponents.cs:134
			                                                                                                                                         // BuildMemberComponents.cs:134
			                                                                                                                                         // BuildMemberComponents.cs:134
			                                                                                                                                         // BuildMemberComponents.cs:134
			                                                                                                                                         // BuildMemberComponents.cs:134
			                                                                                                                                         // BuildMemberReferences.cs:127
		//+ !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:130
			// BuildMemberReferences.cs:131
			/// <summary>
			/// Read all values from resource into this instance
			/// </summary>
			private void ReadHasMembers(BreastRadiologyDocument doc)                                                                                 // BuildMemberReferences.cs:134
			{                                                                                                                                        // BuildMemberReferences.cs:135
			    List<ResourceReference> items = this.Resource.GetValue<ResourceReference>("hasMember").ToList();                                     // BuildMemberReferences.cs:136
			    //+ ReadHasMembers
			    this.AssociatedFeature.Read(this.Doc, items);                                                                                        // BuildMemberReferences.cs:89
			    this.ConsistentWith.Read(this.Doc, items);                                                                                           // BuildMemberReferences.cs:89
			    //- ReadHasMembers
			}                                                                                                                                        // BuildMemberReferences.cs:138
			                                                                                                                                         // BuildMemberReferences.cs:140
			// BuildMemberReferences.cs:141
			/// <summary>
			/// Write all values from this instance into resource
			/// </summary>
			private void WriteHasMembers(BreastRadiologyDocument doc)                                                                                // BuildMemberReferences.cs:144
			{                                                                                                                                        // BuildMemberReferences.cs:145
			    List<ResourceReference> items = new List<ResourceReference>();                                                                       // BuildMemberReferences.cs:146
			    //+ WriteHasMembers
			    items.AddRange(this.AssociatedFeature.Write(this.Doc));                                                                              // BuildMemberReferences.cs:107
			    items.AddRange(this.ConsistentWith.Write(this.Doc));                                                                                 // BuildMemberReferences.cs:107
			    //- WriteHasMembers
			    this.Resource.SetValue("hasMember", items);                                                                                          // BuildMemberReferences.cs:148
			}                                                                                                                                        // BuildMemberReferences.cs:149
		//- !HasMembers
			                                                                                                                                         // BuildMemberReferences.cs:127
		//- Methods
	}
}
