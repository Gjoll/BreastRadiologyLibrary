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
	public class MGFinding_Accessor : MemberListReferenceMultiple<MGFinding>                                                                   // CSBuildMemberListReference.cs:62
	{                                                                                                                                          // CSBuildMemberListReference.cs:63
	    /// <summary>
	    /// MGFinding_Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base("MGFinding_Accessor")                                                    // CSBuildMemberListReference.cs:68
	    {                                                                                                                                      // CSBuildMemberListReference.cs:69
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                    // CSBuildMemberListReference.cs:70
	    }                                                                                                                                      // CSBuildMemberListReference.cs:71
	}                                                                                                                                          // CSBuildMemberListReference.cs:72
	/// <summary>
	/// Accessor class for slice 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : MemberListReferenceMultiple<MRIFinding>                                                                 // CSBuildMemberListReference.cs:62
	{                                                                                                                                          // CSBuildMemberListReference.cs:63
	    /// <summary>
	    /// MRIFinding_Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base("MRIFinding_Accessor")                                                  // CSBuildMemberListReference.cs:68
	    {                                                                                                                                      // CSBuildMemberListReference.cs:69
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding");                                   // CSBuildMemberListReference.cs:70
	    }                                                                                                                                      // CSBuildMemberListReference.cs:71
	}                                                                                                                                          // CSBuildMemberListReference.cs:72
	/// <summary>
	/// Accessor class for slice 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : MemberListReferenceMultiple<NMFinding>                                                                   // CSBuildMemberListReference.cs:62
	{                                                                                                                                          // CSBuildMemberListReference.cs:63
	    /// <summary>
	    /// NMFinding_Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base("NMFinding_Accessor")                                                    // CSBuildMemberListReference.cs:68
	    {                                                                                                                                      // CSBuildMemberListReference.cs:69
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");                                    // CSBuildMemberListReference.cs:70
	    }                                                                                                                                      // CSBuildMemberListReference.cs:71
	}                                                                                                                                          // CSBuildMemberListReference.cs:72
	/// <summary>
	/// Accessor class for slice 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : MemberListReferenceMultiple<USFinding>                                                                   // CSBuildMemberListReference.cs:62
	{                                                                                                                                          // CSBuildMemberListReference.cs:63
	    /// <summary>
	    /// USFinding_Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base("USFinding_Accessor")                                                    // CSBuildMemberListReference.cs:68
	    {                                                                                                                                      // CSBuildMemberListReference.cs:69
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");                                    // CSBuildMemberListReference.cs:70
	    }                                                                                                                                      // CSBuildMemberListReference.cs:71
	}                                                                                                                                          // CSBuildMemberListReference.cs:72
	//- LocalClassDefs
}
