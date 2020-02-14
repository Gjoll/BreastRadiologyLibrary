using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;

using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;

namespace BreastRadLib
{
	public interface IMGFinding : IObservationBase, IObservationSectionFragment
	{
		//+ Fields
		MemberList<IAbnormalityCyst> AbnormalityCyst {get;}                                                                                       // CSDefineObservation.cs:61
		MemberList<IAbnormalityDuct> AbnormalityDuct {get;}                                                                                       // CSDefineObservation.cs:61
		MemberList<IAbnormalityForeignObject> AbnormalityForeignObject {get;}                                                                     // CSDefineObservation.cs:61
		MemberList<IAbnormalityLymphNode> AbnormalityLymphNode {get;}                                                                             // CSDefineObservation.cs:61
		MemberList<IAbnormalityMass> AbnormalityMass {get;}                                                                                       // CSDefineObservation.cs:61
		MemberList<IAssociatedFeatures> AssociatedFeatures {get;}                                                                                 // CSDefineObservation.cs:61
		MemberList<IAbnormalityFibroadenoma> AbnormalityFibroadenoma {get;}                                                                       // CSDefineObservation.cs:61
		MemberList<IMGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion {get;}                                             // CSDefineObservation.cs:61
		MemberList<IMGAbnormalityAsymmetry> MGAbnormalityAsymmetry {get;}                                                                         // CSDefineObservation.cs:61
		MemberList<IMGAbnormalityCalcification> MGAbnormalityCalcification {get;}                                                                 // CSDefineObservation.cs:61
		MemberList<IMGAbnormalityDensity> MGAbnormalityDensity {get;}                                                                             // CSDefineObservation.cs:61
		MemberList<IMGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis {get;}                                                                     // CSDefineObservation.cs:61
		MemberList<IMGBreastDensity> MGBreastDensity {get;}                                                                                       // CSDefineObservation.cs:61
		//- Fields

		//+ Methods
		//- Methods
	}
}
