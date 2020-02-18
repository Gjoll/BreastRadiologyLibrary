using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityDensityLocal;
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
using BreastRadLib.ObservedCountFragmentLocal;
using BreastRadLib.ObservedSizeFragmentLocal;
using BreastRadLib.ObservedDistributionFragmentLocal;
using BreastRadLib.CorrespondsWithFragmentLocal;
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;
//-Usings

namespace BreastRadLib
{
	public class MGAbnormalityDensity : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, IShapeComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSDefineObservation.cs:398
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:398
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSDefineObservation.cs:398
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSDefineObservation.cs:398
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSDefineObservation.cs:398
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSDefineObservation.cs:398
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public ObsCount_Accessor ObsCount { get ; protected set; }                                                                                // CSDefineObservation.cs:398
		public ObsSize_Accessor ObsSize { get ; protected set; }                                                                                  // CSDefineObservation.cs:398
		public ObsDistribution_Accessor ObsDistribution { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public ObsDistRegionSize_Accessor ObsDistRegionSize { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:398
		public DensityType_Accessor DensityType { get ; protected set; }                                                                          // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public MGAbnormalityDensity() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityDensity(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityDensity(BreastRadiologyDocument doc)
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
			this.ObsChanges = new ObsChanges_Accessor(doc);                                                                                          // CSDefineObservation.cs:401
			this.BiRadsAssessmentCategory = new BiRadsAssessmentCategory_Accessor(doc);                                                              // CSDefineObservation.cs:401
			this.Orientation = new Orientation_Accessor(doc);                                                                                        // CSDefineObservation.cs:401
			this.Shape = new Shape_Accessor(doc);                                                                                                    // CSDefineObservation.cs:401
			this.Margin = new Margin_Accessor(doc);                                                                                                  // CSDefineObservation.cs:401
			this.MgDensity = new MgDensity_Accessor(doc);                                                                                            // CSDefineObservation.cs:401
			this.NotPreviouslySeen = new NotPreviouslySeen_Accessor(doc);                                                                            // CSDefineObservation.cs:401
			this.ObsCount = new ObsCount_Accessor(doc);                                                                                              // CSDefineObservation.cs:401
			this.ObsSize = new ObsSize_Accessor(doc);                                                                                                // CSDefineObservation.cs:401
			this.ObsDistribution = new ObsDistribution_Accessor(doc);                                                                                // CSDefineObservation.cs:401
			this.ObsDistRegionSize = new ObsDistRegionSize_Accessor(doc);                                                                            // CSDefineObservation.cs:401
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSDefineObservation.cs:401
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSDefineObservation.cs:401
			this.DensityType = new DensityType_Accessor(doc);                                                                                        // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.ObsChanges);                                                                                                     // CSDefineObservation.cs:404
		this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.Orientation);                                                                                                    // CSDefineObservation.cs:404
		this.WriteComponent(this.Shape);                                                                                                          // CSDefineObservation.cs:404
		this.WriteComponent(this.Margin);                                                                                                         // CSDefineObservation.cs:404
		this.WriteComponent(this.MgDensity);                                                                                                      // CSDefineObservation.cs:404
		this.WriteComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsCount);                                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsSize);                                                                                                        // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsDistribution);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.ObsDistRegionSize);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.DensityType);                                                                                                    // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadComponent(this.ObsChanges);                                                                                                      // CSDefineObservation.cs:407
		this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.Orientation);                                                                                                     // CSDefineObservation.cs:407
		this.ReadComponent(this.Shape);                                                                                                           // CSDefineObservation.cs:407
		this.ReadComponent(this.Margin);                                                                                                          // CSDefineObservation.cs:407
		this.ReadComponent(this.MgDensity);                                                                                                       // CSDefineObservation.cs:407
		this.ReadComponent(this.NotPreviouslySeen);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsCount);                                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsSize);                                                                                                         // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsDistribution);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.ObsDistRegionSize);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.CorrespondsWith);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.DensityType);                                                                                                     // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
