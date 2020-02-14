using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public class AssociatedFeatures : ObservationBase, IObservationSectionFragment
	{
		//+ Fields
		
        public MemberList<IMGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion {get;}
        public MemberList<IMGAbnormalityCalcification> MGAbnormalityCalcification {get;}
        public MemberList<IObservedFeature> ObservedFeature {get;}
		//- Fields

		public AssociatedFeatures(BreastRadiologyDocument doc, Observation resource) : base(doc, resource)
		{
			//+ Constructor
		
            this.MGAbnormalityArchitecturalDistortion = CreateHasMemberList<IMGAbnormalityArchitecturalDistortion>(0, -1);
            this.MGAbnormalityCalcification = CreateHasMemberList<IMGAbnormalityCalcification>(0, -1);
            this.ObservedFeature = CreateHasMemberList<IObservedFeature>(0, -1);
			//- Constructor
		}

		public AssociatedFeatures(BreastRadiologyDocument doc) : this(doc, new Observation())
		{
		}

		public override void Write()
		{
		//+ WriteCode
		SetProfileUrl("http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                                          // CSDefineBase.cs:112
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
