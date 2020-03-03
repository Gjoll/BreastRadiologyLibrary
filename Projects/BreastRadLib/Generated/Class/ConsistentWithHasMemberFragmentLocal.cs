using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;
//+Usings
//-Usings

namespace BreastRadLib.ConsistentWithHasMemberFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'consistentWith'
	/// [Fhir Element 'Observation.hasMember:consistentWith]'
	/// </summary>
	public class ConsistentWith_Accessor : MemberListReferenceMultiple<ConsistentWith>                                                         // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// ConsistentWith_Accessor class constructor
	    /// </summary>
	    public ConsistentWith_Accessor(BreastRadiologyDocument doc) : base("ConsistentWith_Accessor")                                          // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/ConsistentWith");                               // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	//- LocalClassDefs
}
