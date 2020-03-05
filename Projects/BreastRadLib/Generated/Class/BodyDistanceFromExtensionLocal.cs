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
	public class BodyDistanceFromExtensionItem : IComplexExtensionItem                                                                         // BuildItemExtension.cs:327
	{                                                                                                                                          // BuildItemExtension.cs:328
	    TItemExtensionSingle<CodeableConcept> LandMark;                                                                                  // BuildItemExtension.cs:484
	    TItemExtensionSingle<Quantity> DistanceFromLandMark;                                                                             // BuildItemExtension.cs:484
	                                                                                                                                           // BuildItemExtension.cs:330
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtensionItem()                                                                                                 // BuildItemExtension.cs:334
	    {                                                                                                                                      // BuildItemExtension.cs:335
	        this.LandMark = new TItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "landMark");                                 // BuildItemExtension.cs:487
	        this.DistanceFromLandMark = new TItemExtensionSingle<Quantity>("propertyName", 0, 1, "distanceFromLandMark");                // BuildItemExtension.cs:487
	    }                                                                                                                                      // BuildItemExtension.cs:337
	                                                                                                                                           // BuildItemExtension.cs:338
	    /// <summary>
	    /// Children
	    /// </summary>
	    public IEnumerable<IExtensionItem> Items()                                                                                             // BuildItemExtension.cs:342
	    {                                                                                                                                      // BuildItemExtension.cs:343
	        yield return this.LandMark;                                                                                                        // BuildItemExtension.cs:490
	        yield return this.DistanceFromLandMark;                                                                                            // BuildItemExtension.cs:490
	    }                                                                                                                                      // BuildItemExtension.cs:345
	                                                                                                                                           // BuildItemExtension.cs:346
	}                                                                                                                                          // BuildItemExtension.cs:347
	//- LocalClassDefs
}
