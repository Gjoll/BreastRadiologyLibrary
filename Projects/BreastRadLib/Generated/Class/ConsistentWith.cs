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
		                                                                                                                                          // BuildMemberBase.cs:301
		/// <summary>
		/// Value
		/// Access fhir element 'Observation.component:value'
		/// </summary>
		public ValueContainer Value { get ; protected set; }                                                                                      // BuildMemberBase.cs:306
		                                                                                                                                          // BuildMemberBase.cs:301
		/// <summary>
		/// Qualifier
		/// Access fhir element 'Observation.component:qualifier'
		/// </summary>
		public QualifierContainer Qualifier { get ; protected set; }                                                                              // BuildMemberBase.cs:306
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
			this.Value = new ValueContainer(1, 1);                                                                                                   // BuildMemberBase.cs:290
			this.Qualifier = new QualifierContainer(0, 0);                                                                                           // BuildMemberBase.cs:290
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
			this.ClearHasMember();
			//- WriteCodeStart
			//+ WriteCode
			//+ !WriteComponents
			this.WriteComponents(this.Doc);                                                                                                          // BuildMemberComponents.cs:146
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
			this.ReadComponents(this.Doc);                                                                                                           // BuildMemberComponents.cs:155
			//- !ReadComponents
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
		        temp4.CodeElement.Value = "consistentWithObservation";                                                                            // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Consistent With observation";                                                                       // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Consistent With observation";                                                                             // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		                                                                                                                                          // BuildMemberComponents.cs:110
		//+ !Components
		                                                                                                                                          // BuildMemberComponents.cs:113
		/// <summary>
		/// Read all component values from resource into this instance
		/// </summary>
		private void ReadComponents(BreastRadiologyDocument doc)                                                                                  // BuildMemberComponents.cs:117
		{                                                                                                                                         // BuildMemberComponents.cs:118
		    List<Observation.ComponentComponent> items = this.Resource.GetValue<Observation.ComponentComponent>("component").ToList();            // BuildMemberComponents.cs:119
		    //+ ReadComponents
		    this.Value.Read(this.Doc, items);                                                                                                     // BuildMemberComponents.cs:68
		    this.Qualifier.Read(this.Doc, items);                                                                                                 // BuildMemberComponents.cs:68
		    //- ReadComponents
		}                                                                                                                                         // BuildMemberComponents.cs:121
		                                                                                                                                          // BuildMemberComponents.cs:123
		/// <summary>
		/// Write all component values from this instance into resource
		/// </summary>
		private void WriteComponents(BreastRadiologyDocument doc)                                                                                 // BuildMemberComponents.cs:127
		{                                                                                                                                         // BuildMemberComponents.cs:128
		    List<Observation.ComponentComponent> items = new List<Observation.ComponentComponent>();                                              // BuildMemberComponents.cs:129
		    //+ WriteComponents
		    items.AddRange(this.Value.Write(this.Doc));                                                                                           // BuildMemberComponents.cs:90
		    items.AddRange(this.Qualifier.Write(this.Doc));                                                                                       // BuildMemberComponents.cs:90
		    //- WriteComponents
		    this.Resource.SetValue("component", items);                                                                                           // BuildMemberComponents.cs:131
		}                                                                                                                                         // BuildMemberComponents.cs:132
		//- !Components
		//- Methods
	}
}
