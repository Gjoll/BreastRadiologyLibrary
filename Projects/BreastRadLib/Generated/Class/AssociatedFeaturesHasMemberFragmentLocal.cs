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
	public class AssociatedFeatures_Accessor : MemberListReferenceSingle<AssociatedFeatures>                                                   // CSBuildMemberListReference.cs:50
	{                                                                                                                                          // CSBuildMemberListReference.cs:51
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildMemberListReference.cs:56
	    {                                                                                                                                      // CSBuildMemberListReference.cs:57
	        this.Init(doc, 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                            // CSBuildMemberListReference.cs:58
	    }                                                                                                                                      // CSBuildMemberListReference.cs:59
	}                                                                                                                                          // CSBuildMemberListReference.cs:60
	//- LocalClassDefs
}
