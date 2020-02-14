using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityCyst : ObservationBase, IObservationLeafFragment, ITumorSatelliteFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, INotPreviouslySeenComponentFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IConsistentWithHasMemberFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ Fields
		
        public MemberList<ITumorSatellite> TumorSatellite {get;}
        public MemberList<IConsistentWith> ConsistentWith {get;}
        public MemberList<IAssociatedFeatures> AssociatedFeatures {get;}
		//- Fields

		public AbnormalityCyst(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
		
            this.TumorSatellite = CreateHasMemberList<ITumorSatellite>(0, -1);
            this.ConsistentWith = CreateHasMemberList<IConsistentWith>(0, -1);
            this.AssociatedFeatures = CreateHasMemberList<IAssociatedFeatures>(0, 1);
			//- Constructor
		}

		public AbnormalityCyst(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityCyst");                                             // CSDefineBase.cs:112
		//- WriteCode
		}

		public override void Read()
		{
		//+ ReadCode
		//- ReadCode
		}

		//+ Methods
		//- Methods
	}
}
