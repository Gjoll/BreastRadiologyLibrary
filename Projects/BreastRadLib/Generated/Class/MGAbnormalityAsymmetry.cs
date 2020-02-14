using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class MGAbnormalityAsymmetry : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoComponentFragment, IBreastRadObservationNoValueFragment, ICommonComponentsFragment, IShapeComponentsFragment, INotPreviouslySeenComponentFragment, IObservedCountFragment, ICorrespondsWithFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment, IConsistentWithHasMemberFragment
	{
		//+ Fields
		
        public MemberList<IAssociatedFeatures> AssociatedFeatures {get;}
        public MemberList<IConsistentWith> ConsistentWith {get;}
		//- Fields

		public MGAbnormalityAsymmetry(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
			SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGAbnormalityAsymmetry");                                     // CSDefineBase.cs:112
		
            this.AssociatedFeatures = CreateHasMemberList<IAssociatedFeatures>(0, 1);
            this.ConsistentWith = CreateHasMemberList<IConsistentWith>(0, -1);
			//- Constructor
		}

		public MGAbnormalityAsymmetry(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
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
