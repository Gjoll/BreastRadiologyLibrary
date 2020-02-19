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
	public class ConsistentWith : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment
	{
		//+ Fields
		public Value_Accessor Value { get ; protected set; }                                                                                      // CSBuildMemberListCodedValue.cs:214
		public Qualifier_Accessor Qualifier { get ; protected set; }                                                                              // CSBuildMemberListCodedValue.cs:214
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Init();
		/// </summary>
		public ConsistentWith() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
		public ConsistentWith(BreastRadiologyDocument doc, Observation resource)
		{
			this.Init(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Init().
		/// </summary>
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
			this.Resource.Code = DefaultValue_1();                                                                                                   // CSDefineBase.cs:121
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                                             // CSDefineBase.cs:182
			this.Value = new Value_Accessor(doc);                                                                                                    // CSBuildMemberListCodedValue.cs:217
			this.Qualifier = new Qualifier_Accessor(doc);                                                                                            // CSBuildMemberListCodedValue.cs:217
			//- Constructor
		}

		public override void Write()
		{
			//+ WriteCodeStart
			this.ClearComponents();                                                                                                                  // CSBuildMemberListCodedValue.cs:176
			//- WriteCodeStart
			//+ WriteCode
			this.WriteComponent(this.Value);                                                                                                         // CSBuildMemberListCodedValue.cs:220
			this.WriteComponent(this.Qualifier);                                                                                                     // CSBuildMemberListCodedValue.cs:220
			//- WriteCode
		}

		public override void Read()
		{
			//+ ReadCodeStart
			//- ReadCodeStart
			//+ ReadCode
			this.ReadComponent(this.Value);                                                                                                          // CSBuildMemberListCodedValue.cs:223
			this.ReadComponent(this.Qualifier);                                                                                                      // CSBuildMemberListCodedValue.cs:223
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
		        temp4.CodeElement.Value = "consistentWithObservation";                                                                            // FhirConstruct.cs:786
		        temp4.DisplayElement = new FhirString();                                                                                          // FhirConstruct.cs:792
		        temp4.DisplayElement.Value = "Consistent With observation";                                                                       // FhirConstruct.cs:794
		        retVal.Coding.Add(temp4);                                                                                                         // FhirConstruct.cs:813
		    }                                                                                                                                     // FhirConstruct.cs:814
		    retVal.TextElement = new FhirString();                                                                                                // FhirConstruct.cs:819
		    retVal.TextElement.Value = "Consistent With observation";                                                                             // FhirConstruct.cs:821
		    return retVal;                                                                                                                        // FhirConstruct.cs:829
		}                                                                                                                                         // FhirConstruct.cs:830
		//- Methods
	}
}
