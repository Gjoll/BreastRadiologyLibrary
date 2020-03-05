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
	public class BreastBodyLocationExtensionItem : IComplexExtensionItem                                                                       // BuildItemExtension.cs:327
	{                                                                                                                                          // BuildItemExtension.cs:328
	    TItemExtensionSingle<CodeableConcept> Quadrant;                                                                                  // BuildItemExtension.cs:484
	    TItemExtensionMultiple<CodeableConcept> Region;                                                                                  // BuildItemExtension.cs:484
	    TItemExtensionSingle<CodeableConcept> ClockDirection;                                                                            // BuildItemExtension.cs:484
	    TItemExtensionSingle<CodeableConcept> Depth;                                                                                     // BuildItemExtension.cs:484
	                                                                                                                                           // BuildItemExtension.cs:330
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtensionItem()                                                                                               // BuildItemExtension.cs:334
	    {                                                                                                                                      // BuildItemExtension.cs:335
	        this.Quadrant = new TItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "quadrant");                                 // BuildItemExtension.cs:487
	        this.Region = new TItemExtensionMultiple<CodeableConcept>("propertyName", 0, -1, "region");                                  // BuildItemExtension.cs:487
	        this.ClockDirection = new TItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "clockDirection");                     // BuildItemExtension.cs:487
	        this.Depth = new TItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "depth");                                       // BuildItemExtension.cs:487
	    }                                                                                                                                      // BuildItemExtension.cs:337
	                                                                                                                                           // BuildItemExtension.cs:338
	    /// <summary>
	    /// Children
	    /// </summary>
	    public IEnumerable<IExtensionItem> Items()                                                                                             // BuildItemExtension.cs:342
	    {                                                                                                                                      // BuildItemExtension.cs:343
	        yield return this.Quadrant;                                                                                                        // BuildItemExtension.cs:490
	        yield return this.Region;                                                                                                          // BuildItemExtension.cs:490
	        yield return this.ClockDirection;                                                                                                  // BuildItemExtension.cs:490
	        yield return this.Depth;                                                                                                           // BuildItemExtension.cs:490
	    }                                                                                                                                      // BuildItemExtension.cs:345
	                                                                                                                                           // BuildItemExtension.cs:346
	}                                                                                                                                          // BuildItemExtension.cs:347
	//- LocalClassDefs
}
