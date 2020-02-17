using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class ConsistentWith : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment
	{
		//+ LocalClassDefs
		/// <summary>
		/// Accessor class for 'value'
		/// [Fhir Element 'Observation.component:value]'
		/// </summary>
		public class Value_Accessor : ComponentBase<CodeableConcept>                                                                              // CSDefineObservation.cs:215
		{                                                                                                                                         // CSDefineObservation.cs:216
		    // Properties                                                                                                                         // CSDefineObservation.cs:222
		    /// <summary>
		    /// get {propertyName} value
		    /// </summary>
		    public CodeableConcept Value() => this.GetSingleItem<CodeableConcept> ();                                                             // CSDefineObservation.cs:251
		                                                                                                                                          // CSDefineObservation.cs:224
		    // Methods                                                                                                                            // CSDefineObservation.cs:225
		                                                                                                                                          // CSDefineObservation.cs:256
		    /// <summary>
		    /// Set Value value
		    /// </summary>
		    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                      // CSDefineObservation.cs:260
		                                                                                                                                          // CSDefineObservation.cs:227
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Value_Accessor(BreastRadiologyDocument doc) : base()                                                                           // CSDefineObservation.cs:231
		    {                                                                                                                                     // CSDefineObservation.cs:232
		        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithValue"));// CSDefineObservation.cs:233
		    }                                                                                                                                     // CSDefineObservation.cs:235
		}                                                                                                                                         // CSDefineObservation.cs:236
		/// <summary>
		/// Accessor class for 'qualifier'
		/// [Fhir Element 'Observation.component:qualifier]'
		/// </summary>
		public class Qualifier_Accessor : ComponentBase<CodeableConcept>                                                                          // CSDefineObservation.cs:215
		{                                                                                                                                         // CSDefineObservation.cs:216
		    // Properties                                                                                                                         // CSDefineObservation.cs:222
		    /// <summary>
		    /// get {propertyName} value
		    /// </summary>
		    public CodeableConcept Value() => this.GetSingleItem<CodeableConcept> ();                                                             // CSDefineObservation.cs:251
		                                                                                                                                          // CSDefineObservation.cs:224
		    // Methods                                                                                                                            // CSDefineObservation.cs:225
		                                                                                                                                          // CSDefineObservation.cs:256
		    /// <summary>
		    /// Set Qualifier value
		    /// </summary>
		    public void ValueCodeableConcept(CodeableConcept value) => this.SetFirst(value);                                                      // CSDefineObservation.cs:260
		                                                                                                                                          // CSDefineObservation.cs:227
		    /// <summary>
		    /// Accessor class constructor
		    /// </summary>
		    public Qualifier_Accessor(BreastRadiologyDocument doc) : base()                                                                       // CSDefineObservation.cs:231
		    {                                                                                                                                     // CSDefineObservation.cs:232
		        this.Create(doc, 1, 1, new Coding("http://hl7.org/fhir/us/breast-radiology/CodeSystem/ObservationComponentSliceCodes", "consistentWithQualifier"));// CSDefineObservation.cs:233
		    }                                                                                                                                     // CSDefineObservation.cs:235
		}                                                                                                                                         // CSDefineObservation.cs:236
		//- LocalClassDefs

		//+ Fields
		public Value_Accessor Value { get ; protected set; }                                                                                      // CSDefineObservation.cs:380
		public Qualifier_Accessor Qualifier { get ; protected set; }                                                                              // CSDefineObservation.cs:380
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public ConsistentWith() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public ConsistentWith(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public ConsistentWith(BreastRadiologyDocument doc)
		{
		this.Create(doc, new Observation());
		}

		/// <summary>
		/// Init object.
		/// </summary>
		public void Create(BreastRadiologyDocument doc, Observation resource)
		{
			base.Create(doc, resource);
			//+ Constructor
			this.Value = new Value_Accessor(doc);                                                                                                    // CSDefineObservation.cs:383
			this.Qualifier = new Qualifier_Accessor(doc);                                                                                            // CSDefineObservation.cs:383
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCode
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:331
		this.WriteComponent(this.Value);                                                                                                          // CSDefineObservation.cs:386
		this.WriteComponent(this.Qualifier);                                                                                                      // CSDefineObservation.cs:386
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		this.ReadComponent(this.Value);                                                                                                           // CSDefineObservation.cs:389
		this.ReadComponent(this.Qualifier);                                                                                                       // CSDefineObservation.cs:389
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
