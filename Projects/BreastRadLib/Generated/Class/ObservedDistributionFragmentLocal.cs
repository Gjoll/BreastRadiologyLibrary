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

namespace BreastRadLib.ObservedDistributionFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Container class for Observation.component.
	/// </summary>
	public class ObsDistributionContainer : MContainer, ITMItem<Observation.ComponentComponent>                                                // BuildMemberBase.cs:69
	{                                                                                                                                          // BuildMemberBase.cs:70
	    /// <summary>
	    /// Item class for Observation.component.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:57
	    {                                                                                                                                      // BuildMemberBase.cs:58
	    }                                                                                                                                      // BuildMemberBase.cs:59
	                                                                                                                                           // BuildMemberBase.cs:72
	    // Properties                                                                                                                          // BuildMemberBase.cs:73
	    List<CodeableConcept> items = new List<CodeableConcept>();                                                                             // BuildMemberBase.cs:107
	                                                                                                                                           // BuildMemberBase.cs:109
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:113
	                                                                                                                                           // BuildMemberBase.cs:75
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ObsDistributionContainer(Int32 min, Int32 max) : base("Observation.component", min, max)                                        // BuildMemberBase.cs:79
	    {                                                                                                                                      // BuildMemberBase.cs:80
	    }                                                                                                                                      // BuildMemberBase.cs:82
	                                                                                                                                           // BuildMemberBase.cs:83
	    // Methods                                                                                                                             // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:119
	    /// <summary>
	    /// Write out member item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberBase.cs:123
	    {                                                                                                                                      // BuildMemberBase.cs:124
	        throw new NotImplementedException();                                                                                               // BuildMemberBase.cs:125
	    }                                                                                                                                      // BuildMemberBase.cs:135
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> element)                                     // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	        throw new NotImplementedException();                                                                                               // BuildMemberBase.cs:143
	    }                                                                                                                                      // BuildMemberBase.cs:175
	}                                                                                                                                          // BuildMemberBase.cs:86
	/// <summary>
	/// Container class for Observation.component.
	/// </summary>
	public class ObsDistRegionSizeContainer : MContainer, ITMItem<Observation.ComponentComponent>                                              // BuildMemberBase.cs:69
	{                                                                                                                                          // BuildMemberBase.cs:70
	    /// <summary>
	    /// Item class for Observation.component.
	    /// </summary>
	    public class Item                                                                                                                      // BuildMemberBase.cs:57
	    {                                                                                                                                      // BuildMemberBase.cs:58
	    }                                                                                                                                      // BuildMemberBase.cs:59
	                                                                                                                                           // BuildMemberBase.cs:72
	    // Properties                                                                                                                          // BuildMemberBase.cs:73
	    List<Element> items = new List<Element>();                                                                                             // BuildMemberBase.cs:107
	                                                                                                                                           // BuildMemberBase.cs:109
	    /// <summary>
	    /// Count property
	    /// </summary>
	    public override Int32 Count => items.Count;                                                                                            // BuildMemberBase.cs:113
	                                                                                                                                           // BuildMemberBase.cs:75
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public ObsDistRegionSizeContainer(Int32 min, Int32 max) : base("Observation.component", min, max)                                      // BuildMemberBase.cs:79
	    {                                                                                                                                      // BuildMemberBase.cs:80
	    }                                                                                                                                      // BuildMemberBase.cs:82
	                                                                                                                                           // BuildMemberBase.cs:83
	    // Methods                                                                                                                             // BuildMemberBase.cs:84
	                                                                                                                                           // BuildMemberBase.cs:119
	    /// <summary>
	    /// Write out member item as a fhir element.
	    /// </summary>
	    public IEnumerable<Observation.ComponentComponent> Write(BreastRadiologyDocument doc)                                                  // BuildMemberBase.cs:123
	    {                                                                                                                                      // BuildMemberBase.cs:124
	        throw new NotImplementedException();                                                                                               // BuildMemberBase.cs:125
	    }                                                                                                                                      // BuildMemberBase.cs:135
	                                                                                                                                           // BuildMemberBase.cs:137
	    /// <summary>
	    /// Read data from fhir element into member item.
	    /// </summary>
	    public void Read(BreastRadiologyDocument doc, IEnumerable<Observation.ComponentComponent> element)                                     // BuildMemberBase.cs:141
	    {                                                                                                                                      // BuildMemberBase.cs:142
	        throw new NotImplementedException();                                                                                               // BuildMemberBase.cs:143
	    }                                                                                                                                      // BuildMemberBase.cs:175
	}                                                                                                                                          // BuildMemberBase.cs:86
	//- LocalClassDefs
}
