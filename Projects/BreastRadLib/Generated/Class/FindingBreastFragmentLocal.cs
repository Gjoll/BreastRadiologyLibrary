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
	/// Accessor class for 'mGFinding'
	/// [Fhir Element 'Observation.hasMember:mGFinding]'
	/// </summary>
	public class MGFinding_Accessor : ObservationBase.HasMemberMultiple<MGFinding>                                                             // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MGFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'mRIFinding'
	/// [Fhir Element 'Observation.hasMember:mRIFinding]'
	/// </summary>
	public class MRIFinding_Accessor : ObservationBase.HasMemberMultiple<MRIFinding>                                                           // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public MRIFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                       // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'nMFinding'
	/// [Fhir Element 'Observation.hasMember:nMFinding]'
	/// </summary>
	public class NMFinding_Accessor : ObservationBase.HasMemberMultiple<NMFinding>                                                             // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public NMFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	/// <summary>
	/// Accessor class for 'uSFinding'
	/// [Fhir Element 'Observation.hasMember:uSFinding]'
	/// </summary>
	public class USFinding_Accessor : ObservationBase.HasMemberMultiple<USFinding>                                                             // CSDefineObservation.cs:194
	{                                                                                                                                          // CSDefineObservation.cs:195
	    /// <summary>
	    /// Accessor class constructor
	    /// </summary>
	    public USFinding_Accessor(BreastRadiologyDocument doc) : base()                                                                        // CSDefineObservation.cs:199
	    {                                                                                                                                      // CSDefineObservation.cs:200
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:201
	    }                                                                                                                                      // CSDefineObservation.cs:202
	}                                                                                                                                          // CSDefineObservation.cs:203
	//- LocalClassDefs
}
