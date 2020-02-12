using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityMass : ObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedSizeFragment, IObservedDistributionFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		
        public MemberList<ITumorSatellite> TumorSatellite {get;}
        public MemberList<IAssociatedFeatures> AssociatedFeatures {get;}
        public MemberList<IConsistentWith> ConsistentWith {get;}
		//- Fields

		public AbnormalityMass(Observation resource) : base(resource)
		{
			//+ Constructor
		
            this.TumorSatellite = CreateHasMemberList<ITumorSatellite>(0, -1);
            this.AssociatedFeatures = CreateHasMemberList<IAssociatedFeatures>(0, 1);
            this.ConsistentWith = CreateHasMemberList<IConsistentWith>(0, -1);
			//- Constructor
		}

		public AbnormalityMass() : this(new Observation())
		{
		}

		public void Write()
		{
		//+ WriteCode
		//- WriteCode
		}

		public void Read(ResourceBag resourceBag)
		{
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
