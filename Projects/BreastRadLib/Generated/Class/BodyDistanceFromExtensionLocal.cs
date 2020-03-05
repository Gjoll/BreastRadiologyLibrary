using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Text;
using System.Linq;
using Hl7.Fhir.Model;
using Hl7.Fhir.Serialization;
using BreastRadLib.ExtensionLocal;
//+Usings
//-Usings

namespace BreastRadLib.BodyDistanceFromExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BodyDistanceFrom' complex extension class.
	/// </summary>
	public class BodyDistanceFromExtensionItem : IComplexExtensionItem                                                                         // BuildElementItemExtension.cs:327
	{                                                                                                                                          // BuildElementItemExtension.cs:328
	    TElementItemExtensionSingle<CodeableConcept> LandMark;                                                                                  // BuildElementItemExtension.cs:484
	    TElementItemExtensionSingle<Quantity> DistanceFromLandMark;                                                                             // BuildElementItemExtension.cs:484
	                                                                                                                                           // BuildElementItemExtension.cs:330
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtensionItem()                                                                                                 // BuildElementItemExtension.cs:334
	    {                                                                                                                                      // BuildElementItemExtension.cs:335
	        this.LandMark = new TElementItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "landMark");                                 // BuildElementItemExtension.cs:487
	        this.DistanceFromLandMark = new TElementItemExtensionSingle<Quantity>("propertyName", 0, 1, "distanceFromLandMark");                // BuildElementItemExtension.cs:487
	    }                                                                                                                                      // BuildElementItemExtension.cs:337
	                                                                                                                                           // BuildElementItemExtension.cs:338
	    /// <summary>
	    /// Children
	    /// </summary>
	    public IEnumerable<IExtensionItem> Items()                                                                                             // BuildElementItemExtension.cs:342
	    {                                                                                                                                      // BuildElementItemExtension.cs:343
	        yield return this.LandMark;                                                                                                        // BuildElementItemExtension.cs:490
	        yield return this.DistanceFromLandMark;                                                                                            // BuildElementItemExtension.cs:490
	    }                                                                                                                                      // BuildElementItemExtension.cs:345
	                                                                                                                                           // BuildElementItemExtension.cs:346
	}                                                                                                                                          // BuildElementItemExtension.cs:347
	//- LocalClassDefs
}
