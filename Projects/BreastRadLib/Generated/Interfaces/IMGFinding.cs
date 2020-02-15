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
		MemberList<IAbnormalityCyst> AbnormalityCyst {get;}                                                                                       // CSDefineObservation.cs:162
		MemberList<IAbnormalityDuct> AbnormalityDuct {get;}                                                                                       // CSDefineObservation.cs:162
		MemberList<IAbnormalityForeignObject> AbnormalityForeignObject {get;}                                                                     // CSDefineObservation.cs:162
		MemberList<IAbnormalityLymphNode> AbnormalityLymphNode {get;}                                                                             // CSDefineObservation.cs:162
		MemberList<IAbnormalityMass> AbnormalityMass {get;}                                                                                       // CSDefineObservation.cs:162
		MemberList<IAssociatedFeatures> AssociatedFeatures {get;}                                                                                 // CSDefineObservation.cs:162
		MemberList<IAbnormalityFibroadenoma> AbnormalityFibroadenoma {get;}                                                                       // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityArchitecturalDistortion> MGAbnormalityArchitecturalDistortion {get;}                                             // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityAsymmetry> MGAbnormalityAsymmetry {get;}                                                                         // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityCalcification> MGAbnormalityCalcification {get;}                                                                 // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityDensity> MGAbnormalityDensity {get;}                                                                             // CSDefineObservation.cs:162
		MemberList<IMGAbnormalityFatNecrosis> MGAbnormalityFatNecrosis {get;}                                                                     // CSDefineObservation.cs:162
		MemberList<IMGBreastDensity> MGBreastDensity {get;}                                                                                       // CSDefineObservation.cs:162
		//- Fields

		//+ Methods
		//- Methods
	}
}
