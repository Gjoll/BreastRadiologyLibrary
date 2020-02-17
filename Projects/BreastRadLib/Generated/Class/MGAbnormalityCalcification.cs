using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.MGAbnormalityCalcificationLocal;

namespace BreastRadLib
{
	public class MGAbnormalityCalcification : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ LocalClassDefs
		//- LocalClassDefs

		//+ Fields
		public CalcificationType_Accessor CalcificationType { get ; protected set; }                                                              // CSDefineObservation.cs:398
		public CalcificationDistribution_Accessor CalcificationDistribution { get ; protected set; }                                              // CSDefineObservation.cs:398
		//- Fields

		/// <summary>
		/// No parameters constructor.
		// Caller must call Create();
		/// </summary>
		public MGAbnormalityCalcification() : base()
		{
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityCalcification(BreastRadiologyDocument doc, Observation resource)
		{
			this.Create(doc, resource);
		}

		/// <summary>
		/// Parametersize constructur.
		/// User must not call Create().
		/// </summary>
		public MGAbnormalityCalcification(BreastRadiologyDocument doc)
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
			this.CalcificationType = new IMGAbnormalityCalcification.CalcificationType_Accessor(doc);                                                // CSDefineObservation.cs:401
			this.CalcificationDistribution = new IMGAbnormalityCalcification.CalcificationDistribution_Accessor(doc);                                // CSDefineObservation.cs:401
			//- Constructor
		}

		public override void Write()
		{
		//+ WriteCode
		this.ClearComponents();                                                                                                                   // CSDefineObservation.cs:348
		this.WriteComponent(this.CalcificationType);                                                                                              // CSDefineObservation.cs:404
		this.WriteComponent(this.CalcificationDistribution);                                                                                      // CSDefineObservation.cs:404
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		this.ReadComponent(this.CalcificationType);                                                                                               // CSDefineObservation.cs:407
		this.ReadComponent(this.CalcificationDistribution);                                                                                       // CSDefineObservation.cs:407
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
