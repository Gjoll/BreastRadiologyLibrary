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
	public class ConsistentWith_Accessor : MemberListReferenceMultiple<ConsistentWith>                                                         // CSBuildMemberListReference.cs:62
	{                                                                                                                                          // CSBuildMemberListReference.cs:63
	    /// <summary>
	    /// ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base("ConsistentWith_Accessor")                                          // CSBuildMemberListReference.cs:68
	    {                                                                                                                                      // CSBuildMemberListReference.cs:69
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                               // CSBuildMemberListReference.cs:70
	    }                                                                                                                                      // CSBuildMemberListReference.cs:71
	}                                                                                                                                          // CSBuildMemberListReference.cs:72
	//- LocalClassDefs
}
