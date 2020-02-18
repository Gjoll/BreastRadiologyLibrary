using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ObservationLocal;

namespace BreastRadLib.TumorSatelliteFragmentLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Accessor class for ObservationhasMember slice 'tumorSatellite'
	/// [Fhir Element 'Observation.hasMember:tumorSatellite]'
	/// </summary>
	public class TumorSatellite_Accessor : ObservationBase.HasMemberBase<TumorSatellite>                                                       // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get items
	    /// </summary>
	    public IEnumerable<TumorSatellite> Get() => base.items;                                                                                // CSDefineObservation.cs:221
	                                                                                                                                           // CSDefineObservation.cs:222
	    /// <summary>
	    /// Add item
	    /// </summary>
	    public TumorSatellite Add(TumorSatellite item = null)                                                                                  // CSDefineObservation.cs:226
	    {                                                                                                                                      // CSDefineObservation.cs:227
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:228
	        {                                                                                                                                  // CSDefineObservation.cs:229
	            item = new TumorSatellite();                                                                                                   // CSDefineObservation.cs:230
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:231
	        }                                                                                                                                  // CSDefineObservation.cs:232
	        base.AppendItem(item);                                                                                                             // CSDefineObservation.cs:233
	        return item;                                                                                                                       // CSDefineObservation.cs:234
	    }                                                                                                                                      // CSDefineObservation.cs:235
	    /// <summary>
	    /// Accessor HasMember slice TumorSatellite_Accessor class constructor
	    /// </summary>
	    public TumorSatellite_Accessor(BreastRadiologyDocument doc) : base()                                                                   // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, -1);                                                                                                           // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	//- LocalClassDefs
}
