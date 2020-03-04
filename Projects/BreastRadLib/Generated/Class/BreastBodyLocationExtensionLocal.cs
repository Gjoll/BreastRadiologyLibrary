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
	public class BreastBodyLocationExtension : ElementItemExtensionComplex                                                                     // BuildElementItemExtension.cs:319
	{                                                                                                                                          // BuildElementItemExtension.cs:320
	    ElementItemExtensionSingle<CodeableConcept> Quadrant;                                                                                  // BuildElementItemExtension.cs:487
	    ElementItemExtensionMultiple<CodeableConcept> Region;                                                                                  // BuildElementItemExtension.cs:487
	    ElementItemExtensionSingle<CodeableConcept> ClockDirection;                                                                            // BuildElementItemExtension.cs:487
	    ElementItemExtensionSingle<CodeableConcept> Depth;                                                                                     // BuildElementItemExtension.cs:487
	                                                                                                                                           // BuildElementItemExtension.cs:322
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BreastBodyLocationExtension(BreastRadiologyDocument doc) : base("BreastBodyLocation")                                           // BuildElementItemExtension.cs:326
	    {                                                                                                                                      // BuildElementItemExtension.cs:327
	        this.Init(doc, 0, -1);                                                                                                             // BuildElementItemExtension.cs:328
	        this.Quadrant = new ElementItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "quadrant");                                 // BuildElementItemExtension.cs:490
	        this.Region = new ElementItemExtensionMultiple<CodeableConcept>("propertyName", 0, -1, "region");                                  // BuildElementItemExtension.cs:490
	        this.ClockDirection = new ElementItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "clockDirection");                     // BuildElementItemExtension.cs:490
	        this.Depth = new ElementItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "depth");                                       // BuildElementItemExtension.cs:490
	    }                                                                                                                                      // BuildElementItemExtension.cs:330
	                                                                                                                                           // BuildElementItemExtension.cs:331
	    /// <summary>
	    /// Read extension values
	    /// </summary>
	    public override void ReadItems(IEnumerable<Extension> e)                                                                               // BuildElementItemExtension.cs:335
	    {                                                                                                                                      // BuildElementItemExtension.cs:336
	    }                                                                                                                                      // BuildElementItemExtension.cs:338
	                                                                                                                                           // BuildElementItemExtension.cs:339
	    /// <summary>
	    /// Write extension values
	    /// </summary>
	    public override IEnumerable<Extension> WriteItems()                                                                                    // BuildElementItemExtension.cs:343
	    {                                                                                                                                      // BuildElementItemExtension.cs:344
	        List<Extension> retVal = new List<Extension>();                                                                                    // BuildElementItemExtension.cs:345
	        return retVal.ToArray();                                                                                                           // BuildElementItemExtension.cs:347
	    }                                                                                                                                      // BuildElementItemExtension.cs:348
	}                                                                                                                                          // BuildElementItemExtension.cs:349
	//- LocalClassDefs
}
