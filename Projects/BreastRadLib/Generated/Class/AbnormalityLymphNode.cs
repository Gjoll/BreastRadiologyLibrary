using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityLymphNodeLocal;
//+Usings
using BreastRadLib.ObservationLeafFragmentLocal;                                                                                            // CSDefineBase.cs:103
using BreastRadLib.TumorSatelliteFragmentLocal;                                                                                             // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;                                                                               // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;                                                                                // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;                                                                            // CSDefineBase.cs:103
using BreastRadLib.CommonComponentsFragmentLocal;                                                                                           // CSDefineBase.cs:103
using BreastRadLib.ShapeComponentsFragmentLocal;                                                                                            // CSDefineBase.cs:103
using BreastRadLib.ObservedCountFragmentLocal;                                                                                              // CSDefineBase.cs:103
using BreastRadLib.ObservedDistributionFragmentLocal;                                                                                       // CSDefineBase.cs:103
using BreastRadLib.ObservedSizeFragmentLocal;                                                                                               // CSDefineBase.cs:103
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;                                                                                 // CSDefineBase.cs:103
using BreastRadLib.CorrespondsWithFragmentLocal;                                                                                            // CSDefineBase.cs:103
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;                                                                                   // CSDefineBase.cs:103
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;                                                                                // CSDefineBase.cs:103
//-Usings

namespace BreastRadLib
{
	public class AbnormalityLymphNode : ObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ Fields
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSDefineObservation.cs:398
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSDefineObservation.cs:398
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSDefineObservation.cs:398
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSDefineObservation.cs:398
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSDefineObservation.cs:398
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSDefineObservation.cs:398
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:398
		public LymphNodeType_Accessor LymphNodeType { get ; protected set; }                                                                      // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public AbnormalityLymphNode() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityLymphNode(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityLymphNode(BreastRadiologyDocument doc)
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
			this.Orientation = new IShapeComponentsFragment.Orientation_Accessor(doc);                                                               // CSDefineObservation.cs:401
			this.Shape = new IShapeComponentsFragment.Shape_Accessor(doc);                                                                           // CSDefineObservation.cs:401
			this.Margin = new IShapeComponentsFragment.Margin_Accessor(doc);                                                                         // CSDefineObservation.cs:401
			this.MgDensity = new IShapeComponentsFragment.MgDensity_Accessor(doc);                                                                   // CSDefineObservation.cs:401
			this.ObsCount = new IObservedCountFragment.ObsCount_Accessor(doc);                                                                       // CSDefineObservation.cs:401
			this.ObsDistribution = new IObservedDistributionFragment.ObsDistribution_Accessor(doc);                                                  // CSDefineObservation.cs:401
			this.ObsDistRegionSize = new IObservedDistributionFragment.ObsDistRegionSize_Accessor(doc);                                              // CSDefineObservation.cs:401
			this.ObsSize = new IObservedSizeFragment.ObsSize_Accessor(doc);                                                                          // CSDefineObservation.cs:401
			this.NotPreviouslySeen = new INotPreviouslySeenComponentFragment.NotPreviouslySeen_Accessor(doc);                                        // CSDefineObservation.cs:401
			this.CorrespondsWith = new ICorrespondsWithFragment.CorrespondsWith_Accessor(doc);                                                       // CSDefineObservation.cs:401
			this.PreviouslyDemonstratedBy = new IPreviouslyDemonstratedByFragment.PreviouslyDemonstratedBy_Accessor(doc);                            // CSDefineObservation.cs:401
			this.LymphNodeType = new IAbnormalityLymphNode.LymphNodeType_Accessor(doc);                                                              // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.Orientation);                                                                                                    // CSDefineObservation.cs:404
		this.WriteComponent(this.Shape);                                                                                                          // CSDefineObservation.cs:404
		this.WriteComponent(this.Margin);                                                                                                         // CSDefineObservation.cs:404
		this.WriteComponent(this.MgDensity);                                                                                                      // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsCount);                                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsDistribution);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsDistRegionSize);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsSize);                                                                                                        // CSDefineObservation.cs:404
		this.WriteComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.LymphNodeType);                                                                                                  // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadComponent(this.Orientation);                                                                                                     // CSDefineObservation.cs:407
		this.ReadComponent(this.Shape);                                                                                                           // CSDefineObservation.cs:407
		this.ReadComponent(this.Margin);                                                                                                          // CSDefineObservation.cs:407
		this.ReadComponent(this.MgDensity);                                                                                                       // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsCount);                                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsDistribution);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsDistRegionSize);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsSize);                                                                                                         // CSDefineObservation.cs:407
		this.ReadComponent(this.NotPreviouslySeen);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.CorrespondsWith);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.LymphNodeType);                                                                                                   // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
