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
	public class AssociatedFeatures_Accessor : ObservationLocal.HasMemberSingle<AssociatedFeatures>                                            // CSDefineObservation.cs:247
	{                                                                                                                                          // CSDefineObservation.cs:248
	    /// <summary>
	    /// Accessor HasMember slice AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:253
	    {                                                                                                                                      // CSDefineObservation.cs:254
	        this.Init(doc, 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                            // CSDefineObservation.cs:255
	    }                                                                                                                                      // CSDefineObservation.cs:256
	}                                                                                                                                          // CSDefineObservation.cs:257
	//- LocalClassDefs
}
