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
	public class AssociatedFeatures_Accessor : CodedReferenceSingle<AssociatedFeatures>                                                        // CSBuildCodedReferenceList.cs:50
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:51
	    /// <summary>
	    /// AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base("AssociatedFeatures_Accessor")                                  // CSBuildCodedReferenceList.cs:56
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:57
	        this.Init(doc, 0, 1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/AssociatedFeatures");                            // CSBuildCodedReferenceList.cs:58
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:59
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:60
	//- LocalClassDefs
}
