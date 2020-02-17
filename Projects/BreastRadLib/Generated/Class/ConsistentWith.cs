using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ConsistentWithLocal;

namespace BreastRadLib
{
	public class ConsistentWith : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		public Value_Accessor Value { get ; protected set; }                                                                                      // CSDefineObservation.cs:398
		public Qualifier_Accessor Qualifier { get ; protected set; }                                                                              // CSDefineObservation.cs:398
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
			this.Value = new IConsistentWith.Value_Accessor(doc);                                                                                    // CSDefineObservation.cs:401
			this.Qualifier = new IConsistentWith.Qualifier_Accessor(doc);                                                                            // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCode
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		this.WriteComponent(this.Value);                                                                                                          // CSDefineObservation.cs:404
		this.WriteComponent(this.Qualifier);                                                                                                      // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		this.ReadComponent(this.Value);                                                                                                           // CSDefineObservation.cs:407
		this.ReadComponent(this.Qualifier);                                                                                                       // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
