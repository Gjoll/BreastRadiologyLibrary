using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.FindingBreastFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'mGFinding'
	/// [Fhir Element 'Observation.hasMember:mGFinding]'
	/// </summary>
	public class MGFinding_Accessor : CodedReferenceMultiple<MGFinding>                                                                        // CSBuildCodedReferenceList.cs:66
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:67
	    /// <summary>
	    /// MGFinding_Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base("MGFinding_Accessor")                                                    // CSBuildCodedReferenceList.cs:72
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                    // CSBuildCodedReferenceList.cs:74
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:75
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:76
	/// <summary>
	/// Accessor class for slice 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : CodedReferenceMultiple<MRIFinding>                                                                      // CSBuildCodedReferenceList.cs:66
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:67
	    /// <summary>
	    /// MRIFinding_Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base("MRIFinding_Accessor")                                                  // CSBuildCodedReferenceList.cs:72
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding");                                   // CSBuildCodedReferenceList.cs:74
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:75
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:76
	/// <summary>
	/// Accessor class for slice 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : CodedReferenceMultiple<NMFinding>                                                                        // CSBuildCodedReferenceList.cs:66
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:67
	    /// <summary>
	    /// NMFinding_Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base("NMFinding_Accessor")                                                    // CSBuildCodedReferenceList.cs:72
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");                                    // CSBuildCodedReferenceList.cs:74
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:75
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:76
	/// <summary>
	/// Accessor class for slice 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : CodedReferenceMultiple<USFinding>                                                                        // CSBuildCodedReferenceList.cs:66
	{                                                                                                                                          // CSBuildCodedReferenceList.cs:67
	    /// <summary>
	    /// USFinding_Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base("USFinding_Accessor")                                                    // CSBuildCodedReferenceList.cs:72
	    {                                                                                                                                      // CSBuildCodedReferenceList.cs:73
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");                                    // CSBuildCodedReferenceList.cs:74
	    }                                                                                                                                      // CSBuildCodedReferenceList.cs:75
	}                                                                                                                                          // CSBuildCodedReferenceList.cs:76
	//- LocalClassDefs
}
