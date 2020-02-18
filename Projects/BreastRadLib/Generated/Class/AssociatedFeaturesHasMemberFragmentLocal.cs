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
	/// Accessor class for ObservationhasMember slice 'associatedFeatures'
	/// [Fhir Element 'Observation.hasMember:associatedFeatures]'
	/// </summary>
	public class AssociatedFeatures_Accessor : ObservationBase.HasMemberBase<AssociatedFeatures>                                               // CSDefineObservation.cs:180
	{                                                                                                                                          // CSDefineObservation.cs:181
	    /// <summary>
	    /// Get item
	    /// </summary>
	    public AssociatedFeatures Get() => base.GetSingleItem();                                                                               // CSDefineObservation.cs:198
	                                                                                                                                           // CSDefineObservation.cs:199
	    /// <summary>
	    /// Set item
	    /// </summary>
	    public AssociatedFeatures Set(AssociatedFeatures item = null)                                                                          // CSDefineObservation.cs:203
	    {                                                                                                                                      // CSDefineObservation.cs:204
	        if (item == null)                                                                                                                  // CSDefineObservation.cs:205
	        {                                                                                                                                  // CSDefineObservation.cs:206
	            item = new AssociatedFeatures();                                                                                               // CSDefineObservation.cs:207
	            item.Create(this.doc);                                                                                                         // CSDefineObservation.cs:208
	        }                                                                                                                                  // CSDefineObservation.cs:209
	        base.SetSingleItem(item);                                                                                                          // CSDefineObservation.cs:210
	        return item;                                                                                                                       // CSDefineObservation.cs:211
	    }                                                                                                                                      // CSDefineObservation.cs:212
	    /// <summary>
	    /// Accessor HasMember slice AssociatedFeatures_Accessor class constructor
	    /// </summary>
	    public AssociatedFeatures_Accessor(BreastRadiologyDocument doc) : base()                                                               // CSDefineObservation.cs:186
	    {                                                                                                                                      // CSDefineObservation.cs:187
	        this.Create(doc, 0, 1);                                                                                                            // CSDefineObservation.cs:188
	    }                                                                                                                                      // CSDefineObservation.cs:189
	}                                                                                                                                          // CSDefineObservation.cs:190
	//- LocalClassDefs
}
