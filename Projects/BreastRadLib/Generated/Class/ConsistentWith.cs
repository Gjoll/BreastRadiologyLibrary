using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;
using BreastRadLib.HeaderFragmentLocal;
using BreastRadLib.CategoryFragmentLocal;
using BreastRadLib.BreastRadObservationFragmentLocal;
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;
//-Usings

namespace BreastRadLib
{
	/// <summary>
	/// Class ConsistentWith.
	/// This class is automatically generated.
	/// </summary>
	public class ConsistentWith : ObservationBase, IConsistentWith
	{
		//+ Properties
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// Value
		/// Access fhir element 'Observation.component:value'
		/// </summary>
		public MValue Value { get ; protected set; }                                                                                              // BuildMemberBase.cs:381
		                                                                                                                                          // BuildMemberBase.cs:375
		// Called from BuildMemberComponents.cs, Line 208
		// BuildMemberBase.cs:377
		/// <summary>
		/// Qualifier
		/// Access fhir element 'Observation.component:qualifier'
		/// </summary>
		public MQualifier Qualifier { get ; protected set; }                                                                                      // BuildMemberBase.cs:381
		//- Properties

		/// <summary>
		/// Constructor.
		/// Caller must call Init();
		/// </summary>
		public ConsistentWith() : base()
		{
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		/// <param name="resource">Fhir observation resource</param>
		public ConsistentWith(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Constructor.
		/// User must not call Init().
		/// </summary>
		/// <param name="doc">base document</param>
		public ConsistentWith(BreastRadiologyDocument doc)
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
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                                             // DefineBase.cs:220
			// Called from BuildMemberComponents.cs, Line 208
			this.Value = new MValue(1, 1);                                                                                                           // BuildMemberBase.cs:360
			// Called from BuildMemberComponents.cs, Line 208
			this.Qualifier = new MQualifier(0, -1);                                                                                                  // BuildMemberBase.cs:360
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
		        temp4.CodeElement.Value = "consistentWithObservation";                                                                            // FhirConstruct.cs:792
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:798
		        temp4.DisplayElement.Value = "Consistent With observation";                                                                       // FhirConstruct.cs:800
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:819
		    }                                                                                                                                     // FhirConstruct.cs:820
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:825
		    retVal.TextElement.Value = "Consistent With observation";                                                                             // FhirConstruct.cs:827
		    return retVal;                                                                                                                        // FhirConstruct.cs:835
		}                                                                                                                                         // FhirConstruct.cs:836
		                                                                                                                                          // BuildMemberComponents.cs:134
		//+ !Components
		                                                                                                                                          // BuildMemberComponents.cs:137
		// BuildMemberComponents.cs:138
		/// <summary>
		/// Read all component values from resource into this instance
		/// </summary>
		private void ReadComponents(BreastRadiologyDocument doc)                                                                                  // BuildMemberComponents.cs:141
		{                                                                                                                                         // BuildMemberComponents.cs:142
		    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();            // BuildMemberComponents.cs:143
		    //+ ReadComponents
		    this.Value.Read(this.Doc, items);                                                                                                     // BuildMemberComponents.cs:96
		    this.Qualifier.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:96
		    //- ReadComponents
		}                                                                                                                                         // BuildMemberComponents.cs:145
		                                                                                                                                          // BuildMemberComponents.cs:147
		// BuildMemberComponents.cs:148
		/// <summary>
		/// Write all values from this instance into resource
		/// </summary>
		private void WriteComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:151
		{                                                                                                                                         // BuildMemberComponents.cs:152
		    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                              // BuildMemberComponents.cs:153
		    //+ WriteComponents
		    items.AddRange(this.Value.Write(this.Doc));                                                                                           // BuildMemberComponents.cs:114
		    items.AddRange(this.Qualifier.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:114
		    //- WriteComponents
		    this.Resource.SetValue("component", items);                                                                                           // BuildMemberComponents.cs:155
		}                                                                                                                                         // BuildMemberComponents.cs:156
		//- !Components
		//- Methods
	}
}
