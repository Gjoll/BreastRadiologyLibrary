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
using BreastRadLib.ObservationLeafFragmentLocal;                                                                                            // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;                                                                               // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;                                                                                // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;                                                                            // CSDefineBase.cs:103
using BreastRadLib.BreastBodyLocationRequiredFragmentLocal;                                                                                 // CSDefineBase.cs:103
using BreastRadLib.ObservedCountFragmentLocal;                                                                                              // CSDefineBase.cs:103
//-Usings

namespace BreastRadLib
{
	public class ObservedFeature : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, IBreastBodyLocationRequiredFragment, IObservedCountFragment
	{
		//+ Fields
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
			this.FeatureType = new IObservedFeature.FeatureType_Accessor(doc);                                                                       // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.FeatureType);                                                                                                    // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadComponent(this.FeatureType);                                                                                                     // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
