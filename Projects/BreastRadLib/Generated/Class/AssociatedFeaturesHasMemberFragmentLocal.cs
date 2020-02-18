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
	/// Accessor class for 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberSingle<AssociatedFeatures>                                             // CSDefineObservation.cs:179
	{                                                                                                                                          // CSDefineObservation.cs:180
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:184
	    {                                                                                                                                      // CSDefineObservation.cs:185
	        this.Create(doc, 0, 1);                                                                                                            // CSDefineObservation.cs:186
	    }                                                                                                                                      // CSDefineObservation.cs:187
	}                                                                                                                                          // CSDefineObservation.cs:188
	//- LocalClassDefs
}
