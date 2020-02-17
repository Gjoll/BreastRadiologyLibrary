using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.AbnormalityForeignObjectLocal;
//+Usings
using BreastRadLib.BreastRadObservationNoDeviceFragmentLocal;                                                                               // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoValueFragmentLocal;                                                                                // CSDefineBase.cs:103
using BreastRadLib.BreastRadObservationNoComponentFragmentLocal;                                                                            // CSDefineBase.cs:103
using BreastRadLib.CommonComponentsFragmentLocal;                                                                                           // CSDefineBase.cs:103
using BreastRadLib.NotPreviouslySeenComponentFragmentLocal;                                                                                 // CSDefineBase.cs:103
using BreastRadLib.CorrespondsWithFragmentLocal;                                                                                            // CSDefineBase.cs:103
using BreastRadLib.BiRadFragmentLocal;                                                                                                      // CSDefineBase.cs:103
using BreastRadLib.PreviouslyDemonstratedByFragmentLocal;                                                                                   // CSDefineBase.cs:103
using BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal;                                                                                // CSDefineBase.cs:103
using BreastRadLib.ConsistentWithHasMemberFragmentLocal;                                                                                    // CSDefineBase.cs:103
//-Usings

namespace BreastRadLib
{
	public class AbnormalityForeignObject : ObservationBase, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IBiRadFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		public NotPreviouslySeen_Accessor NotPreviouslySeen { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public CorrespondsWith_Accessor CorrespondsWith { get ; protected set; }                                                                  // CSDefineObservation.cs:398
		public BiRadsAssessmentCategory_Accessor BiRadsAssessmentCategory { get ; protected set; }                                                // CSDefineObservation.cs:398
		public PreviouslyDemonstratedBy_Accessor PreviouslyDemonstratedBy { get ; protected set; }                                                // CSDefineObservation.cs:398
		public AbnormalityForeignObjectType_Accessor AbnormalityForeignObjectType { get ; protected set; }                                        // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public AbnormalityForeignObject() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityForeignObject(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public AbnormalityForeignObject(BreastRadiologyDocument doc)
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
			this.NotPreviouslySeen = new INotPreviouslySeenComponentFragment.NotPreviouslySeen_Accessor(doc);                                        // CSDefineObservation.cs:401
			this.CorrespondsWith = new ICorrespondsWithFragment.CorrespondsWith_Accessor(doc);                                                       // CSDefineObservation.cs:401
			this.BiRadsAssessmentCategory = new IBiRadFragment.BiRadsAssessmentCategory_Accessor(doc);                                               // CSDefineObservation.cs:401
			this.PreviouslyDemonstratedBy = new IPreviouslyDemonstratedByFragment.PreviouslyDemonstratedBy_Accessor(doc);                            // CSDefineObservation.cs:401
			this.AbnormalityForeignObjectType = new IAbnormalityForeignObject.AbnormalityForeignObjectType_Accessor(doc);                            // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCodeStart
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		//- WriteCodeStart
		//+ WriteCode
		this.WriteComponent(this.NotPreviouslySeen);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.CorrespondsWith);                                                                                                // CSDefineObservation.cs:404
		this.WriteComponent(this.BiRadsAssessmentCategory);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.PreviouslyDemonstratedBy);                                                                                       // CSDefineObservation.cs:404
		this.WriteComponent(this.AbnormalityForeignObjectType);                                                                                   // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCodeStart
		//- ReadCodeStart
		//+ ReadCode
		this.ReadComponent(this.NotPreviouslySeen);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.CorrespondsWith);                                                                                                 // CSDefineObservation.cs:407
		this.ReadComponent(this.BiRadsAssessmentCategory);                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.PreviouslyDemonstratedBy);                                                                                        // CSDefineObservation.cs:407
		this.ReadComponent(this.AbnormalityForeignObjectType);                                                                                    // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
