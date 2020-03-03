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

namespace BreastRadLib.FindingBreastFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for slice 'mGFinding'
	/// [Fhir Element 'Observation.hasMember:mGFinding]'
	/// </summary>
	public class MGFinding_Accessor : MemberListReferenceMultiple<MGFinding>                                                                   // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MGFinding_Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base("MGFinding_Accessor")                                                    // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                    // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : MemberListReferenceMultiple<MRIFinding>                                                                 // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// MRIFinding_Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base("MRIFinding_Accessor")                                                  // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding");                                   // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : MemberListReferenceMultiple<NMFinding>                                                                   // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// NMFinding_Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base("NMFinding_Accessor")                                                    // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");                                    // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	/// <summary>
	/// Accessor class for slice 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : MemberListReferenceMultiple<USFinding>                                                                   // BuildMemberListReference.cs:67
	{                                                                                                                                          // BuildMemberListReference.cs:68
	    /// <summary>
	    /// USFinding_Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base("USFinding_Accessor")                                                    // BuildMemberListReference.cs:73
	    {                                                                                                                                      // BuildMemberListReference.cs:74
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");                                    // BuildMemberListReference.cs:75
	    }                                                                                                                                      // BuildMemberListReference.cs:76
	}                                                                                                                                          // BuildMemberListReference.cs:77
	//- LocalClassDefs
}
