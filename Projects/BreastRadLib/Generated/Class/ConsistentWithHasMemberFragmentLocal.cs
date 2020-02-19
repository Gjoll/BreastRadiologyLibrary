using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.ConsistentWithHasMemberFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'consistentWith'
	/// [Fhir Element 'Observation.hasMember:consistentWith]'
	/// </summary>
	public class ConsistentWith_Accessor : MemberListCodedReferenceMultiple<ConsistentWith>                                                    // CSBuildCodedReferenceList.cs:67
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:68
	    /// <summary>
	    /// ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base("ConsistentWith_Accessor")                                          // CSBuildCodedReferenceList.cs:73
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:74
	        this.Init(doc, "", 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                           // CSBuildCodedReferenceList.cs:75
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:76
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:77
	//- LocalClassDefs
}
