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
	public class AssociatedFeatures_Accessor : MemberListCodedReferenceSingle<AssociatedFeatures>                                              // CSBuildCodedReferenceList.cs:51
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:52
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildCodedReferenceList.cs:57
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:58
	        this.Init(doc, "", 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                        // CSBuildCodedReferenceList.cs:59
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:60
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:61
	//- LocalClassDefs
}
