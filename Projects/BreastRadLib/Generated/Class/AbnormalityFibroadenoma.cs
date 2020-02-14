using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AbnormalityFibroadenoma : ObservationBase, IObservationLeafFragment, IBreastRadObservationNoDeviceFragment, IBreastRadObservationNoValueFragment, IBreastRadObservationNoComponentFragment, ICommonComponentsFragment, IShapeComponentsFragment, IObservedCountFragment, IObservedDistributionFragment, IObservedSizeFragment, IPreviouslyDemonstratedByFragment, IAssociatedFeaturesHasMemberFragment
	{
		//+ Fields
		
        public MemberList<IAssociatedFeatures> AssociatedFeatures {get;}
		//- Fields

		public AbnormalityFibroadenoma(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
		
            this.AssociatedFeatures = CreateHasMemberList<IAssociatedFeatures>(0, 1);
			//- Constructor
		}

		public AbnormalityFibroadenoma(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AbnormalityFibroadenoma");                                     // CSDefineBase.cs:112
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
