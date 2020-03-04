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
	public class BodyDistanceFromExtension : ElementItemExtensionComplex                                                                       // BuildElementItemExtension.cs:319
	{                                                                                                                                          // BuildElementItemExtension.cs:320
	    ElementItemExtensionSingle<CodeableConcept> LandMark;                                                                                  // BuildElementItemExtension.cs:487
	    ElementItemExtensionSingle<Quantity> DistanceFromLandMark;                                                                             // BuildElementItemExtension.cs:487
	                                                                                                                                           // BuildElementItemExtension.cs:322
	    /// <summary>
	    /// Constructor
	    /// </summary>
	    public BodyDistanceFromExtension(BreastRadiologyDocument doc) : base("BodyDistanceFrom")                                               // BuildElementItemExtension.cs:326
	    {                                                                                                                                      // BuildElementItemExtension.cs:327
	        this.Init(doc, 0, -1);                                                                                                             // BuildElementItemExtension.cs:328
	        this.LandMark = new ElementItemExtensionSingle<CodeableConcept>("propertyName", 0, 1, "landMark");                                 // BuildElementItemExtension.cs:490
	        this.DistanceFromLandMark = new ElementItemExtensionSingle<Quantity>("propertyName", 0, 1, "distanceFromLandMark");                // BuildElementItemExtension.cs:490
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
