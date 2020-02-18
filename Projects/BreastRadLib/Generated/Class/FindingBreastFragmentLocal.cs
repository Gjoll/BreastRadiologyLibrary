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
	/// Accessor class for ObservationhasMember slice 'mGFinding'
	/// [Fhir Element 'Observation.hasMember:mGFinding]'
	/// </summary>
	public class MGFinding_Accessor : ObservationBase.HasMemberMultiple<MGFinding>                                                             // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MGFinding_Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MGFinding");                                    // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : ObservationBase.HasMemberMultiple<MRIFinding>                                                           // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice MRIFinding_Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                       // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/MRIFinding");                                   // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : ObservationBase.HasMemberMultiple<NMFinding>                                                             // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice NMFinding_Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/NMFinding");                                    // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : ObservationBase.HasMemberMultiple<USFinding>                                                             // CSDefineObservation.cs:199
	{                                                                                                                                          // CSDefineObservation.cs:200
	    /// <summary>
	    /// Accessor HasMember slice USFinding_Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:205
	    {                                                                                                                                      // CSDefineObservation.cs:206
	        this.Init(doc, 0, -1, "http://hl7.org/fhir/us/breast-radiology/StructureDefinition/USFinding");                                    // CSDefineObservation.cs:207
	    }                                                                                                                                      // CSDefineObservation.cs:208
	}                                                                                                                                          // CSDefineObservation.cs:209
	//- LocalClassDefs
}
