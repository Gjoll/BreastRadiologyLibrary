using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.TumorSatelliteFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'tumorSatellite'
	/// [Fhir Element 'Observation.hasMember:tumorSatellite]'
	/// </summary>
	public class TumorSatellite_Accessor : MemberListCodedReferenceMultiple<TumorSatellite>                                                    // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base("TumorSatellite_Accessor")                                          // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/TumorSatellite");                           // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	//- LocalClassDefs
}
