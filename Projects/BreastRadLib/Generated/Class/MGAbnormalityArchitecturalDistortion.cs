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
	public class MGAbnormalityArchitecturalDistortion : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, IShapeComponentsFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public ObsChanges_Accessor ObsChanges { get ; protected set; }                                                                            // CSDefineObservation.cs:398
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:398
		public Orientation_Accessor Orientation { get ; protected set; }                                                                          // CSDefineObservation.cs:398
		public Shape_Accessor Shape { get ; protected set; }                                                                                      // CSDefineObservation.cs:398
		public Margin_Accessor Margin { get ; protected set; }                                                                                    // CSDefineObservation.cs:398
		public MgDensity_Accessor MgDensity { get ; protected set; }                                                                              // CSDefineObservation.cs:398
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public MGAbnormalityArchitecturalDistortion() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityArchitecturalDistortion(BreastRadiologyDocument doc)
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
			this.CorrespondsWith = new CorrespondsWith_Accessor(doc);                                                                                // CSDefineObservation.cs:401
			this.PreviouslyDemonstratedBy = new PreviouslyDemonstratedBy_Accessor(doc);                                                              // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.ObsChanges);                                                                                                     // CSDefineObservation.cs:404
		this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.Orientation);                                                                                                    // CSDefineObservation.cs:404
		this.WriteComponent(this.Shape);                                                                                                          // CSDefineObservation.cs:404
		this.WriteComponent(this.Margin);                                                                                                         // CSDefineObservation.cs:404
		this.WriteComponent(this.MgDensity);                                                                                                      // CSDefineObservation.cs:404
		this.WriteComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:404
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
		this.ReadComponent(this.CorrespondsWith);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                        // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
