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
using BreastRadLib.BodyDistanceFromExtensionLocal;
//-Usings

namespace BreastRadLib.BreastBodyLocationExtensionLocal
{
	//+ LocalClassDefs
	/// <summary>
	/// Class that implements the 'BreastBodyLocation' complex extension class.
	/// </summary>
	public class BreastBodyLocationExtensionItem : IComplexExtensionItem                                                                       // BuildElementItemExtension.cs:327
	{                                                                                                                                          // BuildElementItemExtension.cs:328
	    TItemExtensionSingle<CodeableConcept> Quadrant;                                                                                        // BuildElementItemExtension.cs:484
	    TItemExtensionMultiple<CodeableConcept> Region;                                                                                        // BuildElementItemExtension.cs:484
	    TItemExtensionSingle<CodeableConcept> ClockDirection;                                                                                  // BuildElementItemExtension.cs:484
	    TItemExtensionSingle<CodeableConcept> Depth;                                                                                           // BuildElementItemExtension.cs:484
	                                                                                                                                           // BuildElementItemExtension.cs:330
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtensionItem()                                                                                               // BuildElementItemExtension.cs:334
	    {                                                                                                                                      // BuildElementItemExtension.cs:335
	        this.Quadrant = new TItemExtensionSingle<CodeableConcept>("Extension.extension:quadrant", 0, 1, "quadrant");                       // BuildElementItemExtension.cs:487
	        this.Region = new TItemExtensionMultiple<CodeableConcept>("Extension.extension:region", 0, -1, "region");                          // BuildElementItemExtension.cs:487
	        this.ClockDirection = new TItemExtensionSingle<CodeableConcept>("Extension.extension:clockDirection", 0, 1, "clockDirection");     // BuildElementItemExtension.cs:487
	        this.Depth = new TItemExtensionSingle<CodeableConcept>("Extension.extension:depth", 0, 1, "depth");                                // BuildElementItemExtension.cs:487
	    }                                                                                                                                      // BuildElementItemExtension.cs:337
	                                                                                                                                           // BuildElementItemExtension.cs:338
	    /// <summary>
	    /// Children
	    /// </summary>
	    public IEnumerable<IExtensionItem> Items()                                                                                             // BuildElementItemExtension.cs:342
	    {                                                                                                                                      // BuildElementItemExtension.cs:343
	        yield return this.Quadrant;                                                                                                        // BuildElementItemExtension.cs:490
	        yield return this.Region;                                                                                                          // BuildElementItemExtension.cs:490
	        yield return this.ClockDirection;                                                                                                  // BuildElementItemExtension.cs:490
	        yield return this.Depth;                                                                                                           // BuildElementItemExtension.cs:490
	    }                                                                                                                                      // BuildElementItemExtension.cs:345
	                                                                                                                                           // BuildElementItemExtension.cs:346
	}                                                                                                                                          // BuildElementItemExtension.cs:347
	//- LocalClassDefs
}
