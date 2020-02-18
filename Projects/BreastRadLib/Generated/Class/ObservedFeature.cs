using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservedFeatureLocal;
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
	public class ObservedFeature : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, IBreastBodyLocationRequiredFragment, IObservedCountFragment
	{
		//+ Fields
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSDefineObservation.cs:398
		public FeatureType_Accessor FeatureType { get ; protected set; }                                                                          // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public ObservedFeature() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public ObservedFeature(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public ObservedFeature(BreastRadiologyDocument doc)
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
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSDefineObservation.cs:401
			this.FeatureType = new FeatureType_Accessor(doc);                                                                                        // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.ObsCount);                                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.FeatureType);                                                                                                    // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadComponent(this.ObsCount);                                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.FeatureType);                                                                                                     // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
