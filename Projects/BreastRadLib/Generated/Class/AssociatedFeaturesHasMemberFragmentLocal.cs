using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.AssociatedFeaturesHasMemberFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberSingle<AssociatedFeatures>                                             // CSDefineObservation.cs:182
	{                                                                                                                                          // CSDefineObservation.cs:183
	    /// <summary>
	    /// Accessor HasMember slice AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:188
	    {                                                                                                                                      // CSDefineObservation.cs:189
	        this.Create(doc, 0, 1);                                                                                                            // CSDefineObservation.cs:190
	    }                                                                                                                                      // CSDefineObservation.cs:191
	}                                                                                                                                          // CSDefineObservation.cs:192
	//- LocalClassDefs
}
