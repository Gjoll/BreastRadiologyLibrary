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
	/// Accessor class for slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : MemberListReferenceSingle<AssociatedFeatures>                                                   // CSBuildMemberListReference.cs:46
	{                                                                                                                                          // CSBuildMemberListReference.cs:47
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildMemberListReference.cs:52
	    {                                                                                                                                      // CSBuildMemberListReference.cs:53
	        this.Init(doc, 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                            // CSBuildMemberListReference.cs:54
	    }                                                                                                                                      // CSBuildMemberListReference.cs:55
	}                                                                                                                                          // CSBuildMemberListReference.cs:56
	//- LocalClassDefs
}
