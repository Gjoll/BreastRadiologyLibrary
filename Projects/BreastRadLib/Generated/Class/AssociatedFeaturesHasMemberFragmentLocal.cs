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
	public class AssociatedFeatures_Accessor : MemberListReferenceSingle<AssociatedFeatures>                                                   // BuildMemberListReference.cs:51
	{                                                                                                                                          // BuildMemberListReference.cs:52
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // BuildMemberListReference.cs:57
	    {                                                                                                                                      // BuildMemberListReference.cs:58
	        this.Init(doc, 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                            // BuildMemberListReference.cs:59
	    }                                                                                                                                      // BuildMemberListReference.cs:60
	}                                                                                                                                          // BuildMemberListReference.cs:61
	//- LocalClassDefs
}
